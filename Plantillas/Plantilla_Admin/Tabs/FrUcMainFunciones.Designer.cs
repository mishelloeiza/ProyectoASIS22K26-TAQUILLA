namespace Plantilla_Admin
{
    partial class FrUcMainFunciones
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            PnlTop = new Panel();
            CbCatalog = new Krypton.Toolkit.KryptonComboBox();
            BtnSalas = new Button();
            BtnPromocion = new Button();
            BtnFunciones = new Button();
            BtnPeliculas = new Button();
            PnlMain = new Panel();
            BtnCartelera = new Button();
            PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CbCatalog).BeginInit();
            SuspendLayout();
            // 
            // PnlTop
            // 
            PnlTop.BackColor = Color.Black;
            PnlTop.BorderStyle = BorderStyle.FixedSingle;
            PnlTop.Controls.Add(BtnCartelera);
            PnlTop.Controls.Add(CbCatalog);
            PnlTop.Controls.Add(BtnSalas);
            PnlTop.Controls.Add(BtnPromocion);
            PnlTop.Controls.Add(BtnFunciones);
            PnlTop.Controls.Add(BtnPeliculas);
            PnlTop.Dock = DockStyle.Top;
            PnlTop.Location = new Point(0, 0);
            PnlTop.Margin = new Padding(0);
            PnlTop.Name = "PnlTop";
            PnlTop.Size = new Size(1050, 35);
            PnlTop.TabIndex = 1;
            // 
            // CbCatalog
            // 
            CbCatalog.Dock = DockStyle.Right;
            CbCatalog.DropDownHeight = 250;
            CbCatalog.DropDownStyle = ComboBoxStyle.DropDownList;
            CbCatalog.IntegralHeight = false;
            CbCatalog.Items.AddRange(new object[] { "Cines", "Ciudades", "Clasificaciones", "Estados De Película", "Formatos De Película", "Generos", "Tipos De Sala" });
            CbCatalog.Location = new Point(798, 0);
            CbCatalog.Margin = new Padding(0);
            CbCatalog.Name = "CbCatalog";
            CbCatalog.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            CbCatalog.Size = new Size(250, 33);
            CbCatalog.StateCommon.ComboBox.Back.Color1 = Color.Black;
            CbCatalog.StateCommon.ComboBox.Border.Width = 1;
            CbCatalog.StateCommon.ComboBox.Content.Color1 = Color.FromArgb(220, 210, 210);
            CbCatalog.StateCommon.ComboBox.Content.Font = new Font("Times New Roman", 13.8F);
            CbCatalog.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            CbCatalog.TabIndex = 2;
            // 
            // BtnSalas
            // 
            BtnSalas.BackColor = Color.Black;
            BtnSalas.Cursor = Cursors.Hand;
            BtnSalas.Dock = DockStyle.Left;
            BtnSalas.FlatAppearance.BorderColor = Color.White;
            BtnSalas.FlatStyle = FlatStyle.Flat;
            BtnSalas.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalas.ForeColor = Color.FromArgb(220, 210, 210);
            BtnSalas.Location = new Point(387, 0);
            BtnSalas.Margin = new Padding(0, 2, 0, 0);
            BtnSalas.Name = "BtnSalas";
            BtnSalas.Size = new Size(129, 33);
            BtnSalas.TabIndex = 7;
            BtnSalas.Text = "Salas";
            BtnSalas.UseVisualStyleBackColor = false;
            // 
            // BtnPromocion
            // 
            BtnPromocion.BackColor = Color.Black;
            BtnPromocion.Cursor = Cursors.Hand;
            BtnPromocion.Dock = DockStyle.Left;
            BtnPromocion.FlatAppearance.BorderColor = Color.White;
            BtnPromocion.FlatStyle = FlatStyle.Flat;
            BtnPromocion.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnPromocion.ForeColor = Color.FromArgb(220, 210, 210);
            BtnPromocion.Location = new Point(258, 0);
            BtnPromocion.Margin = new Padding(0, 2, 0, 0);
            BtnPromocion.Name = "BtnPromocion";
            BtnPromocion.Size = new Size(129, 33);
            BtnPromocion.TabIndex = 6;
            BtnPromocion.Text = "Promociones";
            BtnPromocion.UseVisualStyleBackColor = false;
            // 
            // BtnFunciones
            // 
            BtnFunciones.BackColor = Color.Black;
            BtnFunciones.Cursor = Cursors.Hand;
            BtnFunciones.Dock = DockStyle.Left;
            BtnFunciones.FlatAppearance.BorderColor = Color.White;
            BtnFunciones.FlatStyle = FlatStyle.Flat;
            BtnFunciones.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFunciones.ForeColor = Color.FromArgb(220, 210, 210);
            BtnFunciones.Location = new Point(129, 0);
            BtnFunciones.Margin = new Padding(0, 2, 0, 0);
            BtnFunciones.Name = "BtnFunciones";
            BtnFunciones.Size = new Size(129, 33);
            BtnFunciones.TabIndex = 5;
            BtnFunciones.Text = "Funciones";
            BtnFunciones.UseVisualStyleBackColor = false;
            // 
            // BtnPeliculas
            // 
            BtnPeliculas.BackColor = Color.Black;
            BtnPeliculas.Cursor = Cursors.Hand;
            BtnPeliculas.Dock = DockStyle.Left;
            BtnPeliculas.FlatAppearance.BorderColor = Color.White;
            BtnPeliculas.FlatStyle = FlatStyle.Flat;
            BtnPeliculas.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnPeliculas.ForeColor = Color.FromArgb(220, 210, 210);
            BtnPeliculas.Location = new Point(0, 0);
            BtnPeliculas.Margin = new Padding(0, 2, 0, 0);
            BtnPeliculas.Name = "BtnPeliculas";
            BtnPeliculas.Size = new Size(129, 33);
            BtnPeliculas.TabIndex = 4;
            BtnPeliculas.Text = "Películas";
            BtnPeliculas.UseVisualStyleBackColor = false;
            // 
            // PnlMain
            // 
            PnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlMain.Location = new Point(0, 35);
            PnlMain.Margin = new Padding(0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(1050, 665);
            PnlMain.TabIndex = 3;
            // 
            // BtnCartelera
            // 
            BtnCartelera.BackColor = Color.Black;
            BtnCartelera.Cursor = Cursors.Hand;
            BtnCartelera.Dock = DockStyle.Left;
            BtnCartelera.FlatAppearance.BorderColor = Color.White;
            BtnCartelera.FlatStyle = FlatStyle.Flat;
            BtnCartelera.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCartelera.ForeColor = Color.FromArgb(220, 210, 210);
            BtnCartelera.Location = new Point(516, 0);
            BtnCartelera.Margin = new Padding(0, 2, 0, 0);
            BtnCartelera.Name = "BtnCartelera";
            BtnCartelera.Size = new Size(129, 33);
            BtnCartelera.TabIndex = 8;
            BtnCartelera.Text = "Cartelera";
            BtnCartelera.UseVisualStyleBackColor = false;
            BtnCartelera.Click += BtnCartelera_Click;
            // 
            // FrUcMainFunciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(PnlMain);
            Controls.Add(PnlTop);
            Name = "FrUcMainFunciones";
            Size = new Size(1050, 700);
            PnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CbCatalog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTop;
        private Krypton.Toolkit.KryptonComboBox CbCatalog;
        private Button BtnSalas;
        private Button BtnPromocion;
        private Button BtnFunciones;
        private Button BtnPeliculas;
        private Panel PnlMain;
        private Button BtnCartelera;
    }
}
