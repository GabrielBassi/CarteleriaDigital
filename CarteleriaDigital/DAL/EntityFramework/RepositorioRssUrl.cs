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
    }
}
