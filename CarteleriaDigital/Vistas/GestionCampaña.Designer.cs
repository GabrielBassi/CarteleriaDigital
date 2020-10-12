namespace CarteleriaDigital.Vistas
{
    partial class GestionCampaña
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
            this.tabCampaña = new System.Windows.Forms.TabControl();
            this.tbCtrlAgregar = new System.Windows.Forms.TabPage();
            this.btnAceptarCampaña = new System.Windows.Forms.Button();
            this.gBoxInfoCampaña = new System.Windows.Forms.GroupBox();
            this.CargarImag = new System.Windows.Forms.Button();
            this.nUDuracionAgregar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nUpHastaHoraAgregar = new System.Windows.Forms.NumericUpDown();
            this.nUpDesdeHoraAgregar = new System.Windows.Forms.NumericUpDown();
            this.lblHastaHoraAgregar = new System.Windows.Forms.Label();
            this.lblDesdeHoraAgregar = new System.Windows.Forms.Label();
            this.lblRangoHorasAgregar = new System.Windows.Forms.Label();
            this.txBoxNombreAgregarCamp = new System.Windows.Forms.TextBox();
            this.dTPickFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dTPickFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHastaFechaAgregar = new System.Windows.Forms.Label();
            this.lblDesdeFechaAgregar = new System.Windows.Forms.Label();
            this.lblEntreFechasAgregar = new System.Windows.Forms.Label();
            this.lblNomAgregarCamp = new System.Windows.Forms.Label();
            this.BtnVolverCampaña = new System.Windows.Forms.Button();
            this.gBoxImagenes = new System.Windows.Forms.GroupBox();
            this.tbControlModificar = new System.Windows.Forms.TabPage();
            this.btnModEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnModVolver = new System.Windows.Forms.Button();
            this.gBoxImagenMod = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gBoxCampañaMod = new System.Windows.Forms.GroupBox();
            this.CargarImagMod = new System.Windows.Forms.Button();
            this.nUDuracionMod = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nUpHastaHoraMod = new System.Windows.Forms.NumericUpDown();
            this.nUpDesdeHoraMod = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomCampañaMod = new System.Windows.Forms.TextBox();
            this.dTPickFechaHastaMod = new System.Windows.Forms.DateTimePicker();
            this.dTPickFechaDesdeMod = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxModCampActivas = new System.Windows.Forms.ComboBox();
            this.lblModCampañasAct = new System.Windows.Forms.Label();
            this.tabCampaña.SuspendLayout();
            this.tbCtrlAgregar.SuspendLayout();
            this.gBoxInfoCampaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDuracionAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpHastaHoraAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDesdeHoraAgregar)).BeginInit();
            this.tbControlModificar.SuspendLayout();
            this.gBoxImagenMod.SuspendLayout();
            this.gBoxCampañaMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDuracionMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpHastaHoraMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDesdeHoraMod)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCampaña
            // 
            this.tabCampaña.Controls.Add(this.tbCtrlAgregar);
            this.tabCampaña.Controls.Add(this.tbControlModificar);
            this.tabCampaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.tabCampaña.Location = new System.Drawing.Point(-2, 0);
            this.tabCampaña.Name = "tabCampaña";
            this.tabCampaña.SelectedIndex = 0;
            this.tabCampaña.Size = new System.Drawing.Size(1038, 760);
            this.tabCampaña.TabIndex = 0;
            this.tabCampaña.SelectedIndexChanged += new System.EventHandler(this.TabControl1_TabIndexChanged);
            // 
            // tbCtrlAgregar
            // 
            this.tbCtrlAgregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbCtrlAgregar.Controls.Add(this.btnAceptarCampaña);
            this.tbCtrlAgregar.Controls.Add(this.gBoxInfoCampaña);
            this.tbCtrlAgregar.Controls.Add(this.BtnVolverCampaña);
            this.tbCtrlAgregar.Controls.Add(this.gBoxImagenes);
            this.tbCtrlAgregar.Location = new System.Drawing.Point(4, 29);
            this.tbCtrlAgregar.Name = "tbCtrlAgregar";
            this.tbCtrlAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCtrlAgregar.Size = new System.Drawing.Size(1030, 727);
            this.tbCtrlAgregar.TabIndex = 0;
            this.tbCtrlAgregar.Text = "Agregar";
            this.tbCtrlAgregar.Click += new System.EventHandler(this.TbCtrlAgregar_Click);
            // 
            // btnAceptarCampaña
            // 
            this.btnAceptarCampaña.BackColor = System.Drawing.Color.Silver;
            this.btnAceptarCampaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAceptarCampaña.Location = new System.Drawing.Point(304, 670);
            this.btnAceptarCampaña.Name = "btnAceptarCampaña";
            this.btnAceptarCampaña.Size = new System.Drawing.Size(110, 50);
            this.btnAceptarCampaña.TabIndex = 20;
            this.btnAceptarCampaña.Text = "Aceptar";
            this.btnAceptarCampaña.UseVisualStyleBackColor = false;
            this.btnAceptarCampaña.Click += new System.EventHandler(this.BtnAceptarCampaña_Click);
            // 
            // gBoxInfoCampaña
            // 
            this.gBoxInfoCampaña.BackColor = System.Drawing.Color.Silver;
            this.gBoxInfoCampaña.Controls.Add(this.CargarImag);
            this.gBoxInfoCampaña.Controls.Add(this.nUDuracionAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.label1);
            this.gBoxInfoCampaña.Controls.Add(this.nUpHastaHoraAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.nUpDesdeHoraAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblHastaHoraAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblDesdeHoraAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblRangoHorasAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.txBoxNombreAgregarCamp);
            this.gBoxInfoCampaña.Controls.Add(this.dTPickFechaHasta);
            this.gBoxInfoCampaña.Controls.Add(this.dTPickFechaDesde);
            this.gBoxInfoCampaña.Controls.Add(this.lblHastaFechaAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblDesdeFechaAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblEntreFechasAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblNomAgregarCamp);
            this.gBoxInfoCampaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBoxInfoCampaña.Location = new System.Drawing.Point(10, 7);
            this.gBoxInfoCampaña.Name = "gBoxInfoCampaña";
            this.gBoxInfoCampaña.Size = new System.Drawing.Size(1007, 175);
            this.gBoxInfoCampaña.TabIndex = 0;
            this.gBoxInfoCampaña.TabStop = false;
            this.gBoxInfoCampaña.Text = "Información de campaña";
            // 
            // CargarImag
            // 
            this.CargarImag.Image = global::CarteleriaDigital.Properties.Resources._Imagen;
            this.CargarImag.Location = new System.Drawing.Point(914, 21);
            this.CargarImag.Name = "CargarImag";
            this.CargarImag.Size = new System.Drawing.Size(84, 83);
            this.CargarImag.TabIndex = 19;
            this.CargarImag.UseVisualStyleBackColor = true;
            this.CargarImag.Click += new System.EventHandler(this.CargarImag_Click);
            // 
            // nUDuracionAgregar
            // 
            this.nUDuracionAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDuracionAgregar.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDuracionAgregar.Location = new System.Drawing.Point(272, 111);
            this.nUDuracionAgregar.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUDuracionAgregar.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDuracionAgregar.Name = "nUDuracionAgregar";
            this.nUDuracionAgregar.Size = new System.Drawing.Size(58, 27);
            this.nUDuracionAgregar.TabIndex = 18;
            this.nUDuracionAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDuracionAgregar.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Duracion entre imagenes";
            // 
            // nUpHastaHoraAgregar
            // 
            this.nUpHastaHoraAgregar.Location = new System.Drawing.Point(782, 116);
            this.nUpHastaHoraAgregar.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nUpHastaHoraAgregar.Name = "nUpHastaHoraAgregar";
            this.nUpHastaHoraAgregar.Size = new System.Drawing.Size(67, 27);
            this.nUpHastaHoraAgregar.TabIndex = 15;
            this.nUpHastaHoraAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nUpDesdeHoraAgregar
            // 
            this.nUpDesdeHoraAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nUpDesdeHoraAgregar.Location = new System.Drawing.Point(782, 79);
            this.nUpDesdeHoraAgregar.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nUpDesdeHoraAgregar.Name = "nUpDesdeHoraAgregar";
            this.nUpDesdeHoraAgregar.Size = new System.Drawing.Size(67, 27);
            this.nUpDesdeHoraAgregar.TabIndex = 15;
            this.nUpDesdeHoraAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHastaHoraAgregar
            // 
            this.lblHastaHoraAgregar.AutoSize = true;
            this.lblHastaHoraAgregar.Location = new System.Drawing.Point(707, 118);
            this.lblHastaHoraAgregar.Name = "lblHastaHoraAgregar";
            this.lblHastaHoraAgregar.Size = new System.Drawing.Size(59, 20);
            this.lblHastaHoraAgregar.TabIndex = 14;
            this.lblHastaHoraAgregar.Text = "Hasta";
            // 
            // lblDesdeHoraAgregar
            // 
            this.lblDesdeHoraAgregar.AutoSize = true;
            this.lblDesdeHoraAgregar.Location = new System.Drawing.Point(707, 84);
            this.lblDesdeHoraAgregar.Name = "lblDesdeHoraAgregar";
            this.lblDesdeHoraAgregar.Size = new System.Drawing.Size(63, 20);
            this.lblDesdeHoraAgregar.TabIndex = 13;
            this.lblDesdeHoraAgregar.Text = "Desde";
            // 
            // lblRangoHorasAgregar
            // 
            this.lblRangoHorasAgregar.AutoSize = true;
            this.lblRangoHorasAgregar.Location = new System.Drawing.Point(707, 31);
            this.lblRangoHorasAgregar.Name = "lblRangoHorasAgregar";
            this.lblRangoHorasAgregar.Size = new System.Drawing.Size(145, 20);
            this.lblRangoHorasAgregar.TabIndex = 12;
            this.lblRangoHorasAgregar.Text = "Rango de Horas";
            // 
            // txBoxNombreAgregarCamp
            // 
            this.txBoxNombreAgregarCamp.Location = new System.Drawing.Point(24, 59);
            this.txBoxNombreAgregarCamp.Name = "txBoxNombreAgregarCamp";
            this.txBoxNombreAgregarCamp.Size = new System.Drawing.Size(250, 27);
            this.txBoxNombreAgregarCamp.TabIndex = 11;
            // 
            // dTPickFechaHasta
            // 
            this.dTPickFechaHasta.Checked = false;
            this.dTPickFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dTPickFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickFechaHasta.Location = new System.Drawing.Point(464, 116);
            this.dTPickFechaHasta.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dTPickFechaHasta.Name = "dTPickFechaHasta";
            this.dTPickFechaHasta.Size = new System.Drawing.Size(166, 27);
            this.dTPickFechaHasta.TabIndex = 10;
            this.dTPickFechaHasta.Value = new System.DateTime(2020, 9, 10, 0, 0, 0, 0);
            // 
            // dTPickFechaDesde
            // 
            this.dTPickFechaDesde.Checked = false;
            this.dTPickFechaDesde.CustomFormat = "dd/MM/yyyy";
            this.dTPickFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickFechaDesde.Location = new System.Drawing.Point(464, 79);
            this.dTPickFechaDesde.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dTPickFechaDesde.Name = "dTPickFechaDesde";
            this.dTPickFechaDesde.Size = new System.Drawing.Size(166, 27);
            this.dTPickFechaDesde.TabIndex = 9;
            this.dTPickFechaDesde.Value = new System.DateTime(2020, 9, 10, 0, 0, 0, 0);
            // 
            // lblHastaFechaAgregar
            // 
            this.lblHastaFechaAgregar.AutoSize = true;
            this.lblHastaFechaAgregar.Location = new System.Drawing.Point(388, 116);
            this.lblHastaFechaAgregar.Name = "lblHastaFechaAgregar";
            this.lblHastaFechaAgregar.Size = new System.Drawing.Size(59, 20);
            this.lblHastaFechaAgregar.TabIndex = 8;
            this.lblHastaFechaAgregar.Text = "Hasta";
            // 
            // lblDesdeFechaAgregar
            // 
            this.lblDesdeFechaAgregar.AutoSize = true;
            this.lblDesdeFechaAgregar.Location = new System.Drawing.Point(388, 84);
            this.lblDesdeFechaAgregar.Name = "lblDesdeFechaAgregar";
            this.lblDesdeFechaAgregar.Size = new System.Drawing.Size(63, 20);
            this.lblDesdeFechaAgregar.TabIndex = 7;
            this.lblDesdeFechaAgregar.Text = "Desde";
            // 
            // lblEntreFechasAgregar
            // 
            this.lblEntreFechasAgregar.AutoSize = true;
            this.lblEntreFechasAgregar.Location = new System.Drawing.Point(388, 31);
            this.lblEntreFechasAgregar.Name = "lblEntreFechasAgregar";
            this.lblEntreFechasAgregar.Size = new System.Drawing.Size(173, 20);
            this.lblEntreFechasAgregar.TabIndex = 6;
            this.lblEntreFechasAgregar.Text = "Rango entre fechas";
            // 
            // lblNomAgregarCamp
            // 
            this.lblNomAgregarCamp.AutoSize = true;
            this.lblNomAgregarCamp.Location = new System.Drawing.Point(21, 29);
            this.lblNomAgregarCamp.Name = "lblNomAgregarCamp";
            this.lblNomAgregarCamp.Size = new System.Drawing.Size(80, 20);
            this.lblNomAgregarCamp.TabIndex = 0;
            this.lblNomAgregarCamp.Text = "Nombre ";
            // 
            // BtnVolverCampaña
            // 
            this.BtnVolverCampaña.BackColor = System.Drawing.Color.Silver;
            this.BtnVolverCampaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnVolverCampaña.Location = new System.Drawing.Point(602, 670);
            this.BtnVolverCampaña.Name = "BtnVolverCampaña";
            this.BtnVolverCampaña.Size = new System.Drawing.Size(110, 50);
            this.BtnVolverCampaña.TabIndex = 21;
            this.BtnVolverCampaña.Text = "Volver";
            this.BtnVolverCampaña.UseVisualStyleBackColor = false;
            this.BtnVolverCampaña.Click += new System.EventHandler(this.BtnVolverCampaña_Click);
            // 
            // gBoxImagenes
            // 
            this.gBoxImagenes.BackColor = System.Drawing.Color.Silver;
            this.gBoxImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBoxImagenes.Location = new System.Drawing.Point(10, 188);
            this.gBoxImagenes.Name = "gBoxImagenes";
            this.gBoxImagenes.Size = new System.Drawing.Size(1008, 467);
            this.gBoxImagenes.TabIndex = 3;
            this.gBoxImagenes.TabStop = false;
            this.gBoxImagenes.Text = "Imágenes a visualizar";
            // 
            // tbControlModificar
            // 
            this.tbControlModificar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbControlModificar.Controls.Add(this.btnModEliminar);
            this.tbControlModificar.Controls.Add(this.btnModificar);
            this.tbControlModificar.Controls.Add(this.btnModVolver);
            this.tbControlModificar.Controls.Add(this.gBoxImagenMod);
            this.tbControlModificar.Controls.Add(this.gBoxCampañaMod);
            this.tbControlModificar.Location = new System.Drawing.Point(4, 29);
            this.tbControlModificar.Name = "tbControlModificar";
            this.tbControlModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbControlModificar.Size = new System.Drawing.Size(1030, 727);
            this.tbControlModificar.TabIndex = 1;
            this.tbControlModificar.Text = "Modificar";
            // 
            // btnModEliminar
            // 
            this.btnModEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnModEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnModEliminar.Location = new System.Drawing.Point(907, 670);
            this.btnModEliminar.Name = "btnModEliminar";
            this.btnModEliminar.Size = new System.Drawing.Size(110, 50);
            this.btnModEliminar.TabIndex = 24;
            this.btnModEliminar.Text = "Eliminar";
            this.btnModEliminar.UseVisualStyleBackColor = false;
            this.btnModEliminar.Click += new System.EventHandler(this.BtnModEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Silver;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(304, 670);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 50);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnModVolver
            // 
            this.btnModVolver.BackColor = System.Drawing.Color.Silver;
            this.btnModVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnModVolver.Location = new System.Drawing.Point(602, 670);
            this.btnModVolver.Name = "btnModVolver";
            this.btnModVolver.Size = new System.Drawing.Size(110, 50);
            this.btnModVolver.TabIndex = 23;
            this.btnModVolver.Text = "Volver";
            this.btnModVolver.UseVisualStyleBackColor = false;
            this.btnModVolver.Click += new System.EventHandler(this.BtnModVolver_Click);
            // 
            // gBoxImagenMod
            // 
            this.gBoxImagenMod.BackColor = System.Drawing.Color.Silver;
            this.gBoxImagenMod.Controls.Add(this.button1);
            this.gBoxImagenMod.Controls.Add(this.button2);
            this.gBoxImagenMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBoxImagenMod.Location = new System.Drawing.Point(9, 187);
            this.gBoxImagenMod.Name = "gBoxImagenMod";
            this.gBoxImagenMod.Size = new System.Drawing.Size(1008, 467);
            this.gBoxImagenMod.TabIndex = 4;
            this.gBoxImagenMod.TabStop = false;
            this.gBoxImagenMod.Text = "Imágenes a visualizar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gBoxCampañaMod
            // 
            this.gBoxCampañaMod.BackColor = System.Drawing.Color.Silver;
            this.gBoxCampañaMod.Controls.Add(this.CargarImagMod);
            this.gBoxCampañaMod.Controls.Add(this.nUDuracionMod);
            this.gBoxCampañaMod.Controls.Add(this.label2);
            this.gBoxCampañaMod.Controls.Add(this.nUpHastaHoraMod);
            this.gBoxCampañaMod.Controls.Add(this.nUpDesdeHoraMod);
            this.gBoxCampañaMod.Controls.Add(this.label3);
            this.gBoxCampañaMod.Controls.Add(this.label4);
            this.gBoxCampañaMod.Controls.Add(this.label5);
            this.gBoxCampañaMod.Controls.Add(this.txtNomCampañaMod);
            this.gBoxCampañaMod.Controls.Add(this.dTPickFechaHastaMod);
            this.gBoxCampañaMod.Controls.Add(this.dTPickFechaDesdeMod);
            this.gBoxCampañaMod.Controls.Add(this.label6);
            this.gBoxCampañaMod.Controls.Add(this.label7);
            this.gBoxCampañaMod.Controls.Add(this.label8);
            this.gBoxCampañaMod.Controls.Add(this.label9);
            this.gBoxCampañaMod.Controls.Add(this.cBoxModCampActivas);
            this.gBoxCampañaMod.Controls.Add(this.lblModCampañasAct);
            this.gBoxCampañaMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBoxCampañaMod.Location = new System.Drawing.Point(9, 6);
            this.gBoxCampañaMod.Name = "gBoxCampañaMod";
            this.gBoxCampañaMod.Size = new System.Drawing.Size(1008, 175);
            this.gBoxCampañaMod.TabIndex = 1;
            this.gBoxCampañaMod.TabStop = false;
            this.gBoxCampañaMod.Text = "Campañas";
            // 
            // CargarImagMod
            // 
            this.CargarImagMod.Image = global::CarteleriaDigital.Properties.Resources._Imagen;
            this.CargarImagMod.Location = new System.Drawing.Point(914, 21);
            this.CargarImagMod.Name = "CargarImagMod";
            this.CargarImagMod.Size = new System.Drawing.Size(84, 83);
            this.CargarImagMod.TabIndex = 22;
            this.CargarImagMod.UseVisualStyleBackColor = true;
            this.CargarImagMod.Click += new System.EventHandler(this.CargarImagMod_Click);
            // 
            // nUDuracionMod
            // 
            this.nUDuracionMod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDuracionMod.Location = new System.Drawing.Point(315, 118);
            this.nUDuracionMod.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUDuracionMod.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDuracionMod.Name = "nUDuracionMod";
            this.nUDuracionMod.Size = new System.Drawing.Size(51, 27);
            this.nUDuracionMod.TabIndex = 32;
            this.nUDuracionMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDuracionMod.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Duracion entre imagenes";
            // 
            // nUpHastaHoraMod
            // 
            this.nUpHastaHoraMod.Location = new System.Drawing.Point(820, 117);
            this.nUpHastaHoraMod.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nUpHastaHoraMod.Name = "nUpHastaHoraMod";
            this.nUpHastaHoraMod.Size = new System.Drawing.Size(64, 27);
            this.nUpHastaHoraMod.TabIndex = 30;
            this.nUpHastaHoraMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nUpDesdeHoraMod
            // 
            this.nUpDesdeHoraMod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nUpDesdeHoraMod.Location = new System.Drawing.Point(820, 81);
            this.nUpDesdeHoraMod.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nUpDesdeHoraMod.Name = "nUpDesdeHoraMod";
            this.nUpDesdeHoraMod.Size = new System.Drawing.Size(64, 27);
            this.nUpDesdeHoraMod.TabIndex = 29;
            this.nUpDesdeHoraMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(750, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Rango de Horas";
            // 
            // txtNomCampañaMod
            // 
            this.txtNomCampañaMod.Location = new System.Drawing.Point(7, 120);
            this.txtNomCampañaMod.Name = "txtNomCampañaMod";
            this.txtNomCampañaMod.Size = new System.Drawing.Size(220, 27);
            this.txtNomCampañaMod.TabIndex = 25;
            // 
            // dTPickFechaHastaMod
            // 
            this.dTPickFechaHastaMod.Checked = false;
            this.dTPickFechaHastaMod.CustomFormat = "dd/MM/yyyy";
            this.dTPickFechaHastaMod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickFechaHastaMod.Location = new System.Drawing.Point(571, 119);
            this.dTPickFechaHastaMod.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dTPickFechaHastaMod.Name = "dTPickFechaHastaMod";
            this.dTPickFechaHastaMod.Size = new System.Drawing.Size(166, 27);
            this.dTPickFechaHastaMod.TabIndex = 24;
            this.dTPickFechaHastaMod.Value = new System.DateTime(2020, 9, 10, 0, 0, 0, 0);
            // 
            // dTPickFechaDesdeMod
            // 
            this.dTPickFechaDesdeMod.Checked = false;
            this.dTPickFechaDesdeMod.CustomFormat = "dd/MM/yyyy";
            this.dTPickFechaDesdeMod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickFechaDesdeMod.Location = new System.Drawing.Point(571, 82);
            this.dTPickFechaDesdeMod.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dTPickFechaDesdeMod.Name = "dTPickFechaDesdeMod";
            this.dTPickFechaDesdeMod.Size = new System.Drawing.Size(166, 27);
            this.dTPickFechaDesdeMod.TabIndex = 23;
            this.dTPickFechaDesdeMod.Value = new System.DateTime(2020, 9, 10, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Desde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rango entre fechas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nombre ";
            // 
            // cBoxModCampActivas
            // 
            this.cBoxModCampActivas.FormattingEnabled = true;
            this.cBoxModCampActivas.Location = new System.Drawing.Point(108, 31);
            this.cBoxModCampActivas.Name = "cBoxModCampActivas";
            this.cBoxModCampActivas.Size = new System.Drawing.Size(309, 28);
            this.cBoxModCampActivas.TabIndex = 1;
            this.cBoxModCampActivas.TabStop = false;
            this.cBoxModCampActivas.SelectedIndexChanged += new System.EventHandler(this.CBoxModCampActivas_SelectedIndexChanged);
            // 
            // lblModCampañasAct
            // 
            this.lblModCampañasAct.AutoSize = true;
            this.lblModCampañasAct.Location = new System.Drawing.Point(6, 35);
            this.lblModCampañasAct.Name = "lblModCampañasAct";
            this.lblModCampañasAct.Size = new System.Drawing.Size(71, 20);
            this.lblModCampañasAct.TabIndex = 0;
            this.lblModCampañasAct.Text = "Activas";
            // 
            // GestionCampaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 757);
            this.Controls.Add(this.tabCampaña);
            this.Name = "GestionCampaña";
            this.Load += new System.EventHandler(this.GestionCampaña_Load);
            this.tabCampaña.ResumeLayout(false);
            this.tbCtrlAgregar.ResumeLayout(false);
            this.gBoxInfoCampaña.ResumeLayout(false);
            this.gBoxInfoCampaña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDuracionAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpHastaHoraAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDesdeHoraAgregar)).EndInit();
            this.tbControlModificar.ResumeLayout(false);
            this.gBoxImagenMod.ResumeLayout(false);
            this.gBoxCampañaMod.ResumeLayout(false);
            this.gBoxCampañaMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDuracionMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpHastaHoraMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDesdeHoraMod)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabCampaña;
    private System.Windows.Forms.TabPage tbCtrlAgregar;
    private System.Windows.Forms.TabPage tbControlModificar;
    private System.Windows.Forms.GroupBox gBoxInfoCampaña;
    private System.Windows.Forms.Label lblNomAgregarCamp;
    private System.Windows.Forms.Label lblHastaHoraAgregar;
    private System.Windows.Forms.Label lblDesdeHoraAgregar;
    private System.Windows.Forms.Label lblRangoHorasAgregar;
    private System.Windows.Forms.TextBox txBoxNombreAgregarCamp;
    private System.Windows.Forms.DateTimePicker dTPickFechaHasta;
    private System.Windows.Forms.DateTimePicker dTPickFechaDesde;
    private System.Windows.Forms.Label lblHastaFechaAgregar;
    private System.Windows.Forms.Label lblDesdeFechaAgregar;
    private System.Windows.Forms.Label lblEntreFechasAgregar;
    private System.Windows.Forms.NumericUpDown nUDuracionAgregar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nUpHastaHoraAgregar;
    private System.Windows.Forms.NumericUpDown nUpDesdeHoraAgregar;
    private System.Windows.Forms.Button CargarImag;
    private System.Windows.Forms.Button btnAceptarCampaña;
    private System.Windows.Forms.GroupBox gBoxImagenes;
    private System.Windows.Forms.Button BtnVolverCampaña;
    private System.Windows.Forms.GroupBox gBoxImagenMod;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.GroupBox gBoxCampañaMod;
    private System.Windows.Forms.NumericUpDown nUDuracionMod;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown nUpHastaHoraMod;
    private System.Windows.Forms.NumericUpDown nUpDesdeHoraMod;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtNomCampañaMod;
    private System.Windows.Forms.DateTimePicker dTPickFechaHastaMod;
    private System.Windows.Forms.DateTimePicker dTPickFechaDesdeMod;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox cBoxModCampActivas;
    private System.Windows.Forms.Label lblModCampañasAct;
    private System.Windows.Forms.Button btnModEliminar;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnModVolver;
    private System.Windows.Forms.Button CargarImagMod;
    }
}