using System;
using System.Windows.Forms;
using CarteleriaDigital.Vistas;

namespace CarteleriaDigital
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCampaña_Click(object sender, EventArgs e)
        {
            GestionCampaña mGestionCampaña = new GestionCampaña();
            mGestionCampaña.ShowDialog();
        }

        private void btnBanner_Click(object sender, EventArgs e)
        {
            GestionBanner mGestionBanner = new GestionBanner();
            mGestionBanner.ShowDialog();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.pBarCarga.Increment(20);
            this.timerCarga.Start();
            this.pBarCarga.Increment(40);
            lblCargaBarra.Text = pBarCarga.Value.ToString() + "%";
            this.pBarCarga.Increment(100);
            if (pBarCarga.Value == pBarCarga.Maximum)
            {
                timerCarga.Stop();
                this.Hide();
            }

            IniciarCampañaBannerDia mIniciarCampañaBannerDia = new IniciarCampañaBannerDia();
            mIniciarCampañaBannerDia.Show();
        }

        private void pBarCarga_Click(object sender, EventArgs e)
        {
            ProgressBar pBar = new ProgressBar();

        }
    }
}
