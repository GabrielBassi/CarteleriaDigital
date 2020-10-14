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
        int contador = 0;
        int aa = 0;
        //int jj = 0;
        public ControladorImagen(IUnidadDeTrabajo pUnidadDeTrabajo, int pp, int aa)
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

        //Metodo que controla la cantidad de imagenes a cargar.
        public void CargarImagenes(IList<Imagen> listaImagenes, GroupBox gBoxImagen, int pContador, IList<int> pListaImagenMod)
        {
            contador = pContador;
            contador += 1;
            OpenFileDialog CargarImagen = new OpenFileDialog();
            CargarImagen.Filter = "Imágenes(*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.png";


            if (CargarImagen.ShowDialog() == DialogResult.OK)

            {
                if (contador == 1)
                {
                    CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 20, 35, pListaImagenMod);
                }
                else
                {
                    if (contador == 2)
                    {
                        CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 210, 35, pListaImagenMod);
                    }
                    else
                    {
                        if (contador == 3)
                        {
                            CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 400, 35, pListaImagenMod);
                        }
                        else
                        {
                            if (contador == 4)
                            {
                                CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 590, 35, pListaImagenMod);
                            }
                            else
                            {
                                if (contador == 5)
                                {
                                    CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 20, 210, pListaImagenMod);
                                }
                                else
                                {
                                    if (contador == 6)
                                    {
                                        CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 210, 210, pListaImagenMod);
                                    }
                                    else
                                    {
                                        if (contador == 7)
                                        {
                                            CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 400, 210, pListaImagenMod);
                                        }
                                        else
                                        {
                                            if (contador == 8)
                                            {
                                                CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 590, 210, pListaImagenMod);
                                            }
                                            else
                                            {
                                                MessageBox.Show("Límite de imágenes alcanzado por campaña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //Metodo que carga las imagenes en el group box imagenes a visualizar.
        public void CargoPictureBox(OpenFileDialog CargarImagen, IList<Imagen> pLista, GroupBox gBoxImagen, int aa, int jj,IList<int> pListaImagenMod)
        {
            PictureBox imagPic = new PictureBox();
            gBoxImagen.Controls.Add(imagPic);
            imagPic.Size = new Size(150, 150);
            imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
            imagPic.Location = new Point(aa, jj);
            string RutaImagen = CargarImagen.FileName;
            imagPic.ImageLocation = RutaImagen;
            imagPic.Image = Image.FromFile(CargarImagen.FileName);
            imagPic.Tag = CargarImagen.FileName;
            string nombre = Path.GetFileName(imagPic.Tag.ToString());
            AgregarImagen(nombre, RutaImagen, pLista);
            int cantLista = (pLista.Count)-1;
            pListaImagenMod.Add(cantLista);

        }

        
        public void CargoPictureBoxModificar(IList<Imagen> pLista, GroupBox gBoxImagenMod, int aa, int jj)
        {
            if (pLista.Count <= 4)
            {
                foreach (var item in pLista)
                {
                    PictureBox imagPic = new PictureBox();
                    gBoxImagenMod.Controls.Add(imagPic);
                    imagPic.Size = new Size(150, 150);
                    imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    imagPic.Location = new Point(aa, jj);
                    imagPic.Image = Image.FromFile(item.RutaImagen);
                    aa += 190;
                }

            }
            else
            {
                if (pLista.Count >= 5)
                {
                    int contador = 0;
                    foreach (var item in pLista)
                    {
                        PictureBox imagPic = new PictureBox();
                        gBoxImagenMod.Controls.Add(imagPic);
                        imagPic.Size = new Size(150, 150);
                        imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                        imagPic.Location = new Point(aa, jj);
                        imagPic.Image = Image.FromFile(item.RutaImagen);
                        aa += 190;
                        contador += 1;
                        if (contador == 5)
                        {
                            aa += 190;
                            jj += 180;
                            gBoxImagenMod.Controls.Add(imagPic);
                            imagPic.Size = new Size(150, 150);
                            imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                            imagPic.Location = new Point(20, jj);
                            imagPic.Image = Image.FromFile(item.RutaImagen);
                        }

                        if (contador == 6)
                        {
                            gBoxImagenMod.Controls.Add(imagPic);
                            imagPic.Size = new Size(150, 150);
                            imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                            imagPic.Location = new Point(210, jj);
                            imagPic.Image = Image.FromFile(item.RutaImagen);
                        }
                        if (contador == 7)
                        {
                            gBoxImagenMod.Controls.Add(imagPic);
                            imagPic.Size = new Size(150, 150);
                            imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                            imagPic.Location = new Point(400, jj);
                            imagPic.Image = Image.FromFile(item.RutaImagen);
                        }

                        if (contador == 8)
                        {

                            gBoxImagenMod.Controls.Add(imagPic);
                            imagPic.Size = new Size(150, 150);
                            imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                            imagPic.Location = new Point(590, jj);
                            imagPic.Image = Image.FromFile(item.RutaImagen);
                        }


                    }
                }
            }
        }
        public IList<Imagen> ListaImagensPorCampañaId(int pIdCampaña)
        {
            IList<Imagen> mLista = iUdT.RepositorioImagen.ObtenerTodasLasImagensDeLaCampaña(pIdCampaña);
            return mLista;
        }

        //IList<Imagen> pListaImagenMod controlar que este parámetro no se usa....
        //el problema es con el contador que no se reinicia
        public bool CargarImagenesMod(IList<Imagen> listaImagenes, IList<int> pListaImagenMod, GroupBox gBoxImagen,int pContador)
        {
            contador = pContador;
            contador += 1;
            bool control = false;
           // contador += 1;
            OpenFileDialog CargarImagen = new OpenFileDialog();
            CargarImagen.Filter = "Imágenes(*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.png";


            if (CargarImagen.ShowDialog() == DialogResult.OK)

            {
                if (listaImagenes.Count == 1)
                {
                    CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 210, 35, pListaImagenMod);
                }
                else
                {
                    if (listaImagenes.Count == 2)
                    {
                        CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 400, 35, pListaImagenMod);
                    }
                    else
                    {
                        if (listaImagenes.Count == 3)
                        {
                            CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 590, 35, pListaImagenMod);
                        }
                        else
                        {
                            if (listaImagenes.Count == 4)
                            {
                                CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 20, 210, pListaImagenMod);
                            }
                            else
                            {
                                if (listaImagenes.Count == 5)
                                {
                                    CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 210, 210, pListaImagenMod);
                                }
                                else
                                {
                                    if (listaImagenes.Count == 6)
                                    {
                                        CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 400, 210, pListaImagenMod);
                                    }
                                    else
                                    {
                                        if (listaImagenes.Count == 7)
                                        {
                                            CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, 590, 210, pListaImagenMod);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Límite de imágenes alcanzado por campaña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                control = true;
                return control;
            }
            return control;
        }
     
    }
}