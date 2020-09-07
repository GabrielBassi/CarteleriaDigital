using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.Modelo
{
    public class Banner
    {
        //Definicion de propiedades de la clase 
        public int BannerId { get; set; }
        public string NombreBanner { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }

        // public virtual TipoFuente TipoFuente { get; set; }
    }
}
