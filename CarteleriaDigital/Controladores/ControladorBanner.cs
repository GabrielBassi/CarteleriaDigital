using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.DAL;
using CarteleriaDigital.Excepciones;
using CarteleriaDigital.Modelo;
using CarteleriaDigital.DAL.EntityFramework;
using System.Windows.Forms;
using System.Xml.Linq;
using System.ComponentModel;

namespace CarteleriaDigital.Controladores
{
    class ControladorBanner
    {
        private readonly IUnidadDeTrabajo iUdT;
        ControladorTextoFijo iControladorTextoFijo;
        ControladorRssUrl iControladorRssUrl;

        public ControladorBanner(IUnidadDeTrabajo pUnidadDeTrabajo)
        {
            this.iUdT = pUnidadDeTrabajo;
            iControladorTextoFijo = new ControladorTextoFijo(iUdT);
            iControladorRssUrl = new ControladorRssUrl(iUdT);
        }
        public void AgregarBanner(string pNombreBanner, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, string mNombreTipoDeEstrategia, int pEstrategia)
        {

            EstrategiaTipoDatosFuente mETDF = new EstrategiaTipoDatosFuente
            {
               NombreTipoDeEstrategia = mNombreTipoDeEstrategia,
               DatosEstrategiaId=pEstrategia,
               
            };

            Banner iBanner = new Banner()
            {
                NombreBanner = pNombreBanner,
                FechaInicio = pFechaInicio,
                FechaFin = pFechaFin,
                HoraInicio = pHoraInicio,
                HoraFin = pHoraFin,
                EstrategiaTipoDatosFuente = mETDF,
            };

            this.iUdT.RepositorioBanner.Agregar(iBanner);
            iUdT.Guardar();
        }
        public void ModificarBanner(Banner pBanner, string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pidDatosFuente)
        {
            pBanner.NombreBanner = pNombre;
            pBanner.FechaInicio = pFechaInicio;
            pBanner.FechaFin = pFechaFin;
            pBanner.HoraInicio = pHoraInicio;
            pBanner.HoraFin = pHoraFin;
            pBanner.EstrategiaTipoDatosFuente.DatosEstrategiaId = pidDatosFuente;
            this.iUdT.RepositorioBanner.Modificar(pBanner);
            iUdT.Guardar();
        }

        internal bool ConsultarExistenciaNombreBanner(string pNombreBanner)
        {
            bool existencia = false;
            existencia = iUdT.RepositorioBanner.ExisteBannerPorNombre(pNombreBanner);
            if (existencia == true) 
            {
                return true;
            }
            else 
            {
                return existencia; 
            }
        }

        public void CargarBannerModificar(Banner mBannerMod, TextBox txtNomBannerMod, DateTimePicker dTPickFechaDesdeModBan, DateTimePicker dTPickFechaHastaModBan, NumericUpDown nUpDesdeHoraModBan, NumericUpDown nUpHastaHoraModBan, ComboBox cBoxFuenteModBanner, TextBox txtNombreTextoFijoMod, TextBox txtDescripModTexFijo, TextBox txtNombreModRss, TextBox txtModUrl)
        {
            txtNomBannerMod.Text = mBannerMod.NombreBanner;
            dTPickFechaDesdeModBan.Value = mBannerMod.FechaInicio;
            dTPickFechaHastaModBan.Value = mBannerMod.FechaFin;
            nUpDesdeHoraModBan.Value = Convert.ToDecimal(mBannerMod.HoraInicio.Hours);
            nUpHastaHoraModBan.Value = Convert.ToDecimal(mBannerMod.HoraFin.Hours);
            cBoxFuenteModBanner.Text = mBannerMod.EstrategiaTipoDatosFuente.NombreTipoDeEstrategia;

            if (mBannerMod.EstrategiaTipoDatosFuente.NombreTipoDeEstrategia == "Texto Fijo")
            {
                int idtF = Convert.ToInt32(mBannerMod.EstrategiaTipoDatosFuente.DatosEstrategiaId);
                TextoFijo mTextoFijo = iControladorTextoFijo.Obtener(idtF);
                var contenido = XDocument.Load(iControladorTextoFijo.Obtener(Convert.ToInt32(mBannerMod.EstrategiaTipoDatosFuente.DatosEstrategiaId)).Path);
                txtNombreTextoFijoMod.Text = mTextoFijo.Nombre;
                txtDescripModTexFijo.Text = Convert.ToString(contenido);

                foreach (var item in contenido.Elements())
                {
                    txtDescripModTexFijo.Text = item.Element("description").Value;
                }

            }
            else if (mBannerMod.EstrategiaTipoDatosFuente.NombreTipoDeEstrategia == "RSS")
            {
                int idtF = Convert.ToInt32(mBannerMod.EstrategiaTipoDatosFuente.DatosEstrategiaId);
                RssUrl mRssUrl = iControladorRssUrl.Obtener(idtF);
                txtNombreModRss.Text = mRssUrl.Nombre;
                txtModUrl.Text = mRssUrl.Url;
            }
        }
        public void EliminarBanner(Banner mBanner)
        {
            this.iUdT.RepositorioBanner.Eliminar(mBanner);
            iUdT.Guardar();
        }
        public void CargarBannerActivasComboBox(ComboBox pCombo)
        {
            IList<Banner> listaBanner = iUdT.RepositorioBanner.ObtenerTodos();
            foreach (Banner item in listaBanner)
            {
                pCombo.Items.Add(item.NombreBanner);
            }
        }
        public Banner BuscarBannerPorNombre(string pCadena)
        {
            Banner iBanner = iUdT.RepositorioBanner.ExistenciaBanner(pCadena);
            return iBanner;
        }
    }
}
