namespace Plantilla_Cliente
{
    partial class FrMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrMenu));
            Pnl_MenuLayout = new TableLayoutPanel();
            Pnl_Menu = new Panel();
            helpProvider1 = new HelpProvider();
            Pnl_MenuLayout.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_MenuLayout
            // 
            Pnl_MenuLayout.BackColor = SystemColors.ControlDark;
            Pnl_MenuLayout.ColumnCount = 1;
            Pnl_MenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Pnl_MenuLayout.Controls.Add(Pnl_Menu, 0, 0);
            Pnl_MenuLayout.Dock = DockStyle.Fill;
            Pnl_MenuLayout.Location = new Point(0, 0);
            Pnl_MenuLayout.Name = "Pnl_MenuLayout";
            Pnl_MenuLayout.RowCount = 1;
            Pnl_MenuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4.285714F));
            Pnl_MenuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 95.71429F));
            Pnl_MenuLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Pnl_MenuLayout.Size = new Size(1240, 770);
            Pnl_MenuLayout.TabIndex = 0;
            Pnl_MenuLayout.Paint += tableLayoutPanel1_Paint;
            // 
            // Pnl_Menu
            // 
            Pnl_Menu.BackColor = SystemColors.ActiveCaption;
            Pnl_Menu.Dock = DockStyle.Fill;
            Pnl_Menu.Location = new Point(3, 3);
            Pnl_Menu.Name = "Pnl_Menu";
            Pnl_MenuLayout.SetRowSpan(Pnl_Menu, 2);
            Pnl_Menu.Size = new Size(1234, 764);
            Pnl_Menu.TabIndex = 3;
            // 
            // FrMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 770);
            Controls.Add(Pnl_MenuLayout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1200, 700);
            Name = "FrMenu";
            Text = "Menú principal";
            WindowState = FormWindowState.Maximized;
            Pnl_MenuLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Pnl_MenuLayout;
        private Panel Pnl_Menu;
        private HelpProvider helpProvider1;
    }
}
