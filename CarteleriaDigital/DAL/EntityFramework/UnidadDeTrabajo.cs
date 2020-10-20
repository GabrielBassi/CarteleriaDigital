using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.DAL.EntityFramework
{
    class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        //atributo para utilizar un solo Contexto
        private readonly CarteleriaDigitalContext iDbContext;
        private static volatile UnidadDeTrabajo cInstancia = null;
        private static readonly object cPadlock = new object();

        private UnidadDeTrabajo()
        {
            this.iDbContext = new CarteleriaDigitalContext();
            this.RepositorioCampaña = new RepositorioCampaña(this.iDbContext);
            this.RepositorioImagen = new RepositorioImagen(this.iDbContext);
            this.RepositorioBanner = new RepositorioBanner(this.iDbContext);
            this.RepositorioRssUrl = new RepositorioFuenteRss(this.iDbContext);
            this.RepositorioTextoFijo = new RepositorioTextoFijo(this.iDbContext);
            this.RepositorioEstrategiaTipoDatos = new RepositorioEstrategiaTipoDatosFuente(this.iDbContext);
        }

        //Implementacion de las interfaces en la unidad de trabajo

        public IRepositorioCampaña RepositorioCampaña { get; private set; }
        public IRepositorioImagen RepositorioImagen { get; private set; }
        public IRepositorioBanner RepositorioBanner { get; private set; }
        public IRepositorioFuenteRss RepositorioRssUrl { get; private set; }
        public IRepositorioTextoFijo RepositorioTextoFijo { get; private set; }
        public IRepositorioEstrategiaTipoDatosFuente RepositorioEstrategiaTipoDatos { get; private set; }

        /// <summary>
        /// Patron singleton para usar el mismo contexto en todo el sistema
        /// </summary>
        public static UnidadDeTrabajo Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    lock (cPadlock)
                    {
                        if (cInstancia == null)
                        {
                            cInstancia = new UnidadDeTrabajo();
                        }
                    }
                }

                return cInstancia;
            }
        }
        /// <summary>
        ///Implementación de IDisposable: Define el método Dispose para liberar recursos no administrados.
        /// </summary>
        public void Dispose()
        {
            iDbContext.Dispose();
        }
        public void Guardar()
        {
            iDbContext.SaveChanges();
        }
    }
}
