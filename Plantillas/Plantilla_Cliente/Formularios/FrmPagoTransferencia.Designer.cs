namespace Plantilla_Cliente.Formularios
{
    partial class FrmPagoTransferencia
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
            lblInstrucciones = new Label();
            txtReferencia = new TextBox();
            btnVerificar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.Control;
            lblTotal.Font = new Font("Segoe UI", 11F);
            lblTotal.Location = new Point(219, 28);
            lblTotal.MinimumSize = new Size(100, 23);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Click += lblTotal_Click;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.BackColor = SystemColors.ControlLightLight;
            lblInstrucciones.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lblInstrucciones.ForeColor = SystemColors.ActiveCaptionText;
            lblInstrucciones.Location = new Point(219, 72);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(103, 22);
            lblInstrucciones.TabIndex = 7;
            lblInstrucciones.Text = "Intrucciones";
            lblInstrucciones.Click += btnVerificar_Click;
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(219, 137);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(100, 23);
            txtReferencia.TabIndex = 8;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(271, 196);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(88, 49);
            btnVerificar.TabIndex = 9;
            btnVerificar.Text = "Verificar Transferencia";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(105, 29);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 10;
            label1.Text = "Total a Pagar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(111, 72);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 11;
            label2.Text = "Información";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(69, 138);
            label3.Name = "label3";
            label3.Size = new Size(144, 22);
            label3.TabIndex = 12;
            label3.Text = "No. Comprobante";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPagoTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(591, 266);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVerificar);
            Controls.Add(txtReferencia);
            Controls.Add(lblInstrucciones);
            Controls.Add(lblTotal);
            Name = "FrmPagoTransferencia";
            Text = "FrmPagoTransferencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label lblInstrucciones;
        private TextBox txtReferencia;
        private Button btnVerificar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}