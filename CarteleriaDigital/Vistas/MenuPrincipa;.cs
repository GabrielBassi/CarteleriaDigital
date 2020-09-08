using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {


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
    }
}
