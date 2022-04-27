namespace Capa_Presentacion
{
    partial class CreateVisits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateVisits));
            this.PanelTopFormulario = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VisitanteName = new System.Windows.Forms.TextBox();
            this.VisitanteLName = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VisitanteCarrera = new System.Windows.Forms.TextBox();
            this.VisitanteEmail = new System.Windows.Forms.MaskedTextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VisitanteEntrada = new System.Windows.Forms.DateTimePicker();
            this.VisitanteSalida = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VisitanteMotivo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.VisitanteFoto = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VisitanteEdificio = new System.Windows.Forms.ComboBox();
            this.VisitanteAula = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VisitantebtnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.VisitanteSubirImagenbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelTopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitanteFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopFormulario
            // 
            this.PanelTopFormulario.BackColor = System.Drawing.Color.Teal;
            this.PanelTopFormulario.Controls.Add(this.pictureBox2);
            this.PanelTopFormulario.Controls.Add(this.bunifuCustomLabel1);
            this.PanelTopFormulario.Controls.Add(this.pictureBox1);
            this.PanelTopFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopFormulario.Location = new System.Drawing.Point(0, 0);
            this.PanelTopFormulario.Name = "PanelTopFormulario";
            this.PanelTopFormulario.Size = new System.Drawing.Size(911, 86);
            this.PanelTopFormulario.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Capa_Presentacion.Properties.Resources._8445624_left_return_arrow_icon__1_;
            this.pictureBox2.Location = new System.Drawing.Point(820, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(95, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(237, 33);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Nuevo Visitante";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // VisitanteName
            // 
            this.VisitanteName.Location = new System.Drawing.Point(29, 152);
            this.VisitanteName.Name = "VisitanteName";
            this.VisitanteName.Size = new System.Drawing.Size(200, 20);
            this.VisitanteName.TabIndex = 1;
            // 
            // VisitanteLName
            // 
            this.VisitanteLName.Location = new System.Drawing.Point(248, 152);
            this.VisitanteLName.Name = "VisitanteLName";
            this.VisitanteLName.Size = new System.Drawing.Size(213, 20);
            this.VisitanteLName.TabIndex = 2;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(26, 122);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(66, 17);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Nombre";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(245, 122);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(67, 17);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Apellido";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(475, 122);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(146, 17);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Carrera (Opcional)";
            // 
            // VisitanteCarrera
            // 
            this.VisitanteCarrera.Location = new System.Drawing.Point(478, 152);
            this.VisitanteCarrera.Name = "VisitanteCarrera";
            this.VisitanteCarrera.Size = new System.Drawing.Size(213, 20);
            this.VisitanteCarrera.TabIndex = 5;
            // 
            // VisitanteEmail
            // 
            this.VisitanteEmail.Location = new System.Drawing.Point(29, 231);
            this.VisitanteEmail.Name = "VisitanteEmail";
            this.VisitanteEmail.Size = new System.Drawing.Size(200, 20);
            this.VisitanteEmail.TabIndex = 7;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(26, 201);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(127, 17);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Email (Opcional)";
            // 
            // VisitanteEntrada
            // 
            this.VisitanteEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VisitanteEntrada.Location = new System.Drawing.Point(261, 228);
            this.VisitanteEntrada.Name = "VisitanteEntrada";
            this.VisitanteEntrada.Size = new System.Drawing.Size(211, 20);
            this.VisitanteEntrada.TabIndex = 9;
            // 
            // VisitanteSalida
            // 
            this.VisitanteSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VisitanteSalida.Location = new System.Drawing.Point(490, 228);
            this.VisitanteSalida.Name = "VisitanteSalida";
            this.VisitanteSalida.Size = new System.Drawing.Size(201, 20);
            this.VisitanteSalida.TabIndex = 10;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(264, 201);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(66, 17);
            this.bunifuCustomLabel6.TabIndex = 11;
            this.bunifuCustomLabel6.Text = "Entrada";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(489, 201);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(53, 17);
            this.bunifuCustomLabel7.TabIndex = 12;
            this.bunifuCustomLabel7.Text = "Salida";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(91, 278);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(138, 17);
            this.bunifuCustomLabel8.TabIndex = 14;
            this.bunifuCustomLabel8.Text = "Motivo de la Visita";
            // 
            // VisitanteMotivo
            // 
            this.VisitanteMotivo.Location = new System.Drawing.Point(29, 308);
            this.VisitanteMotivo.Multiline = true;
            this.VisitanteMotivo.Name = "VisitanteMotivo";
            this.VisitanteMotivo.Size = new System.Drawing.Size(266, 103);
            this.VisitanteMotivo.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VisitanteFoto
            // 
            this.VisitanteFoto.BackColor = System.Drawing.Color.White;
            this.VisitanteFoto.Location = new System.Drawing.Point(358, 319);
            this.VisitanteFoto.Name = "VisitanteFoto";
            this.VisitanteFoto.Size = new System.Drawing.Size(141, 79);
            this.VisitanteFoto.TabIndex = 16;
            this.VisitanteFoto.TabStop = false;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(435, 278);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(119, 17);
            this.bunifuCustomLabel9.TabIndex = 17;
            this.bunifuCustomLabel9.Text = "Foto (Opcional)";
            // 
            // VisitanteEdificio
            // 
            this.VisitanteEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisitanteEdificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisitanteEdificio.FormattingEnabled = true;
            this.VisitanteEdificio.Location = new System.Drawing.Point(718, 151);
            this.VisitanteEdificio.Name = "VisitanteEdificio";
            this.VisitanteEdificio.Size = new System.Drawing.Size(157, 21);
            this.VisitanteEdificio.TabIndex = 18;
            this.VisitanteEdificio.SelectedIndexChanged += new System.EventHandler(this.VisitanteEdificio_SelectedIndexChanged);
            // 
            // VisitanteAula
            // 
            this.VisitanteAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisitanteAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisitanteAula.FormattingEnabled = true;
            this.VisitanteAula.Location = new System.Drawing.Point(718, 227);
            this.VisitanteAula.Name = "VisitanteAula";
            this.VisitanteAula.Size = new System.Drawing.Size(157, 21);
            this.VisitanteAula.TabIndex = 19;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(715, 122);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(58, 17);
            this.bunifuCustomLabel10.TabIndex = 20;
            this.bunifuCustomLabel10.Text = "Edifico";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(715, 201);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel11.TabIndex = 21;
            this.bunifuCustomLabel11.Text = "Aula";
            // 
            // VisitantebtnSave
            // 
            this.VisitantebtnSave.Activecolor = System.Drawing.Color.Teal;
            this.VisitantebtnSave.BackColor = System.Drawing.Color.Teal;
            this.VisitantebtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisitantebtnSave.BorderRadius = 0;
            this.VisitantebtnSave.ButtonText = "Guerdar";
            this.VisitantebtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisitantebtnSave.DisabledColor = System.Drawing.Color.Gray;
            this.VisitantebtnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.VisitantebtnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("VisitantebtnSave.Iconimage")));
            this.VisitantebtnSave.Iconimage_right = null;
            this.VisitantebtnSave.Iconimage_right_Selected = null;
            this.VisitantebtnSave.Iconimage_Selected = null;
            this.VisitantebtnSave.IconMarginLeft = 0;
            this.VisitantebtnSave.IconMarginRight = 0;
            this.VisitantebtnSave.IconRightVisible = true;
            this.VisitantebtnSave.IconRightZoom = 0D;
            this.VisitantebtnSave.IconVisible = true;
            this.VisitantebtnSave.IconZoom = 90D;
            this.VisitantebtnSave.IsTab = false;
            this.VisitantebtnSave.Location = new System.Drawing.Point(709, 319);
            this.VisitantebtnSave.Name = "VisitantebtnSave";
            this.VisitantebtnSave.Normalcolor = System.Drawing.Color.Teal;
            this.VisitantebtnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VisitantebtnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.VisitantebtnSave.selected = false;
            this.VisitantebtnSave.Size = new System.Drawing.Size(166, 79);
            this.VisitantebtnSave.TabIndex = 22;
            this.VisitantebtnSave.Text = "Guerdar";
            this.VisitantebtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VisitantebtnSave.Textcolor = System.Drawing.Color.White;
            this.VisitantebtnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitantebtnSave.Click += new System.EventHandler(this.VisitantebtnSave_Click);
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.PanelTopFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // VisitanteSubirImagenbtn
            // 
            this.VisitanteSubirImagenbtn.Activecolor = System.Drawing.Color.Teal;
            this.VisitanteSubirImagenbtn.BackColor = System.Drawing.Color.Teal;
            this.VisitanteSubirImagenbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisitanteSubirImagenbtn.BorderRadius = 0;
            this.VisitanteSubirImagenbtn.ButtonText = "Subir";
            this.VisitanteSubirImagenbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisitanteSubirImagenbtn.DisabledColor = System.Drawing.Color.Gray;
            this.VisitanteSubirImagenbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.VisitanteSubirImagenbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("VisitanteSubirImagenbtn.Iconimage")));
            this.VisitanteSubirImagenbtn.Iconimage_right = null;
            this.VisitanteSubirImagenbtn.Iconimage_right_Selected = null;
            this.VisitanteSubirImagenbtn.Iconimage_Selected = null;
            this.VisitanteSubirImagenbtn.IconMarginLeft = 0;
            this.VisitanteSubirImagenbtn.IconMarginRight = 0;
            this.VisitanteSubirImagenbtn.IconRightVisible = true;
            this.VisitanteSubirImagenbtn.IconRightZoom = 0D;
            this.VisitanteSubirImagenbtn.IconVisible = true;
            this.VisitanteSubirImagenbtn.IconZoom = 90D;
            this.VisitanteSubirImagenbtn.IsTab = false;
            this.VisitanteSubirImagenbtn.Location = new System.Drawing.Point(505, 319);
            this.VisitanteSubirImagenbtn.Name = "VisitanteSubirImagenbtn";
            this.VisitanteSubirImagenbtn.Normalcolor = System.Drawing.Color.Teal;
            this.VisitanteSubirImagenbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VisitanteSubirImagenbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.VisitanteSubirImagenbtn.selected = false;
            this.VisitanteSubirImagenbtn.Size = new System.Drawing.Size(131, 79);
            this.VisitanteSubirImagenbtn.TabIndex = 23;
            this.VisitanteSubirImagenbtn.Text = "Subir";
            this.VisitanteSubirImagenbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VisitanteSubirImagenbtn.Textcolor = System.Drawing.Color.White;
            this.VisitanteSubirImagenbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitanteSubirImagenbtn.Click += new System.EventHandler(this.VisitanteSubirImagenbtn_Click);
            // 
            // CreateVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(911, 446);
            this.Controls.Add(this.VisitanteSubirImagenbtn);
            this.Controls.Add(this.VisitantebtnSave);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.VisitanteAula);
            this.Controls.Add(this.VisitanteEdificio);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.VisitanteFoto);
            this.Controls.Add(this.VisitanteMotivo);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.VisitanteSalida);
            this.Controls.Add(this.VisitanteEntrada);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.VisitanteEmail);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.VisitanteCarrera);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.VisitanteLName);
            this.Controls.Add(this.VisitanteName);
            this.Controls.Add(this.PanelTopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateVisits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateVisits_Load);
            this.PanelTopFormulario.ResumeLayout(false);
            this.PanelTopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitanteFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox VisitanteName;
        private System.Windows.Forms.TextBox VisitanteLName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox VisitanteCarrera;
        private System.Windows.Forms.MaskedTextBox VisitanteEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.DateTimePicker VisitanteEntrada;
        private System.Windows.Forms.DateTimePicker VisitanteSalida;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.TextBox VisitanteMotivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox VisitanteFoto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ComboBox VisitanteEdificio;
        private System.Windows.Forms.ComboBox VisitanteAula;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuFlatButton VisitantebtnSave;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private Bunifu.Framework.UI.BunifuFlatButton VisitanteSubirImagenbtn;
    }
}

