namespace Plantilla_Cliente.Formularios
{
    partial class FrmPagoTarjeta
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
            txtNumeroTarjeta = new TextBox();
            picMarcaTarjeta = new PictureBox();
            btnProcesar = new Button();
            lblTotal = new Label();
            txtFechaExpiracion = new TextBox();
            txtCVV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picMarcaTarjeta).BeginInit();
            SuspendLayout();
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Font = new Font("Segoe UI", 11F);
            txtNumeroTarjeta.Location = new Point(397, 96);
            txtNumeroTarjeta.Margin = new Padding(3, 4, 3, 4);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(178, 32);
            txtNumeroTarjeta.TabIndex = 2;
            // 
            // picMarcaTarjeta
            // 
            picMarcaTarjeta.Location = new Point(346, 91);
            picMarcaTarjeta.Margin = new Padding(3, 4, 3, 4);
            picMarcaTarjeta.Name = "picMarcaTarjeta";
            picMarcaTarjeta.Size = new Size(43, 41);
            picMarcaTarjeta.SizeMode = PictureBoxSizeMode.Zoom;
            picMarcaTarjeta.TabIndex = 3;
            picMarcaTarjeta.TabStop = false;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(289, 283);
            btnProcesar.Margin = new Padding(3, 4, 3, 4);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(90, 56);
            btnProcesar.TabIndex = 4;
            btnProcesar.Text = "Procesar Tarjeta";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.Control;
            lblTotal.Font = new Font("Segoe UI", 11F);
            lblTotal.Location = new Point(346, 29);
            lblTotal.MinimumSize = new Size(114, 31);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(114, 31);
            lblTotal.TabIndex = 5;
            // 
            // txtFechaExpiracion
            // 
            txtFechaExpiracion.Location = new Point(365, 157);
            txtFechaExpiracion.Margin = new Padding(3, 4, 3, 4);
            txtFechaExpiracion.Name = "txtFechaExpiracion";
            txtFechaExpiracion.PlaceholderText = "MM/AA";
            txtFechaExpiracion.Size = new Size(114, 27);
            txtFechaExpiracion.TabIndex = 6;
            txtFechaExpiracion.Tag = "MM/AA";
            txtFechaExpiracion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(346, 219);
            txtCVV.Margin = new Padding(3, 4, 3, 4);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(114, 27);
            txtCVV.TabIndex = 7;
            txtCVV.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(216, 31);
            label1.Name = "label1";
            label1.Size = new Size(132, 26);
            label1.TabIndex = 8;
            label1.Text = "Total a Pagar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(230, 103);
            label2.Name = "label2";
            label2.Size = new Size(117, 26);
            label2.TabIndex = 9;
            label2.Text = "No. Tarjeta";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(138, 156);
            label3.Name = "label3";
            label3.Size = new Size(221, 26);
            label3.TabIndex = 10;
            label3.Text = "Fecha de Vencimiento";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(207, 219);
            label4.Name = "label4";
            label4.Size = new Size(143, 26);
            label4.TabIndex = 11;
            label4.Text = "No. Seguridad";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPagoTarjeta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(675, 363);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCVV);
            Controls.Add(txtFechaExpiracion);
            Controls.Add(lblTotal);
            Controls.Add(btnProcesar);
            Controls.Add(picMarcaTarjeta);
            Controls.Add(txtNumeroTarjeta);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPagoTarjeta";
            Text = "FrmPagoTarjeta";
            Click += btnProcesar_Click;
            ((System.ComponentModel.ISupportInitialize)picMarcaTarjeta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNumeroTarjeta;
        private PictureBox picMarcaTarjeta;
        private Button btnProcesar;
        private Label lblTotal;
        private TextBox txtFechaExpiracion;
        private TextBox txtCVV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}