namespace CarteleriaDigital
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCampaña = new System.Windows.Forms.Button();
            this.btnBanner = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pBarCarga = new System.Windows.Forms.ProgressBar();
            this.lblCargaBarra = new System.Windows.Forms.Label();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCampaña
            // 
            this.btnCampaña.BackColor = System.Drawing.Color.Silver;
            this.btnCampaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCampaña.Location = new System.Drawing.Point(120, 78);
            this.btnCampaña.Name = "btnCampaña";
            this.btnCampaña.Size = new System.Drawing.Size(130, 70);
            this.btnCampaña.TabIndex = 1;
            this.btnCampaña.Text = "Gestión Campañas";
            this.btnCampaña.UseVisualStyleBackColor = false;
            this.btnCampaña.Click += new System.EventHandler(this.btnCampaña_Click);
            // 
            // btnBanner
            // 
            this.btnBanner.BackColor = System.Drawing.Color.Silver;
            this.btnBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBanner.Location = new System.Drawing.Point(570, 78);
            this.btnBanner.Name = "btnBanner";
            this.btnBanner.Size = new System.Drawing.Size(130, 70);
            this.btnBanner.TabIndex = 2;
            this.btnBanner.Text = "Gestión Banners";
            this.btnBanner.UseVisualStyleBackColor = false;
            this.btnBanner.Click += new System.EventHandler(this.btnBanner_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Silver;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Image = global::CarteleriaDigital.Properties.Resources.Play;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciar.Location = new System.Drawing.Point(321, 206);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(130, 70);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pBarCarga
            // 
            this.pBarCarga.BackColor = System.Drawing.Color.Silver;
            this.pBarCarga.Location = new System.Drawing.Point(120, 355);
            this.pBarCarga.Name = "pBarCarga";
            this.pBarCarga.Size = new System.Drawing.Size(580, 61);
            this.pBarCarga.TabIndex = 4;
            this.pBarCarga.Click += new System.EventHandler(this.pBarCarga_Click);
            // 
            // lblCargaBarra
            // 
            this.lblCargaBarra.AutoSize = true;
            this.lblCargaBarra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCargaBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaBarra.Location = new System.Drawing.Point(332, 367);
            this.lblCargaBarra.Name = "lblCargaBarra";
            this.lblCargaBarra.Size = new System.Drawing.Size(148, 29);
            this.lblCargaBarra.TabIndex = 5;
            this.lblCargaBarra.Text = "Cargando...";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lblCargaBarra);
            this.Controls.Add(this.pBarCarga);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnBanner);
            this.Controls.Add(this.btnCampaña);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCampaña;
        private System.Windows.Forms.Button btnBanner;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ProgressBar pBarCarga;
        private System.Windows.Forms.Label lblCargaBarra;
        private System.Windows.Forms.Timer timerCarga;
    }
}


