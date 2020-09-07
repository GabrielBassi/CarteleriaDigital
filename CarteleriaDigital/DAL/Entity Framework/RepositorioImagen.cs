using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.Entity_Framework
{
    class RepositorioImagen : RepositorioGeneral<Imagen, CarteleriaDigitalContext>, IRepositorioImagen
    {
        public RepositorioImagen(CarteleriaDigitalContext pContext) : base(pContext)
        {
        }
        //public IList<Imagen> ObtenerTodasLasImagensDeLaCampaña(int pidCampaña)
        //{
        //    var m = from imagen in iDbContext.Imagenes
        //            where imagen.Campaña.CampañaId == pidCampaña
        //            select imagen;
        //    return m.ToList();
        //}
    }
}
