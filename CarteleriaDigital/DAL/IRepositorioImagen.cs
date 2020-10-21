using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL
{
    interface IRepositorioImagen : IRepositorioGeneral<Imagen>
    {
        IList<Imagen> ObtenerTodasLasImagensDeLaCampaña(int pidCampaña);
        void EliminarPorNombre(string pNombre);
    }

}
