using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;
using CarteleriaDigital.DAL.EntityFramework;
using System.Windows.Forms;
using CarteleriaDigital.Excepciones;

namespace CarteleriaDigital.Controladores
{
    class ControladorCampaña
    {
        private readonly UnidadDeTrabajo iUdT;
        private ControladorImagen iControladorImagen;
        int aa = 20;
        int jj = 35;

        public ControladorCampaña(UnidadDeTrabajo pUnidadDeTrabajo)
        {
            this.iUdT = pUnidadDeTrabajo;
            iControladorImagen = new ControladorImagen(iUdT, aa, jj);

        }
        /// <summary>
        /// Se agrega una nueva campaña al repositorio
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pFechaFin"></param>
        /// <param name="pFechaInicio"></param>
        /// <param name="pHoraFin"></param>
        /// <param name="pHoraInicio"></param>
        /// <param name="pDuracion"></param>

        public void AgregarCampaña(string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pDuracion, IList<Imagen> pListaImagen)
        {
            Campaña iCampaña = new Campaña()
            {
                Nombre = pNombre,
                FechaInicio = pFechaInicio,
                FechaFin = pFechaFin,
                HoraInicio = pHoraInicio,
                HoraFin = pHoraFin,
                DuracionImagen = pDuracion,
                ListaImagenes = pListaImagen,
            };

            iUdT.RepositorioCampaña.Agregar(iCampaña);
            iUdT.Guardar();
        }

        internal bool ConsultarExistenciaNombreCampaña(string pNombreCampaña)
        {
            bool existencia = false;
            existencia = iUdT.RepositorioCampaña.ExisteCampañaPorNombre(pNombreCampaña);
            if (existencia == true)
            {
                return true;
            }
            else
            {
                return existencia;
            }
        }

        /// <summary>
        /// Modifica una campaña en el repositorio
        /// </summary>
        /// <param name="pCampaña">Campaña a modificar</param>
        /// 
        public void ModificarCampaña(Campaña pCampaña, string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pDuracionImagen, IList<Imagen> pListaImagen)
        {
            pCampaña.Nombre = pNombre;
            pCampaña.FechaInicio = pFechaInicio;
            pCampaña.FechaFin = pFechaFin;
            pCampaña.HoraInicio = pHoraInicio;
            pCampaña.HoraFin = pHoraFin;
            pCampaña.DuracionImagen = pDuracionImagen;
            pCampaña.ListaImagenes = pListaImagen;
            this.iUdT.RepositorioCampaña.Modificar(pCampaña);
            iUdT.Guardar();
        }

        public void CargarCampañasActivasComboBox(ComboBox pCombo)
        {
            IList<Campaña> listaCampañas = iUdT.RepositorioCampaña.ObtenerTodos();
            foreach (Campaña item in listaCampañas)
            {
                pCombo.Items.Add(item.Nombre);
            }
        }
        public Campaña BuscarCampaña(int pId)
        {
            Campaña iCampaña = iUdT.RepositorioCampaña.Obtener(pId);
            return iCampaña;
        }
        public Campaña BuscarCampañaPorNombre(string pCadena)
        {
            Campaña iCampaña = iUdT.RepositorioCampaña.ExistenciaCampaña(pCadena);
            return iCampaña;
        }
        public void CargarCampañaModificar(Campaña mCampañaMod, TextBox txtNomCampañaMod, NumericUpDown nUDuracionMod, DateTimePicker dTPickFechaDesdeMod, DateTimePicker dTPickFechaHastaMod, NumericUpDown nUpDesdeHoraMod, NumericUpDown nUpHastaHoraMod, GroupBox gBoxCampañaMod)
        {

            txtNomCampañaMod.Text = mCampañaMod.Nombre;
            nUDuracionMod.Value = mCampañaMod.DuracionImagen;
            dTPickFechaDesdeMod.Value = mCampañaMod.FechaInicio;
            dTPickFechaHastaMod.Value = mCampañaMod.FechaFin;
            nUpDesdeHoraMod.Value = Convert.ToDecimal(mCampañaMod.HoraInicio.Hours);
            nUpHastaHoraMod.Value = Convert.ToDecimal(mCampañaMod.HoraFin.Hours);

            iControladorImagen.CargoPictureBoxModificar(iControladorImagen.ListaImagensPorCampañaId(mCampañaMod.CampañaId), gBoxCampañaMod, 20, 35);
        }
        public void EliminarCampaña(Campaña mCampañaMod)
        {
            this.iUdT.RepositorioCampaña.Eliminar(mCampañaMod);
            iUdT.Guardar();
        }
    }
}
