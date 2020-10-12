using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CarteleriaDigital.DAL;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.Controladores
{
    class ControladorTextoFijo
    {
        private readonly IUnidadDeTrabajo iUdT;

        public ControladorTextoFijo(IUnidadDeTrabajo pUnidadDeTrabajo)
        {
            this.iUdT = pUnidadDeTrabajo;
        }

        public void AgregarTextoFijo(string pNombre, string pDescripcion)
        {
            XDocument mDocumentoXML = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("item",
                        new XElement("title", pNombre),
                        new XElement("description", pDescripcion)
                        )
                    );

            string nombreArchivoXML = string.Format("{0}.xml", pNombre);
            //Rura donde se guardara el archivo XML
            string mRuta = Path.Combine(string.Format("{0}{1}", Directory.GetCurrentDirectory(), @"..\..\..\"), @"DAL\ArchivosXML\" + nombreArchivoXML);

            //Guardo el documento XML
            mDocumentoXML.Save(mRuta);

            TextoFijo iTextoFijo = new TextoFijo()
            { 
            Nombre = pNombre,
            Path = mRuta,
            };
            this.iUdT.RepositorioTextoFijo.Agregar(iTextoFijo);
            iUdT.Guardar();
        }

        public IList<TextoFijo> ObtenerTextoFijo(string pNombre)
        {
            return this.iUdT.RepositorioTextoFijo.ObtenerTextoFijo(pNombre);
        }

        public TextoFijo Obtener(int textoFijoId)
        {
          
                return this.iUdT.RepositorioTextoFijo.Obtener(textoFijoId);
            
        }
        public int UltimoIdTextoFijo()
        {
            IEnumerable<TextoFijo> lista;
            lista = iUdT.RepositorioTextoFijo.ObtenerTodos();
            return lista.Last().TextoFijoId;
        }

        internal bool ConsultarExistenciaNombreTextoFijo(string pNombreTextoFijo)
        {
            bool existencia = false;
            existencia = iUdT.RepositorioTextoFijo.ExisteTextoFijoPorNombre(pNombreTextoFijo);
            if (existencia == true)
            {
                return true;
            }
            else 
            {
                return existencia;
            }
        }
        public void CargarTextoFijoActivos(ComboBox pComboTextoFijo)
        {
            IEnumerable<TextoFijo> listaTextoFijo = iUdT.RepositorioTextoFijo.ObtenerTodos();
            foreach (TextoFijo item in listaTextoFijo)
            {
                pComboTextoFijo.Items.Add(item.Nombre);
            }
        }
        public TextoFijo BuscarTextoFijoPorNombre(string pCadena)
        {
            TextoFijo iTextoFijo = iUdT.RepositorioTextoFijo.ExistenciaTextoFijo(pCadena);
            return iTextoFijo;
        }
        public void CargarTextoFijoModificar(TextoFijo pTextoFijo, TextBox txtNombreTextoFijoMod, TextBox txtDescripModTexFijo )
        {
            txtNombreTextoFijoMod.Text = pTextoFijo.Nombre;
            var contenido = XDocument.Load(pTextoFijo.Path);
            foreach (var item in contenido.Elements())
            {
                txtDescripModTexFijo.Text = item.Element("description").Value;
            }
        }
    }
  
}
