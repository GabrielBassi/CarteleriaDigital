using CarteleriaDigital.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.DAL.EntityFramework
{
    class RepositorioEstrategiaTipoDatosFuente : RepositorioGeneral <EstrategiaTipoDatosFuente, CarteleriaDigitalContext>, IRepositorioEstrategiaTipoDatosFuente
    {
        public RepositorioEstrategiaTipoDatosFuente(CarteleriaDigitalContext pContext) : base(pContext)
        {

        }
    }
}
