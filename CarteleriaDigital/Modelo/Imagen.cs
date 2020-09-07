using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.Modelo
{
    public class Imagen
    {
        //Definicion de propiedades de la clase campaña
        public int ImagenId { get; set; }
        public string Nombre { get; set; }
        public string RutaImagen { get; set; }
        public virtual Campaña Campaña { get; set; }
    }
}