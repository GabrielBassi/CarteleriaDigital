using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;


namespace CarteleriaDigital.DAL
{
    interface IRepositorioRssUrl : IRepositorioGeneral<RssUrl>
    {
        RssUrl ExistenciaRssUrl(string pNombre);
        bool ExisteRssUrlPorNombre(string pNombreRss);
    }
}
