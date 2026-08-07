namespace Plantilla_Cliente
{
    partial class Reservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservas));
            TlpReservas = new TableLayoutPanel();
            PicPelicula = new PictureBox();
            TlpInfo = new TableLayoutPanel();
            PicTrailer = new PictureBox();
            TxDirectorHead = new Label();
            TxDuracionHead = new Label();
            TxRestriccionHead = new Label();
            TxDirector = new Label();
            TxDuracion = new Label();
            TxRestriccion = new Label();
            TlpEleccionFunciones = new TableLayoutPanel();
            FlpHorarios = new FlowLayoutPanel();
            button1 = new Button();
            FlpFunciones = new FlowLayoutPanel();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            TxHorarios = new Label();
            TxFunciones = new Label();
            CboCines = new ComboBox();
            TxSeleccionCine = new Label();
            BtnContinuar = new Button();
            Btn_Cartelera = new Button();
            TlpReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicPelicula).BeginInit();
            TlpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicTrailer).BeginInit();
            TlpEleccionFunciones.SuspendLayout();
            FlpHorarios.SuspendLayout();
            FlpFunciones.SuspendLayout();
            SuspendLayout();
            // 
            // TlpReservas
            // 
            TlpReservas.BackColor = Color.FromArgb(18, 18, 18);
            TlpReservas.ColumnCount = 3;
            TlpReservas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.638916F));
            TlpReservas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.09478423F));
            TlpReservas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.2663F));
            TlpReservas.Controls.Add(PicPelicula, 0, 0);
            TlpReservas.Controls.Add(TlpInfo, 2, 0);
            TlpReservas.Controls.Add(TlpEleccionFunciones, 2, 1);
            TlpReservas.Controls.Add(BtnContinuar, 2, 2);
            TlpReservas.Controls.Add(Btn_Cartelera, 0, 1);
            TlpReservas.Dock = DockStyle.Fill;
            TlpReservas.Location = new Point(0, 0);
            TlpReservas.Name = "TlpReservas";
            TlpReservas.RowCount = 3;
            TlpReservas.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            TlpReservas.RowStyles.Add(new RowStyle(SizeType.Percent, 41.8571434F));
            TlpReservas.RowStyles.Add(new RowStyle(SizeType.Percent, 8.285714F));
            TlpReservas.RowStyles.Add(new RowStyle(SizeType.Percent, 12.7142859F));
            TlpReservas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpReservas.Size = new Size(1394, 700);
            TlpReservas.TabIndex = 0;
            TlpReservas.Paint += TlP_Reservas_Paint;
            // 
            // PicPelicula
            // 
            PicPelicula.BackColor = Color.White;
            TlpReservas.SetColumnSpan(PicPelicula, 2);
            PicPelicula.Dock = DockStyle.Fill;
            PicPelicula.Image = (Image)resources.GetObject("PicPelicula.Image");
            PicPelicula.Location = new Point(3, 3);
            PicPelicula.Name = "PicPelicula";
            PicPelicula.Size = new Size(226, 291);
            PicPelicula.SizeMode = PictureBoxSizeMode.CenterImage;
            PicPelicula.TabIndex = 0;
            PicPelicula.TabStop = false;
            // 
            // TlpInfo
            // 
            TlpInfo.ColumnCount = 3;
            TlpInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9861593F));
            TlpInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.6228371F));
            TlpInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TlpInfo.Controls.Add(PicTrailer, 2, 0);
            TlpInfo.Controls.Add(TxDirectorHead, 0, 0);
            TlpInfo.Controls.Add(TxDuracionHead, 0, 1);
            TlpInfo.Controls.Add(TxRestriccionHead, 0, 2);
            TlpInfo.Controls.Add(TxDirector, 1, 0);
            TlpInfo.Controls.Add(TxDuracion, 1, 1);
            TlpInfo.Controls.Add(TxRestriccion, 1, 2);
            TlpInfo.Dock = DockStyle.Fill;
            TlpInfo.Location = new Point(235, 3);
            TlpInfo.Name = "TlpInfo";
            TlpInfo.RowCount = 3;
            TlpInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TlpInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TlpInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TlpInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpInfo.Size = new Size(1156, 291);
            TlpInfo.TabIndex = 4;
            // 
            // PicTrailer
            // 
            PicTrailer.Cursor = Cursors.Hand;
            PicTrailer.Dock = DockStyle.Fill;
            PicTrailer.Image = (Image)resources.GetObject("PicTrailer.Image");
            PicTrailer.Location = new Point(773, 3);
            PicTrailer.Name = "PicTrailer";
            TlpInfo.SetRowSpan(PicTrailer, 3);
            PicTrailer.Size = new Size(380, 285);
            PicTrailer.SizeMode = PictureBoxSizeMode.StretchImage;
            PicTrailer.TabIndex = 16;
            PicTrailer.TabStop = false;
            PicTrailer.Click += PicTrailer_Click_1;
            // 
            // TxDirectorHead
            // 
            TxDirectorHead.AutoSize = true;
            TxDirectorHead.BackColor = Color.FromArgb(74, 18, 26);
            TxDirectorHead.Dock = DockStyle.Fill;
            TxDirectorHead.Font = new Font("Segoe UI", 10F);
            TxDirectorHead.ForeColor = Color.FromArgb(250, 248, 245);
            TxDirectorHead.Location = new Point(3, 0);
            TxDirectorHead.Name = "TxDirectorHead";
            TxDirectorHead.Size = new Size(121, 97);
            TxDirectorHead.TabIndex = 0;
            TxDirectorHead.Text = "Director";
            TxDirectorHead.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxDuracionHead
            // 
            TxDuracionHead.AutoSize = true;
            TxDuracionHead.BackColor = Color.FromArgb(74, 18, 26);
            TxDuracionHead.Dock = DockStyle.Fill;
            TxDuracionHead.Font = new Font("Segoe UI", 10F);
            TxDuracionHead.ForeColor = Color.FromArgb(250, 248, 245);
            TxDuracionHead.Location = new Point(3, 97);
            TxDuracionHead.Name = "TxDuracionHead";
            TxDuracionHead.Size = new Size(121, 97);
            TxDuracionHead.TabIndex = 1;
            TxDuracionHead.Text = "Duración";
            TxDuracionHead.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxRestriccionHead
            // 
            TxRestriccionHead.AutoSize = true;
            TxRestriccionHead.BackColor = Color.FromArgb(74, 18, 26);
            TxRestriccionHead.Dock = DockStyle.Fill;
            TxRestriccionHead.Font = new Font("Segoe UI", 10F);
            TxRestriccionHead.ForeColor = Color.FromArgb(250, 248, 245);
            TxRestriccionHead.Location = new Point(3, 194);
            TxRestriccionHead.Name = "TxRestriccionHead";
            TxRestriccionHead.Size = new Size(121, 97);
            TxRestriccionHead.TabIndex = 2;
            TxRestriccionHead.Text = "Restricción";
            TxRestriccionHead.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxDirector
            // 
            TxDirector.AutoSize = true;
            TxDirector.BackColor = Color.FromArgb(18, 18, 18);
            TxDirector.Dock = DockStyle.Fill;
            TxDirector.FlatStyle = FlatStyle.Flat;
            TxDirector.Font = new Font("Segoe UI", 10F);
            TxDirector.ForeColor = Color.FromArgb(250, 248, 245);
            TxDirector.Location = new Point(130, 0);
            TxDirector.Name = "TxDirector";
            TxDirector.Size = new Size(637, 97);
            TxDirector.TabIndex = 3;
            TxDirector.Text = "XXX";
            TxDirector.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxDuracion
            // 
            TxDuracion.AutoSize = true;
            TxDuracion.BackColor = Color.FromArgb(18, 18, 18);
            TxDuracion.Dock = DockStyle.Fill;
            TxDuracion.FlatStyle = FlatStyle.Flat;
            TxDuracion.Font = new Font("Segoe UI", 10F);
            TxDuracion.ForeColor = Color.FromArgb(250, 248, 245);
            TxDuracion.Location = new Point(130, 97);
            TxDuracion.Name = "TxDuracion";
            TxDuracion.Size = new Size(637, 97);
            TxDuracion.TabIndex = 4;
            TxDuracion.Text = "XXX";
            TxDuracion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxRestriccion
            // 
            TxRestriccion.AutoSize = true;
            TxRestriccion.BackColor = Color.FromArgb(18, 18, 18);
            TxRestriccion.Dock = DockStyle.Fill;
            TxRestriccion.FlatStyle = FlatStyle.Flat;
            TxRestriccion.Font = new Font("Segoe UI", 10F);
            TxRestriccion.ForeColor = Color.FromArgb(250, 248, 245);
            TxRestriccion.Location = new Point(130, 194);
            TxRestriccion.Name = "TxRestriccion";
            TxRestriccion.Size = new Size(637, 97);
            TxRestriccion.TabIndex = 5;
            TxRestriccion.Text = "XXX";
            TxRestriccion.TextAlign = ContentAlignment.MiddleLeft;
            TxRestriccion.Click += TxRestriccion_Click;
            // 
            // TlpEleccionFunciones
            // 
            TlpEleccionFunciones.BackColor = Color.FromArgb(18, 18, 18);
            TlpEleccionFunciones.ColumnCount = 2;
            TlpEleccionFunciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9482794F));
            TlpEleccionFunciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.05172F));
            TlpEleccionFunciones.Controls.Add(FlpHorarios, 1, 2);
            TlpEleccionFunciones.Controls.Add(FlpFunciones, 1, 1);
            TlpEleccionFunciones.Controls.Add(TxHorarios, 0, 2);
            TlpEleccionFunciones.Controls.Add(TxFunciones, 0, 1);
            TlpEleccionFunciones.Controls.Add(CboCines, 1, 0);
            TlpEleccionFunciones.Controls.Add(TxSeleccionCine, 0, 0);
            TlpEleccionFunciones.Dock = DockStyle.Fill;
            TlpEleccionFunciones.Location = new Point(235, 300);
            TlpEleccionFunciones.Name = "TlpEleccionFunciones";
            TlpEleccionFunciones.RowCount = 3;
            TlpEleccionFunciones.RowStyles.Add(new RowStyle(SizeType.Percent, 23.8970585F));
            TlpEleccionFunciones.RowStyles.Add(new RowStyle(SizeType.Percent, 38.55422F));
            TlpEleccionFunciones.RowStyles.Add(new RowStyle(SizeType.Percent, 37.95181F));
            TlpEleccionFunciones.Size = new Size(1156, 330);
            TlpEleccionFunciones.TabIndex = 13;
            // 
            // FlpHorarios
            // 
            FlpHorarios.BackColor = Color.FromArgb(18, 18, 18);
            FlpHorarios.Controls.Add(button1);
            FlpHorarios.Dock = DockStyle.Fill;
            FlpHorarios.ForeColor = Color.FromArgb(250, 248, 245);
            FlpHorarios.Location = new Point(129, 207);
            FlpHorarios.Name = "FlpHorarios";
            FlpHorarios.Size = new Size(1024, 120);
            FlpHorarios.TabIndex = 17;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(80, 61);
            button1.TabIndex = 0;
            button1.Text = "Fecha 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FlpFunciones
            // 
            FlpFunciones.BackColor = Color.FromArgb(18, 18, 18);
            FlpFunciones.Controls.Add(button11);
            FlpFunciones.Controls.Add(button12);
            FlpFunciones.Controls.Add(button13);
            FlpFunciones.Controls.Add(button14);
            FlpFunciones.Controls.Add(button15);
            FlpFunciones.Controls.Add(button16);
            FlpFunciones.Controls.Add(button17);
            FlpFunciones.Dock = DockStyle.Fill;
            FlpFunciones.ForeColor = Color.FromArgb(250, 248, 245);
            FlpFunciones.Location = new Point(129, 81);
            FlpFunciones.Name = "FlpFunciones";
            FlpFunciones.Size = new Size(1024, 120);
            FlpFunciones.TabIndex = 16;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(3, 3);
            button11.Name = "button11";
            button11.Size = new Size(80, 60);
            button11.TabIndex = 0;
            button11.Text = "Fecha 1";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(89, 3);
            button12.Name = "button12";
            button12.Size = new Size(80, 60);
            button12.TabIndex = 1;
            button12.Text = "Fecha 2";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(175, 3);
            button13.Name = "button13";
            button13.Size = new Size(80, 60);
            button13.TabIndex = 2;
            button13.Text = "Fecha 3";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(261, 3);
            button14.Name = "button14";
            button14.Size = new Size(80, 60);
            button14.TabIndex = 3;
            button14.Text = "Fecha 4";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.FlatStyle = FlatStyle.Flat;
            button15.Location = new Point(347, 3);
            button15.Name = "button15";
            button15.Size = new Size(80, 60);
            button15.TabIndex = 4;
            button15.Text = "Fecha 5";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.FlatStyle = FlatStyle.Flat;
            button16.Location = new Point(433, 3);
            button16.Name = "button16";
            button16.Size = new Size(80, 60);
            button16.TabIndex = 5;
            button16.Text = "Fecha 6";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.FlatStyle = FlatStyle.Flat;
            button17.Location = new Point(519, 3);
            button17.Name = "button17";
            button17.Size = new Size(80, 60);
            button17.TabIndex = 6;
            button17.Text = "Fecha 7";
            button17.UseVisualStyleBackColor = true;
            // 
            // TxHorarios
            // 
            TxHorarios.AutoSize = true;
            TxHorarios.BackColor = Color.FromArgb(74, 18, 26);
            TxHorarios.Dock = DockStyle.Fill;
            TxHorarios.Font = new Font("Segoe UI", 10F);
            TxHorarios.ForeColor = Color.FromArgb(250, 248, 245);
            TxHorarios.Location = new Point(3, 204);
            TxHorarios.Name = "TxHorarios";
            TxHorarios.Size = new Size(120, 126);
            TxHorarios.TabIndex = 15;
            TxHorarios.Text = "Horarios disponibles";
            TxHorarios.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxFunciones
            // 
            TxFunciones.AutoSize = true;
            TxFunciones.BackColor = Color.FromArgb(74, 18, 26);
            TxFunciones.Dock = DockStyle.Fill;
            TxFunciones.Font = new Font("Segoe UI", 10F);
            TxFunciones.ForeColor = Color.FromArgb(250, 248, 245);
            TxFunciones.Location = new Point(3, 78);
            TxFunciones.Name = "TxFunciones";
            TxFunciones.Size = new Size(120, 126);
            TxFunciones.TabIndex = 13;
            TxFunciones.Text = "Funciones disponibles";
            TxFunciones.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CboCines
            // 
            CboCines.Dock = DockStyle.Fill;
            CboCines.DrawMode = DrawMode.OwnerDrawFixed;
            CboCines.FormattingEnabled = true;
            CboCines.ItemHeight = 50;
            CboCines.Location = new Point(129, 3);
            CboCines.Name = "CboCines";
            CboCines.Size = new Size(1024, 56);
            CboCines.TabIndex = 14;
            CboCines.Text = "Seleccione un cine...";
            CboCines.SelectedIndexChanged += Cbo_Cines_SelectedIndexChanged;
            // 
            // TxSeleccionCine
            // 
            TxSeleccionCine.AutoSize = true;
            TxSeleccionCine.BackColor = Color.FromArgb(74, 18, 26);
            TxSeleccionCine.Dock = DockStyle.Fill;
            TxSeleccionCine.Font = new Font("Segoe UI", 10F);
            TxSeleccionCine.ForeColor = Color.FromArgb(250, 248, 245);
            TxSeleccionCine.Location = new Point(3, 0);
            TxSeleccionCine.Name = "TxSeleccionCine";
            TxSeleccionCine.Size = new Size(120, 78);
            TxSeleccionCine.TabIndex = 18;
            TxSeleccionCine.Text = "Selección de cine";
            TxSeleccionCine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnContinuar
            // 
            BtnContinuar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnContinuar.BackColor = Color.FromArgb(197, 155, 39);
            BtnContinuar.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 27, 40);
            BtnContinuar.FlatStyle = FlatStyle.Popup;
            BtnContinuar.ForeColor = Color.FromArgb(250, 248, 245);
            BtnContinuar.Location = new Point(235, 636);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(1156, 52);
            BtnContinuar.TabIndex = 14;
            BtnContinuar.Text = "Continuar";
            BtnContinuar.UseVisualStyleBackColor = false;
            BtnContinuar.Click += Btn_Continuar_Click;
            // 
            // Btn_Cartelera
            // 
            Btn_Cartelera.BackColor = Color.FromArgb(197, 155, 39);
            Btn_Cartelera.Dock = DockStyle.Fill;
            Btn_Cartelera.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 27, 40);
            Btn_Cartelera.FlatStyle = FlatStyle.Popup;
            Btn_Cartelera.ForeColor = Color.FromArgb(250, 248, 245);
            Btn_Cartelera.Location = new Point(3, 300);
            Btn_Cartelera.Name = "Btn_Cartelera";
            Btn_Cartelera.Size = new Size(225, 330);
            Btn_Cartelera.TabIndex = 15;
            Btn_Cartelera.Text = "Volver a Cartelera";
            Btn_Cartelera.UseVisualStyleBackColor = false;
            Btn_Cartelera.Click += Btn_Cartelera_Click;
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TlpReservas);
            MinimumSize = new Size(1000, 700);
            Name = "Reservas";
            Size = new Size(1394, 700);
            TlpReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicPelicula).EndInit();
            TlpInfo.ResumeLayout(false);
            TlpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicTrailer).EndInit();
            TlpEleccionFunciones.ResumeLayout(false);
            TlpEleccionFunciones.PerformLayout();
            FlpHorarios.ResumeLayout(false);
            FlpFunciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpReservas;
        private TableLayoutPanel TlpInfo;
        private Label TxDuracionHead;
        private Label TxRestriccionHead;
        private Label TxRestriccion;
        private PictureBox PicPelicula;
        private TableLayoutPanel TlpEleccionFunciones;
        private Button button1;
        private FlowLayoutPanel FlpFunciones;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Label TxFunciones;
        private ComboBox CboCines;
        private Button BtnContinuar;
        private Label TxDirectorHead;
        private Label TxDirector;
        private Label TxDuracion;
        private FlowLayoutPanel FlpHorarios;
        private Label TxHorarios;
        private Button Btn_DobFilter;
        private Button Btn_SubFilter;
        private Label TxSeleccionCine;
        private PictureBox PicTrailer;
        private Button Btn_Cartelera;
    }
}
