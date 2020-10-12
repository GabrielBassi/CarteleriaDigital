using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarteleriaDigital.Modelo
{

    /// <summary>
    /// Esta clase es el contexto del Patron Estrategia, la cual va a obtener que tipo de estrategia se va a obtener para pasarsela al banner.
    /// </summary>
    public class EstrategiaTipoDatosFuente
    {
        public int EstrategiaTipoDatosFuenteId { get; set; }

        //Aquí va el nombre de la clase estrategia que se elige. Para obtener el nombre de la clase se usar nameof()
        public string NombreTipoDeEstrategia { get; set; }

        public int DatosEstrategiaId { get; set; }

        public virtual IList<Banner> Banners { get; set; }

        /// <summary>
        /// EstrategiaInformacion se recibe por parametro
        /// </summary>
        public virtual IEstrategiaTipoDatosFuente EstrategiaTipoDatosFuentes { get; set; }

        /// <summary>
        /// Metodo que implementan todos los objetos Estrategia.
        /// </summary>
        /// <returns></returns>
        public XDocument LeerInformacion(string pcadena)
        {
            return this.EstrategiaTipoDatosFuentes.LeerInformacion(pcadena);
        }

        //public enum TipoDeEstrategia
        //{
        //    EstrategiaTextoFijo = 1,
        //    EstrategiaRss = 2
        //}
    }
}

