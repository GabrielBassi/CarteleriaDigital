using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace CarteleriaDigital.Modelo
{
    public class FuenteRss : IEstrategiaTipoDatosFuente
    {
        public int FuenteRssId { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }

        public XDocument LeerInformacion(string purl)
        {
            FuenteRss mLectorRSS = new FuenteRss();
            return mLectorRSS.ObteneDocumentoXML(purl);
        }

        public XDocument ObteneDocumentoXML(string purl)
        {
            try
            {
                string[] mInformacion = new string[2];
                string mDescripcionSinSaltosDeLineas = "";

                XmlTextReader mXmlReader = new XmlTextReader(purl);
                XDocument mDocumentoXML = XDocument.Load(mXmlReader);
                var mListaItemNodo = mDocumentoXML.Descendants("item");

                foreach (var unItem in mListaItemNodo)
                {
                    mInformacion[0] = unItem.Descendants("title").First().Value;
                    string mDescripcion = unItem.Descendants("description").First().Value;
                    mDescripcionSinSaltosDeLineas = string.Join(" ", Regex.Split(mDescripcion, @"(?:\r\n|\n|\r)"));


                    //Si mDescripcionSinSaltosDeLineas tiene el caracter "<" elimina toda la subcadena que continua despues de dicho caracter.
                    int mIndice = mDescripcionSinSaltosDeLineas.IndexOf('<');
                    if (mIndice >= 0)
                    {
                        mDescripcionSinSaltosDeLineas = mDescripcionSinSaltosDeLineas.Substring(0, mIndice);
                    }

                    mInformacion[1] = mDescripcionSinSaltosDeLineas;

                }

                XDocument mDocumentoXMLReducido = new XDocument(
                   new XDeclaration("1.0", "utf-8", "yes"),                   new XElement("item",
                       new XElement("title", mInformacion[0]),
                       new XElement("description", mInformacion[1])
                       )
                   );

                //Ruta del archivo XML donde se rescribe cada RSS Leido. Este archivo guardado se usa cuando no haya internet.
                string mRuta = Path.Combine(string.Format("{0}{1}", Directory.GetCurrentDirectory(), @"\UltimoRssLeido.xml"));
                //Guardo el documento XML
                mDocumentoXMLReducido.Save(mRuta);

                return mDocumentoXMLReducido;
            }
            catch (WebException)
            {
                return this.ObtenerUltimoRSSLeido();

            }


        }
        private XDocument ObtenerUltimoRSSLeido()
        {
            //Ruta donde se guardara el Feed leido.
            string mRuta = Path.Combine(string.Format("{0}{1}", Directory.GetCurrentDirectory(), @"\UltimoRssLeido.xml"));
            return XDocument.Load(mRuta);

        }
    }
}
