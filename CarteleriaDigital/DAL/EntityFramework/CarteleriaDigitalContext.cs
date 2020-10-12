using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.DAL.EntityFramework
{
    class CarteleriaDigitalContext : DbContext
    {
        public CarteleriaDigitalContext() : base ("CarteleriaDigital")
        {

        }
        public DbSet<Campaña> Campañas { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<RssUrl> RssUrls { get; set; }
        public DbSet<TextoFijo> TextoFijos { get; set; }
        public DbSet<EstrategiaTipoDatosFuente> EstrategiaTipoDatos { get; set; }
    }
}

