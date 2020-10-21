using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CarteleriaDigital.DAL;
using CarteleriaDigital.Modelo;

namespace CarteleriaDigital.Controladores
{
    class ControladorImagen
    {
        private readonly IUnidadDeTrabajo iUdT;
        //int contador = 0;
        //int aa = 0;
        ////int jj = 0;
        public ControladorImagen(IUnidadDeTrabajo pUnidadDeTrabajo/*, int pp, int aa*/)
        {
            this.iUdT = pUnidadDeTrabajo;
            //aa = pAa;
            //jj = pjj;
        }
        public IList<Imagen> AgregarImagen(string pNombre, string pRutaImagen, IList<Imagen> pListaImagenes)
        {
            Imagen iImagen = new Imagen()
            {
                Nombre = pNombre,
                RutaImagen = pRutaImagen,
            };
            pListaImagenes.Add(iImagen);
            return pListaImagenes;
        }
           
        public IList<Imagen> ListaImagensPorCampañaId(int pIdCampaña)
        {
            IList<Imagen> mLista = iUdT.RepositorioImagen.ObtenerTodasLasImagensDeLaCampaña(pIdCampaña);
            return mLista;
        }

        public void EliminarImagenPorNombre(string pNombre)
        {
            this.iUdT.RepositorioImagen.EliminarPorNombre(pNombre);
            this.iUdT.Guardar();
        }
       
    }
}