using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.EntityFramework
{
    class RepositorioRssUrl : RepositorioGeneral<RssUrl, CarteleriaDigitalContext>, IRepositorioRssUrl
    {
        public RepositorioRssUrl(CarteleriaDigitalContext pContext) : base(pContext)
        {

        }
        public RssUrl ExistenciaRssUrl(string pNombre)
        {
            return iDbContext.RssUrls.Where(x => x.Nombre == pNombre).FirstOrDefault();
        }

        public bool ExisteRssUrlPorNombre(string pNombre)
        {
            bool valor = false;
            valor = iDbContext.RssUrls.Any(x => x.Nombre == pNombre);
            return valor;
        }


    }
}
