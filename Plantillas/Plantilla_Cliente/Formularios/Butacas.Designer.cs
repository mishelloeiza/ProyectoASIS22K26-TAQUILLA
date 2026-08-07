namespace Plantilla_Cliente
{
    partial class Butacas
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
            Tlp_Butacas = new TableLayoutPanel();
            Btn_Confirmacion = new Button();
            Tlp_butacaselector = new TableLayoutPanel();
            Tlp_Butacas.SuspendLayout();
            SuspendLayout();
            // 
            // Tlp_Butacas
            // 
            Tlp_Butacas.ColumnCount = 1;
            Tlp_Butacas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_Butacas.Controls.Add(Btn_Confirmacion, 0, 1);
            Tlp_Butacas.Controls.Add(Tlp_butacaselector, 0, 0);
            Tlp_Butacas.Dock = DockStyle.Fill;
            Tlp_Butacas.Location = new Point(0, 0);
            Tlp_Butacas.Name = "Tlp_Butacas";
            Tlp_Butacas.RowCount = 2;
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Percent, 81.8314F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Percent, 18.1686039F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp_Butacas.Size = new Size(1288, 501);
            Tlp_Butacas.TabIndex = 0;
            // 
            // Btn_Confirmacion
            // 
            Btn_Confirmacion.BackColor = SystemColors.Menu;
            Btn_Confirmacion.Cursor = Cursors.Hand;
            Btn_Confirmacion.Dock = DockStyle.Fill;
            Btn_Confirmacion.Location = new Point(3, 412);
            Btn_Confirmacion.Name = "Btn_Confirmacion";
            Btn_Confirmacion.Size = new Size(1282, 86);
            Btn_Confirmacion.TabIndex = 1;
            Btn_Confirmacion.Text = "Continuar";
            Btn_Confirmacion.UseVisualStyleBackColor = false;
            Btn_Confirmacion.Click += Btn_Confirmacion_Click;
            // 
            // Tlp_butacaselector
            // 
            Tlp_butacaselector.ColumnCount = 2;
            Tlp_butacaselector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_butacaselector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tlp_butacaselector.Dock = DockStyle.Fill;
            Tlp_butacaselector.Location = new Point(3, 3);
            Tlp_butacaselector.Name = "Tlp_butacaselector";
            Tlp_butacaselector.RowCount = 2;
            Tlp_butacaselector.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tlp_butacaselector.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tlp_butacaselector.Size = new Size(1282, 403);
            Tlp_butacaselector.TabIndex = 2;
            // 
            // Butacas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 501);
            Controls.Add(Tlp_Butacas);
            Name = "Butacas";
            Text = "Selector de butacas";
            Load += Butacas_Load;
            Tlp_Butacas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Tlp_Butacas;
        private Button Btn_Confirmacion;
        private TableLayoutPanel Tlp_butacaselector;
    }
}