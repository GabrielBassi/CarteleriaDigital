﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL
{
    interface IRepositorioBanner : IRepositorioGeneral<Banner>
    {
        Banner ExistenciaBanner(string pNombre);
        bool ExisteBannerPorNombre(string pNombreBanner);
        IList<Banner> BuscarBannerActivos();
        IList<Banner> BuscarBannerActivosRango();
    }
}
