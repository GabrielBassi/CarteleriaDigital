using System;
using System.Collections.Generic;
using CarteleriaDigital.DAL;
using CarteleriaDigital.Modelo;
using System.Windows.Forms;
using System.Xml.Linq;

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

        /// <summary>
        /// Metodo para agregar un banner
        /// </summary>
        /// <param name="pNombreBanner"></param>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFin"></param>
        /// <param name="pHoraInicio"></param>
        /// <param name="pHoraFin"></param>
        /// <param name="mNombreTipoDeEstrategia"></param>
        /// <param name="pEstrategia"></param>
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
        /// <summary>
        /// metodo para modificar un banner
        /// </summary>
        /// <param name="pBanner"></param>
        /// <param name="pNombre"></param>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFin"></param>
        /// <param name="pHoraInicio"></param>
        /// <param name="pHoraFin"></param>
        /// <param name="pidDatosFuente"></param>
        /// <param name="pNombreEstrategia"></param>
        public void ModificarBanner(Banner pBanner, string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pidDatosFuente, string pNombreEstrategia)
        {
            pBanner.NombreBanner = pNombre;
            pBanner.FechaInicio = pFechaInicio;
            pBanner.FechaFin = pFechaFin;
            pBanner.HoraInicio = pHoraInicio;
            pBanner.HoraFin = pHoraFin;
            pBanner.EstrategiaTipoDatosFuente.NombreTipoDeEstrategia = pNombreEstrategia;
            pBanner.EstrategiaTipoDatosFuente.DatosEstrategiaId = pidDatosFuente;
            this.iUdT.RepositorioBanner.Modificar(pBanner);
            iUdT.Guardar();
        }

        /// <summary>
        /// Metodo para eliminar un banner
        /// </summary>
        /// <param name="mBanner"></param>
        public void EliminarBanner(Banner mBanner)
        {
            this.iUdT.RepositorioBanner.Eliminar(mBanner);
            iUdT.Guardar();
        }

        /// <summary>
        /// Este metodo cumple la función de cargar un banner para su modificación.
        /// </summary>
        /// <param name="mBannerMod"></param>
        /// <param name="txtNomBannerMod"></param>
        /// <param name="dTPickFechaDesdeModBan"></param>
        /// <param name="dTPickFechaHastaModBan"></param>
        /// <param name="nUpDesdeHoraModBan"></param>
        /// <param name="nUpHastaHoraModBan"></param>
        /// <param name="cBoxFuenteModBanner"></param>
        /// <param name="txtNombreTextoFijoMod"></param>
        /// <param name="txtDescripModTexFijo"></param>
        /// <param name="txtNombreModRss"></param>
        /// <param name="txtModUrl"></param>
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

        internal IList<Banner> BuscarBannerActivosHoyPorRango()
        {
            IList<Banner> listaBannerRango = iUdT.RepositorioBanner.BuscarBannerActivosRango();
            return listaBannerRango;
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
        public IList<Banner> BuscarBannerActivosHoy()
        {
            IList<Banner> listaBanner= iUdT.RepositorioBanner.BuscarBannerActivos();
            return listaBanner;
        }
    }


}
