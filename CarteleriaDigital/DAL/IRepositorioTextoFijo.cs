using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL
{
    interface IRepositorioTextoFijo : IRepositorioGeneral<TextoFijo>
    {
        IList<TextoFijo> ObtenerTextoFijo(string pNombre);
        bool ExisteTextoFijoPorNombre(string pNombreTextoFijo);
        TextoFijo ExistenciaTextoFijo(string pNombre);
    }
}
