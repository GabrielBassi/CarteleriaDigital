using CarteleriaDigital.Controladores;
using CarteleriaDigital.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarteleriaDigital.Modelo
{
    public class TextoFijo : IEstrategiaTipoDatosFuente
    {
          public int TextoFijoId { get; set; }
        public string Nombre { get; set; }
        public string Path { get; set; }
        public XDocument LeerInformacion(string pstring)
        {
            ControladorTextoFijo mControlador = new ControladorTextoFijo(UnidadDeTrabajo.Instancia);

            TextoFijo mTextoXML = mControlador.Obtener(this.TextoFijoId);
            var mPath = mTextoXML.Path;
            var mArchivXML = XDocument.Load(mPath);
            return mArchivXML;
        }
    }
}
