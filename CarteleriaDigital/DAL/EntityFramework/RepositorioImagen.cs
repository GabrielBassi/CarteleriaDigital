using System.Collections.Generic;
using System.Linq;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.EntityFramework
{
    class RepositorioImagen : RepositorioGeneral<Imagen, CarteleriaDigitalContext>, IRepositorioImagen
    {
        public RepositorioImagen(CarteleriaDigitalContext pContext) : base(pContext)
        {
        }

        public void EliminarPorNombre(string pNombre) 
        {
            var mImagen = this.iDbContext.Imagenes.Where(x => x.Nombre == pNombre);

            if (mImagen!=null)
            {
                this.Eliminar(mImagen.First());
            }
            
        }

        public IList<Imagen> ObtenerTodasLasImagensDeLaCampaña(int pidCampaña)
        {
            var m = from imagen in iDbContext.Imagenes
                    where imagen.Campaña.CampañaId == pidCampaña
                    select imagen;
            return m.ToList();
        }
    }
}
