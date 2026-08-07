namespace Plantilla_Admin.FormulariosPrincipales
{
    partial class FrMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrMenu));
            TlpEstructura = new TableLayoutPanel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            PnlTop = new Panel();
            TlpDescripcionUsuario = new TableLayoutPanel();
            LbUsuarioDescripcion = new Componentes.CustomLabel();
            PnlMain = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnLogo = new Button();
            BtnSalir = new Button();
            BtnFunciones = new Button();
            BtnAyuda = new Button();
            BtnVentas = new Button();
            BtnReportes = new Button();
            BtnUsuarios = new Button();
            TlpEstructura.SuspendLayout();
            PnlTop.SuspendLayout();
            TlpDescripcionUsuario.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // TlpEstructura
            // 
            TlpEstructura.ColumnCount = 3;
            TlpEstructura.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            TlpEstructura.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpEstructura.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            TlpEstructura.Controls.Add(nightControlBox1, 2, 0);
            TlpEstructura.Controls.Add(PnlTop, 1, 0);
            TlpEstructura.Controls.Add(PnlMain, 1, 1);
            TlpEstructura.Controls.Add(tableLayoutPanel2, 0, 0);
            TlpEstructura.Dock = DockStyle.Fill;
            TlpEstructura.Location = new Point(0, 0);
            TlpEstructura.Margin = new Padding(0);
            TlpEstructura.Name = "TlpEstructura";
            TlpEstructura.RowCount = 1;
            TlpEstructura.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TlpEstructura.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpEstructura.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpEstructura.Size = new Size(1200, 700);
            TlpEstructura.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.Cursor = Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.Dock = DockStyle.Fill;
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1053, 3);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 5;
            // 
            // PnlTop
            // 
            PnlTop.Controls.Add(TlpDescripcionUsuario);
            PnlTop.Dock = DockStyle.Fill;
            PnlTop.Location = new Point(200, 0);
            PnlTop.Margin = new Padding(0);
            PnlTop.Name = "PnlTop";
            PnlTop.Size = new Size(850, 35);
            PnlTop.TabIndex = 4;
            PnlTop.MouseMove += PnlTop_MouseMove;
            // 
            // TlpDescripcionUsuario
            // 
            TlpDescripcionUsuario.ColumnCount = 1;
            TlpDescripcionUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TlpDescripcionUsuario.Controls.Add(LbUsuarioDescripcion, 0, 0);
            TlpDescripcionUsuario.Dock = DockStyle.Left;
            TlpDescripcionUsuario.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            TlpDescripcionUsuario.Location = new Point(0, 0);
            TlpDescripcionUsuario.Name = "TlpDescripcionUsuario";
            TlpDescripcionUsuario.RowCount = 1;
            TlpDescripcionUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDescripcionUsuario.Size = new Size(574, 35);
            TlpDescripcionUsuario.TabIndex = 2;
            TlpDescripcionUsuario.MouseMove += TlpDescripcionUsuario_MouseMove;
            // 
            // LbUsuarioDescripcion
            // 
            LbUsuarioDescripcion.AutoSize = true;
            LbUsuarioDescripcion.Dock = DockStyle.Left;
            LbUsuarioDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbUsuarioDescripcion.ForeColor = Color.FromArgb(220, 220, 220);
            LbUsuarioDescripcion.Location = new Point(3, 0);
            LbUsuarioDescripcion.Name = "LbUsuarioDescripcion";
            LbUsuarioDescripcion.Padding = new Padding(0, 0, 2, 0);
            LbUsuarioDescripcion.Size = new Size(77, 35);
            LbUsuarioDescripcion.TabIndex = 2;
            LbUsuarioDescripcion.Text = "Usuario:";
            LbUsuarioDescripcion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PnlMain
            // 
            PnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TlpEstructura.SetColumnSpan(PnlMain, 2);
            PnlMain.Location = new Point(200, 35);
            PnlMain.Margin = new Padding(0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(1000, 665);
            PnlMain.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(BtnLogo, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnSalir, 0, 6);
            tableLayoutPanel2.Controls.Add(BtnFunciones, 0, 1);
            tableLayoutPanel2.Controls.Add(BtnAyuda, 0, 5);
            tableLayoutPanel2.Controls.Add(BtnVentas, 0, 2);
            tableLayoutPanel2.Controls.Add(BtnReportes, 0, 4);
            tableLayoutPanel2.Controls.Add(BtnUsuarios, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            TlpEstructura.SetRowSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(200, 700);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // BtnLogo
            // 
            BtnLogo.BackColor = Color.FromArgb(244, 233, 216);
            BtnLogo.BackgroundImage = (Image)resources.GetObject("BtnLogo.BackgroundImage");
            BtnLogo.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLogo.Cursor = Cursors.Hand;
            BtnLogo.FlatStyle = FlatStyle.Popup;
            BtnLogo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogo.Location = new Point(0, 0);
            BtnLogo.Margin = new Padding(0);
            BtnLogo.Name = "BtnLogo";
            BtnLogo.Size = new Size(200, 200);
            BtnLogo.TabIndex = 2;
            BtnLogo.UseVisualStyleBackColor = false;
            BtnLogo.Click += BtnLogo_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(74, 21, 26);
            BtnSalir.Cursor = Cursors.Hand;
            BtnSalir.Dock = DockStyle.Fill;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.FromArgb(220, 210, 210);
            BtnSalir.Location = new Point(0, 618);
            BtnSalir.Margin = new Padding(0, 3, 0, 0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(200, 82);
            BtnSalir.TabIndex = 8;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnFunciones
            // 
            BtnFunciones.BackColor = Color.FromArgb(74, 21, 26);
            BtnFunciones.Cursor = Cursors.Hand;
            BtnFunciones.Dock = DockStyle.Fill;
            BtnFunciones.FlatAppearance.BorderSize = 0;
            BtnFunciones.FlatStyle = FlatStyle.Flat;
            BtnFunciones.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFunciones.ForeColor = Color.FromArgb(220, 210, 210);
            BtnFunciones.Location = new Point(0, 202);
            BtnFunciones.Margin = new Padding(0, 2, 0, 0);
            BtnFunciones.Name = "BtnFunciones";
            BtnFunciones.Size = new Size(200, 81);
            BtnFunciones.TabIndex = 3;
            BtnFunciones.Text = "Funciones";
            BtnFunciones.UseVisualStyleBackColor = false;
            BtnFunciones.Click += BtnFunciones_Click;
            // 
            // BtnAyuda
            // 
            BtnAyuda.BackColor = Color.FromArgb(74, 21, 26);
            BtnAyuda.Cursor = Cursors.Hand;
            BtnAyuda.Dock = DockStyle.Fill;
            BtnAyuda.FlatAppearance.BorderSize = 0;
            BtnAyuda.FlatStyle = FlatStyle.Flat;
            BtnAyuda.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAyuda.ForeColor = Color.FromArgb(220, 210, 210);
            BtnAyuda.Location = new Point(0, 535);
            BtnAyuda.Margin = new Padding(0, 3, 0, 0);
            BtnAyuda.Name = "BtnAyuda";
            BtnAyuda.Size = new Size(200, 80);
            BtnAyuda.TabIndex = 7;
            BtnAyuda.Text = "Ayuda";
            BtnAyuda.UseVisualStyleBackColor = false;
            BtnAyuda.Click += BtnAyuda_Click;
            // 
            // BtnVentas
            // 
            BtnVentas.BackColor = Color.FromArgb(74, 21, 26);
            BtnVentas.Cursor = Cursors.Hand;
            BtnVentas.Dock = DockStyle.Fill;
            BtnVentas.FlatAppearance.BorderSize = 0;
            BtnVentas.FlatStyle = FlatStyle.Flat;
            BtnVentas.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVentas.ForeColor = Color.FromArgb(220, 210, 210);
            BtnVentas.Location = new Point(0, 286);
            BtnVentas.Margin = new Padding(0, 3, 0, 0);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(200, 80);
            BtnVentas.TabIndex = 4;
            BtnVentas.Text = "Ventas";
            BtnVentas.UseVisualStyleBackColor = false;
            BtnVentas.Click += BtnVentas_Click;
            // 
            // BtnReportes
            // 
            BtnReportes.BackColor = Color.FromArgb(74, 21, 26);
            BtnReportes.Cursor = Cursors.Hand;
            BtnReportes.Dock = DockStyle.Fill;
            BtnReportes.FlatAppearance.BorderSize = 0;
            BtnReportes.FlatStyle = FlatStyle.Flat;
            BtnReportes.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnReportes.ForeColor = Color.FromArgb(220, 210, 210);
            BtnReportes.Location = new Point(0, 452);
            BtnReportes.Margin = new Padding(0, 3, 0, 0);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(200, 80);
            BtnReportes.TabIndex = 6;
            BtnReportes.Text = "Reportes";
            BtnReportes.UseVisualStyleBackColor = false;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = Color.FromArgb(74, 21, 26);
            BtnUsuarios.Cursor = Cursors.Hand;
            BtnUsuarios.Dock = DockStyle.Fill;
            BtnUsuarios.FlatAppearance.BorderSize = 0;
            BtnUsuarios.FlatStyle = FlatStyle.Flat;
            BtnUsuarios.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUsuarios.ForeColor = Color.FromArgb(220, 210, 210);
            BtnUsuarios.Location = new Point(0, 369);
            BtnUsuarios.Margin = new Padding(0, 3, 0, 0);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(200, 80);
            BtnUsuarios.TabIndex = 5;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.UseVisualStyleBackColor = false;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // FrMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1200, 700);
            Controls.Add(TlpEstructura);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 700);
            Name = "FrMenu";
            Text = "FrMenu";
            TlpEstructura.ResumeLayout(false);
            PnlTop.ResumeLayout(false);
            TlpDescripcionUsuario.ResumeLayout(false);
            TlpDescripcionUsuario.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpEstructura;
        private Button BtnLogo;
        private Panel PnlTop;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Button BtnFunciones;
        private Button BtnVentas;
        private Button BtnUsuarios;
        private Button BtnReportes;
        private Button BtnAyuda;
        private Button BtnSalir;
        private Panel PnlMain;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel TlpDescripcionUsuario;
        private Componentes.CustomLabel LbUsuarioDescripcion;
    }
}