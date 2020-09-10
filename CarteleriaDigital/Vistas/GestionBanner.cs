using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarteleriaDigital.Controladores;
using CarteleriaDigital.DAL.EntityFramework;
using CarteleriaDigital.Excepciones;
using CarteleriaDigital.Modelo;
using CarteleriaDigital.Control;

namespace CarteleriaDigital.Vistas
{
    public partial class GestionBanner : Form
    {
        ControladorBanner iControladorBanner;
        Controles iControl;
        Banner mBannerMod;
        public GestionBanner()
        {
            InitializeComponent();
            iControladorBanner = new ControladorBanner(UnidadDeTrabajo.Instancia);
            iControl = new Controles();
        }

        private void btnAceptarBanner_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomAgregarBanner.Text) || (string.IsNullOrWhiteSpace(dTPickFechaDesdeBan.Text))
                || (string.IsNullOrWhiteSpace(dTPickFechaHastaBan.Text)) || (string.IsNullOrWhiteSpace(nUpDesdeHoraAgregarBan.Text))
                || (string.IsNullOrWhiteSpace(nUpHastaHoraAgregarBan.Text)))

                {
                    throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                }

                DateTime pFechaInicio = new DateTime(this.dTPickFechaDesdeBan.Value.Year, this.dTPickFechaDesdeBan.Value.Month, this.dTPickFechaDesdeBan.Value.Day, Convert.ToInt32(this.nUpDesdeHoraAgregarBan.Text), 0, 0);
                DateTime pFechaFin = new DateTime(this.dTPickFechaHastaBan.Value.Year, this.dTPickFechaHastaBan.Value.Month, this.dTPickFechaHastaBan.Value.Day, Convert.ToInt32(this.nUpHastaHoraAgregarBan.Text), 0, 0);
                int pHoraInicio = Convert.ToInt32(nUpDesdeHoraAgregarBan.Value);
                int pHoraFin = Convert.ToInt32(nUpHastaHoraAgregarBan.Value);
                iControl.ValidarFecha(pFechaInicio, pFechaFin);
                iControl.ValidarHora(pHoraInicio, pHoraFin);

                iControladorBanner.AgregarBanner(txtNomAgregarBanner.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay);
                MessageBox.Show("El banner se registro correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Error", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void tabCtrlBanner_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlBanner.SelectedIndex == 0)
            {
                LimpiarPantallaAlta();
            }
            else if (tabCtrlBanner.SelectedIndex == 1)
            {
                LimpiarPantallaMod();
            }
        }
        private void LimpiarPantallaAlta()
        {
            txtNomAgregarBanner.Text = "";
            dTPickFechaDesdeBan.Value = DateTime.Now;
            dTPickFechaHastaBan.Value = DateTime.Now;
            nUpDesdeHoraAgregarBan.Value = 0;
            nUpHastaHoraAgregarBan.Value = 0;
            //falta limpiar combos
            
        }
        private void LimpiarPantallaMod()
        {
            txtNomBannerMod.Text = "";
            dTPickFechaDesdeModBan.Value = DateTime.Now;
            dTPickFechaHastaModBan.Value = DateTime.Now;
            nUpDesdeHoraModBan.Value = 0;
            nUpHastaHoraModBan.Value = 0;
            //falta limpiar combos

        }

        private void btnModVolverBanner_Click(object sender, EventArgs e)
        {
            this.Close();
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
                }

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarBanner_Click(object sender, EventArgs e)
        {
            try
            { 
                if (string.IsNullOrWhiteSpace(txtNomBannerMod.Text) /*|| (string.IsNullOrWhiteSpace(cBoxFuenteDatosAgregBanner.Text))*/
                || (string.IsNullOrWhiteSpace(dTPickFechaDesdeModBan.Text)) || (string.IsNullOrWhiteSpace(dTPickFechaHastaModBan.Text))
                || (string.IsNullOrWhiteSpace(nUpHastaHoraModBan.Text)) || (string.IsNullOrWhiteSpace(nUpHastaHoraModBan.Text)))

            {
                throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
            }
                DateTime pFechaInicio = new DateTime(this.dTPickFechaDesdeModBan.Value.Year, this.dTPickFechaDesdeModBan.Value.Month, this.dTPickFechaDesdeModBan.Value.Day, Convert.ToInt32(this.nUpDesdeHoraModBan.Text), 0, 0);
                DateTime pFechaFin = new DateTime(this.dTPickFechaHastaModBan.Value.Year, this.dTPickFechaHastaModBan.Value.Month, this.dTPickFechaHastaModBan.Value.Day, Convert.ToInt32(this.nUpHastaHoraModBan.Text), 0, 0);
                int pHoraInicio = Convert.ToInt32(nUpDesdeHoraModBan.Value);
                int pHoraFin = Convert.ToInt32(nUpHastaHoraModBan.Value);
                iControl.ValidarFecha(pFechaInicio, pFechaFin);
                iControl.ValidarHora(pHoraInicio, pHoraFin);

                iControladorBanner.ModificarBanner(mBannerMod, txtNomBannerMod.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay);

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
        }
    }
}




