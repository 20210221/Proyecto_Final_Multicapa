namespace Capa_Presentacion
{
    partial class ConfigRegistre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigRegistre));
            this.PanelTopFormulario = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TablaConfig = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EdificioLugar = new System.Windows.Forms.TextBox();
            this.AulaLugar = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddLugar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditLugar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveLugar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelTopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaConfig)).BeginInit();
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
            this.PanelTopFormulario.Size = new System.Drawing.Size(736, 86);
            this.PanelTopFormulario.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Capa_Presentacion.Properties.Resources._8445624_left_return_arrow_icon__1_;
            this.pictureBox2.Location = new System.Drawing.Point(659, 12);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(304, 33);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Configurar Registro ";
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
            // TablaConfig
            // 
            this.TablaConfig.AllowUserToAddRows = false;
            this.TablaConfig.AllowUserToDeleteRows = false;
            this.TablaConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaConfig.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaConfig.BackgroundColor = System.Drawing.Color.White;
            this.TablaConfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaConfig.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaConfig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaConfig.ColumnHeadersVisible = false;
            this.TablaConfig.Location = new System.Drawing.Point(29, 148);
            this.TablaConfig.Name = "TablaConfig";
            this.TablaConfig.ReadOnly = true;
            this.TablaConfig.RowHeadersVisible = false;
            this.TablaConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaConfig.Size = new System.Drawing.Size(427, 217);
            this.TablaConfig.TabIndex = 6;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(109, 113);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(62, 17);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Edificio";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(329, 113);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel3.TabIndex = 23;
            this.bunifuCustomLabel3.Text = "Aula";
            // 
            // EdificioLugar
            // 
            this.EdificioLugar.Enabled = false;
            this.EdificioLugar.Location = new System.Drawing.Point(492, 199);
            this.EdificioLugar.Name = "EdificioLugar";
            this.EdificioLugar.Size = new System.Drawing.Size(203, 20);
            this.EdificioLugar.TabIndex = 24;
            // 
            // AulaLugar
            // 
            this.AulaLugar.Enabled = false;
            this.AulaLugar.Location = new System.Drawing.Point(492, 287);
            this.AulaLugar.Name = "AulaLugar";
            this.AulaLugar.Size = new System.Drawing.Size(203, 20);
            this.AulaLugar.TabIndex = 25;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(489, 252);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel4.TabIndex = 27;
            this.bunifuCustomLabel4.Text = "Aula";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(489, 162);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(62, 17);
            this.bunifuCustomLabel5.TabIndex = 26;
            this.bunifuCustomLabel5.Text = "Edificio";
            // 
            // btnAddLugar
            // 
            this.btnAddLugar.Activecolor = System.Drawing.Color.Teal;
            this.btnAddLugar.BackColor = System.Drawing.Color.Teal;
            this.btnAddLugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddLugar.BorderRadius = 0;
            this.btnAddLugar.ButtonText = "Agregar";
            this.btnAddLugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLugar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddLugar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddLugar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddLugar.Iconimage")));
            this.btnAddLugar.Iconimage_right = null;
            this.btnAddLugar.Iconimage_right_Selected = null;
            this.btnAddLugar.Iconimage_Selected = null;
            this.btnAddLugar.IconMarginLeft = 0;
            this.btnAddLugar.IconMarginRight = 0;
            this.btnAddLugar.IconRightVisible = true;
            this.btnAddLugar.IconRightZoom = 0D;
            this.btnAddLugar.IconVisible = true;
            this.btnAddLugar.IconZoom = 90D;
            this.btnAddLugar.IsTab = false;
            this.btnAddLugar.Location = new System.Drawing.Point(71, 380);
            this.btnAddLugar.Name = "btnAddLugar";
            this.btnAddLugar.Normalcolor = System.Drawing.Color.Teal;
            this.btnAddLugar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddLugar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddLugar.selected = false;
            this.btnAddLugar.Size = new System.Drawing.Size(146, 56);
            this.btnAddLugar.TabIndex = 28;
            this.btnAddLugar.Text = "Agregar";
            this.btnAddLugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLugar.Textcolor = System.Drawing.Color.White;
            this.btnAddLugar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLugar.Click += new System.EventHandler(this.btnAddLugar_Click);
            // 
            // btnEditLugar
            // 
            this.btnEditLugar.Activecolor = System.Drawing.Color.Teal;
            this.btnEditLugar.BackColor = System.Drawing.Color.Teal;
            this.btnEditLugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditLugar.BorderRadius = 0;
            this.btnEditLugar.ButtonText = "Editar";
            this.btnEditLugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditLugar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditLugar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditLugar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditLugar.Iconimage")));
            this.btnEditLugar.Iconimage_right = null;
            this.btnEditLugar.Iconimage_right_Selected = null;
            this.btnEditLugar.Iconimage_Selected = null;
            this.btnEditLugar.IconMarginLeft = 0;
            this.btnEditLugar.IconMarginRight = 0;
            this.btnEditLugar.IconRightVisible = true;
            this.btnEditLugar.IconRightZoom = 0D;
            this.btnEditLugar.IconVisible = true;
            this.btnEditLugar.IconZoom = 90D;
            this.btnEditLugar.IsTab = false;
            this.btnEditLugar.Location = new System.Drawing.Point(271, 380);
            this.btnEditLugar.Name = "btnEditLugar";
            this.btnEditLugar.Normalcolor = System.Drawing.Color.Teal;
            this.btnEditLugar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditLugar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditLugar.selected = false;
            this.btnEditLugar.Size = new System.Drawing.Size(135, 56);
            this.btnEditLugar.TabIndex = 29;
            this.btnEditLugar.Text = "Editar";
            this.btnEditLugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditLugar.Textcolor = System.Drawing.Color.White;
            this.btnEditLugar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLugar.Click += new System.EventHandler(this.btnEditLugar_Click);
            // 
            // btnSaveLugar
            // 
            this.btnSaveLugar.Activecolor = System.Drawing.Color.Teal;
            this.btnSaveLugar.BackColor = System.Drawing.Color.Teal;
            this.btnSaveLugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveLugar.BorderRadius = 0;
            this.btnSaveLugar.ButtonText = "Guardar";
            this.btnSaveLugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLugar.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveLugar.Enabled = false;
            this.btnSaveLugar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveLugar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveLugar.Iconimage")));
            this.btnSaveLugar.Iconimage_right = null;
            this.btnSaveLugar.Iconimage_right_Selected = null;
            this.btnSaveLugar.Iconimage_Selected = null;
            this.btnSaveLugar.IconMarginLeft = 0;
            this.btnSaveLugar.IconMarginRight = 0;
            this.btnSaveLugar.IconRightVisible = true;
            this.btnSaveLugar.IconRightZoom = 0D;
            this.btnSaveLugar.IconVisible = true;
            this.btnSaveLugar.IconZoom = 90D;
            this.btnSaveLugar.IsTab = false;
            this.btnSaveLugar.Location = new System.Drawing.Point(537, 369);
            this.btnSaveLugar.Name = "btnSaveLugar";
            this.btnSaveLugar.Normalcolor = System.Drawing.Color.Teal;
            this.btnSaveLugar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveLugar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveLugar.selected = false;
            this.btnSaveLugar.Size = new System.Drawing.Size(158, 67);
            this.btnSaveLugar.TabIndex = 30;
            this.btnSaveLugar.Text = "Guardar";
            this.btnSaveLugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveLugar.Textcolor = System.Drawing.Color.White;
            this.btnSaveLugar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLugar.Click += new System.EventHandler(this.btnSaveLugar_Click);
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.PanelTopFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // ConfigRegistre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(736, 460);
            this.Controls.Add(this.btnSaveLugar);
            this.Controls.Add(this.btnEditLugar);
            this.Controls.Add(this.btnAddLugar);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.AulaLugar);
            this.Controls.Add(this.EdificioLugar);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.TablaConfig);
            this.Controls.Add(this.PanelTopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigRegistre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConfigRegistre_Load);
            this.PanelTopFormulario.ResumeLayout(false);
            this.PanelTopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView TablaConfig;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox EdificioLugar;
        private System.Windows.Forms.TextBox AulaLugar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddLugar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditLugar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveLugar;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
    }
}

