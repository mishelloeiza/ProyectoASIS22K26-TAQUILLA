namespace Plantilla_Cliente
{
    partial class Pago
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
            cboMetodoPago = new ComboBox();
            lblTotal = new Label();
            btnConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.Location = new Point(273, 62);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(121, 23);
            cboMetodoPago.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.ControlLightLight;
            lblTotal.Font = new Font("Segoe UI", 15F);
            lblTotal.Location = new Point(273, 110);
            lblTotal.MinimumSize = new Size(121, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(121, 28);
            lblTotal.TabIndex = 1;
            //lblTotal.Click += label1_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(239, 174);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Continuar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(159, 63);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 3;
            label1.Text = "Tipo de pago";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(220, 116);
            label2.Name = "label2";
            label2.Size = new Size(47, 22);
            label2.TabIndex = 4;
            label2.Text = "Total";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            //label2.Click += label2_Click;
            // 
            // Pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(591, 266);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(lblTotal);
            Controls.Add(cboMetodoPago);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Pago";
            Text = "Pago de boleto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMetodoPago;
        private Label lblTotal;
        private Button btnConfirmar;
        private Label label1;
        private Label label2;
    }
}