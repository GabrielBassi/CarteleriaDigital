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
            this.btnCampaña = new System.Windows.Forms.Button();
            this.btnBanner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCampaña
            // 
            this.btnCampaña.Location = new System.Drawing.Point(308, 66);
            this.btnCampaña.Name = "btnCampaña";
            this.btnCampaña.Size = new System.Drawing.Size(130, 70);
            this.btnCampaña.TabIndex = 1;
            this.btnCampaña.Text = "Campaña";
            this.btnCampaña.UseVisualStyleBackColor = true;
            this.btnCampaña.Click += new System.EventHandler(this.btnCampaña_Click);
            // 
            // btnBanner
            // 
            this.btnBanner.Location = new System.Drawing.Point(308, 213);
            this.btnBanner.Name = "btnBanner";
            this.btnBanner.Size = new System.Drawing.Size(130, 70);
            this.btnBanner.TabIndex = 2;
            this.btnBanner.Text = "Banner";
            this.btnBanner.UseVisualStyleBackColor = true;
            this.btnBanner.Click += new System.EventHandler(this.btnBanner_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBanner);
            this.Controls.Add(this.btnCampaña);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCampaña;
        private System.Windows.Forms.Button btnBanner;
    }
}


