using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.DAL;
using CarteleriaDigital.Excepciones;
using CarteleriaDigital.Modelo;
using CarteleriaDigital.DAL.EntityFramework;

namespace CarteleriaDigital.Controladores
{
    class ControladorBanner
    {
        private readonly IUnidadDeTrabajo iUdT;

        public ControladorBanner(IUnidadDeTrabajo pUnidadDeTrabajo)
        {
            this.iUdT = pUnidadDeTrabajo;
        }
        public void AgregarBanner(string pNombreBanner, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin)
        {
            Banner iBanner = new Banner()
            {
                NombreBanner = pNombreBanner,
                FechaInicio = pFechaInicio,
                FechaFin = pFechaFin,
                HoraInicio = pHoraInicio,
                HoraFin = pHoraFin,
            };

            this.iUdT.RepositorioBanner.Agregar(iBanner);
            iUdT.Guardar();
        }
        public void ModificarBanner(Banner pBanner, string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin)
        {
            pBanner.NombreBanner = pNombre;
            pBanner.FechaInicio = pFechaInicio;
            pBanner.FechaFin = pFechaFin;
            pBanner.HoraInicio = pHoraInicio;
            pBanner.HoraFin = pHoraFin;
            this.iUdT.RepositorioBanner.Modificar(pBanner);
            iUdT.Guardar();
        }
        public void EliminarBanner(Banner mBanner)
        {
            this.iUdT.RepositorioBanner.Eliminar(mBanner);
            iUdT.Guardar();
        }
    }
}
