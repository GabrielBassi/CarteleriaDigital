using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.EntityFramework
{
    class RepositorioFuenteRss : RepositorioGeneral<FuenteRss, CarteleriaDigitalContext>, IRepositorioFuenteRssUrl
    {
        public RepositorioFuenteRss(CarteleriaDigitalContext pContext) : base(pContext)
        {

        }
    }
}
