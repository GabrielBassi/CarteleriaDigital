namespace CarteleriaDigital.Vistas
{
    partial class IniciarCampañaBannerDia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gBoxTextoDeslizable = new System.Windows.Forms.GroupBox();
            this.lblBannerDeslizable = new System.Windows.Forms.Label();
            this.pBoxCampañas = new System.Windows.Forms.PictureBox();
            this.timerBanner = new System.Windows.Forms.Timer(this.components);
            this.timerCampañas = new System.Windows.Forms.Timer(this.components);
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            this.gBoxTextoDeslizable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCampañas)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxTextoDeslizable
            // 
            this.gBoxTextoDeslizable.BackColor = System.Drawing.Color.Silver;
            this.gBoxTextoDeslizable.Controls.Add(this.lblBannerDeslizable);
            this.gBoxTextoDeslizable.Location = new System.Drawing.Point(12, 819);
            this.gBoxTextoDeslizable.Name = "gBoxTextoDeslizable";
            this.gBoxTextoDeslizable.Size = new System.Drawing.Size(2016, 205);
            this.gBoxTextoDeslizable.TabIndex = 1;
            this.gBoxTextoDeslizable.TabStop = false;
            // 
            // lblBannerDeslizable
            // 
            this.lblBannerDeslizable.AutoSize = true;
            this.lblBannerDeslizable.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.lblBannerDeslizable.Location = new System.Drawing.Point(523, 42);
            this.lblBannerDeslizable.Name = "lblBannerDeslizable";
            this.lblBannerDeslizable.Size = new System.Drawing.Size(722, 135);
            this.lblBannerDeslizable.TabIndex = 0;
            this.lblBannerDeslizable.Text = "Su banner...";
            // 
            // pBoxCampañas
            // 
            this.pBoxCampañas.BackColor = System.Drawing.Color.Silver;
            this.pBoxCampañas.Location = new System.Drawing.Point(12, 16);
            this.pBoxCampañas.Name = "pBoxCampañas";
            this.pBoxCampañas.Size = new System.Drawing.Size(2016, 787);
            this.pBoxCampañas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCampañas.TabIndex = 2;
            this.pBoxCampañas.TabStop = false;
            // 
            // timerBanner
            // 
            this.timerBanner.Tick += new System.EventHandler(this.timerBanner_Tick);
            // 
            // timerCampañas
            // 
            this.timerCampañas.Tick += new System.EventHandler(this.timerCampañas_Tick);
            // 
            // timerControl
            // 
            this.timerControl.Tick += new System.EventHandler(this.timerControl_Tick);
            // 
            // IniciarCampañaBannerDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(2041, 1055);
            this.Controls.Add(this.pBoxCampañas);
            this.Controls.Add(this.gBoxTextoDeslizable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IniciarCampañaBannerDia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IniciarCampañaBannerDia_Load);
            this.gBoxTextoDeslizable.ResumeLayout(false);
            this.gBoxTextoDeslizable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCampañas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxTextoDeslizable;
        private System.Windows.Forms.PictureBox pBoxCampañas;
        private System.Windows.Forms.Timer timerBanner;
        private System.Windows.Forms.Label lblBannerDeslizable;
        private System.Windows.Forms.Timer timerCampañas;
        private System.Windows.Forms.Timer timerControl;
    }
}