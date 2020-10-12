using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL
{
    interface IRepositorioCampaña : IRepositorioGeneral<Campaña>
    {
        Campaña ExistenciaCampaña(string pNombre);
        bool ExisteCampañaPorNombre(string pNombre);
        IList<Campaña> BuscarCampañaActivos();
        IList<Campaña> BuscarCampañaActivosRango();
    }
}
