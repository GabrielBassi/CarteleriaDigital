using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.Entity_Framework
{
    class RepositorioTextoFijo : RepositorioGeneral<TextoFijo, CarteleriaDigitalContext>, IRepositorioTextoFijo
    {
        public RepositorioTextoFijo(CarteleriaDigitalContext pContext) : base(pContext)
        {
        }
    }
}
