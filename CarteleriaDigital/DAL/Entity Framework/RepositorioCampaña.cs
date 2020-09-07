using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.Entity_Framework
{ 
    class RepositorioCampaña : RepositorioGeneral<Campaña, CarteleriaDigitalContext>, IRepositorioCampaña
    {
        public RepositorioCampaña(CarteleriaDigitalContext pContext) : base(pContext)
        {

        }
        //public Campaña ExistenciaCampaña(string pNombre)
        //{
        //    return iDbContext.Campañas.Where(x => x.Nombre == pNombre).FirstOrDefault();
        //}
        //public bool ExisteCampañaPorNombre(string pNombre)
        //{
        //    bool valor = false;
        //    valor = iDbContext.Campañas.Any(x => x.Nombre == pNombre);
        //    return valor;
    }
}
