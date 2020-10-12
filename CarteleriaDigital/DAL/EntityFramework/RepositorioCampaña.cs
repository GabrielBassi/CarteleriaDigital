using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.EntityFramework
{ 
    class RepositorioCampaña : RepositorioGeneral<Campaña, CarteleriaDigitalContext>, IRepositorioCampaña
    {
        public RepositorioCampaña(CarteleriaDigitalContext pContext) : base(pContext)
        {

        }
        public Campaña ExistenciaCampaña(string pNombre)
        {
            return iDbContext.Campañas.Where(x => x.Nombre == pNombre).FirstOrDefault();
        }
        public bool ExisteCampañaPorNombre(string pNombre)
        {
            bool valor = false;
            valor = iDbContext.Campañas.Any(x => x.Nombre == pNombre);
            return valor;
        }
        public IList<Campaña> BuscarCampañaActivos()
        {
            var mImagen = (from imagen in iDbContext.Campañas
                           where ((imagen.FechaInicio >= DateTime.Today))
                           select imagen).ToList();
            return mImagen;
        }
        public IList<Campaña> BuscarCampañaActivosRango()
        {
            int ss = DateTime.Now.Hour;
            var mCampañaRango = (from campaña in iDbContext.Campañas
                                 where ((campaña.FechaInicio >= DateTime.Today) &&
                                 ((campaña.HoraInicio).Hours >= (DateTime.Now.Hour))
                                 && ((campaña.HoraFin).Hours <= (DateTime.Now.Hour + 1)))
                                 select campaña).ToList();
            return mCampañaRango;
        
        
        
        
        
        }
    }

}