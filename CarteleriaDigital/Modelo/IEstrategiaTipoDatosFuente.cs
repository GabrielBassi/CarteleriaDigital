using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarteleriaDigital.Modelo
{
    public interface IEstrategiaTipoDatosFuente
    {
        XDocument LeerInformacion(string purl);
    }
}
