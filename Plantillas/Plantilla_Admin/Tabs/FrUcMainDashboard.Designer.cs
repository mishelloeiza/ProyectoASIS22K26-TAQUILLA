namespace Plantilla_Admin.Tabs
{
    partial class FrUcMainDashboard
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
            TlpArquitectura = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            LbMensajeDeUsuario = new Componentes.CustomTitleLabel();
            LbHora = new Componentes.CustomTitleLabel();
            LbBienvenida = new Componentes.CustomTitleLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            RcbDetalles = new Componentes.CustomRichTextBox();
            RcbDatosImportantes = new Componentes.CustomRichTextBox();
            TlpCartelera = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            TlpArquitectura.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            TlpCartelera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TlpArquitectura
            // 
            TlpArquitectura.ColumnCount = 1;
            TlpArquitectura.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpArquitectura.Controls.Add(tableLayoutPanel2, 0, 0);
            TlpArquitectura.Controls.Add(tableLayoutPanel1, 0, 1);
            TlpArquitectura.Controls.Add(TlpCartelera, 0, 2);
            TlpArquitectura.Dock = DockStyle.Fill;
            TlpArquitectura.Location = new Point(0, 0);
            TlpArquitectura.Name = "TlpArquitectura";
            TlpArquitectura.RowCount = 3;
            TlpArquitectura.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            TlpArquitectura.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            TlpArquitectura.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpArquitectura.Size = new Size(1050, 700);
            TlpArquitectura.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(LbMensajeDeUsuario, 2, 0);
            tableLayoutPanel2.Controls.Add(LbHora, 1, 0);
            tableLayoutPanel2.Controls.Add(LbBienvenida, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1050, 70);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LbMensajeDeUsuario
            // 
            LbMensajeDeUsuario.AutoSize = true;
            LbMensajeDeUsuario.Dock = DockStyle.Fill;
            LbMensajeDeUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LbMensajeDeUsuario.ForeColor = Color.Crimson;
            LbMensajeDeUsuario.Location = new Point(753, 0);
            LbMensajeDeUsuario.Name = "LbMensajeDeUsuario";
            LbMensajeDeUsuario.Size = new Size(194, 70);
            LbMensajeDeUsuario.TabIndex = 2;
            LbMensajeDeUsuario.Text = "05/08/2026";
            LbMensajeDeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbHora
            // 
            LbHora.AutoSize = true;
            LbHora.Dock = DockStyle.Fill;
            LbHora.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LbHora.ForeColor = Color.Crimson;
            LbHora.Location = new Point(603, 0);
            LbHora.Name = "LbHora";
            LbHora.Size = new Size(144, 70);
            LbHora.TabIndex = 1;
            LbHora.Text = "11:00";
            LbHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbBienvenida
            // 
            LbBienvenida.AutoSize = true;
            LbBienvenida.Dock = DockStyle.Left;
            LbBienvenida.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LbBienvenida.ForeColor = Color.Crimson;
            LbBienvenida.Location = new Point(3, 0);
            LbBienvenida.Name = "LbBienvenida";
            LbBienvenida.Size = new Size(201, 70);
            LbBienvenida.TabIndex = 0;
            LbBienvenida.Text = "Buenos días, ";
            LbBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 550F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(RcbDetalles, 1, 0);
            tableLayoutPanel1.Controls.Add(RcbDatosImportantes, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1044, 244);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // RcbDetalles
            // 
            RcbDetalles.BackColor = Color.Black;
            RcbDetalles.BorderStyle = BorderStyle.None;
            RcbDetalles.Dock = DockStyle.Fill;
            RcbDetalles.Font = new Font("Segoe UI", 10F);
            RcbDetalles.ForeColor = Color.FromArgb(230, 230, 230);
            RcbDetalles.Location = new Point(405, 10);
            RcbDetalles.Margin = new Padding(5, 10, 5, 10);
            RcbDetalles.MinimumSize = new Size(190, 60);
            RcbDetalles.Name = "RcbDetalles";
            RcbDetalles.ReadOnly = true;
            RcbDetalles.ScrollBars = RichTextBoxScrollBars.None;
            RcbDetalles.Size = new Size(540, 224);
            RcbDetalles.TabIndex = 2;
            RcbDetalles.Text = "";
            // 
            // RcbDatosImportantes
            // 
            RcbDatosImportantes.BackColor = Color.Black;
            RcbDatosImportantes.BorderStyle = BorderStyle.None;
            RcbDatosImportantes.Dock = DockStyle.Fill;
            RcbDatosImportantes.Font = new Font("Segoe UI", 10F);
            RcbDatosImportantes.ForeColor = Color.FromArgb(230, 230, 230);
            RcbDatosImportantes.Location = new Point(5, 10);
            RcbDatosImportantes.Margin = new Padding(5, 10, 5, 10);
            RcbDatosImportantes.MinimumSize = new Size(190, 60);
            RcbDatosImportantes.Name = "RcbDatosImportantes";
            RcbDatosImportantes.ReadOnly = true;
            RcbDatosImportantes.ScrollBars = RichTextBoxScrollBars.None;
            RcbDatosImportantes.Size = new Size(390, 224);
            RcbDatosImportantes.TabIndex = 1;
            RcbDatosImportantes.Text = "";
            // 
            // TlpCartelera
            // 
            TlpCartelera.ColumnCount = 4;
            TlpCartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TlpCartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TlpCartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TlpCartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TlpCartelera.Controls.Add(pictureBox4, 3, 0);
            TlpCartelera.Controls.Add(pictureBox3, 2, 0);
            TlpCartelera.Controls.Add(pictureBox2, 1, 0);
            TlpCartelera.Controls.Add(pictureBox1, 0, 0);
            TlpCartelera.Dock = DockStyle.Fill;
            TlpCartelera.Location = new Point(0, 320);
            TlpCartelera.Margin = new Padding(0);
            TlpCartelera.Name = "TlpCartelera";
            TlpCartelera.RowCount = 1;
            TlpCartelera.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpCartelera.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpCartelera.Size = new Size(1050, 380);
            TlpCartelera.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(789, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(258, 374);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(527, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(256, 374);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(265, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 374);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 374);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrUcMainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(TlpArquitectura);
            Name = "FrUcMainDashboard";
            Size = new Size(1050, 700);
            TlpArquitectura.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            TlpCartelera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpArquitectura;
        private TableLayoutPanel tableLayoutPanel2;
        private Componentes.CustomTitleLabel LbBienvenida;
        private Componentes.CustomTitleLabel LbHora;
        private TableLayoutPanel tableLayoutPanel1;
        private Componentes.CustomRichTextBox RcbDatosImportantes;
        private TableLayoutPanel TlpCartelera;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Componentes.CustomTitleLabel LbMensajeDeUsuario;
        private Componentes.CustomRichTextBox RcbDetalles;
    }
}
