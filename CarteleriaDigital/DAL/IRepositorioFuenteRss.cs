using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;


namespace CarteleriaDigital.DAL
{
    interface IRepositorioFuenteRss : IRepositorioGeneral<FuenteRss>
    {
        FuenteRss ExistenciaRssUrl(string pNombre);
        bool ExisteRssUrlPorNombre(string pNombreRss);
    }
}
