
namespace Plantilla_Cliente

{
    partial class Cartelera
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartelera));
            PnlBuscador = new TableLayoutPanel();
            PnlFiltros1 = new TableLayoutPanel();
            CboCiudad = new ComboBox();
            CboCine = new ComboBox();
            BtnCargarCartelera = new Button();
            PnlFiltros2 = new TableLayoutPanel();
            Btn2DFilter = new Button();
            Btn3DFilter = new Button();
            Btn4DXFilter = new Button();
            BtnIMAXFilter = new Button();
            BtnDobFilter = new Button();
            BtnSubFilter = new Button();
            DgvCartelera = new DataGridView();
            Reservar = new DataGridViewButtonColumn();
            PicLogo = new PictureBox();
            comboBox2 = new ComboBox();
            PnlBuscador.SuspendLayout();
            PnlFiltros1.SuspendLayout();
            PnlFiltros2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCartelera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            SuspendLayout();
            // 
            // PnlBuscador
            // 
            PnlBuscador.BackColor = Color.FromArgb(20, 10, 12);
            PnlBuscador.ColumnCount = 2;
            PnlBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1888237F));
            PnlBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.81118F));
            PnlBuscador.Controls.Add(PnlFiltros1, 1, 0);
            PnlBuscador.Controls.Add(PnlFiltros2, 1, 1);
            PnlBuscador.Controls.Add(DgvCartelera, 0, 3);
            PnlBuscador.Controls.Add(PicLogo, 0, 0);
            PnlBuscador.Dock = DockStyle.Fill;
            PnlBuscador.Location = new Point(0, 0);
            PnlBuscador.Name = "PnlBuscador";
            PnlBuscador.RowCount = 4;
            PnlBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 5.99173546F));
            PnlBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 11.363636F));
            PnlBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 4.235537F));
            PnlBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 78.3057861F));
            PnlBuscador.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PnlBuscador.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PnlBuscador.Size = new Size(1053, 700);
            PnlBuscador.TabIndex = 0;
            PnlBuscador.Paint += tableLayoutPanel1_Paint;
            // 
            // PnlFiltros1
            // 
            PnlFiltros1.BackColor = Color.FromArgb(20, 10, 12);
            PnlFiltros1.ColumnCount = 3;
            PnlFiltros1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            PnlFiltros1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            PnlFiltros1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            PnlFiltros1.Controls.Add(CboCiudad, 0, 0);
            PnlFiltros1.Controls.Add(CboCine, 1, 0);
            PnlFiltros1.Controls.Add(BtnCargarCartelera, 2, 0);
            PnlFiltros1.Dock = DockStyle.Fill;
            PnlFiltros1.Location = new Point(183, 3);
            PnlFiltros1.Name = "PnlFiltros1";
            PnlFiltros1.RowCount = 1;
            PnlFiltros1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlFiltros1.Size = new Size(867, 35);
            PnlFiltros1.TabIndex = 6;
            // 
            // CboCiudad
            // 
            CboCiudad.Dock = DockStyle.Fill;
            CboCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCiudad.FormattingEnabled = true;
            CboCiudad.ItemHeight = 20;
            CboCiudad.Location = new Point(3, 3);
            CboCiudad.Name = "CboCiudad";
            CboCiudad.Size = new Size(282, 28);
            CboCiudad.TabIndex = 2;
            CboCiudad.SelectedIndexChanged += Cbo_Ciudad_SelectedIndexChanged;
            // 
            // CboCine
            // 
            CboCine.DisplayMember = "Seleccione Cine...";
            CboCine.Dock = DockStyle.Fill;
            CboCine.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCine.FormattingEnabled = true;
            CboCine.ItemHeight = 20;
            CboCine.Location = new Point(291, 3);
            CboCine.Name = "CboCine";
            CboCine.Size = new Size(283, 28);
            CboCine.TabIndex = 3;
            CboCine.ValueMember = "Seleccione Cine...";
            CboCine.SelectedIndexChanged += Cbo_Cine_SelectedIndexChanged;
            // 
            // BtnCargarCartelera
            // 
            BtnCargarCartelera.Cursor = Cursors.Hand;
            BtnCargarCartelera.Dock = DockStyle.Fill;
            BtnCargarCartelera.Location = new Point(580, 3);
            BtnCargarCartelera.Name = "BtnCargarCartelera";
            BtnCargarCartelera.Size = new Size(284, 29);
            BtnCargarCartelera.TabIndex = 5;
            BtnCargarCartelera.Text = "Consultar cartelera";
            BtnCargarCartelera.UseVisualStyleBackColor = true;
            BtnCargarCartelera.Click += BtnCargarCartelera_Click;
            // 
            // PnlFiltros2
            // 
            PnlFiltros2.BackColor = Color.FromArgb(20, 10, 12);
            PnlFiltros2.ColumnCount = 4;
            PnlFiltros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PnlFiltros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PnlFiltros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PnlFiltros2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PnlFiltros2.Controls.Add(Btn2DFilter, 0, 0);
            PnlFiltros2.Controls.Add(Btn3DFilter, 1, 0);
            PnlFiltros2.Controls.Add(Btn4DXFilter, 2, 0);
            PnlFiltros2.Controls.Add(BtnIMAXFilter, 3, 0);
            PnlFiltros2.Controls.Add(BtnDobFilter, 0, 1);
            PnlFiltros2.Controls.Add(BtnSubFilter, 1, 1);
            PnlFiltros2.Dock = DockStyle.Fill;
            PnlFiltros2.Location = new Point(183, 44);
            PnlFiltros2.Name = "PnlFiltros2";
            PnlFiltros2.RowCount = 2;
            PnlBuscador.SetRowSpan(PnlFiltros2, 2);
            PnlFiltros2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PnlFiltros2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PnlFiltros2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PnlFiltros2.Size = new Size(867, 102);
            PnlFiltros2.TabIndex = 7;
            // 
            // Btn2DFilter
            // 
            Btn2DFilter.BackColor = Color.FromArgb(197, 155, 39);
            Btn2DFilter.Cursor = Cursors.Hand;
            Btn2DFilter.Dock = DockStyle.Fill;
            Btn2DFilter.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 27, 40);
            Btn2DFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 239, 230);
            Btn2DFilter.FlatStyle = FlatStyle.Popup;
            Btn2DFilter.ForeColor = Color.FromArgb(250, 248, 245);
            Btn2DFilter.Location = new Point(3, 3);
            Btn2DFilter.Name = "Btn2DFilter";
            Btn2DFilter.Size = new Size(210, 45);
            Btn2DFilter.TabIndex = 0;
            Btn2DFilter.Text = "2D";
            Btn2DFilter.UseVisualStyleBackColor = false;
            Btn2DFilter.Click += Btn_2DFilter_Click;
            // 
            // Btn3DFilter
            // 
            Btn3DFilter.BackColor = Color.FromArgb(197, 155, 39);
            Btn3DFilter.Cursor = Cursors.Hand;
            Btn3DFilter.Dock = DockStyle.Fill;
            Btn3DFilter.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 27, 40);
            Btn3DFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 239, 230);
            Btn3DFilter.FlatStyle = FlatStyle.Popup;
            Btn3DFilter.ForeColor = Color.FromArgb(250, 248, 245);
            Btn3DFilter.Location = new Point(219, 3);
            Btn3DFilter.Name = "Btn3DFilter";
            Btn3DFilter.Size = new Size(210, 45);
            Btn3DFilter.TabIndex = 1;
            Btn3DFilter.Text = "3D";
            Btn3DFilter.UseVisualStyleBackColor = false;
            Btn3DFilter.Click += Btn_3DFilter_Click;
            // 
            // Btn4DXFilter
            // 
            Btn4DXFilter.BackColor = Color.FromArgb(197, 155, 39);
            Btn4DXFilter.Cursor = Cursors.Hand;
            Btn4DXFilter.Dock = DockStyle.Fill;
            Btn4DXFilter.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 27, 40);
            Btn4DXFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 239, 230);
            Btn4DXFilter.FlatStyle = FlatStyle.Popup;
            Btn4DXFilter.ForeColor = Color.FromArgb(250, 248, 245);
            Btn4DXFilter.Location = new Point(435, 3);
            Btn4DXFilter.Name = "Btn4DXFilter";
            Btn4DXFilter.Size = new Size(210, 45);
            Btn4DXFilter.TabIndex = 2;
            Btn4DXFilter.Text = "4DX";
            Btn4DXFilter.UseVisualStyleBackColor = false;
            Btn4DXFilter.Click += Btn_4DXFilter_Click;
            // 
            // BtnIMAXFilter
            // 
            BtnIMAXFilter.BackColor = Color.FromArgb(197, 155, 39);
            BtnIMAXFilter.Cursor = Cursors.Hand;
            BtnIMAXFilter.Dock = DockStyle.Fill;
            BtnIMAXFilter.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 27, 40);
            BtnIMAXFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 239, 230);
            BtnIMAXFilter.FlatStyle = FlatStyle.Popup;
            BtnIMAXFilter.ForeColor = Color.FromArgb(250, 248, 245);
            BtnIMAXFilter.Location = new Point(651, 3);
            BtnIMAXFilter.Name = "BtnIMAXFilter";
            BtnIMAXFilter.Size = new Size(213, 45);
            BtnIMAXFilter.TabIndex = 3;
            BtnIMAXFilter.Text = "IMAX";
            BtnIMAXFilter.UseVisualStyleBackColor = false;
            BtnIMAXFilter.Click += Btn_IMAXFilter_Click;
            // 
            // BtnDobFilter
            // 
            BtnDobFilter.BackColor = Color.FromArgb(197, 155, 39);
            BtnDobFilter.Dock = DockStyle.Fill;
            BtnDobFilter.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 27, 40);
            BtnDobFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 239, 230);
            BtnDobFilter.FlatStyle = FlatStyle.Popup;
            BtnDobFilter.ForeColor = Color.FromArgb(250, 248, 245);
            BtnDobFilter.Location = new Point(3, 54);
            BtnDobFilter.Name = "BtnDobFilter";
            BtnDobFilter.Size = new Size(210, 45);
            BtnDobFilter.TabIndex = 4;
            BtnDobFilter.Text = "Doblado";
            BtnDobFilter.UseVisualStyleBackColor = false;
            BtnDobFilter.Click += Btn_DobFilter_Click;
            // 
            // BtnSubFilter
            // 
            BtnSubFilter.BackColor = Color.FromArgb(197, 155, 39);
            BtnSubFilter.Dock = DockStyle.Fill;
            BtnSubFilter.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 27, 40);
            BtnSubFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 239, 230);
            BtnSubFilter.FlatStyle = FlatStyle.Popup;
            BtnSubFilter.ForeColor = Color.FromArgb(250, 248, 245);
            BtnSubFilter.Location = new Point(219, 54);
            BtnSubFilter.Name = "BtnSubFilter";
            BtnSubFilter.Size = new Size(210, 45);
            BtnSubFilter.TabIndex = 5;
            BtnSubFilter.Text = "Subtitulado";
            BtnSubFilter.UseVisualStyleBackColor = false;
            BtnSubFilter.Click += Btn_SubFilter_Click;
            // 
            // DgvCartelera
            // 
            DgvCartelera.AllowUserToAddRows = false;
            DgvCartelera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCartelera.BackgroundColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(74, 18, 26);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(250, 248, 245);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvCartelera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvCartelera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCartelera.Columns.AddRange(new DataGridViewColumn[] { Reservar });
            PnlBuscador.SetColumnSpan(DgvCartelera, 2);
            DgvCartelera.Cursor = Cursors.Hand;
            DgvCartelera.Dock = DockStyle.Fill;
            DgvCartelera.EnableHeadersVisualStyles = false;
            DgvCartelera.Location = new Point(3, 152);
            DgvCartelera.Name = "DgvCartelera";
            DgvCartelera.RowHeadersWidth = 51;
            DgvCartelera.Size = new Size(1047, 545);
            DgvCartelera.TabIndex = 9;
            DgvCartelera.CellContentClick += Dgv_Cartelera_CellContentClick;
            // 
            // Reservar
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(197, 155, 39);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(250, 248, 245);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(112, 27, 40);
            Reservar.DefaultCellStyle = dataGridViewCellStyle2;
            Reservar.FlatStyle = FlatStyle.Popup;
            Reservar.HeaderText = "Reservar";
            Reservar.MinimumWidth = 6;
            Reservar.Name = "Reservar";
            Reservar.ReadOnly = true;
            Reservar.Resizable = DataGridViewTriState.False;
            Reservar.Text = "Reservar";
            Reservar.UseColumnTextForButtonValue = true;
            // 
            // PicLogo
            // 
            PicLogo.Dock = DockStyle.Fill;
            PicLogo.Image = (Image)resources.GetObject("PicLogo.Image");
            PicLogo.Location = new Point(3, 3);
            PicLogo.Name = "PicLogo";
            PnlBuscador.SetRowSpan(PicLogo, 3);
            PicLogo.Size = new Size(174, 143);
            PicLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLogo.TabIndex = 10;
            PicLogo.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox2.FormattingEnabled = true;
            comboBox2.ItemHeight = 38;
            comboBox2.Location = new Point(598, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(589, 44);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Seleccionar Cine";
            // 
            // Cartelera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnlBuscador);
            MinimumSize = new Size(1000, 700);
            Name = "Cartelera";
            Size = new Size(1053, 700);
            Load += Cartelera_Load;
            PnlBuscador.ResumeLayout(false);
            PnlFiltros1.ResumeLayout(false);
            PnlFiltros2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvCartelera).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PnlBuscador;
        private TableLayoutPanel PnlFiltros1;
        private ComboBox comboBox2;
        private TableLayoutPanel PnlFiltros2;
        private Button Btn4DXFilter;
        private Button Btn3DFilter;
        private Button BtnIMAXFilter;
        private Button Btn2DFilter;
        private DataGridView DgvCartelera;
        private ComboBox CboCine;
        private Button BtnCargarCartelera;
        private Button BtnDobFilter;
        private Button BtnSubFilter;
        private ComboBox CboCiudad;
        private PictureBox PicLogo;
        private DataGridViewButtonColumn Reservar;
    }
}
