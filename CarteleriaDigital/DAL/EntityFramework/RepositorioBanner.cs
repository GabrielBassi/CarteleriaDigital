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
    }
}
