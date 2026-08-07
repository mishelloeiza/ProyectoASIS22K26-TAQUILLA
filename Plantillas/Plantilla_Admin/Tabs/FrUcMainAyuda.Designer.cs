namespace Plantilla_Admin.Tabs
{
    partial class FrUcMainAyuda
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
            TreeNode treeNode1 = new TreeNode("Nodo0adsad");
            TreeNode treeNode2 = new TreeNode("Nodo1asdads");
            TvRamasDeAyuda = new TreeView();
            RtbTextoAyuda = new Componentes.CustomRichTextBox();
            TlpAyuda = new TableLayoutPanel();
            TlpBotones = new TableLayoutPanel();
            BtnManualTecnico = new ReaLTaiizor.Controls.Button();
            BtnManualDeUsuario = new ReaLTaiizor.Controls.Button();
            TlpAyuda.SuspendLayout();
            TlpBotones.SuspendLayout();
            SuspendLayout();
            // 
            // TvRamasDeAyuda
            // 
            TvRamasDeAyuda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TvRamasDeAyuda.BackColor = Color.Black;
            TvRamasDeAyuda.ForeColor = Color.White;
            TvRamasDeAyuda.Location = new Point(0, 75);
            TvRamasDeAyuda.Margin = new Padding(0);
            TvRamasDeAyuda.Name = "TvRamasDeAyuda";
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "Nodo0adsad";
            treeNode2.Name = "Nodo1";
            treeNode2.Text = "Nodo1asdads";
            TvRamasDeAyuda.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2 });
            TvRamasDeAyuda.Scrollable = false;
            TvRamasDeAyuda.Size = new Size(525, 625);
            TvRamasDeAyuda.TabIndex = 0;
            // 
            // RtbTextoAyuda
            // 
            RtbTextoAyuda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RtbTextoAyuda.BackColor = Color.FromArgb(55, 60, 72);
            RtbTextoAyuda.BorderStyle = BorderStyle.None;
            RtbTextoAyuda.Font = new Font("Segoe UI", 10F);
            RtbTextoAyuda.ForeColor = Color.FromArgb(230, 230, 230);
            RtbTextoAyuda.Location = new Point(525, 75);
            RtbTextoAyuda.Margin = new Padding(0);
            RtbTextoAyuda.MinimumSize = new Size(190, 60);
            RtbTextoAyuda.Name = "RtbTextoAyuda";
            RtbTextoAyuda.Size = new Size(525, 625);
            RtbTextoAyuda.TabIndex = 1;
            RtbTextoAyuda.Text = "";
            // 
            // TlpAyuda
            // 
            TlpAyuda.ColumnCount = 2;
            TlpAyuda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAyuda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAyuda.Controls.Add(RtbTextoAyuda, 1, 1);
            TlpAyuda.Controls.Add(TvRamasDeAyuda, 0, 1);
            TlpAyuda.Controls.Add(TlpBotones, 0, 0);
            TlpAyuda.Dock = DockStyle.Fill;
            TlpAyuda.Location = new Point(0, 0);
            TlpAyuda.Name = "TlpAyuda";
            TlpAyuda.RowCount = 2;
            TlpAyuda.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAyuda.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAyuda.Size = new Size(1050, 700);
            TlpAyuda.TabIndex = 2;
            // 
            // TlpBotones
            // 
            TlpBotones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TlpBotones.ColumnCount = 2;
            TlpAyuda.SetColumnSpan(TlpBotones, 2);
            TlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpBotones.Controls.Add(BtnManualTecnico, 1, 0);
            TlpBotones.Controls.Add(BtnManualDeUsuario, 0, 0);
            TlpBotones.Location = new Point(3, 3);
            TlpBotones.Name = "TlpBotones";
            TlpBotones.RowCount = 1;
            TlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpBotones.Size = new Size(500, 69);
            TlpBotones.TabIndex = 6;
            // 
            // BtnManualTecnico
            // 
            BtnManualTecnico.Anchor = AnchorStyles.None;
            BtnManualTecnico.BackColor = Color.Transparent;
            BtnManualTecnico.BorderColor = Color.FromArgb(21, 67, 116);
            BtnManualTecnico.Cursor = Cursors.Hand;
            BtnManualTecnico.EnteredBorderColor = Color.FromArgb(66, 165, 245);
            BtnManualTecnico.EnteredColor = Color.FromArgb(41, 128, 185);
            BtnManualTecnico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnManualTecnico.Image = null;
            BtnManualTecnico.ImageAlign = ContentAlignment.MiddleLeft;
            BtnManualTecnico.InactiveColor = Color.FromArgb(31, 97, 141);
            BtnManualTecnico.Location = new Point(253, 9);
            BtnManualTecnico.Name = "BtnManualTecnico";
            BtnManualTecnico.PressedBorderColor = Color.FromArgb(15, 50, 90);
            BtnManualTecnico.PressedColor = Color.FromArgb(21, 67, 116);
            BtnManualTecnico.Size = new Size(244, 50);
            BtnManualTecnico.TabIndex = 6;
            BtnManualTecnico.Text = "Descargar Manual Técnico";
            BtnManualTecnico.TextAlignment = StringAlignment.Center;
            // 
            // BtnManualDeUsuario
            // 
            BtnManualDeUsuario.Anchor = AnchorStyles.None;
            BtnManualDeUsuario.BackColor = Color.Transparent;
            BtnManualDeUsuario.BorderColor = Color.FromArgb(139, 0, 0);
            BtnManualDeUsuario.Cursor = Cursors.Hand;
            BtnManualDeUsuario.EnteredBorderColor = Color.FromArgb(255, 99, 71);
            BtnManualDeUsuario.EnteredColor = Color.FromArgb(205, 51, 51);
            BtnManualDeUsuario.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            BtnManualDeUsuario.Image = null;
            BtnManualDeUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnManualDeUsuario.InactiveColor = Color.FromArgb(178, 34, 34);
            BtnManualDeUsuario.Location = new Point(3, 9);
            BtnManualDeUsuario.Name = "BtnManualDeUsuario";
            BtnManualDeUsuario.PressedBorderColor = Color.FromArgb(100, 0, 0);
            BtnManualDeUsuario.PressedColor = Color.FromArgb(139, 0, 0);
            BtnManualDeUsuario.Size = new Size(244, 50);
            BtnManualDeUsuario.TabIndex = 5;
            BtnManualDeUsuario.Text = "Descargar Manual de Usuario";
            BtnManualDeUsuario.TextAlignment = StringAlignment.Center;
            BtnManualDeUsuario.Click += button1_Click;
            // 
            // FrUcMainAyuda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(TlpAyuda);
            Margin = new Padding(0);
            Name = "FrUcMainAyuda";
            Size = new Size(1050, 700);
            TlpAyuda.ResumeLayout(false);
            TlpBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView TvRamasDeAyuda;
        private Componentes.CustomRichTextBox RtbTextoAyuda;
        private TableLayoutPanel TlpAyuda;
        private TableLayoutPanel TlpBotones;
        private ReaLTaiizor.Controls.Button BtnManualDeUsuario;
        private ReaLTaiizor.Controls.Button BtnManualTecnico;
    }
}
