using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.EntityFramework
{
    class RepositorioFuenteRss : RepositorioGeneral<FuenteRss, CarteleriaDigitalContext>, IRepositorioFuenteRss
    {
        public RepositorioFuenteRss(CarteleriaDigitalContext pContext) : base(pContext)
        {

        }
        public FuenteRss ExistenciaRssUrl(string pNombre)
        {
            return iDbContext.FuenteRss.Where(x => x.Nombre == pNombre).FirstOrDefault();
        }

        public bool ExisteRssUrlPorNombre(string pNombre)
        {
            bool valor = false;
            valor = iDbContext.FuenteRss.Any(x => x.Nombre == pNombre);
            return valor;
        }


    }
}
