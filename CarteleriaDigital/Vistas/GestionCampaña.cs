using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarteleriaDigital.Excepciones;
using CarteleriaDigital.Controladores;
using CarteleriaDigital.DAL.EntityFramework;
using CarteleriaDigital.Modelo;
using CarteleriaDigital.Control;


namespace CarteleriaDigital.Vistas
{
    public partial class GestionCampaña : Form
    {
        ControladorCampaña iControladorCampaña;
        ControladorImagen iControladorImagen;
        Campaña mCampañaMod;
        Controles iControl;
        IList<Imagen> listaImagenes = new List<Imagen>();
        IList<Imagen> listaImagenesMod = new List<Imagen>();
        int aa = 20;
        int jj = 35;
        int contador = 0;
        bool control = false;

        public GestionCampaña()
        {
            InitializeComponent();
            iControladorCampaña = new ControladorCampaña(UnidadDeTrabajo.Instancia);
            iControladorImagen = new ControladorImagen(UnidadDeTrabajo.Instancia, aa, jj);
            iControl = new Controles();

        }

        private void TbCtrlAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptarCampaña_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txBoxNombreAgregarCamp.Text) || (string.IsNullOrWhiteSpace(dTPickFechaDesde.Text))
              || (string.IsNullOrWhiteSpace(dTPickFechaHasta.Text)) || (string.IsNullOrWhiteSpace(nUDuracionAgregar.Text))
              || (string.IsNullOrWhiteSpace(nUpDesdeHoraAgregar.Text)) || (string.IsNullOrWhiteSpace(nUpHastaHoraAgregar.Text)))

                {
                    throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                }
                if (txBoxNombreAgregarCamp.Text != "")
                {
                    if (iControladorCampaña.ConsultarExistenciaNombreCampaña(txBoxNombreAgregarCamp.Text) == true)
                    {
                        throw new ExisteNombre("Ya existe campaña con ese nombre");
                    }
                }
                //Métodos de control de los campos fechas, horas y duración.
                DateTime pFechaInicio = new DateTime(this.dTPickFechaDesde.Value.Year, this.dTPickFechaDesde.Value.Month, this.dTPickFechaDesde.Value.Day, Convert.ToInt32(this.nUpDesdeHoraAgregar.Text), 0, 0);
                DateTime pFechaFin = new DateTime(this.dTPickFechaHasta.Value.Year, this.dTPickFechaHasta.Value.Month, this.dTPickFechaHasta.Value.Day, Convert.ToInt32(this.nUpHastaHoraAgregar.Text), 0, 0);
                int pHoraInicio = Convert.ToInt32(nUpDesdeHoraAgregar.Value);
                int pHoraFin = Convert.ToInt32(nUpHastaHoraAgregar.Value); ;
                iControl.ValidarFecha(pFechaInicio, pFechaFin);
                iControl.ValidarHora(pHoraInicio, pHoraFin);


                if (listaImagenes.Count == 0)
                {
                    throw new FaltanDatosObligatorios("Faltar Cargar Imágenes a la Campaña");
                }

                //Revisar estos parámetros
                iControladorCampaña.AgregarCampaña(txBoxNombreAgregarCamp.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, Convert.ToInt32(nUDuracionAgregar.Text), listaImagenes);
                MessageBox.Show("La campaña se registro con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contador = 0; ///
                LimpiarPantallaAlta();

            }
            catch (ExisteNombre msg)
            {
                MessageBox.Show(msg.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarImag_Click(object sender, EventArgs e)
        {
            try
            {
                iControladorImagen.CargarImagenes(listaImagenes, gBoxImagenes, contador);
                contador = contador + 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar la imagen", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnVolverCampaña_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBoxModCampActivas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gBoxImagenMod.Controls.Clear();
                mCampañaMod = iControladorCampaña.BuscarCampañaPorNombre(cBoxModCampActivas.Text);
                iControladorCampaña.CargarCampañaModificar(mCampañaMod, txtNomCampañaMod, nUDuracionMod, dTPickFechaDesdeMod, dTPickFechaHastaMod, nUpDesdeHoraMod, nUpHastaHoraMod, gBoxImagenMod);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarImagMod_Click(object sender, EventArgs e)
        {
            control = iControladorImagen.CargarImagenesMod(mCampañaMod.ListaImagenes, listaImagenesMod, gBoxImagenMod);
        }


        private void GestionCampaña_Load(object sender, EventArgs e)
        {
            dTPickFechaDesde.Value = DateTime.Today;
            dTPickFechaHasta.Value = DateTime.Today;
            dTPickFechaDesdeMod.Value = DateTime.Today;
            dTPickFechaHastaMod.Value = DateTime.Today;
            iControladorCampaña.CargarCampañasActivasComboBox(cBoxModCampActivas);
        }

        private void TabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabCampaña.SelectedIndex == 0)
            {
                LimpiarPantallaAlta();
            }
            else if (tabCampaña.SelectedIndex == 1)
            {
                LimpiarPantallaMod();
            }
        }

        private void LimpiarPantallaAlta()
        {
            txBoxNombreAgregarCamp.Text = "";
            nUDuracionAgregar.Text = "5";
            dTPickFechaDesde.Value = DateTime.Now;
            dTPickFechaHasta.Value = DateTime.Now;
            nUpDesdeHoraAgregar.Value = 0;
            nUpHastaHoraAgregar.Value = 0;
            gBoxImagenes.Controls.Clear();
            listaImagenes.Clear();
            listaImagenes = new List<Imagen>();
        }
        private void LimpiarPantallaMod()
        {

            cBoxModCampActivas.Text = "";
            cBoxModCampActivas.Items.Clear();
            iControladorCampaña.CargarCampañasActivasComboBox(cBoxModCampActivas);
            txtNomCampañaMod.Text = "";
            nUDuracionMod.Text = "5";
            dTPickFechaDesdeMod.Value = DateTime.Now;
            dTPickFechaHastaMod.Value = DateTime.Now;
            nUpDesdeHoraMod.Value = 0;
            nUpHastaHoraMod.Value = 0;
            gBoxImagenMod.Controls.Clear();
            aa = 20;
            jj = 35;
            contador = 0;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomCampañaMod.Text) || (string.IsNullOrWhiteSpace(dTPickFechaDesdeMod.Text))
                 || (string.IsNullOrWhiteSpace(dTPickFechaHastaMod.Text)) || (string.IsNullOrWhiteSpace(nUDuracionMod.Text))
                 || (string.IsNullOrWhiteSpace(nUpDesdeHoraMod.Text)) || (string.IsNullOrWhiteSpace(nUpHastaHoraMod.Text)))

                {
                    throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                }
                DateTime pFechaInicio = new DateTime(this.dTPickFechaDesdeMod.Value.Year, this.dTPickFechaDesdeMod.Value.Month, this.dTPickFechaDesdeMod.Value.Day, Convert.ToInt32(this.nUpDesdeHoraMod.Text), 0, 0);
                DateTime pFechaFin = new DateTime(this.dTPickFechaHastaMod.Value.Year, this.dTPickFechaHastaMod.Value.Month, this.dTPickFechaHastaMod.Value.Day, Convert.ToInt32(this.nUpHastaHoraMod.Text), 0, 0);
                int pHoraInicio = Convert.ToInt32(nUpDesdeHoraMod.Value);
                int pHoraFin = Convert.ToInt32(nUpHastaHoraMod.Value);
                iControl.ValidarFecha(pFechaInicio, pFechaFin);
                iControl.ValidarHora(pHoraInicio, pHoraFin);
                if (control == true)
                {
                    iControladorCampaña.ModificarCampaña(mCampañaMod, txtNomCampañaMod.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, Convert.ToInt32(nUDuracionMod.Text), listaImagenesMod);
                }
                else
                {
                    iControladorCampaña.ModificarCampaña(mCampañaMod, txtNomCampañaMod.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, Convert.ToInt32(nUDuracionMod.Text), iControladorImagen.ListaImagensPorCampañaId(mCampañaMod.CampañaId));
                }

                MessageBox.Show("La campaña se modifico correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnModEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Desea Eliminar la Campaña", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    iControladorCampaña.EliminarCampaña(mCampañaMod);
                    MessageBox.Show("Se eliminó correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cBoxModCampActivas.Items.Clear();
                    LimpiarPantallaMod();
                    iControladorCampaña.CargarCampañasActivasComboBox(cBoxModCampActivas);
                }

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
