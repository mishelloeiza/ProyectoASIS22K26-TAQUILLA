namespace Plantilla_Admin
{
    partial class usuarios
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
            menuStrip1 = new MenuStrip();
            verUsuariosToolStripMenuItem = new ToolStripMenuItem();
            pruebaToolStripMenuItem = new ToolStripMenuItem();
            pruebaToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verUsuariosToolStripMenuItem, pruebaToolStripMenuItem, pruebaToolStripMenuItem1, eliminarUsuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(149, 360);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // verUsuariosToolStripMenuItem
            // 
            verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            verUsuariosToolStripMenuItem.Size = new Size(143, 24);
            verUsuariosToolStripMenuItem.Text = "Buscar Usuario";
            // 
            // pruebaToolStripMenuItem
            // 
            pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            pruebaToolStripMenuItem.Size = new Size(143, 24);
            pruebaToolStripMenuItem.Text = "Nuevo Usuario";
            pruebaToolStripMenuItem.Click += pruebaToolStripMenuItem_Click;
            // 
            // pruebaToolStripMenuItem1
            // 
            pruebaToolStripMenuItem1.Name = "pruebaToolStripMenuItem1";
            pruebaToolStripMenuItem1.Size = new Size(143, 24);
            pruebaToolStripMenuItem1.Text = "Actualizar Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            eliminarUsuarioToolStripMenuItem.Size = new Size(143, 24);
            eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            // 
            // usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(menuStrip1);
            Name = "usuarios";
            Size = new Size(621, 360);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pruebaToolStripMenuItem;
        private ToolStripMenuItem pruebaToolStripMenuItem1;
        private ToolStripMenuItem verUsuariosToolStripMenuItem;
        private ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
    }
}
