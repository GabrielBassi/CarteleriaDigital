using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.EntityFramework
{
    class RepositorioBanner : RepositorioGeneral<Banner, CarteleriaDigitalContext>, IRepositorioBanner
    {
        public RepositorioBanner(CarteleriaDigitalContext pContext) : base(pContext)
        {

        }
        public Banner ExistenciaBanner(string pNombre)
        {
            return iDbContext.Banners.Where(x => x.NombreBanner == pNombre).FirstOrDefault();
        }

        public bool ExisteBannerPorNombre(string pNombre)
        {
            bool valor = false;
            valor = iDbContext.Banners.Any(x => x.NombreBanner == pNombre);
            return valor;
        }
        public IList<Banner> BuscarBannerActivos()
        {
            var mbanner = (from banner in iDbContext.Banners
                           where ((banner.FechaInicio <= DateTime.Now.Date) && (banner.FechaFin >= DateTime.Now.Date))
                           select banner).ToList();
            return mbanner;
        }
        public IList<Banner> BuscarBannerActivosRango()
        {
            var mbannerRango = (from banner in iDbContext.Banners
                                where ((banner.FechaInicio >= DateTime.Today) &&
                                ((banner.HoraInicio).Hours >= (DateTime.Now.Hour))
                                && ((banner.HoraFin).Hours <= (DateTime.Now.Hour + 1)))
                                select banner).ToList();
            return mbannerRango;
        }
    }
}
