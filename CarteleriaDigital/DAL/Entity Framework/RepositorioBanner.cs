using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.Entity_Framework
{
    class RepositorioBanner : RepositorioGeneral<Banner, CarteleriaDigitalContext>, IRepositorioBanner
    {
        public RepositorioBanner(CarteleriaDigitalContext pContext) : base(pContext)
        {

        }
    }
}
