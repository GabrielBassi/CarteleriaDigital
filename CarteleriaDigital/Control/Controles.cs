using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Excepciones;


namespace CarteleriaDigital.Control
{
    class Controles
    {
        /// <summary>
        /// Método para validar la fecha de inicio y fin de una campaña
        /// </summary>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFin"></param>
        public void ValidarFecha(DateTime pFechaInicio, DateTime pFechaFin)
        {
            if (pFechaInicio > pFechaFin)
            {
                throw new ExcepcionControlFechas("La fecha de fin debe ser mayor o igual a la fecha de inicio");
            }
        }

        /// <summary>
        /// Metodo para validar hira de inicio y fin de una campaña
        /// </summary>
        /// <param name="pHoraInicio"></param>
        /// <param name="pHoraFin"></param>
        public void ValidarHora(int pHoraInicio, int pHoraFin)
        {
            if (pHoraInicio >= pHoraFin)
            {
                throw new ExcepcionControlFechas("La hora de fin debe ser mayor la hora de inicio");
            }
        }
        public void ValidarRangoHora(int pHoraInicio, int pHoraFin)
        {
            if (pHoraFin- pHoraInicio>1)
            {
                throw new ExcepcionControlFechas("El rango no puede exceder más de 1 hora");
            }
        }
    }
}


