using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarteleriaDigital.Excepciones;
using CarteleriaDigital.Controladores;
using CarteleriaDigital.DAL.EntityFramework;
using CarteleriaDigital.Modelo;
using CarteleriaDigital.Controless;
using System.Drawing;
using System.IO;

namespace CarteleriaDigital.Vistas
{
    public partial class GestionCampaña : Form
    {
        ControladorCampaña iControladorCampaña;
        ControladorImagen iControladorImagen;
        Campaña mCampañaMod;
        Controles iControl;
        IList<Imagen> listaImagenes = new List<Imagen>();

        public GestionCampaña()
        {
            InitializeComponent();
            iControladorCampaña = new ControladorCampaña(UnidadDeTrabajo.Instancia);
            iControladorImagen = new ControladorImagen(UnidadDeTrabajo.Instancia/*,1,1*/);
            iControl = new Controles();

        }


        //Evento que se activa al presionar el boton aceptar en campaña, la cual agregar una nueva campaña con los datos de la misma.
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
                iControl.ValidarRangoHora(pHoraInicio, pHoraFin);

                if (listaImagenes.Count == 0)
                {
                    throw new FaltanDatosObligatorios("Faltar Cargar Imágenes a la Campaña");
                }
                iControladorCampaña.AgregarCampaña(txBoxNombreAgregarCamp.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, Convert.ToInt32(nUDuracionAgregar.Text), listaImagenes);
                
                MessageBox.Show("La campaña se registro con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /// <summary>
        ///Evento que cargar las imagenes cuando se crea una nueva campaña. 
        /// </summary>

        private void CargarImag_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog CargarImagen = new OpenFileDialog();
                CargarImagen.Filter = "Imágenes(*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.png";

                if (CargarImagen.ShowDialog() == DialogResult.OK)
                {
                    this.CargarImagenEnUnPictureBox(CargarImagen,this.gBoxImagenes);                  
                    
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                MessageBox.Show("Ocurrió un error al cargar la imagen", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarImagenEnUnPictureBox(OpenFileDialog CargarImagen, GroupBox pBoxImagenes)
        {
            bool mCompleto = true;
            foreach (Control unPictureBox in pBoxImagenes.Controls)
            {
                if (unPictureBox.GetType()==typeof(PictureBox) && ((PictureBox)unPictureBox).Image == null)
                {
                    mCompleto = false;
                    ((PictureBox)unPictureBox).Image = Image.FromFile(CargarImagen.FileName);
                    ((PictureBox)unPictureBox).SizeMode = PictureBoxSizeMode.StretchImage;

                    ((PictureBox)unPictureBox).Tag = CargarImagen.FileName;

                    Imagen mImagen = new Imagen()
                    {
                        Nombre = Path.GetFileName(((PictureBox)unPictureBox).Tag.ToString()),
                        RutaImagen = CargarImagen.FileName,
                    };
                    this.listaImagenes.Add(mImagen);

                    break;
                }
            }

            if (mCompleto)
            {
                MessageBox.Show("Llegaste al máximo de Imágenes", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.QuitarLasImagenesEnPictureBox(this.gBoxImagenMod);
                mCampañaMod = iControladorCampaña.BuscarCampañaPorNombre(cBoxModCampActivas.Text);

                this.txtNomCampañaMod.Text = mCampañaMod.Nombre;
                this.nUDuracionMod.Value = mCampañaMod.DuracionImagen;
                this.dTPickFechaDesdeMod.Value = mCampañaMod.FechaInicio;
                this.dTPickFechaHastaMod.Value = mCampañaMod.FechaFin;
                this.nUpDesdeHoraMod.Value = Convert.ToDecimal(mCampañaMod.HoraInicio.Hours);
                this.nUpHastaHoraMod.Value = Convert.ToDecimal(mCampañaMod.HoraFin.Hours);
                this.listaImagenes = this.ClonarLista(mCampañaMod.ListaImagenes);
                this.CargarImagenEnLosPictureBox(this.listaImagenes);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarImagenEnLosPictureBox(IList<Imagen> pListaImagenes)
        {
            this.QuitarLasImagenesEnPictureBox(this.gBoxCampañaMod);
            foreach (Imagen unaImagen in pListaImagenes)
            {
                foreach (Control unPicturBox in this.gBoxImagenMod.Controls)
                {
                    if ((unPicturBox.GetType() == typeof(PictureBox)) && ((PictureBox)unPicturBox).Image == null)
                    {
                        ((PictureBox)unPicturBox).Image = Image.FromFile(unaImagen.RutaImagen);
                        ((PictureBox)unPicturBox).SizeMode = PictureBoxSizeMode.StretchImage;
                        ((PictureBox)unPicturBox).Tag = unaImagen.RutaImagen;
                        break;
                    }
                }
            }
        }

        private IList<Imagen> ClonarLista(IList<Imagen> pListaImagenes)
        {
            IList<Imagen> mLista = new List<Imagen>();
            foreach (Imagen unImagen in pListaImagenes)
            {
                mLista.Add(unImagen);
            }

            return mLista;
        }

        private void QuitarLasImagenesEnPictureBox(GroupBox pGBoxConImagenes)
        {
            foreach (Control unPictureBox in pGBoxConImagenes.Controls)
            {
                if (unPictureBox.GetType()==typeof(PictureBox))
                {
                    ((PictureBox)unPictureBox).Image = null;
                }                
            }
            this.Refresh();
        }

        private void CargarImagMod_Click(object sender, EventArgs e)
        {
            OpenFileDialog CargarImagen = new OpenFileDialog();
            CargarImagen.Filter = "";
            if (CargarImagen.ShowDialog()==DialogResult.OK)
            {
                this.CargarImagenEnUnPictureBox(CargarImagen, this.gBoxImagenMod);
            }

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
            this.QuitarLasImagenesEnPictureBox(this.gBoxImagenes);
            this.listaImagenes = new List<Imagen>(); 
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
            this.QuitarLasImagenesEnPictureBox(this.gBoxImagenMod);
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
                iControl.ValidarRangoHora(pHoraInicio, pHoraFin);
                //if (control == false)
                //{
                    iControladorCampaña.ModificarCampaña(mCampañaMod, txtNomCampañaMod.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, Convert.ToInt32(nUDuracionMod.Text),this.listaImagenes);
                ////}
                //else
                //{
                //    iControladorCampaña.ModificarCampaña(mCampañaMod, txtNomCampañaMod.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, Convert.ToInt32(nUDuracionMod.Text), iControladorImagen.ListaImagensPorCampañaId(mCampañaMod.CampañaId));
                //}

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
                }

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ElimarImagen(PictureBox pPictureBox)
        {
            pPictureBox.Image = null;

            string mNombre = Path.GetFileName(pPictureBox.Tag.ToString());
            var mlistaANTES = mCampañaMod.ListaImagenes;
            this.iControladorImagen.EliminarImagenPorNombre(mNombre);
            var lista = this.iControladorImagen.ListaImagensPorCampañaId(mCampañaMod.CampañaId);
            var mListaDESPUES = listaImagenes;
            this.cargarComboBORRAR(lista);
        }

        private void cargarComboBORRAR(IList<Imagen> lista)
        {
            this.QuitarLasImagenesEnPictureBox(this.gBoxImagenMod);
            mCampañaMod = iControladorCampaña.BuscarCampañaPorNombre(cBoxModCampActivas.Text);

            this.txtNomCampañaMod.Text = mCampañaMod.Nombre;
            this.nUDuracionMod.Value = mCampañaMod.DuracionImagen;
            this.dTPickFechaDesdeMod.Value = mCampañaMod.FechaInicio;
            this.dTPickFechaHastaMod.Value = mCampañaMod.FechaFin;
            this.nUpDesdeHoraMod.Value = Convert.ToDecimal(mCampañaMod.HoraInicio.Hours);
            this.nUpHastaHoraMod.Value = Convert.ToDecimal(mCampañaMod.HoraFin.Hours);
            this.CargarImagenEnLosPictureBox(lista);
        }

        /// <summary>
        /// Elimina cada imagen en la posición del picture box.
        /// </summary>

        private void btnEliminarMod1_Click(object sender, EventArgs e)
        {
            this.ElimarImagen(this.pictureBox11);

        }

        private void btnEliminarMod2_Click(object sender, EventArgs e)
        {
            this.ElimarImagen(this.pictureBox12);
        }

        private void btnEliminarMod3_Click(object sender, EventArgs e)
        {
            this.ElimarImagen(this.pictureBox13);
        }

        private void btnEliminarMod4_Click(object sender, EventArgs e)
        {
            this.ElimarImagen(this.pictureBox14);
        }

        private void btnEliminarMod5_Click(object sender, EventArgs e)
        {
            this.ElimarImagen(this.pictureBox15);
        }

        private void btnEliminarMod6_Click(object sender, EventArgs e)
        {
            this.ElimarImagen(this.pictureBox16);
        }

        private void btnEliminarMod7_Click(object sender, EventArgs e)
        {
            this.ElimarImagen(this.pictureBox17);
        }

        private void btnEliminarMod8_Click(object sender, EventArgs e)
        {
            this.ElimarImagen(this.pictureBox18);
        }

        private void btnEliminarMod9_Click(object sender, EventArgs e)
        {
            this.ElimarImagen(this.pictureBox19);
        }

        private void btnEliminarMod10_Click(object sender, EventArgs e)
        {
            this.ElimarImagen(this.pictureBox20);
        }
    }
}
