namespace Forms_Admin.Ventas
{
    partial class FrUcBoletos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TlpDivFormAndDgv = new TableLayoutPanel();
            TlpAux1 = new TableLayoutPanel();
            TlpAux2 = new TableLayoutPanel();
            TlpFormWithButtons = new TableLayoutPanel();
            TlpForm = new TableLayoutPanel();
            TbAsientoDecodificado = new Componentes.CustomTextBox();
            RtbDatosVenta = new Componentes.CustomRichTextBox();
            TbID = new Componentes.CustomIDTextBox();
            LbID = new Componentes.CustomLabel();
            LbEstado = new Componentes.CustomLabel();
            CbEstado = new Componentes.CustomComboBox();
            RtbDatosFuncion = new Componentes.CustomRichTextBox();
            LbTotalDeVenta = new Componentes.CustomLabel();
            LbFuncion = new Componentes.CustomLabel();
            TbIdFuncion = new Componentes.CustomTextBox();
            BtnBuscarFuncion = new Componentes.CustomButton();
            LbVenta = new Componentes.CustomLabel();
            TbIdVenta = new Componentes.CustomTextBox();
            BtnBuscarVenta = new Componentes.CustomButton();
            TbAsientoCodificado = new Componentes.CustomTextBox();
            TlpButtons = new TableLayoutPanel();
            BtnEliminar = new Componentes.CustomButton();
            BtnActualizar = new Componentes.CustomButton();
            BtnCopiar = new Componentes.CustomButton();
            BtnAgregar = new Componentes.CustomButton();
            BtnLimpiar = new Componentes.CustomButton();
            TlpTitleLabel = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomTitleLabel();
            TlpAux3 = new TableLayoutPanel();
            TlpFilter = new TableLayoutPanel();
            BtnBuscar = new Componentes.CustomButton();
            TbFiltro = new Componentes.CustomTextBox();
            CbFiltro = new Componentes.CustomComboBox();
            DgvBoletos = new Componentes.CustomDataGridView();
            TlpDivFormAndDgv.SuspendLayout();
            TlpAux1.SuspendLayout();
            TlpAux2.SuspendLayout();
            TlpFormWithButtons.SuspendLayout();
            TlpForm.SuspendLayout();
            TlpButtons.SuspendLayout();
            TlpTitleLabel.SuspendLayout();
            TlpAux3.SuspendLayout();
            TlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBoletos).BeginInit();
            SuspendLayout();
            // 
            // TlpDivFormAndDgv
            // 
            TlpDivFormAndDgv.ColumnCount = 1;
            TlpDivFormAndDgv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Controls.Add(TlpAux1, 0, 0);
            TlpDivFormAndDgv.Controls.Add(DgvBoletos, 0, 1);
            TlpDivFormAndDgv.Dock = DockStyle.Fill;
            TlpDivFormAndDgv.Location = new Point(0, 0);
            TlpDivFormAndDgv.Margin = new Padding(0);
            TlpDivFormAndDgv.Name = "TlpDivFormAndDgv";
            TlpDivFormAndDgv.RowCount = 2;
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 450F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 700);
            TlpDivFormAndDgv.TabIndex = 13;
            // 
            // TlpAux1
            // 
            TlpAux1.ColumnCount = 1;
            TlpAux1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpAux1.Controls.Add(TlpAux2, 0, 1);
            TlpAux1.Controls.Add(TlpTitleLabel, 0, 0);
            TlpAux1.Controls.Add(TlpAux3, 0, 2);
            TlpAux1.Dock = DockStyle.Fill;
            TlpAux1.Location = new Point(0, 0);
            TlpAux1.Margin = new Padding(0);
            TlpAux1.Name = "TlpAux1";
            TlpAux1.RowCount = 3;
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpAux1.Size = new Size(1050, 450);
            TlpAux1.TabIndex = 1;
            // 
            // TlpAux2
            // 
            TlpAux2.ColumnCount = 3;
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1000F));
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux2.Controls.Add(TlpFormWithButtons, 1, 0);
            TlpAux2.Dock = DockStyle.Fill;
            TlpAux2.Location = new Point(0, 75);
            TlpAux2.Margin = new Padding(0);
            TlpAux2.Name = "TlpAux2";
            TlpAux2.RowCount = 1;
            TlpAux2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux2.Size = new Size(1050, 300);
            TlpAux2.TabIndex = 0;
            // 
            // TlpFormWithButtons
            // 
            TlpFormWithButtons.ColumnCount = 1;
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpFormWithButtons.Controls.Add(TlpForm, 0, 0);
            TlpFormWithButtons.Controls.Add(TlpButtons, 0, 1);
            TlpFormWithButtons.Dock = DockStyle.Fill;
            TlpFormWithButtons.Location = new Point(25, 0);
            TlpFormWithButtons.Margin = new Padding(0);
            TlpFormWithButtons.Name = "TlpFormWithButtons";
            TlpFormWithButtons.RowCount = 2;
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpFormWithButtons.Size = new Size(1000, 300);
            TlpFormWithButtons.TabIndex = 0;
            // 
            // TlpForm
            // 
            TlpForm.ColumnCount = 6;
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TlpForm.Controls.Add(TbAsientoDecodificado, 1, 5);
            TlpForm.Controls.Add(RtbDatosVenta, 4, 2);
            TlpForm.Controls.Add(TbID, 0, 1);
            TlpForm.Controls.Add(LbID, 0, 0);
            TlpForm.Controls.Add(LbEstado, 0, 2);
            TlpForm.Controls.Add(CbEstado, 0, 3);
            TlpForm.Controls.Add(RtbDatosFuncion, 2, 2);
            TlpForm.Controls.Add(LbTotalDeVenta, 0, 4);
            TlpForm.Controls.Add(LbFuncion, 2, 0);
            TlpForm.Controls.Add(TbIdFuncion, 2, 1);
            TlpForm.Controls.Add(BtnBuscarFuncion, 3, 0);
            TlpForm.Controls.Add(LbVenta, 4, 0);
            TlpForm.Controls.Add(TbIdVenta, 4, 1);
            TlpForm.Controls.Add(BtnBuscarVenta, 5, 0);
            TlpForm.Controls.Add(TbAsientoCodificado, 0, 5);
            TlpForm.Dock = DockStyle.Fill;
            TlpForm.Location = new Point(0, 0);
            TlpForm.Margin = new Padding(0);
            TlpForm.Name = "TlpForm";
            TlpForm.RowCount = 8;
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.Size = new Size(1000, 225);
            TlpForm.TabIndex = 4;
            // 
            // TbAsientoDecodificado
            // 
            TbAsientoDecodificado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbAsientoDecodificado.BackColor = Color.FromArgb(35, 40, 52);
            TbAsientoDecodificado.BorderStyle = BorderStyle.FixedSingle;
            TbAsientoDecodificado.Font = new Font("Segoe UI", 10F);
            TbAsientoDecodificado.ForeColor = Color.FromArgb(160, 165, 175);
            TbAsientoDecodificado.Location = new Point(195, 175);
            TbAsientoDecodificado.Margin = new Padding(5, 0, 5, 10);
            TbAsientoDecodificado.MaximumSize = new Size(0, 30);
            TbAsientoDecodificado.MinimumSize = new Size(95, 30);
            TbAsientoDecodificado.Name = "TbAsientoDecodificado";
            TbAsientoDecodificado.PlaceholderText = "A10";
            TbAsientoDecodificado.Size = new Size(180, 30);
            TbAsientoDecodificado.TabIndex = 67;
            // 
            // RtbDatosVenta
            // 
            RtbDatosVenta.BackColor = Color.FromArgb(35, 40, 52);
            RtbDatosVenta.BorderStyle = BorderStyle.None;
            TlpForm.SetColumnSpan(RtbDatosVenta, 2);
            RtbDatosVenta.Dock = DockStyle.Fill;
            RtbDatosVenta.Font = new Font("Segoe UI", 10F);
            RtbDatosVenta.ForeColor = Color.FromArgb(230, 230, 230);
            RtbDatosVenta.Location = new Point(695, 85);
            RtbDatosVenta.Margin = new Padding(5, 10, 5, 10);
            RtbDatosVenta.MinimumSize = new Size(190, 60);
            RtbDatosVenta.Name = "RtbDatosVenta";
            TlpForm.SetRowSpan(RtbDatosVenta, 4);
            RtbDatosVenta.Size = new Size(300, 130);
            RtbDatosVenta.TabIndex = 84;
            RtbDatosVenta.Text = "";
            // 
            // TbID
            // 
            TbID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbID.BackColor = Color.FromArgb(28, 30, 38);
            TbID.BorderStyle = BorderStyle.FixedSingle;
            TlpForm.SetColumnSpan(TbID, 2);
            TbID.Font = new Font("Segoe UI", 10F);
            TbID.ForeColor = Color.FromArgb(120, 125, 135);
            TbID.Location = new Point(5, 25);
            TbID.Margin = new Padding(5, 0, 5, 10);
            TbID.MaximumSize = new Size(0, 30);
            TbID.MinimumSize = new Size(190, 30);
            TbID.Name = "TbID";
            TbID.ReadOnly = true;
            TbID.Size = new Size(370, 30);
            TbID.TabIndex = 60;
            TbID.TabStop = false;
            // 
            // LbID
            // 
            LbID.AutoSize = true;
            LbID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbID.ForeColor = Color.FromArgb(220, 220, 220);
            LbID.Location = new Point(3, 0);
            LbID.Margin = new Padding(3, 0, 0, 0);
            LbID.Name = "LbID";
            LbID.Padding = new Padding(0, 0, 2, 0);
            LbID.Size = new Size(87, 23);
            LbID.TabIndex = 11;
            LbID.Text = "ID Boleto";
            LbID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbEstado
            // 
            LbEstado.AutoSize = true;
            LbEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbEstado.ForeColor = Color.FromArgb(220, 220, 220);
            LbEstado.Location = new Point(3, 75);
            LbEstado.Name = "LbEstado";
            LbEstado.Padding = new Padding(0, 0, 2, 0);
            LbEstado.Size = new Size(65, 23);
            LbEstado.TabIndex = 67;
            LbEstado.Text = "Estado";
            LbEstado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbEstado
            // 
            CbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbEstado.BackColor = Color.FromArgb(55, 60, 72);
            CbEstado.BaseColor = Color.FromArgb(40, 40, 40);
            CbEstado.BGColor = Color.FromArgb(55, 60, 72);
            TlpForm.SetColumnSpan(CbEstado, 2);
            CbEstado.DrawMode = DrawMode.OwnerDrawFixed;
            CbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CbEstado.FlatStyle = FlatStyle.Flat;
            CbEstado.Font = new Font("Segoe UI", 9.5F);
            CbEstado.ForeColor = Color.FromArgb(230, 230, 230);
            CbEstado.FormattingEnabled = true;
            CbEstado.HoverColor = Color.Crimson;
            CbEstado.HoverFontColor = Color.White;
            CbEstado.ItemHeight = 24;
            CbEstado.Location = new Point(5, 100);
            CbEstado.Margin = new Padding(5, 0, 5, 10);
            CbEstado.MinimumSize = new Size(190, 0);
            CbEstado.Name = "CbEstado";
            CbEstado.Size = new Size(370, 30);
            CbEstado.TabIndex = 64;
            // 
            // RtbDatosFuncion
            // 
            RtbDatosFuncion.BackColor = Color.FromArgb(35, 40, 52);
            RtbDatosFuncion.BorderStyle = BorderStyle.None;
            TlpForm.SetColumnSpan(RtbDatosFuncion, 2);
            RtbDatosFuncion.Dock = DockStyle.Fill;
            RtbDatosFuncion.Font = new Font("Segoe UI", 10F);
            RtbDatosFuncion.ForeColor = Color.FromArgb(230, 230, 230);
            RtbDatosFuncion.Location = new Point(385, 85);
            RtbDatosFuncion.Margin = new Padding(5, 10, 5, 10);
            RtbDatosFuncion.MinimumSize = new Size(190, 60);
            RtbDatosFuncion.Name = "RtbDatosFuncion";
            TlpForm.SetRowSpan(RtbDatosFuncion, 4);
            RtbDatosFuncion.Size = new Size(300, 130);
            RtbDatosFuncion.TabIndex = 83;
            RtbDatosFuncion.Text = "";
            // 
            // LbTotalDeVenta
            // 
            LbTotalDeVenta.AutoSize = true;
            LbTotalDeVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbTotalDeVenta.ForeColor = Color.FromArgb(220, 220, 220);
            LbTotalDeVenta.Location = new Point(3, 150);
            LbTotalDeVenta.Name = "LbTotalDeVenta";
            LbTotalDeVenta.Padding = new Padding(0, 0, 2, 0);
            LbTotalDeVenta.Size = new Size(167, 23);
            LbTotalDeVenta.TabIndex = 72;
            LbTotalDeVenta.Text = "Número de Asiento";
            LbTotalDeVenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbFuncion
            // 
            LbFuncion.AutoSize = true;
            LbFuncion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbFuncion.ForeColor = Color.FromArgb(220, 220, 220);
            LbFuncion.Location = new Point(383, 0);
            LbFuncion.Margin = new Padding(3, 0, 0, 0);
            LbFuncion.Name = "LbFuncion";
            LbFuncion.Padding = new Padding(0, 0, 2, 0);
            LbFuncion.Size = new Size(97, 23);
            LbFuncion.TabIndex = 12;
            LbFuncion.Text = "ID Función";
            LbFuncion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbIdFuncion
            // 
            TbIdFuncion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbIdFuncion.BackColor = Color.FromArgb(55, 60, 72);
            TbIdFuncion.BorderStyle = BorderStyle.FixedSingle;
            TbIdFuncion.Font = new Font("Segoe UI", 10F);
            TbIdFuncion.ForeColor = Color.FromArgb(160, 165, 175);
            TbIdFuncion.Location = new Point(385, 25);
            TbIdFuncion.Margin = new Padding(5, 0, 5, 10);
            TbIdFuncion.MaximumSize = new Size(0, 30);
            TbIdFuncion.MinimumSize = new Size(190, 30);
            TbIdFuncion.Name = "TbIdFuncion";
            TbIdFuncion.PlaceholderText = "1";
            TbIdFuncion.Size = new Size(190, 30);
            TbIdFuncion.TabIndex = 80;
            // 
            // BtnBuscarFuncion
            // 
            BtnBuscarFuncion.Action = Componentes.ButtonAction.Buscar;
            BtnBuscarFuncion.Anchor = AnchorStyles.None;
            BtnBuscarFuncion.BackColor = Color.FromArgb(39, 174, 96);
            BtnBuscarFuncion.FlatAppearance.BorderSize = 0;
            BtnBuscarFuncion.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            BtnBuscarFuncion.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            BtnBuscarFuncion.FlatStyle = FlatStyle.Flat;
            BtnBuscarFuncion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscarFuncion.ForeColor = Color.White;
            BtnBuscarFuncion.Location = new Point(580, 15);
            BtnBuscarFuncion.Margin = new Padding(0, 0, 0, 4);
            BtnBuscarFuncion.MaximumSize = new Size(100, 40);
            BtnBuscarFuncion.MinimumSize = new Size(100, 40);
            BtnBuscarFuncion.Name = "BtnBuscarFuncion";
            TlpForm.SetRowSpan(BtnBuscarFuncion, 2);
            BtnBuscarFuncion.Size = new Size(100, 40);
            BtnBuscarFuncion.TabIndex = 81;
            BtnBuscarFuncion.Text = "Buscar";
            BtnBuscarFuncion.UseVisualStyleBackColor = false;
            // 
            // LbVenta
            // 
            LbVenta.AutoSize = true;
            LbVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbVenta.ForeColor = Color.FromArgb(220, 220, 220);
            LbVenta.Location = new Point(693, 0);
            LbVenta.Name = "LbVenta";
            LbVenta.Padding = new Padding(0, 0, 2, 0);
            LbVenta.Size = new Size(80, 23);
            LbVenta.TabIndex = 68;
            LbVenta.Text = "ID Venta";
            LbVenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbIdVenta
            // 
            TbIdVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbIdVenta.BackColor = Color.FromArgb(55, 60, 72);
            TbIdVenta.BorderStyle = BorderStyle.FixedSingle;
            TbIdVenta.Font = new Font("Segoe UI", 10F);
            TbIdVenta.ForeColor = Color.FromArgb(160, 165, 175);
            TbIdVenta.Location = new Point(695, 25);
            TbIdVenta.Margin = new Padding(5, 0, 5, 10);
            TbIdVenta.MaximumSize = new Size(0, 30);
            TbIdVenta.MinimumSize = new Size(190, 30);
            TbIdVenta.Name = "TbIdVenta";
            TbIdVenta.PlaceholderText = "1";
            TbIdVenta.Size = new Size(190, 30);
            TbIdVenta.TabIndex = 79;
            // 
            // BtnBuscarVenta
            // 
            BtnBuscarVenta.Action = Componentes.ButtonAction.Buscar;
            BtnBuscarVenta.Anchor = AnchorStyles.None;
            BtnBuscarVenta.BackColor = Color.FromArgb(39, 174, 96);
            BtnBuscarVenta.FlatAppearance.BorderSize = 0;
            BtnBuscarVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            BtnBuscarVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            BtnBuscarVenta.FlatStyle = FlatStyle.Flat;
            BtnBuscarVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscarVenta.ForeColor = Color.White;
            BtnBuscarVenta.Location = new Point(890, 15);
            BtnBuscarVenta.Margin = new Padding(0, 0, 0, 4);
            BtnBuscarVenta.MaximumSize = new Size(100, 40);
            BtnBuscarVenta.MinimumSize = new Size(100, 40);
            BtnBuscarVenta.Name = "BtnBuscarVenta";
            TlpForm.SetRowSpan(BtnBuscarVenta, 2);
            BtnBuscarVenta.Size = new Size(100, 40);
            BtnBuscarVenta.TabIndex = 82;
            BtnBuscarVenta.Text = "Buscar";
            BtnBuscarVenta.UseVisualStyleBackColor = false;
            // 
            // TbAsientoCodificado
            // 
            TbAsientoCodificado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbAsientoCodificado.BackColor = Color.FromArgb(55, 60, 72);
            TbAsientoCodificado.BorderStyle = BorderStyle.FixedSingle;
            TbAsientoCodificado.Font = new Font("Segoe UI", 10F);
            TbAsientoCodificado.ForeColor = Color.FromArgb(160, 165, 175);
            TbAsientoCodificado.Location = new Point(5, 175);
            TbAsientoCodificado.Margin = new Padding(5, 0, 5, 10);
            TbAsientoCodificado.MaximumSize = new Size(0, 30);
            TbAsientoCodificado.MinimumSize = new Size(95, 30);
            TbAsientoCodificado.Name = "TbAsientoCodificado";
            TbAsientoCodificado.PlaceholderText = "10";
            TbAsientoCodificado.Size = new Size(180, 30);
            TbAsientoCodificado.TabIndex = 66;
            // 
            // TlpButtons
            // 
            TlpButtons.ColumnCount = 7;
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.Controls.Add(BtnEliminar, 5, 0);
            TlpButtons.Controls.Add(BtnActualizar, 4, 0);
            TlpButtons.Controls.Add(BtnCopiar, 3, 0);
            TlpButtons.Controls.Add(BtnAgregar, 2, 0);
            TlpButtons.Controls.Add(BtnLimpiar, 1, 0);
            TlpButtons.Dock = DockStyle.Fill;
            TlpButtons.Location = new Point(0, 225);
            TlpButtons.Margin = new Padding(0);
            TlpButtons.Name = "TlpButtons";
            TlpButtons.RowCount = 1;
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpButtons.Size = new Size(1000, 75);
            TlpButtons.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Action = Componentes.ButtonAction.Eliminar;
            BtnEliminar.Anchor = AnchorStyles.None;
            BtnEliminar.BackColor = Color.FromArgb(192, 57, 43);
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(116, 35, 27);
            BtnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 62, 46);
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Location = new Point(670, 17);
            BtnEliminar.Margin = new Padding(0);
            BtnEliminar.MaximumSize = new Size(100, 40);
            BtnEliminar.MinimumSize = new Size(100, 40);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 40);
            BtnEliminar.TabIndex = 4;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Action = Componentes.ButtonAction.Actualizar;
            BtnActualizar.Anchor = AnchorStyles.None;
            BtnActualizar.BackColor = Color.FromArgb(214, 157, 15);
            BtnActualizar.FlatAppearance.BorderSize = 0;
            BtnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(130, 97, 9);
            BtnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 169, 16);
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnActualizar.ForeColor = Color.White;
            BtnActualizar.Location = new Point(560, 17);
            BtnActualizar.Margin = new Padding(0);
            BtnActualizar.MaximumSize = new Size(100, 40);
            BtnActualizar.MinimumSize = new Size(100, 40);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(100, 40);
            BtnActualizar.TabIndex = 2;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // BtnCopiar
            // 
            BtnCopiar.Action = Componentes.ButtonAction.Copiar;
            BtnCopiar.Anchor = AnchorStyles.None;
            BtnCopiar.BackColor = Color.FromArgb(26, 156, 156);
            BtnCopiar.FlatAppearance.BorderSize = 0;
            BtnCopiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 95, 95);
            BtnCopiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 169, 169);
            BtnCopiar.FlatStyle = FlatStyle.Flat;
            BtnCopiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCopiar.ForeColor = Color.White;
            BtnCopiar.Location = new Point(450, 17);
            BtnCopiar.Margin = new Padding(0);
            BtnCopiar.MaximumSize = new Size(100, 40);
            BtnCopiar.MinimumSize = new Size(100, 40);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(100, 40);
            BtnCopiar.TabIndex = 3;
            BtnCopiar.Text = "Copiar";
            BtnCopiar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.None;
            BtnAgregar.BackColor = Color.FromArgb(41, 128, 185);
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 75, 109);
            BtnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 134, 194);
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(340, 17);
            BtnAgregar.Margin = new Padding(0);
            BtnAgregar.MaximumSize = new Size(100, 40);
            BtnAgregar.MinimumSize = new Size(100, 40);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(100, 40);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Action = Componentes.ButtonAction.Limpiar;
            BtnLimpiar.Anchor = AnchorStyles.None;
            BtnLimpiar.BackColor = Color.FromArgb(22, 160, 133);
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 97, 80);
            BtnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 174, 145);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(230, 17);
            BtnLimpiar.Margin = new Padding(0);
            BtnLimpiar.MaximumSize = new Size(100, 40);
            BtnLimpiar.MinimumSize = new Size(100, 40);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(100, 40);
            BtnLimpiar.TabIndex = 2;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // TlpTitleLabel
            // 
            TlpTitleLabel.BackColor = Color.Black;
            TlpTitleLabel.ColumnCount = 3;
            TlpTitleLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpTitleLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            TlpTitleLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpTitleLabel.Controls.Add(LbTitulo, 1, 0);
            TlpTitleLabel.Dock = DockStyle.Fill;
            TlpTitleLabel.Location = new Point(0, 0);
            TlpTitleLabel.Margin = new Padding(0);
            TlpTitleLabel.Name = "TlpTitleLabel";
            TlpTitleLabel.RowCount = 1;
            TlpTitleLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpTitleLabel.Size = new Size(1050, 75);
            TlpTitleLabel.TabIndex = 1;
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.Dock = DockStyle.Fill;
            LbTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LbTitulo.ForeColor = Color.Crimson;
            LbTitulo.Location = new Point(278, 0);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(494, 75);
            LbTitulo.TabIndex = 0;
            LbTitulo.Text = "BOLETOS";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TlpAux3
            // 
            TlpAux3.ColumnCount = 3;
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 510F));
            TlpAux3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpAux3.Controls.Add(TlpFilter, 1, 0);
            TlpAux3.Dock = DockStyle.Fill;
            TlpAux3.Location = new Point(0, 375);
            TlpAux3.Margin = new Padding(0);
            TlpAux3.Name = "TlpAux3";
            TlpAux3.RowCount = 1;
            TlpAux3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAux3.Size = new Size(1050, 75);
            TlpAux3.TabIndex = 2;
            // 
            // TlpFilter
            // 
            TlpFilter.ColumnCount = 3;
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            TlpFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpFilter.Controls.Add(BtnBuscar, 2, 0);
            TlpFilter.Controls.Add(TbFiltro, 1, 0);
            TlpFilter.Controls.Add(CbFiltro, 0, 0);
            TlpFilter.Dock = DockStyle.Fill;
            TlpFilter.Location = new Point(270, 0);
            TlpFilter.Margin = new Padding(0);
            TlpFilter.Name = "TlpFilter";
            TlpFilter.RowCount = 1;
            TlpFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFilter.Size = new Size(510, 75);
            TlpFilter.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Action = Componentes.ButtonAction.Buscar;
            BtnBuscar.Anchor = AnchorStyles.None;
            BtnBuscar.BackColor = Color.FromArgb(39, 174, 96);
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            BtnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(405, 17);
            BtnBuscar.Margin = new Padding(0);
            BtnBuscar.MaximumSize = new Size(100, 40);
            BtnBuscar.MinimumSize = new Size(100, 40);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(100, 40);
            BtnBuscar.TabIndex = 5;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // TbFiltro
            // 
            TbFiltro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TbFiltro.BackColor = Color.FromArgb(55, 60, 72);
            TbFiltro.BorderStyle = BorderStyle.FixedSingle;
            TbFiltro.Font = new Font("Segoe UI", 10F);
            TbFiltro.ForeColor = Color.FromArgb(230, 230, 230);
            TbFiltro.Location = new Point(205, 22);
            TbFiltro.Margin = new Padding(5);
            TbFiltro.MaximumSize = new Size(0, 30);
            TbFiltro.MinimumSize = new Size(190, 30);
            TbFiltro.Name = "TbFiltro";
            TbFiltro.Size = new Size(190, 30);
            TbFiltro.TabIndex = 7;
            // 
            // CbFiltro
            // 
            CbFiltro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CbFiltro.BackColor = Color.FromArgb(55, 60, 72);
            CbFiltro.BaseColor = Color.FromArgb(40, 40, 40);
            CbFiltro.BGColor = Color.FromArgb(55, 60, 72);
            CbFiltro.DrawMode = DrawMode.OwnerDrawFixed;
            CbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            CbFiltro.FlatStyle = FlatStyle.Flat;
            CbFiltro.Font = new Font("Segoe UI", 9.5F);
            CbFiltro.ForeColor = Color.FromArgb(230, 230, 230);
            CbFiltro.FormattingEnabled = true;
            CbFiltro.HoverColor = Color.Crimson;
            CbFiltro.HoverFontColor = Color.White;
            CbFiltro.ItemHeight = 24;
            CbFiltro.Location = new Point(5, 22);
            CbFiltro.Margin = new Padding(5);
            CbFiltro.MinimumSize = new Size(190, 0);
            CbFiltro.Name = "CbFiltro";
            CbFiltro.Size = new Size(190, 30);
            CbFiltro.TabIndex = 8;
            // 
            // DgvBoletos
            // 
            DgvBoletos.AllowUserToAddRows = false;
            DgvBoletos.AllowUserToResizeColumns = false;
            DgvBoletos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 44, 49);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DgvBoletos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvBoletos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBoletos.BackgroundColor = Color.FromArgb(37, 38, 43);
            DgvBoletos.BorderStyle = BorderStyle.None;
            DgvBoletos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvBoletos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvBoletos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvBoletos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 38, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvBoletos.DefaultCellStyle = dataGridViewCellStyle3;
            DgvBoletos.Dock = DockStyle.Fill;
            DgvBoletos.EnableHeadersVisualStyles = false;
            DgvBoletos.Font = new Font("Segoe UI", 9.5F);
            DgvBoletos.GridColor = Color.FromArgb(58, 60, 66);
            DgvBoletos.Location = new Point(0, 450);
            DgvBoletos.Margin = new Padding(0);
            DgvBoletos.MultiSelect = false;
            DgvBoletos.Name = "DgvBoletos";
            DgvBoletos.ReadOnly = true;
            DgvBoletos.RowHeadersVisible = false;
            DgvBoletos.RowHeadersWidth = 51;
            DgvBoletos.RowTemplate.Height = 36;
            DgvBoletos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvBoletos.Size = new Size(1050, 250);
            DgvBoletos.TabIndex = 2;
            // 
            // FrUcBoletos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(TlpDivFormAndDgv);
            Name = "FrUcBoletos";
            Size = new Size(1050, 700);
            TlpDivFormAndDgv.ResumeLayout(false);
            TlpAux1.ResumeLayout(false);
            TlpAux2.ResumeLayout(false);
            TlpFormWithButtons.ResumeLayout(false);
            TlpForm.ResumeLayout(false);
            TlpForm.PerformLayout();
            TlpButtons.ResumeLayout(false);
            TlpTitleLabel.ResumeLayout(false);
            TlpTitleLabel.PerformLayout();
            TlpAux3.ResumeLayout(false);
            TlpFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvBoletos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpDivFormAndDgv;
        private TableLayoutPanel TlpAux1;
        private TableLayoutPanel TlpAux2;
        private TableLayoutPanel TlpFormWithButtons;
        private TableLayoutPanel TlpButtons;
        private Componentes.CustomButton BtnEliminar;
        private Componentes.CustomButton BtnActualizar;
        private Componentes.CustomButton BtnCopiar;
        private Componentes.CustomButton BtnAgregar;
        private Componentes.CustomButton BtnLimpiar;
        private TableLayoutPanel TlpTitleLabel;
        private Componentes.CustomTitleLabel LbTitulo;
        private TableLayoutPanel TlpAux3;
        private TableLayoutPanel TlpFilter;
        private Componentes.CustomButton BtnBuscar;
        private Componentes.CustomTextBox TbFiltro;
        private Componentes.CustomComboBox CbFiltro;
        private TableLayoutPanel TlpForm;
        private Componentes.CustomRichTextBox RtbDatosVenta;
        private Componentes.CustomIDTextBox TbID;
        private Componentes.CustomLabel LbID;
        private Componentes.CustomLabel LbEstado;
        private Componentes.CustomComboBox CbEstado;
        private Componentes.CustomRichTextBox RtbDatosFuncion;
        private Componentes.CustomLabel LbTotalDeVenta;
        private Componentes.CustomTextBox TbAsientoCodificado;
        private Componentes.CustomLabel LbFuncion;
        private Componentes.CustomTextBox TbIdFuncion;
        private Componentes.CustomButton BtnBuscarFuncion;
        private Componentes.CustomLabel LbVenta;
        private Componentes.CustomTextBox TbIdVenta;
        private Componentes.CustomButton BtnBuscarVenta;
        private Componentes.CustomTextBox TbAsientoDecodificado;
        private Componentes.CustomDataGridView DgvBoletos;
    }
}
