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
    class ControladorRssUrl
    {
        private readonly IUnidadDeTrabajo iUdT;

        public ControladorRssUrl(IUnidadDeTrabajo pUnidadDeTrabajo)
        {
            this.iUdT = pUnidadDeTrabajo;
        }

        public void AgregarRssUrl(string pNombre, string pUrl)
        {

            RssUrl iRssUrl = new RssUrl()
            {
                Nombre = pNombre,
                Url = Convert.ToString(pUrl),
            };
            this.iUdT.RepositorioRssUrl.Agregar(iRssUrl);
            iUdT.Guardar();
        }
        public RssUrl Obtener(int RssUrlId)
        {
            return this.iUdT.RepositorioRssUrl.Obtener(RssUrlId);
        }

        public int UltimoIdRSS()
        {
            IEnumerable<RssUrl> lista;
            lista = iUdT.RepositorioRssUrl.ObtenerTodos();
            return lista.Last().RssUrlId;
        }
        public RssUrl BuscarRssPorNombre(string pCadena)
        {
            RssUrl iRssUrl = iUdT.RepositorioRssUrl.ExistenciaRssUrl(pCadena);
            return iRssUrl;
        }

        public void CargarRssUrlModificar(RssUrl mRssUrl, TextBox txtNombreModRss, TextBox txtModUrl)
        {
            txtNombreModRss.Text = mRssUrl.Nombre;
            txtModUrl.Text = mRssUrl.Url;
        }

        public void CargarRssActivos(ComboBox pComboRss)
        {
            IEnumerable<RssUrl> listaRss = iUdT.RepositorioRssUrl.ObtenerTodos();
            foreach (RssUrl item in listaRss)
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



