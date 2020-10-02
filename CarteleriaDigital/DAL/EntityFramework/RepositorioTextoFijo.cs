using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.EntityFramework
{
    class RepositorioTextoFijo : RepositorioGeneral<TextoFijo, CarteleriaDigitalContext>, IRepositorioTextoFijo
    {
        public RepositorioTextoFijo(CarteleriaDigitalContext pContext) : base(pContext)
        {
        }
        public IList<TextoFijo> ObtenerTextoFijo(string pNombre)
        {
            return this.iDbContext.TextoFijos.Where(e => e.Nombre == pNombre).ToList();
        }

        public bool ExisteTextoFijoPorNombre(string pNombre)
        {
            bool valor = false;
            valor = iDbContext.TextoFijos.Any(x => x.Nombre == pNombre);
            return valor;
        }
        public TextoFijo ExistenciaTextoFijo(string pNombre)
        {
            return iDbContext.TextoFijos.Where(x => x.Nombre == pNombre).FirstOrDefault();
        }
    }
}
