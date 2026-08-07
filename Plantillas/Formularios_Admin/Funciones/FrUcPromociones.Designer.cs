namespace Forms_Admin.Funciones
{
    partial class FrUcPromociones
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            TlpDivFormAndDgv = new TableLayoutPanel();
            TlpAux1 = new TableLayoutPanel();
            TlpAux2 = new TableLayoutPanel();
            TlpFormWithButtons = new TableLayoutPanel();
            TlpForm = new TableLayoutPanel();
            ccb_tipopromocion = new Componentes.CustomComboBox();
            customLabel3 = new Componentes.CustomLabel();
            customLabel2 = new Componentes.CustomLabel();
            cpfinal = new Componentes.CustomDatePicker();
            customLabel1 = new Componentes.CustomLabel();
            TbID = new Componentes.CustomIDTextBox();
            LbID = new Componentes.CustomLabel();
            LbFecha = new Componentes.CustomLabel();
            LbTipelicula = new Componentes.CustomLabel();
            c = new Componentes.CustomLabel();
            Tbvalorpromocion = new Componentes.CustomTextBox();
            DpFechaincio = new Componentes.CustomDatePicker();
            ctb_nombre = new Componentes.CustomTextBox();
            Lbnombre = new Componentes.CustomLabel();
            LbPelicula = new Componentes.CustomLabel();
            ctb_descripcion = new Componentes.CustomTextBox();
            CbPelicula = new Componentes.CustomComboBox();
            customTextBoxestado = new Componentes.CustomComboBox();
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
            DgvFunciones = new Componentes.CustomDataGridView();
            TlpDivFormAndDgv.SuspendLayout();
            TlpAux1.SuspendLayout();
            TlpAux2.SuspendLayout();
            TlpFormWithButtons.SuspendLayout();
            TlpForm.SuspendLayout();
            TlpButtons.SuspendLayout();
            TlpTitleLabel.SuspendLayout();
            TlpAux3.SuspendLayout();
            TlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvFunciones).BeginInit();
            SuspendLayout();
            // 
            // TlpDivFormAndDgv
            // 
            TlpDivFormAndDgv.ColumnCount = 1;
            TlpDivFormAndDgv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Controls.Add(TlpAux1, 0, 0);
            TlpDivFormAndDgv.Controls.Add(DgvFunciones, 0, 1);
            TlpDivFormAndDgv.Dock = DockStyle.Fill;
            TlpDivFormAndDgv.Location = new Point(0, 0);
            TlpDivFormAndDgv.Margin = new Padding(0);
            TlpDivFormAndDgv.Name = "TlpDivFormAndDgv";
            TlpDivFormAndDgv.RowCount = 2;
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 450F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 700);
            TlpDivFormAndDgv.TabIndex = 11;
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
            TlpAux2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 900F));
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
            TlpFormWithButtons.Location = new Point(75, 0);
            TlpFormWithButtons.Margin = new Padding(0);
            TlpFormWithButtons.Name = "TlpFormWithButtons";
            TlpFormWithButtons.RowCount = 2;
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpFormWithButtons.Size = new Size(900, 300);
            TlpFormWithButtons.TabIndex = 0;
            // 
            // TlpForm
            // 
            TlpForm.ColumnCount = 3;
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            TlpForm.Controls.Add(ccb_tipopromocion, 1, 3);
            TlpForm.Controls.Add(customLabel3, 2, 2);
            TlpForm.Controls.Add(customLabel2, 0, 4);
            TlpForm.Controls.Add(cpfinal, 2, 3);
            TlpForm.Controls.Add(customLabel1, 1, 2);
            TlpForm.Controls.Add(TbID, 0, 1);
            TlpForm.Controls.Add(LbID, 0, 0);
            TlpForm.Controls.Add(LbFecha, 2, 0);
            TlpForm.Controls.Add(LbTipelicula, 1, 4);
            TlpForm.Controls.Add(c, 2, 4);
            TlpForm.Controls.Add(Tbvalorpromocion, 2, 5);
            TlpForm.Controls.Add(DpFechaincio, 2, 1);
            TlpForm.Controls.Add(ctb_nombre, 1, 1);
            TlpForm.Controls.Add(Lbnombre, 1, 0);
            TlpForm.Controls.Add(LbPelicula, 0, 2);
            TlpForm.Controls.Add(ctb_descripcion, 0, 3);
            TlpForm.Controls.Add(CbPelicula, 1, 5);
            TlpForm.Controls.Add(customTextBoxestado, 0, 5);
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
            TlpForm.Size = new Size(900, 225);
            TlpForm.TabIndex = 0;
            // 
            // ccb_tipopromocion
            // 
            ccb_tipopromocion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ccb_tipopromocion.BackColor = Color.FromArgb(55, 60, 72);
            ccb_tipopromocion.BaseColor = Color.FromArgb(40, 40, 40);
            ccb_tipopromocion.BGColor = Color.FromArgb(55, 60, 72);
            ccb_tipopromocion.DrawMode = DrawMode.OwnerDrawFixed;
            ccb_tipopromocion.DropDownStyle = ComboBoxStyle.DropDownList;
            ccb_tipopromocion.FlatStyle = FlatStyle.Flat;
            ccb_tipopromocion.Font = new Font("Segoe UI", 9.5F);
            ccb_tipopromocion.ForeColor = Color.FromArgb(230, 230, 230);
            ccb_tipopromocion.FormattingEnabled = true;
            ccb_tipopromocion.HoverColor = Color.Crimson;
            ccb_tipopromocion.HoverFontColor = Color.White;
            ccb_tipopromocion.ItemHeight = 24;
            ccb_tipopromocion.Location = new Point(304, 100);
            ccb_tipopromocion.Margin = new Padding(5, 0, 5, 10);
            ccb_tipopromocion.MinimumSize = new Size(190, 0);
            ccb_tipopromocion.Name = "ccb_tipopromocion";
            ccb_tipopromocion.Size = new Size(290, 30);
            ccb_tipopromocion.TabIndex = 83;
            // 
            // customLabel3
            // 
            customLabel3.AutoSize = true;
            customLabel3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customLabel3.ForeColor = Color.FromArgb(220, 220, 220);
            customLabel3.Location = new Point(602, 75);
            customLabel3.Name = "customLabel3";
            customLabel3.Padding = new Padding(0, 0, 2, 0);
            customLabel3.Size = new Size(98, 23);
            customLabel3.TabIndex = 81;
            customLabel3.Text = "Fecha final";
            customLabel3.TextAlign = ContentAlignment.MiddleRight;
            customLabel3.Click += customLabel3_Click;
            // 
            // customLabel2
            // 
            customLabel2.AutoSize = true;
            customLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customLabel2.ForeColor = Color.FromArgb(220, 220, 220);
            customLabel2.Location = new Point(3, 150);
            customLabel2.Name = "customLabel2";
            customLabel2.Padding = new Padding(0, 0, 2, 0);
            customLabel2.Size = new Size(65, 23);
            customLabel2.TabIndex = 80;
            customLabel2.Text = "Estado";
            customLabel2.TextAlign = ContentAlignment.MiddleRight;
            customLabel2.Click += customLabel2_Click;
            // 
            // cpfinal
            // 
            cpfinal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cpfinal.CustomFormat = "dd/MM/yyyy";
            cpfinal.Format = DateTimePickerFormat.Custom;
            cpfinal.Location = new Point(604, 100);
            cpfinal.Margin = new Padding(5, 0, 5, 10);
            cpfinal.MaximumSize = new Size(0, 30);
            cpfinal.MinimumSize = new Size(190, 30);
            cpfinal.Name = "cpfinal";
            cpfinal.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            cpfinal.Size = new Size(291, 30);
            cpfinal.StateActive.Back.Color1 = Color.FromArgb(55, 60, 72);
            cpfinal.StateActive.Border.Color1 = Color.FromArgb(40, 40, 40);
            cpfinal.StateActive.Border.Color2 = Color.FromArgb(40, 40, 40);
            cpfinal.StateActive.Content.Color1 = Color.FromArgb(230, 230, 230);
            cpfinal.StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            cpfinal.StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            cpfinal.StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);
            cpfinal.StateCommon.Content.Color1 = Color.FromArgb(230, 230, 230);
            cpfinal.TabIndex = 79;
            // 
            // customLabel1
            // 
            customLabel1.AutoSize = true;
            customLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            customLabel1.Location = new Point(302, 75);
            customLabel1.Margin = new Padding(3, 0, 0, 0);
            customLabel1.Name = "customLabel1";
            customLabel1.Padding = new Padding(0, 0, 2, 0);
            customLabel1.Size = new Size(162, 23);
            customLabel1.TabIndex = 78;
            customLabel1.Text = "tipo de promocion";
            customLabel1.TextAlign = ContentAlignment.MiddleRight;
            customLabel1.Click += customLabel1_Click;
            // 
            // TbID
            // 
            TbID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbID.BackColor = Color.FromArgb(28, 30, 38);
            TbID.BorderStyle = BorderStyle.FixedSingle;
            TbID.Font = new Font("Segoe UI", 10F);
            TbID.ForeColor = Color.FromArgb(120, 125, 135);
            TbID.Location = new Point(5, 25);
            TbID.Margin = new Padding(5, 0, 5, 10);
            TbID.MaximumSize = new Size(0, 30);
            TbID.MinimumSize = new Size(190, 30);
            TbID.Name = "TbID";
            TbID.ReadOnly = true;
            TbID.Size = new Size(289, 30);
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
            LbID.Size = new Size(121, 23);
            LbID.TabIndex = 11;
            LbID.Text = "ID Promocion";
            LbID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbFecha
            // 
            LbFecha.AutoSize = true;
            LbFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbFecha.ForeColor = Color.FromArgb(220, 220, 220);
            LbFecha.Location = new Point(602, 0);
            LbFecha.Name = "LbFecha";
            LbFecha.Padding = new Padding(0, 0, 2, 0);
            LbFecha.Size = new Size(105, 23);
            LbFecha.TabIndex = 61;
            LbFecha.Text = "Fecha inicio";
            LbFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbTipelicula
            // 
            LbTipelicula.AutoSize = true;
            LbTipelicula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbTipelicula.ForeColor = Color.FromArgb(220, 220, 220);
            LbTipelicula.Location = new Point(302, 150);
            LbTipelicula.Name = "LbTipelicula";
            LbTipelicula.Padding = new Padding(0, 0, 2, 0);
            LbTipelicula.Size = new Size(72, 23);
            LbTipelicula.TabIndex = 68;
            LbTipelicula.Text = "Pelicula";
            LbTipelicula.TextAlign = ContentAlignment.MiddleRight;
            LbTipelicula.Click += LbTipoDeFuncion_Click;
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            c.ForeColor = Color.FromArgb(220, 220, 220);
            c.Location = new Point(602, 150);
            c.Name = "c";
            c.Padding = new Padding(0, 0, 2, 0);
            c.Size = new Size(170, 23);
            c.TabIndex = 72;
            c.Text = "Valor de promocion";
            c.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tbvalorpromocion
            // 
            Tbvalorpromocion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Tbvalorpromocion.BackColor = Color.FromArgb(55, 60, 72);
            Tbvalorpromocion.BorderStyle = BorderStyle.FixedSingle;
            Tbvalorpromocion.Font = new Font("Segoe UI", 10F);
            Tbvalorpromocion.ForeColor = Color.FromArgb(160, 165, 175);
            Tbvalorpromocion.Location = new Point(604, 175);
            Tbvalorpromocion.Margin = new Padding(5, 0, 5, 10);
            Tbvalorpromocion.MaximumSize = new Size(0, 30);
            Tbvalorpromocion.MinimumSize = new Size(190, 30);
            Tbvalorpromocion.Name = "Tbvalorpromocion";
            Tbvalorpromocion.PlaceholderText = "100";
            Tbvalorpromocion.Size = new Size(291, 30);
            Tbvalorpromocion.TabIndex = 66;
            // 
            // DpFechaincio
            // 
            DpFechaincio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DpFechaincio.CustomFormat = "dd/MM/yyyy";
            DpFechaincio.Format = DateTimePickerFormat.Custom;
            DpFechaincio.Location = new Point(604, 25);
            DpFechaincio.Margin = new Padding(5, 0, 5, 10);
            DpFechaincio.MaximumSize = new Size(0, 30);
            DpFechaincio.MinimumSize = new Size(190, 30);
            DpFechaincio.Name = "DpFechaincio";
            DpFechaincio.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            DpFechaincio.Size = new Size(291, 30);
            DpFechaincio.StateActive.Back.Color1 = Color.FromArgb(55, 60, 72);
            DpFechaincio.StateActive.Border.Color1 = Color.FromArgb(40, 40, 40);
            DpFechaincio.StateActive.Border.Color2 = Color.FromArgb(40, 40, 40);
            DpFechaincio.StateActive.Content.Color1 = Color.FromArgb(230, 230, 230);
            DpFechaincio.StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            DpFechaincio.StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            DpFechaincio.StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);
            DpFechaincio.StateCommon.Content.Color1 = Color.FromArgb(230, 230, 230);
            DpFechaincio.TabIndex = 73;
            // 
            // ctb_nombre
            // 
            ctb_nombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ctb_nombre.BackColor = Color.FromArgb(55, 60, 72);
            ctb_nombre.BorderStyle = BorderStyle.FixedSingle;
            ctb_nombre.Font = new Font("Segoe UI", 10F);
            ctb_nombre.ForeColor = Color.FromArgb(160, 165, 175);
            ctb_nombre.Location = new Point(304, 25);
            ctb_nombre.Margin = new Padding(5, 0, 5, 10);
            ctb_nombre.MaximumSize = new Size(0, 30);
            ctb_nombre.MinimumSize = new Size(190, 30);
            ctb_nombre.Name = "ctb_nombre";
            ctb_nombre.PlaceholderText = "2x1";
            ctb_nombre.Size = new Size(290, 30);
            ctb_nombre.TabIndex = 75;
            // 
            // Lbnombre
            // 
            Lbnombre.AutoSize = true;
            Lbnombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbnombre.ForeColor = Color.FromArgb(220, 220, 220);
            Lbnombre.Location = new Point(302, 0);
            Lbnombre.Name = "Lbnombre";
            Lbnombre.Padding = new Padding(0, 0, 2, 0);
            Lbnombre.Size = new Size(78, 23);
            Lbnombre.TabIndex = 67;
            Lbnombre.Text = "Nombre";
            Lbnombre.TextAlign = ContentAlignment.MiddleRight;
            Lbnombre.Click += LbSala_Click;
            // 
            // LbPelicula
            // 
            LbPelicula.AutoSize = true;
            LbPelicula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbPelicula.ForeColor = Color.FromArgb(220, 220, 220);
            LbPelicula.Location = new Point(3, 75);
            LbPelicula.Margin = new Padding(3, 0, 0, 0);
            LbPelicula.Name = "LbPelicula";
            LbPelicula.Padding = new Padding(0, 0, 2, 0);
            LbPelicula.Size = new Size(105, 23);
            LbPelicula.TabIndex = 12;
            LbPelicula.Text = "Descripcion";
            LbPelicula.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ctb_descripcion
            // 
            ctb_descripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ctb_descripcion.BackColor = Color.FromArgb(55, 60, 72);
            ctb_descripcion.BorderStyle = BorderStyle.FixedSingle;
            ctb_descripcion.Font = new Font("Segoe UI", 10F);
            ctb_descripcion.ForeColor = Color.FromArgb(160, 165, 175);
            ctb_descripcion.Location = new Point(5, 100);
            ctb_descripcion.Margin = new Padding(5, 0, 5, 10);
            ctb_descripcion.MaximumSize = new Size(0, 30);
            ctb_descripcion.MinimumSize = new Size(190, 30);
            ctb_descripcion.Name = "ctb_descripcion";
            ctb_descripcion.PlaceholderText = "...";
            ctb_descripcion.Size = new Size(289, 30);
            ctb_descripcion.TabIndex = 76;
            // 
            // CbPelicula
            // 
            CbPelicula.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbPelicula.BackColor = Color.FromArgb(55, 60, 72);
            CbPelicula.BaseColor = Color.FromArgb(40, 40, 40);
            CbPelicula.BGColor = Color.FromArgb(55, 60, 72);
            CbPelicula.DrawMode = DrawMode.OwnerDrawFixed;
            CbPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPelicula.FlatStyle = FlatStyle.Flat;
            CbPelicula.Font = new Font("Segoe UI", 9.5F);
            CbPelicula.ForeColor = Color.FromArgb(230, 230, 230);
            CbPelicula.FormattingEnabled = true;
            CbPelicula.HoverColor = Color.Crimson;
            CbPelicula.HoverFontColor = Color.White;
            CbPelicula.ItemHeight = 24;
            CbPelicula.Location = new Point(304, 175);
            CbPelicula.Margin = new Padding(5, 0, 5, 10);
            CbPelicula.MinimumSize = new Size(190, 0);
            CbPelicula.Name = "CbPelicula";
            CbPelicula.Size = new Size(290, 30);
            CbPelicula.TabIndex = 63;
            // 
            // customTextBoxestado
            // 
            customTextBoxestado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customTextBoxestado.BackColor = Color.FromArgb(55, 60, 72);
            customTextBoxestado.BaseColor = Color.FromArgb(40, 40, 40);
            customTextBoxestado.BGColor = Color.FromArgb(55, 60, 72);
            customTextBoxestado.DrawMode = DrawMode.OwnerDrawFixed;
            customTextBoxestado.DropDownStyle = ComboBoxStyle.DropDownList;
            customTextBoxestado.FlatStyle = FlatStyle.Flat;
            customTextBoxestado.Font = new Font("Segoe UI", 9.5F);
            customTextBoxestado.ForeColor = Color.FromArgb(230, 230, 230);
            customTextBoxestado.FormattingEnabled = true;
            customTextBoxestado.HoverColor = Color.Crimson;
            customTextBoxestado.HoverFontColor = Color.White;
            customTextBoxestado.ItemHeight = 24;
            customTextBoxestado.Location = new Point(5, 185);
            customTextBoxestado.Margin = new Padding(5);
            customTextBoxestado.MinimumSize = new Size(190, 0);
            customTextBoxestado.Name = "customTextBoxestado";
            customTextBoxestado.Size = new Size(289, 30);
            customTextBoxestado.TabIndex = 84;
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
            TlpButtons.Size = new Size(900, 75);
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
            BtnEliminar.Location = new Point(620, 17);
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
            BtnActualizar.Location = new Point(510, 17);
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
            BtnCopiar.Location = new Point(400, 17);
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
            BtnAgregar.Location = new Point(290, 17);
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
            BtnLimpiar.Location = new Point(180, 17);
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
            LbTitulo.Text = "PROMOCIONES";
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
            // DgvFunciones
            // 
            DgvFunciones.AllowUserToAddRows = false;
            DgvFunciones.AllowUserToResizeColumns = false;
            DgvFunciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(42, 44, 49);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            DgvFunciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvFunciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvFunciones.BackgroundColor = Color.FromArgb(37, 38, 43);
            DgvFunciones.BorderStyle = BorderStyle.None;
            DgvFunciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvFunciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvFunciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(37, 38, 43);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle6.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvFunciones.DefaultCellStyle = dataGridViewCellStyle6;
            DgvFunciones.Dock = DockStyle.Fill;
            DgvFunciones.EnableHeadersVisualStyles = false;
            DgvFunciones.Font = new Font("Segoe UI", 9.5F);
            DgvFunciones.GridColor = Color.FromArgb(58, 60, 66);
            DgvFunciones.Location = new Point(0, 450);
            DgvFunciones.Margin = new Padding(0);
            DgvFunciones.MultiSelect = false;
            DgvFunciones.Name = "DgvFunciones";
            DgvFunciones.ReadOnly = true;
            DgvFunciones.RowHeadersVisible = false;
            DgvFunciones.RowHeadersWidth = 51;
            DgvFunciones.RowTemplate.Height = 36;
            DgvFunciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvFunciones.Size = new Size(1050, 250);
            DgvFunciones.TabIndex = 2;
            // 
            // FrUcPromociones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(TlpDivFormAndDgv);
            Name = "FrUcPromociones";
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
            ((System.ComponentModel.ISupportInitialize)DgvFunciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpDivFormAndDgv;
        private TableLayoutPanel TlpAux1;
        private TableLayoutPanel TlpAux2;
        private TableLayoutPanel TlpFormWithButtons;
        private TableLayoutPanel TlpForm;
        private Componentes.CustomIDTextBox TbID;
        private Componentes.CustomLabel LbID;
        private Componentes.CustomLabel LbPelicula;
        private Componentes.CustomComboBox CbPelicula;
        private Componentes.CustomLabel LbFecha;
        private Componentes.CustomLabel Lbnombre;
        private Componentes.CustomLabel LbTipelicula;
        private Componentes.CustomLabel c;
        private Componentes.CustomTextBox Tbvalorpromocion;
        private Componentes.CustomDatePicker DpFechaincio;
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
        private Componentes.CustomDataGridView DgvFunciones;
        private Componentes.CustomTextBox ctb_nombre;
        private Componentes.CustomTextBox ctb_descripcion;
        private Componentes.CustomLabel customLabel1;
        private Componentes.CustomDatePicker cpfinal;
        private Componentes.CustomLabel customLabel2;
        private Componentes.CustomLabel customLabel3;
        private Componentes.CustomComboBox ccb_tipopromocion;
        private Componentes.CustomComboBox customTextBoxestado;
    }
}
