using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Drawing;
using System.Windows.Forms;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;

namespace Plantilla_Admin
{
    partial class FrUcMainReportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            PnlBarra = new Panel();
            TlpBarra = new TableLayoutPanel();
            LbReporte = new Componentes.CustomLabel();
            LbSemanaMes = new Componentes.CustomLabel();
            CbReporte = new Componentes.CustomComboBox();
            LbAnio = new Componentes.CustomLabel();
            NudAnio = new Krypton.Toolkit.KryptonNumericUpDown();
            NudMesSemana = new Krypton.Toolkit.KryptonNumericUpDown();
            BtnImprimir = new Componentes.CustomButton();
            BtnExportar = new Componentes.CustomButton();
            btnGenerar = new Componentes.CustomButton();
            TlpReporte = new TableLayoutPanel();
            TlpEncabezado = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomLabel();
            LbSubtitulo = new Componentes.CustomLabel();
            LbFecha = new Componentes.CustomLabel();
            LbTotales = new Componentes.CustomLabel();
            DgvReporte = new Componentes.CustomDataGridView();
            PnlBarra.SuspendLayout();
            TlpBarra.SuspendLayout();
            TlpReporte.SuspendLayout();
            TlpEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvReporte).BeginInit();
            SuspendLayout();
            // 
            // PnlBarra
            // 
            PnlBarra.BackColor = Color.FromArgb(40, 44, 54);
            PnlBarra.Controls.Add(TlpBarra);
            PnlBarra.Dock = DockStyle.Top;
            PnlBarra.Location = new Point(0, 0);
            PnlBarra.Name = "PnlBarra";
            PnlBarra.Padding = new Padding(16, 12, 16, 12);
            PnlBarra.Size = new Size(980, 92);
            PnlBarra.TabIndex = 1;
            // 
            // TlpBarra
            // 
            TlpBarra.ColumnCount = 6;
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            TlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            TlpBarra.Controls.Add(LbReporte, 0, 0);
            TlpBarra.Controls.Add(LbSemanaMes, 2, 0);
            TlpBarra.Controls.Add(CbReporte, 0, 1);
            TlpBarra.Controls.Add(LbAnio, 1, 0);
            TlpBarra.Controls.Add(NudAnio, 1, 1);
            TlpBarra.Controls.Add(NudMesSemana, 2, 1);
            TlpBarra.Controls.Add(BtnImprimir, 4, 0);
            TlpBarra.Controls.Add(BtnExportar, 5, 0);
            TlpBarra.Controls.Add(btnGenerar, 3, 0);
            TlpBarra.Dock = DockStyle.Top;
            TlpBarra.Location = new Point(16, 12);
            TlpBarra.Margin = new Padding(0);
            TlpBarra.Name = "TlpBarra";
            TlpBarra.RowCount = 2;
            TlpBarra.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpBarra.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpBarra.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpBarra.Size = new Size(948, 74);
            TlpBarra.TabIndex = 20;
            // 
            // LbReporte
            // 
            LbReporte.AutoSize = true;
            LbReporte.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbReporte.ForeColor = Color.FromArgb(228, 231, 237);
            LbReporte.Location = new Point(3, 0);
            LbReporte.Name = "LbReporte";
            LbReporte.Padding = new Padding(0, 0, 2, 0);
            LbReporte.Size = new Size(76, 23);
            LbReporte.TabIndex = 17;
            LbReporte.Text = "Reporte";
            LbReporte.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbSemanaMes
            // 
            LbSemanaMes.AutoSize = true;
            LbSemanaMes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbSemanaMes.ForeColor = Color.FromArgb(228, 231, 237);
            LbSemanaMes.Location = new Point(416, 0);
            LbSemanaMes.Name = "LbSemanaMes";
            LbSemanaMes.Padding = new Padding(0, 0, 2, 0);
            LbSemanaMes.Size = new Size(43, 23);
            LbSemanaMes.TabIndex = 19;
            LbSemanaMes.Text = "Aux";
            LbSemanaMes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbReporte
            // 
            CbReporte.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbReporte.BackColor = Color.FromArgb(55, 60, 72);
            CbReporte.BaseColor = Color.FromArgb(45, 49, 59);
            CbReporte.BGColor = Color.FromArgb(55, 60, 72);
            CbReporte.DrawMode = DrawMode.OwnerDrawFixed;
            CbReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            CbReporte.FlatStyle = FlatStyle.Flat;
            CbReporte.Font = new Font("Segoe UI", 9.5F);
            CbReporte.ForeColor = Color.FromArgb(230, 230, 230);
            CbReporte.FormattingEnabled = true;
            CbReporte.HoverColor = Color.FromArgb(94, 129, 172);
            CbReporte.HoverFontColor = Color.White;
            CbReporte.ItemHeight = 24;
            CbReporte.Location = new Point(5, 30);
            CbReporte.Margin = new Padding(5);
            CbReporte.MinimumSize = new Size(190, 0);
            CbReporte.Name = "CbReporte";
            CbReporte.Size = new Size(300, 30);
            CbReporte.TabIndex = 11;
            // 
            // LbAnio
            // 
            LbAnio.AutoSize = true;
            LbAnio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbAnio.ForeColor = Color.FromArgb(228, 231, 237);
            LbAnio.Location = new Point(313, 0);
            LbAnio.Name = "LbAnio";
            LbAnio.Padding = new Padding(0, 0, 2, 0);
            LbAnio.Size = new Size(44, 23);
            LbAnio.TabIndex = 18;
            LbAnio.Text = "Año";
            LbAnio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NudAnio
            // 
            NudAnio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NudAnio.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            NudAnio.Location = new Point(313, 28);
            NudAnio.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            NudAnio.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            NudAnio.Name = "NudAnio";
            NudAnio.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            NudAnio.Size = new Size(97, 26);
            NudAnio.TabIndex = 12;
            NudAnio.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // NudMesSemana
            // 
            NudMesSemana.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NudMesSemana.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            NudMesSemana.Location = new Point(416, 28);
            NudMesSemana.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            NudMesSemana.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            NudMesSemana.Name = "NudMesSemana";
            NudMesSemana.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            NudMesSemana.Size = new Size(97, 26);
            NudMesSemana.TabIndex = 13;
            NudMesSemana.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // BtnImprimir
            // 
            BtnImprimir.Action = Componentes.ButtonAction.Copiar;
            BtnImprimir.Anchor = AnchorStyles.None;
            BtnImprimir.BackColor = Color.FromArgb(66, 138, 142);
            BtnImprimir.FlatAppearance.BorderSize = 0;
            BtnImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 106, 110);
            BtnImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 156, 160);
            BtnImprimir.FlatStyle = FlatStyle.Flat;
            BtnImprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnImprimir.ForeColor = Color.White;
            BtnImprimir.Location = new Point(631, 17);
            BtnImprimir.Margin = new Padding(0);
            BtnImprimir.MaximumSize = new Size(150, 40);
            BtnImprimir.MinimumSize = new Size(150, 40);
            BtnImprimir.Name = "BtnImprimir";
            TlpBarra.SetRowSpan(BtnImprimir, 2);
            BtnImprimir.Size = new Size(150, 40);
            BtnImprimir.TabIndex = 15;
            BtnImprimir.Text = "Imprimir PDF";
            BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // BtnExportar
            // 
            BtnExportar.Action = Componentes.ButtonAction.Copiar;
            BtnExportar.Anchor = AnchorStyles.None;
            BtnExportar.BackColor = Color.FromArgb(66, 138, 142);
            BtnExportar.FlatAppearance.BorderSize = 0;
            BtnExportar.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 106, 110);
            BtnExportar.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 156, 160);
            BtnExportar.FlatStyle = FlatStyle.Flat;
            BtnExportar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnExportar.ForeColor = Color.White;
            BtnExportar.Location = new Point(792, 17);
            BtnExportar.Margin = new Padding(0);
            BtnExportar.MaximumSize = new Size(150, 40);
            BtnExportar.MinimumSize = new Size(150, 40);
            BtnExportar.Name = "BtnExportar";
            TlpBarra.SetRowSpan(BtnExportar, 2);
            BtnExportar.Size = new Size(150, 40);
            BtnExportar.TabIndex = 16;
            BtnExportar.Text = "Exportar CSV";
            BtnExportar.UseVisualStyleBackColor = false;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.None;
            btnGenerar.BackColor = Color.FromArgb(94, 129, 172);
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 105, 145);
            btnGenerar.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 146, 189);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(521, 17);
            btnGenerar.Margin = new Padding(0);
            btnGenerar.MaximumSize = new Size(100, 40);
            btnGenerar.MinimumSize = new Size(100, 40);
            btnGenerar.Name = "btnGenerar";
            TlpBarra.SetRowSpan(btnGenerar, 2);
            btnGenerar.Size = new Size(100, 40);
            btnGenerar.TabIndex = 14;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // TlpReporte
            // 
            TlpReporte.BackColor = Color.FromArgb(25, 30, 42);
            TlpReporte.ColumnCount = 1;
            TlpReporte.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpReporte.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpReporte.Controls.Add(TlpEncabezado, 0, 0);
            TlpReporte.Controls.Add(LbTotales, 0, 2);
            TlpReporte.Controls.Add(DgvReporte, 0, 1);
            TlpReporte.Dock = DockStyle.Fill;
            TlpReporte.Location = new Point(0, 92);
            TlpReporte.Margin = new Padding(20);
            TlpReporte.Name = "TlpReporte";
            TlpReporte.Padding = new Padding(20);
            TlpReporte.RowCount = 3;
            TlpReporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            TlpReporte.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpReporte.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpReporte.Size = new Size(980, 568);
            TlpReporte.TabIndex = 2;
            // 
            // TlpEncabezado
            // 
            TlpEncabezado.BackColor = Color.FromArgb(45, 50, 62);
            TlpEncabezado.ColumnCount = 1;
            TlpEncabezado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpEncabezado.Controls.Add(LbTitulo, 0, 0);
            TlpEncabezado.Controls.Add(LbSubtitulo, 0, 1);
            TlpEncabezado.Controls.Add(LbFecha, 0, 2);
            TlpEncabezado.Dock = DockStyle.Fill;
            TlpEncabezado.Location = new Point(23, 23);
            TlpEncabezado.Name = "TlpEncabezado";
            TlpEncabezado.RowCount = 3;
            TlpEncabezado.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TlpEncabezado.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            TlpEncabezado.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpEncabezado.Size = new Size(934, 104);
            TlpEncabezado.TabIndex = 0;
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbTitulo.ForeColor = Color.FromArgb(220, 220, 220);
            LbTitulo.Location = new Point(3, 0);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Padding = new Padding(0, 0, 2, 0);
            LbTitulo.Size = new Size(59, 23);
            LbTitulo.TabIndex = 0;
            LbTitulo.Text = "Titulo";
            LbTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbSubtitulo
            // 
            LbSubtitulo.AutoSize = true;
            LbSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbSubtitulo.ForeColor = Color.FromArgb(220, 220, 220);
            LbSubtitulo.Location = new Point(3, 40);
            LbSubtitulo.Name = "LbSubtitulo";
            LbSubtitulo.Padding = new Padding(0, 0, 2, 0);
            LbSubtitulo.Size = new Size(87, 23);
            LbSubtitulo.TabIndex = 1;
            LbSubtitulo.Text = "Subtitulo";
            LbSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbFecha
            // 
            LbFecha.AutoSize = true;
            LbFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbFecha.ForeColor = Color.FromArgb(220, 220, 220);
            LbFecha.Location = new Point(3, 70);
            LbFecha.Name = "LbFecha";
            LbFecha.Padding = new Padding(0, 0, 2, 0);
            LbFecha.Size = new Size(57, 23);
            LbFecha.TabIndex = 2;
            LbFecha.Text = "Fecha";
            LbFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbTotales
            // 
            LbTotales.AutoSize = true;
            LbTotales.BackColor = Color.FromArgb(45, 50, 62);
            LbTotales.Dock = DockStyle.Fill;
            LbTotales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbTotales.ForeColor = Color.FromArgb(220, 220, 220);
            LbTotales.Location = new Point(23, 498);
            LbTotales.Name = "LbTotales";
            LbTotales.Padding = new Padding(0, 0, 2, 0);
            LbTotales.Size = new Size(934, 50);
            LbTotales.TabIndex = 1;
            LbTotales.Text = "Label";
            LbTotales.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DgvReporte
            // 
            DgvReporte.AllowUserToAddRows = false;
            DgvReporte.AllowUserToResizeColumns = false;
            DgvReporte.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(42, 44, 49);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            DgvReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvReporte.BackgroundColor = Color.FromArgb(37, 38, 43);
            DgvReporte.BorderStyle = BorderStyle.None;
            DgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvReporte.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(37, 38, 43);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle6.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvReporte.DefaultCellStyle = dataGridViewCellStyle6;
            DgvReporte.Dock = DockStyle.Fill;
            DgvReporte.EnableHeadersVisualStyles = false;
            DgvReporte.Font = new Font("Segoe UI", 9.5F);
            DgvReporte.GridColor = Color.FromArgb(58, 60, 66);
            DgvReporte.Location = new Point(20, 130);
            DgvReporte.Margin = new Padding(0);
            DgvReporte.MultiSelect = false;
            DgvReporte.Name = "DgvReporte";
            DgvReporte.ReadOnly = true;
            DgvReporte.RowHeadersVisible = false;
            DgvReporte.RowHeadersWidth = 51;
            DgvReporte.RowTemplate.Height = 36;
            DgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvReporte.Size = new Size(940, 368);
            DgvReporte.TabIndex = 2;
            // 
            // FrUcMainReportes
            // 
            BackColor = Color.FromArgb(232, 235, 239);
            Controls.Add(TlpReporte);
            Controls.Add(PnlBarra);
            Font = new Font("Segoe UI", 9F);
            Name = "FrUcMainReportes";
            Size = new Size(980, 660);
            PnlBarra.ResumeLayout(false);
            TlpBarra.ResumeLayout(false);
            TlpBarra.PerformLayout();
            TlpReporte.ResumeLayout(false);
            TlpReporte.PerformLayout();
            TlpEncabezado.ResumeLayout(false);
            TlpEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvReporte).EndInit();
            ResumeLayout(false);
        }

        private Panel PnlBarra;
        private NumericUpDown numAnio;
        private NumericUpDown numMes;
        private NumericUpDown numMesSemana;
        private Label lblSemana;
        private NumericUpDown numSemana;
        private Button btnImprimir;
        private Componentes.CustomButton BtnExportar;
        private Componentes.CustomButton BtnImprimir;
        private Componentes.CustomComboBox customComboBox1;
        private Componentes.CustomButton customButton3;
        private Componentes.CustomButton customButton2;
        private Componentes.CustomButton customButton1;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown2;
        private Krypton.Toolkit.KryptonNumericUpDown NudAnio;
        private Krypton.Toolkit.KryptonNumericUpDown NudMesSemana;
        private Componentes.CustomLabel LbSemanaMes;
        private Componentes.CustomLabel LbAnio;
        private Componentes.CustomLabel LbReporte;
        private Componentes.CustomComboBox CbReporte;
        private Componentes.CustomButton btnGenerar;
        private TableLayoutPanel TlpBarra;
        private TableLayoutPanel TlpReporte;
        private TableLayoutPanel TlpEncabezado;
        private Componentes.CustomLabel LbTitulo;
        private Componentes.CustomLabel LbSubtitulo;
        private Componentes.CustomLabel LbFecha;
        private Componentes.CustomLabel LbTotales;
        private Componentes.CustomDataGridView DgvReporte;
    }
}