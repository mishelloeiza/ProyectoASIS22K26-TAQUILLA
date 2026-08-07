namespace Forms_Admin.Funciones
{
    partial class FrUcFunciones
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
            TbID = new Componentes.CustomIDTextBox();
            LbID = new Componentes.CustomLabel();
            LbFecha = new Componentes.CustomLabel();
            CbSala = new Componentes.CustomComboBox();
            LbSala = new Componentes.CustomLabel();
            LbHora = new Componentes.CustomLabel();
            DatePickerFecha = new Componentes.CustomDatePicker();
            TimePickerHora = new Componentes.CustomTimePicker();
            LbPelicula = new Componentes.CustomLabel();
            CbPelicula = new Componentes.CustomComboBox();
            LbPrecioDeFuncion = new Componentes.CustomLabel();
            TbPrecioFuncion = new Componentes.CustomTextBox();
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
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 375F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 700);
            TlpDivFormAndDgv.TabIndex = 10;
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
            TlpAux1.Size = new Size(1050, 375);
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
            TlpAux2.Size = new Size(1050, 225);
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
            TlpFormWithButtons.Size = new Size(900, 225);
            TlpFormWithButtons.TabIndex = 0;
            // 
            // TlpForm
            // 
            TlpForm.ColumnCount = 3;
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            TlpForm.Controls.Add(TbID, 0, 1);
            TlpForm.Controls.Add(LbID, 0, 0);
            TlpForm.Controls.Add(LbFecha, 2, 0);
            TlpForm.Controls.Add(CbSala, 1, 3);
            TlpForm.Controls.Add(LbSala, 1, 2);
            TlpForm.Controls.Add(LbHora, 2, 2);
            TlpForm.Controls.Add(DatePickerFecha, 2, 1);
            TlpForm.Controls.Add(TimePickerHora, 2, 3);
            TlpForm.Controls.Add(LbPelicula, 0, 2);
            TlpForm.Controls.Add(CbPelicula, 0, 3);
            TlpForm.Controls.Add(LbPrecioDeFuncion, 1, 0);
            TlpForm.Controls.Add(TbPrecioFuncion, 1, 1);
            TlpForm.Dock = DockStyle.Fill;
            TlpForm.Location = new Point(0, 0);
            TlpForm.Margin = new Padding(0);
            TlpForm.Name = "TlpForm";
            TlpForm.RowCount = 10;
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.Size = new Size(900, 150);
            TlpForm.TabIndex = 0;
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
            LbID.Size = new Size(97, 23);
            LbID.TabIndex = 11;
            LbID.Text = "ID Funcion";
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
            LbFecha.Size = new Size(57, 23);
            LbFecha.TabIndex = 61;
            LbFecha.Text = "Fecha";
            LbFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbSala
            // 
            CbSala.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbSala.BackColor = Color.FromArgb(55, 60, 72);
            CbSala.BaseColor = Color.FromArgb(40, 40, 40);
            CbSala.BGColor = Color.FromArgb(55, 60, 72);
            CbSala.DrawMode = DrawMode.OwnerDrawFixed;
            CbSala.DropDownStyle = ComboBoxStyle.DropDownList;
            CbSala.FlatStyle = FlatStyle.Flat;
            CbSala.Font = new Font("Segoe UI", 9.5F);
            CbSala.ForeColor = Color.FromArgb(230, 230, 230);
            CbSala.FormattingEnabled = true;
            CbSala.HoverColor = Color.Crimson;
            CbSala.HoverFontColor = Color.White;
            CbSala.ItemHeight = 24;
            CbSala.Location = new Point(304, 100);
            CbSala.Margin = new Padding(5, 0, 5, 10);
            CbSala.MinimumSize = new Size(190, 0);
            CbSala.Name = "CbSala";
            CbSala.Size = new Size(290, 30);
            CbSala.TabIndex = 64;
            // 
            // LbSala
            // 
            LbSala.AutoSize = true;
            LbSala.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbSala.ForeColor = Color.FromArgb(220, 220, 220);
            LbSala.Location = new Point(302, 75);
            LbSala.Name = "LbSala";
            LbSala.Padding = new Padding(0, 0, 2, 0);
            LbSala.Size = new Size(45, 23);
            LbSala.TabIndex = 67;
            LbSala.Text = "Sala";
            LbSala.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbHora
            // 
            LbHora.AutoSize = true;
            LbHora.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbHora.ForeColor = Color.FromArgb(220, 220, 220);
            LbHora.Location = new Point(602, 75);
            LbHora.Name = "LbHora";
            LbHora.Padding = new Padding(0, 0, 2, 0);
            LbHora.Size = new Size(51, 23);
            LbHora.TabIndex = 71;
            LbHora.Text = "Hora";
            LbHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DatePickerFecha
            // 
            DatePickerFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DatePickerFecha.CustomFormat = "dd/MM/yyyy";
            DatePickerFecha.Format = DateTimePickerFormat.Custom;
            DatePickerFecha.Location = new Point(604, 25);
            DatePickerFecha.Margin = new Padding(5, 0, 5, 10);
            DatePickerFecha.MaximumSize = new Size(0, 30);
            DatePickerFecha.MinimumSize = new Size(190, 30);
            DatePickerFecha.Name = "DatePickerFecha";
            DatePickerFecha.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            DatePickerFecha.Size = new Size(291, 30);
            DatePickerFecha.StateActive.Back.Color1 = Color.FromArgb(55, 60, 72);
            DatePickerFecha.StateActive.Border.Color1 = Color.FromArgb(40, 40, 40);
            DatePickerFecha.StateActive.Border.Color2 = Color.FromArgb(40, 40, 40);
            DatePickerFecha.StateActive.Content.Color1 = Color.FromArgb(230, 230, 230);
            DatePickerFecha.StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            DatePickerFecha.StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            DatePickerFecha.StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);
            DatePickerFecha.StateCommon.Content.Color1 = Color.FromArgb(230, 230, 230);
            DatePickerFecha.TabIndex = 73;
            // 
            // TimePickerHora
            // 
            TimePickerHora.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TimePickerHora.BackColor = Color.FromArgb(55, 60, 72);
            TimePickerHora.BorderStyle = BorderStyle.FixedSingle;
            TimePickerHora.Font = new Font("Segoe UI", 11F);
            TimePickerHora.ForeColor = Color.FromArgb(230, 230, 230);
            TimePickerHora.Location = new Point(604, 100);
            TimePickerHora.Margin = new Padding(5, 0, 5, 10);
            TimePickerHora.Mask = "00:00";
            TimePickerHora.MaximumSize = new Size(0, 30);
            TimePickerHora.MinimumSize = new Size(190, 30);
            TimePickerHora.Name = "TimePickerHora";
            TimePickerHora.Size = new Size(291, 30);
            TimePickerHora.TabIndex = 74;
            TimePickerHora.Text = "1200";
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
            LbPelicula.Size = new Size(72, 23);
            LbPelicula.TabIndex = 12;
            LbPelicula.Text = "Película";
            LbPelicula.TextAlign = ContentAlignment.MiddleRight;
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
            CbPelicula.Location = new Point(5, 100);
            CbPelicula.Margin = new Padding(5, 0, 5, 10);
            CbPelicula.MinimumSize = new Size(190, 0);
            CbPelicula.Name = "CbPelicula";
            CbPelicula.Size = new Size(289, 30);
            CbPelicula.TabIndex = 63;
            // 
            // LbPrecioDeFuncion
            // 
            LbPrecioDeFuncion.AutoSize = true;
            LbPrecioDeFuncion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbPrecioDeFuncion.ForeColor = Color.FromArgb(220, 220, 220);
            LbPrecioDeFuncion.Location = new Point(302, 0);
            LbPrecioDeFuncion.Name = "LbPrecioDeFuncion";
            LbPrecioDeFuncion.Padding = new Padding(0, 0, 2, 0);
            LbPrecioDeFuncion.Size = new Size(153, 23);
            LbPrecioDeFuncion.TabIndex = 72;
            LbPrecioDeFuncion.Text = "Precio de Función";
            LbPrecioDeFuncion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbPrecioFuncion
            // 
            TbPrecioFuncion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbPrecioFuncion.BackColor = Color.FromArgb(55, 60, 72);
            TbPrecioFuncion.BorderStyle = BorderStyle.FixedSingle;
            TbPrecioFuncion.Font = new Font("Segoe UI", 10F);
            TbPrecioFuncion.ForeColor = Color.FromArgb(160, 165, 175);
            TbPrecioFuncion.Location = new Point(304, 25);
            TbPrecioFuncion.Margin = new Padding(5, 0, 5, 10);
            TbPrecioFuncion.MaximumSize = new Size(0, 30);
            TbPrecioFuncion.MinimumSize = new Size(190, 30);
            TbPrecioFuncion.Name = "TbPrecioFuncion";
            TbPrecioFuncion.PlaceholderText = "1";
            TbPrecioFuncion.Size = new Size(290, 30);
            TbPrecioFuncion.TabIndex = 66;
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
            TlpButtons.Location = new Point(0, 150);
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
            LbTitulo.Text = "FUNCIONES";
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
            TlpAux3.Location = new Point(0, 300);
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 44, 49);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DgvFunciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvFunciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvFunciones.BackgroundColor = Color.FromArgb(37, 38, 43);
            DgvFunciones.BorderStyle = BorderStyle.None;
            DgvFunciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvFunciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvFunciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 38, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvFunciones.DefaultCellStyle = dataGridViewCellStyle3;
            DgvFunciones.Dock = DockStyle.Fill;
            DgvFunciones.EnableHeadersVisualStyles = false;
            DgvFunciones.Font = new Font("Segoe UI", 9.5F);
            DgvFunciones.GridColor = Color.FromArgb(58, 60, 66);
            DgvFunciones.Location = new Point(0, 375);
            DgvFunciones.Margin = new Padding(0);
            DgvFunciones.MultiSelect = false;
            DgvFunciones.Name = "DgvFunciones";
            DgvFunciones.ReadOnly = true;
            DgvFunciones.RowHeadersVisible = false;
            DgvFunciones.RowHeadersWidth = 51;
            DgvFunciones.RowTemplate.Height = 36;
            DgvFunciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvFunciones.Size = new Size(1050, 325);
            DgvFunciones.TabIndex = 2;
            // 
            // FrUcFunciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(TlpDivFormAndDgv);
            Name = "FrUcFunciones";
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
        private Componentes.CustomComboBox CbSala;
        private Componentes.CustomTextBox TbPrecioFuncion;
        private Componentes.CustomLabel LbSala;
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
        private Componentes.CustomLabel LbHora;
        private Componentes.CustomLabel LbPrecioDeFuncion;
        private Componentes.CustomDatePicker DatePickerFecha;
        private Componentes.CustomTimePicker TimePickerHora;
        private Componentes.CustomDataGridView DgvFunciones;
    }
}
