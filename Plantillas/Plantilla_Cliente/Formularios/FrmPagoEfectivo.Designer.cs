namespace Plantilla_Cliente.Formularios
{
    partial class FrmPagoEfectivo
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
            lblTotal = new Label();
            lblVuelto = new Label();
            txtEfectivoRecibido = new TextBox();
            btnPagar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.ControlLightLight;
            lblTotal.Font = new Font("Segoe UI", 11F);
            lblTotal.Location = new Point(306, 49);
            lblTotal.MinimumSize = new Size(100, 23);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 0;
            // 
            // lblVuelto
            // 
            lblVuelto.AutoSize = true;
            lblVuelto.BackColor = SystemColors.ControlLightLight;
            lblVuelto.Font = new Font("Segoe UI", 11F);
            lblVuelto.Location = new Point(306, 142);
            lblVuelto.MinimumSize = new Size(100, 23);
            lblVuelto.Name = "lblVuelto";
            lblVuelto.Size = new Size(100, 23);
            lblVuelto.TabIndex = 1;
            //lblVuelto.Click += lblVuelto_Click;
            // 
            // txtEfectivoRecibido
            // 
            txtEfectivoRecibido.Font = new Font("Segoe UI", 11F);
            txtEfectivoRecibido.Location = new Point(306, 93);
            txtEfectivoRecibido.Name = "txtEfectivoRecibido";
            txtEfectivoRecibido.Size = new Size(100, 27);
            txtEfectivoRecibido.TabIndex = 2;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 10F);
            btnPagar.Location = new Point(254, 192);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 28);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(179, 50);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 4;
            label1.Text = "Total a Pagar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            //label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(144, 98);
            label2.Name = "label2";
            label2.Size = new Size(143, 22);
            label2.TabIndex = 5;
            label2.Text = "Efectivo Recibido";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(230, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 6;
            label3.Text = "Vuelto";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPagoEfectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(591, 266);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPagar);
            Controls.Add(txtEfectivoRecibido);
            Controls.Add(lblVuelto);
            Controls.Add(lblTotal);
            Name = "FrmPagoEfectivo";
            Text = "FrmPagoEfectivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label lblVuelto;
        private TextBox txtEfectivoRecibido;
        private Button btnPagar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}