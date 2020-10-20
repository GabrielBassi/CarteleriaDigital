using System;
using System.Windows.Forms;
using CarteleriaDigital.Controladores;
using CarteleriaDigital.DAL.EntityFramework;
using CarteleriaDigital.Excepciones;
using CarteleriaDigital.Modelo;
using CarteleriaDigital.Controless;

namespace CarteleriaDigital.Vistas
{
    public partial class GestionBanner : Form
    {
        ControladorBanner iControladorBanner;
        ControladorTextoFijo iControladorTextoFijo;
        ControladorRssUrl iControladorRssUrl;
        Controles iControl;
        Banner mBannerMod;
        RssUrl mRssUrl;
        TextoFijo mTextoFijo;
        int pDatosEstrategia = 0;
        int idDatosTipoFuente = 0;
        public GestionBanner()
        {
            InitializeComponent();
            iControladorBanner = new ControladorBanner(UnidadDeTrabajo.Instancia);
            iControladorTextoFijo = new ControladorTextoFijo(UnidadDeTrabajo.Instancia);
            iControladorRssUrl = new ControladorRssUrl(UnidadDeTrabajo.Instancia);
            iControl = new Controles();
        }

        private void btnAceptarBanner_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtNomAgregarBanner.Text) || (string.IsNullOrWhiteSpace(dTPickFechaDesdeBan.Text))
                || (string.IsNullOrWhiteSpace(dTPickFechaHastaBan.Text)) || (string.IsNullOrWhiteSpace(nUpDesdeHoraAgregarBan.Text))
                || (string.IsNullOrWhiteSpace(nUpHastaHoraAgregarBan.Text)) ||  ( string.IsNullOrWhiteSpace(cBoxFuenteDatosAgregBanner.Text)))

                {
                    throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                }

                if (txtNomAgregarBanner.Text != "")
                {
                    if (iControladorBanner.ConsultarExistenciaNombreBanner(txtNomAgregarBanner.Text) == true)
                    {
                        throw new ExisteNombre("Ya existe un Banner con ese nombre");
                    }
                }
              
                DateTime pFechaInicio = new DateTime(this.dTPickFechaDesdeBan.Value.Year, this.dTPickFechaDesdeBan.Value.Month, this.dTPickFechaDesdeBan.Value.Day, Convert.ToInt32(this.nUpDesdeHoraAgregarBan.Text), 0, 0);
                DateTime pFechaFin = new DateTime(this.dTPickFechaHastaBan.Value.Year, this.dTPickFechaHastaBan.Value.Month, this.dTPickFechaHastaBan.Value.Day, Convert.ToInt32(this.nUpHastaHoraAgregarBan.Text), 0, 0);
                iControl.ValidarFecha(pFechaInicio, pFechaFin);
                
                int pHoraInicio = Convert.ToInt32(nUpDesdeHoraAgregarBan.Value);
                int pHoraFin = Convert.ToInt32(nUpHastaHoraAgregarBan.Value);
                
                iControl.ValidarHora(pHoraInicio, pHoraFin);
                iControl.ValidarRangoHora(pHoraInicio, pHoraFin);

                if (cBoxFuenteDatosAgregBanner.Text == "Texto Fijo") 
                {
                    if ((string.IsNullOrWhiteSpace(txtNombreTextoFijo.Text)) || (string.IsNullOrWhiteSpace(txtDescripTextoFijo.Text)))

                    {
                        throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                    }
                    else if (txtNombreTextoFijo.Text != " ")
                    {
                        if (iControladorTextoFijo.ConsultarExistenciaNombreTextoFijo(txtNombreTextoFijo.Text) == true) 
                        {
                            throw new ExisteNombre("Ya existe un texto fijo con ese nombre");
                        }
                    }
                    iControladorTextoFijo.AgregarTextoFijo(txtNombreTextoFijo.Text, txtDescripTextoFijo.Text);
                    pDatosEstrategia = iControladorTextoFijo.UltimoIdTextoFijo();  
                }
                else if (cBoxFuenteDatosAgregBanner.Text == "RSS")
                {
                    if ((string.IsNullOrWhiteSpace(txtNomAceptarRss.Text)) || (string.IsNullOrWhiteSpace(txtUrlAgregarRssUrl.Text)))

                    {
                        throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                    }
                    else if (txtNomAceptarRss.Text != " ")
                    {
                        if (iControladorRssUrl.ConsultarExistenciaNombreRss(txtNomAceptarRss.Text) == true)
                        {
                            throw new ExisteNombre("Ya existe un Rss con ese nombre");
                        }
                    }

                    iControladorRssUrl.AgregarRssUrl(txtNomAceptarRss.Text,txtUrlAgregarRssUrl.Text);
                    pDatosEstrategia = iControladorRssUrl.UltimoIdRSS();
                }
                iControladorBanner.AgregarBanner(txtNomAgregarBanner.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, cBoxFuenteDatosAgregBanner.Text, pDatosEstrategia);                
                MessageBox.Show("El banner se registro correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarPantallaAlta();
            
            }

            catch (FaltanDatosObligatorios msg)
            {
                MessageBox.Show(msg.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cBoxFuenteDatosAgregBanner_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBoxFuenteDatosAgregBanner.Text == "Texto Fijo")
            {
                gBoxTextoFijo.Visible = true;
                gBoxRss.Visible = false;
                txtNomAceptarRss.Text = "";
                txtUrlAgregarRssUrl.Text = ""; 
            }
            else
            {
                gBoxRss.Visible = true;
                gBoxTextoFijo.Visible = false;
                txtNombreTextoFijo.Text = "";
                txtDescripTextoFijo.Text = "";
            }

        }

        private void BtnVolverBanner_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionBanner_Load(object sender, EventArgs e)
        {
            dTPickFechaDesdeBan.Value = DateTime.Today;
            dTPickFechaHastaBan.Value = DateTime.Today;
            dTPickFechaDesdeModBan.Value = DateTime.Today;
            dTPickFechaHastaModBan.Value = DateTime.Today;
            iControladorBanner.CargarBannerActivasComboBox(cboxBuscarBannerMod);
        }

        private void tabCtrlBanner_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlBanner.SelectedIndex == 0)
            {
                LimpiarPantallaAlta();
              //  iControladorBanner.CargarBannerActivasComboBox(cboxBuscarBannerMod);
            }
            else if (tabCtrlBanner.SelectedIndex == 1)
            {
                LimpiarPantallaMod();
                iControladorRssUrl.CargarRssActivos(cBoxModRss);
                iControladorTextoFijo.CargarTextoFijoActivos(CmbModTextoFijo);
                cboxBuscarBannerMod.Items.Clear();
                iControladorBanner.CargarBannerActivasComboBox(cboxBuscarBannerMod);
            }

        }
        private void LimpiarPantallaAlta()
        {
            txtNomAgregarBanner.Text = "";
            dTPickFechaDesdeBan.Value = DateTime.Now;
            dTPickFechaHastaBan.Value = DateTime.Now;
            nUpDesdeHoraAgregarBan.Value = 0;
            nUpHastaHoraAgregarBan.Value = 0;
            cboxBuscarBannerMod.Items.Clear();
            txtNomAceptarRss.Text = "";
            txtUrlAgregarRssUrl.Text = "";
            cBoxFuenteDatosAgregBanner.Text = ""; 
            txtNombreTextoFijoMod.Text = "";
            txtDescripModTexFijo.Text = "";
            cBoxModRss.Text = "";
            txtNombreModRss.Text = "";
            txtModUrl.Text = "";
            txtNombreTextoFijo.Text = "";
            txtDescripTextoFijo.Text = "";
            cBoxModRss.Items.Clear();
            cBoxModRss.Text = "";
            cBoxFuenteModBanner.SelectedItem = null;
            cBoxFuenteDatosAgregBanner.SelectedItem = null;
            CmbModTextoFijo.Items.Clear();
            

        }
        private void LimpiarPantallaMod()
        {
            txtNomBannerMod.Text = "";
            dTPickFechaDesdeModBan.Value = DateTime.Now;
            dTPickFechaHastaModBan.Value = DateTime.Now;
            nUpDesdeHoraModBan.Value = 0;
            nUpHastaHoraModBan.Value = 0;
            cboxBuscarBannerMod.SelectedItem = null;
            txtNombreTextoFijo.Text = "";
            txtDescripTextoFijo.Text = "";
            cBoxFuenteModBanner.Text = "";
            txtNombreTextoFijoMod.Text = "";
            txtDescripModTexFijo.Text = "";
            cBoxFuenteDatosAgregBanner.SelectedItem = null;
            cBoxFuenteModBanner.SelectedItem = null;
            CmbModTextoFijo.SelectedItem = null;
            txtNombreModRss.Text = "";
            txtModUrl.Text = "";
          
        }

        private void btnModVolverBanner_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarBanner_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomBannerMod.Text) || (string.IsNullOrWhiteSpace(cBoxFuenteModBanner.Text))
                || (string.IsNullOrWhiteSpace(dTPickFechaDesdeModBan.Text)) || (string.IsNullOrWhiteSpace(dTPickFechaHastaModBan.Text))
                || (string.IsNullOrWhiteSpace(nUpDesdeHoraModBan.Text)) || (string.IsNullOrWhiteSpace(nUpHastaHoraModBan.Text))
                || (string.IsNullOrWhiteSpace(cBoxFuenteModBanner.Text)) )
                {
                    throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                }
                DateTime pFechaInicio = new DateTime(this.dTPickFechaDesdeModBan.Value.Year, this.dTPickFechaDesdeModBan.Value.Month, this.dTPickFechaDesdeModBan.Value.Day, Convert.ToInt32(this.nUpDesdeHoraModBan.Text), 0, 0);
                DateTime pFechaFin = new DateTime(this.dTPickFechaHastaModBan.Value.Year, this.dTPickFechaHastaModBan.Value.Month, this.dTPickFechaHastaModBan.Value.Day, Convert.ToInt32(this.nUpHastaHoraModBan.Text), 0, 0);
                int pHoraInicio = Convert.ToInt32(nUpDesdeHoraModBan.Value);
                int pHoraFin = Convert.ToInt32(nUpHastaHoraModBan.Value);
                iControl.ValidarFecha(pFechaInicio, pFechaFin);
                iControl.ValidarHora(pHoraInicio, pHoraFin);
                iControl.ValidarRangoHora(pHoraInicio, pHoraFin);
                if (cBoxFuenteModBanner.Text == "Texto Fijo")
                {
                    if (string.IsNullOrWhiteSpace(txtNombreTextoFijoMod.Text) || (string.IsNullOrWhiteSpace(txtDescripModTexFijo.Text)))

                    {
                        throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                    }
                    else if (txtNombreTextoFijo.Text != " ")
                    {
                        if (iControladorTextoFijo.ConsultarExistenciaNombreTextoFijo(txtNombreTextoFijo.Text) == true)
                        {
                            throw new ExisteNombre("Ya existe un texto fijo con ese nombre");
                        }
                    }
                }
                else if (cBoxFuenteModBanner.Text == "RSS")
                {
                    if (string.IsNullOrWhiteSpace(txtNombreModRss.Text) || (string.IsNullOrWhiteSpace(txtModUrl.Text)))

                    {
                        throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                    }
                }
                else if (txtNomAceptarRss.Text != " ")
                {
                    if (iControladorRssUrl.ConsultarExistenciaNombreRss(txtNomAceptarRss.Text) == true)
                    {
                        throw new ExisteNombre("Ya existe un Rss con ese nombre");
                    }
                }

                iControladorBanner.ModificarBanner(mBannerMod, txtNomBannerMod.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, idDatosTipoFuente, cBoxFuenteModBanner.Text);

            MessageBox.Show("El Banner se modifico correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarPantallaMod();
            }
            catch (ExcepcionControlFechas msg)
            {
                MessageBox.Show(msg.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FaltanDatosObligatorios ex)
            {
                MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cBoxFuenteModBanner_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBoxFuenteModBanner.Text == "Texto Fijo")
            {
                gBoxModTextoFijo.Visible = true;
                gBoxModRss.Visible = false;
                cBoxModRss.Text = "";
                txtNombreModRss.Text = "";
                txtModUrl.Text = "";


            }
            else if (cBoxFuenteModBanner.Text == "RSS")
            {
                gBoxModRss.Visible = true;
                gBoxModTextoFijo.Visible = false;
                txtNombreTextoFijoMod.Text = "";
                txtDescripModTexFijo.Text = "";
            }
        }

        private void btnModEliminarBanner_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Desea Eliminar el banner", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    iControladorBanner.EliminarBanner(mBannerMod);
                    MessageBox.Show("El banner se eliminó correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarPantallaMod();
                    cboxBuscarBannerMod.Text = "";
                    cboxBuscarBannerMod.Items.Clear();
                    iControladorBanner.CargarBannerActivasComboBox(cboxBuscarBannerMod);
                }

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboxBuscarBannerMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboxBuscarBannerMod.Text!="")
                {
                    mBannerMod = iControladorBanner.BuscarBannerPorNombre(cboxBuscarBannerMod.Text);
                    iControladorBanner.CargarBannerModificar(mBannerMod, txtNomBannerMod, dTPickFechaDesdeModBan, dTPickFechaHastaModBan, nUpDesdeHoraModBan, nUpHastaHoraModBan, cBoxFuenteModBanner, txtNombreTextoFijoMod, txtDescripModTexFijo, txtNombreModRss, txtModUrl);
                    if (mBannerMod.EstrategiaTipoDatosFuente.NombreTipoDeEstrategia == "Texto Fijo")
                    {
                        int idtF = Convert.ToInt32(mBannerMod.EstrategiaTipoDatosFuente.DatosEstrategiaId);
                        idDatosTipoFuente = iControladorTextoFijo.Obtener(idtF).TextoFijoId;
                    }
                }
              
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cBoxModRss_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {   
                mRssUrl = iControladorRssUrl.BuscarRssPorNombre(cBoxModRss.Text);
                idDatosTipoFuente= iControladorRssUrl.BuscarRssPorNombre(cBoxModRss.Text).RssUrlId;
                iControladorRssUrl.CargarRssUrlModificar(mRssUrl, txtNombreModRss, txtModUrl);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CmbModTextoFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mTextoFijo = iControladorTextoFijo.BuscarTextoFijoPorNombre(CmbModTextoFijo.Text);
                idDatosTipoFuente = mTextoFijo.TextoFijoId;
                iControladorTextoFijo.CargarTextoFijoModificar(mTextoFijo, txtNombreTextoFijoMod, txtDescripModTexFijo);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}




