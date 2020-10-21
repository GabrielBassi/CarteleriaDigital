using System;
using System.Collections.Generic;
using CarteleriaDigital.Modelo;
using CarteleriaDigital.DAL.EntityFramework;
using System.Windows.Forms;

namespace CarteleriaDigital.Controladores
{
    class ControladorCampaña
    {
        private readonly UnidadDeTrabajo iUdT;
        private ControladorImagen iControladorImagen;

        public ControladorCampaña(UnidadDeTrabajo pUnidadDeTrabajo)
        {
            this.iUdT = pUnidadDeTrabajo;
            iControladorImagen = new ControladorImagen(iUdT/*, 1, 1*/);

        }
        /// <summary>
        /// Se agrega una nueva campaña al repositorio
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFin"></param>
        /// <param name="pHoraInicio"></param>
        /// <param name="pHoraFin"></param>
        /// <param name="pDuracion"></param>
        /// <param name="pListaImagen"></param>
        

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
                ListaImagenes=pListaImagen,
            };

            iUdT.RepositorioCampaña.Agregar(iCampaña);
            iUdT.Guardar();
        }

        /// <summary>
        /// Modifica una campaña en el repositorio
        /// </summary>
        /// <param name="pCampaña">Campaña a modificar</param>
        /// <param name="pNombre"></param>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFin"></param>
        /// <param name="pHoraInicio"></param>
        /// <param name="pHoraFin"></param>
        /// <param name="pDuracion"></param>
        /// <param name="pListaImagen"></param>

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

        /// <summary>
        /// Elimina una campaña
        /// </summary>
        /// <param name="mCampañaMod"></param>
        public void EliminarCampaña(Campaña mCampañaMod)
        {
            this.iUdT.RepositorioCampaña.Eliminar(mCampañaMod);
            iUdT.Guardar();
        }

        /// <summary>
        /// Consulta la existencia de una campaña para controlar que no se repita el nombre
        /// </summary>
        /// <param name="pNombreCampaña"></param>
        /// <returns></returns>
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
        /// Busca campañas por nombre ya cargadas previamente para mostrarlas en el combo box
        /// </summary>
        /// <param name="pCadena"></param>
        /// <returns></returns>

        public Campaña BuscarCampañaPorNombre(string pCadena)
        {
            Campaña iCampaña = iUdT.RepositorioCampaña.ExistenciaCampaña(pCadena);
            return iCampaña;
        }

        /// <summary>
        /// Devuelve una lista con todas las campañas cargadas
        /// </summary>
        /// <param name="pCombo"></param>
        public void CargarCampañasActivasComboBox(ComboBox pCombo)
        {
            IList<Campaña> listaCampañas = iUdT.RepositorioCampaña.ObtenerTodos();
            foreach (Campaña item in listaCampañas)
            {
                pCombo.Items.Add(item.Nombre);
            }
        }

        internal IList<Campaña> BuscarCampañaActivosHoyPorRango()
        {
            IList<Campaña> listaCAmpañasRango = iUdT.RepositorioCampaña.BuscarCampañaActivosRango();
            return listaCAmpañasRango;
        }
    }
    //public Campaña BuscarCampaña(int pId)
    //{
    //    Campaña iCampaña = iUdT.RepositorioCampaña.Obtener(pId);
    //    return iCampaña;
    //}

    //public void CargarCampañaModificar(Campaña mCampañaMod, TextBox txtNomCampañaMod, NumericUpDown nUDuracionMod, DateTimePicker dTPickFechaDesdeMod, DateTimePicker dTPickFechaHastaMod, NumericUpDown nUpDesdeHoraMod, NumericUpDown nUpHastaHoraMod, GroupBox gBoxCampañaMod)
    //{

    //    //txtNomCampañaMod.Text = mCampañaMod.Nombre;
    //    //nUDuracionMod.Value = mCampañaMod.DuracionImagen;
    //    //dTPickFechaDesdeMod.Value = mCampañaMod.FechaInicio;
    //    //dTPickFechaHastaMod.Value = mCampañaMod.FechaFin;
    //    //nUpDesdeHoraMod.Value = Convert.ToDecimal(mCampañaMod.HoraInicio.Hours);
    //    //nUpHastaHoraMod.Value = Convert.ToDecimal(mCampañaMod.HoraFin.Hours);

    //    //iControladorImagen.CargoPictureBoxModificar(iControladorImagen.ListaImagensPorCampañaId(mCampañaMod.CampañaId), gBoxCampañaMod, 20, 35);
    //}

    //public IList<Campaña> BuscarCampañaActivosHoy()
    //{
    //    IList<Campaña> listaCAmpañas = iUdT.RepositorioCampaña.BuscarCampañaActivos();
    //    return listaCAmpañas;
    //}

}
