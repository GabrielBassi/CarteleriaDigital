using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.DAL.Entity_Framework
{
    class CarteleriaDigitalContext : DbContext
    {
        public CarteleriaDigitalContext() : base ("CarteleriaDigital")
        {

        }
    }
}
