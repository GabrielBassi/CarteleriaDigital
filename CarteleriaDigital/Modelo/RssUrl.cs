using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.Modelo
{
    public class RssUrl
    {
        public int RssUrlId { get; set; }
        public string Url { get; set; }
        public virtual IList<FuenteRss> ListaFuenteRss { get; set; }
    }
}
