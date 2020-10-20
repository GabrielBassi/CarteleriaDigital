using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.DAL;
using CarteleriaDigital.Modelo;
using System.IO;
using System.Windows.Forms;

namespace CarteleriaDigital.Controladores
{
    class ControladorFuenteRss
    {
        private readonly IUnidadDeTrabajo iUdT;

        public ControladorFuenteRss(IUnidadDeTrabajo pUnidadDeTrabajo)
        {
            this.iUdT = pUnidadDeTrabajo;
        }

        public void AgregarRssUrl(string pNombre, string pUrl)
        {

            FuenteRss iRssUrl = new FuenteRss()
            {
                Nombre = pNombre,
                Url = Convert.ToString(pUrl),
            };
            this.iUdT.RepositorioRssUrl.Agregar(iRssUrl);
            iUdT.Guardar();
        }
        public FuenteRss Obtener(int RssUrlId)
        {
            return this.iUdT.RepositorioRssUrl.Obtener(RssUrlId);
        }

        public int UltimoIdRSS()
        {
            IEnumerable<FuenteRss> lista;
            lista = iUdT.RepositorioRssUrl.ObtenerTodos();
            return lista.Last().FuenteRssId;
        }
        public FuenteRss BuscarRssPorNombre(string pCadena)
        {
            FuenteRss iRssUrl = iUdT.RepositorioRssUrl.ExistenciaRssUrl(pCadena);
            return iRssUrl;
        }

        public void CargarRssUrlModificar(FuenteRss mRssUrl, TextBox txtNombreModRss, TextBox txtModUrl)
        {
            txtNombreModRss.Text = mRssUrl.Nombre;
            txtModUrl.Text = mRssUrl.Url;
        }

        public void CargarRssActivos(ComboBox pComboRss)
        {
            IEnumerable<FuenteRss> listaRss = iUdT.RepositorioRssUrl.ObtenerTodos();
            foreach (FuenteRss item in listaRss)
            {
                pComboRss.Items.Add(item.Nombre);
            }
        }
        internal bool ConsultarExistenciaNombreRss(string pNombreRss)
        {
            bool existencia = false;
            existencia = iUdT.RepositorioRssUrl.ExisteRssUrlPorNombre(pNombreRss);
            if (existencia == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
    }
}



