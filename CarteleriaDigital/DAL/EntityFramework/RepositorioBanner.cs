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
    }
}
