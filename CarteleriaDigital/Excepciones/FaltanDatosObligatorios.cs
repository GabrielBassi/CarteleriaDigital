using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.Excepciones
{
    class FaltanDatosObligatorios : Exception
    {
        public FaltanDatosObligatorios(string message) : base(message)
        {

        }
    }
}
