using CarteleriaDigital.Controladores;
using CarteleriaDigital.DAL.EntityFramework;
using CarteleriaDigital.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarteleriaDigital.Vistas
{
    public partial class IniciarCampañaBannerDia : Form
    {
        ControladorBanner iControladorBanner;
        ControladorCampaña iControladorCampaña;
        ControladorTextoFijo iControladorTextoFijo;
        ControladorImagen iControladorImagen;
        ControladorRssUrl iControladorRSS;
        IList<Banner> listaBanner;
        IList<Campaña> listaCampaña;
        IList<string> listaPath = new List<string>();
        IList<int> listaTiempo = new List<int>();
        IList<string> listaCadena = new List<string>();
        int iIndiceImagen=0;
        public IniciarCampañaBannerDia()
        {
            InitializeComponent();
            iControladorBanner = new ControladorBanner(UnidadDeTrabajo.Instancia);
            iControladorCampaña = new ControladorCampaña(UnidadDeTrabajo.Instancia);
            iControladorTextoFijo = new ControladorTextoFijo(UnidadDeTrabajo.Instancia);
            iControladorImagen= new ControladorImagen(UnidadDeTrabajo.Instancia,1,1);
            iControladorRSS = new ControladorRssUrl(UnidadDeTrabajo.Instancia);
        }

        private void timerCampañas_Tick(object sender, EventArgs e)
        {
            if (listaCampaña.Count > 0)
            {
                int i = 0;
                foreach (var item in listaCampaña)
                {
                  
                   IList<Imagen> listaImagenes=iControladorImagen.ListaImagensPorCampañaId(listaCampaña[i].CampañaId);
                    foreach (var element in listaImagenes)
                    {
                        listaPath.Add(element.RutaImagen);
                        listaTiempo.Add(item.DuracionImagen);
                    }
                   i++;
                }
                if (listaPath.Count > iIndiceImagen)
                {
                    this.timerCampañas.Interval = listaTiempo[iIndiceImagen] * 1000;
                    var mPath = (listaPath[iIndiceImagen]);
                    iIndiceImagen++;
                    pBoxCampañas.Image = Image.FromFile(mPath);
                }
            }
            listaTiempo.Clear();
            listaPath.Clear();
        }

        private void timerBanner_Tick(object sender, EventArgs e)
        {
            
            this.lblBannerDeslizable.Left -= 3;
            if (this.lblBannerDeslizable.Left <= -this.lblBannerDeslizable.Width)
            {
                this.lblBannerDeslizable.Left = this.Width;
            }
            if (listaBanner.Count > 0)
            {
                string cadena = "";

                for (int i = 0; i < listaBanner.Count; i++)
                {
                    if (listaBanner[i].EstrategiaTipoDatosFuente.NombreTipoDeEstrategia == "Texto Fijo")
                    {
                        var contenido = XDocument.Load(iControladorTextoFijo.Obtener(listaBanner[i].EstrategiaTipoDatosFuente.DatosEstrategiaId).Path);
                        foreach (var item in contenido.Elements())
                        {
                              cadena = cadena + "           ****           " + item.Element("description").Value + "           ****";
                        }
                    }
                    else
                    {
                        var unRss = iControladorRSS.Obtener(listaBanner[i].EstrategiaTipoDatosFuente.DatosEstrategiaId);
                      var contenido= unRss.ObteneDocumentoXML(unRss.Url);
                      foreach (var item in contenido.Elements())
                      {
                            cadena = cadena+ "           ****           " + item.Element("title").Value+ " - "+ item.Element("description").Value;
                        }
                    }
                }
                lblBannerDeslizable.Text = cadena;
            }
        }

        private void IniciarCampañaBannerDia_Load(object sender, EventArgs e)
        {
            timerBanner.Start();
            timerCampañas.Start();
            timerControl.Start();
            
            listaBanner = iControladorBanner.BuscarBannerActivosHoy();
            listaCampaña = iControladorCampaña.BuscarCampañaActivosHoy();
        }

        private void timerControl_Tick(object sender, EventArgs e)
        {
            this.timerControl.Interval = (2*1000);
            listaBanner = iControladorBanner.BuscarBannerActivosHoyPorRango();
            
            listaCampaña = iControladorCampaña.BuscarCampañaActivosHoyPorRango();
            if (listaBanner.Count==0)
            {
                lblBannerDeslizable.Text = "PUBLICITE AQUI SU NEGOCIO!!!";
            }
            if (listaCampaña.Count == 0)
            {
                pBoxCampañas.Image = null; //SE PODRIA AGREGAR UNA IMAGEN GENÉRICA...
            }
        }
    }
}
