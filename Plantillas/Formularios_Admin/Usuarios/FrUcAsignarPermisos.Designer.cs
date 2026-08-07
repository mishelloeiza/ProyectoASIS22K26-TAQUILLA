namespace Formularios_Admin
{
    partial class FrUcAsignarPermisos
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
            TlpButtons = new TableLayoutPanel();
            BtnCopiar = new Componentes.CustomButton();
            TlpForm = new TableLayoutPanel();
            BtnLimpiar = new Componentes.CustomButton();
            ListBoxAplicacion = new Componentes.CustomListBox();
            LbPerfil = new Componentes.CustomLabel();
            CbPerfil = new Componentes.CustomComboBox();
            customLabel1 = new Componentes.CustomLabel();
            CbPermiso = new Componentes.CustomComboBox();
            BtnEliminar = new Componentes.CustomButton();
            LbAplicacion = new Componentes.CustomLabel();
            BtnAgregar = new Componentes.CustomButton();
            TlpTitleLabel = new TableLayoutPanel();
            LbTitulo = new Componentes.CustomTitleLabel();
            TlpAux3 = new TableLayoutPanel();
            TlpFilter = new TableLayoutPanel();
            customButton1 = new Componentes.CustomButton();
            customTextBox1 = new Componentes.CustomTextBox();
            CbFiltro = new Componentes.CustomComboBox();
            DgvAsignarPermisos = new Componentes.CustomDataGridView();
            BtnBuscar = new Componentes.CustomButton();
            TbFiltro = new Componentes.CustomTextBox();
            TlpDivFormAndDgv.SuspendLayout();
            TlpAux1.SuspendLayout();
            TlpAux2.SuspendLayout();
            TlpFormWithButtons.SuspendLayout();
            TlpButtons.SuspendLayout();
            TlpForm.SuspendLayout();
            TlpTitleLabel.SuspendLayout();
            TlpAux3.SuspendLayout();
            TlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvAsignarPermisos).BeginInit();
            SuspendLayout();
            // 
            // TlpDivFormAndDgv
            // 
            TlpDivFormAndDgv.ColumnCount = 1;
            TlpDivFormAndDgv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Controls.Add(TlpAux1, 0, 0);
            TlpDivFormAndDgv.Controls.Add(DgvAsignarPermisos, 0, 1);
            TlpDivFormAndDgv.Dock = DockStyle.Fill;
            TlpDivFormAndDgv.Location = new Point(0, 0);
            TlpDivFormAndDgv.Margin = new Padding(0);
            TlpDivFormAndDgv.Name = "TlpDivFormAndDgv";
            TlpDivFormAndDgv.RowCount = 2;
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Absolute, 525F));
            TlpDivFormAndDgv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpDivFormAndDgv.Size = new Size(1050, 750);
            TlpDivFormAndDgv.TabIndex = 8;
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
            TlpAux1.Size = new Size(1050, 525);
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
            TlpAux2.Size = new Size(1050, 375);
            TlpAux2.TabIndex = 0;
            // 
            // TlpFormWithButtons
            // 
            TlpFormWithButtons.ColumnCount = 1;
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpFormWithButtons.Controls.Add(TlpButtons, 0, 1);
            TlpFormWithButtons.Controls.Add(TlpForm, 0, 0);
            TlpFormWithButtons.Dock = DockStyle.Fill;
            TlpFormWithButtons.Location = new Point(75, 0);
            TlpFormWithButtons.Margin = new Padding(0);
            TlpFormWithButtons.Name = "TlpFormWithButtons";
            TlpFormWithButtons.RowCount = 2;
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFormWithButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TlpFormWithButtons.Size = new Size(900, 375);
            TlpFormWithButtons.TabIndex = 0;
            // 
            // TlpButtons
            // 
            TlpButtons.ColumnCount = 6;
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.Controls.Add(BtnLimpiar, 1, 0);
            TlpButtons.Controls.Add(BtnCopiar, 3, 0);
            TlpButtons.Controls.Add(BtnAgregar, 2, 0);
            TlpButtons.Controls.Add(BtnEliminar, 4, 0);
            TlpButtons.Dock = DockStyle.Fill;
            TlpButtons.Location = new Point(0, 300);
            TlpButtons.Margin = new Padding(0);
            TlpButtons.Name = "TlpButtons";
            TlpButtons.RowCount = 1;
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpButtons.Size = new Size(900, 75);
            TlpButtons.TabIndex = 4;
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
            BtnCopiar.Location = new Point(455, 17);
            BtnCopiar.Margin = new Padding(0);
            BtnCopiar.MaximumSize = new Size(100, 40);
            BtnCopiar.MinimumSize = new Size(100, 40);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(100, 40);
            BtnCopiar.TabIndex = 3;
            BtnCopiar.Text = "Copiar";
            BtnCopiar.UseVisualStyleBackColor = false;
            // 
            // TlpForm
            // 
            TlpForm.ColumnCount = 2;
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpForm.Controls.Add(ListBoxAplicacion, 1, 1);
            TlpForm.Controls.Add(LbPerfil, 0, 0);
            TlpForm.Controls.Add(CbPerfil, 0, 1);
            TlpForm.Controls.Add(customLabel1, 0, 2);
            TlpForm.Controls.Add(CbPermiso, 0, 3);
            TlpForm.Controls.Add(LbAplicacion, 1, 0);
            TlpForm.Dock = DockStyle.Fill;
            TlpForm.Location = new Point(0, 0);
            TlpForm.Margin = new Padding(0);
            TlpForm.Name = "TlpForm";
            TlpForm.RowCount = 8;
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TlpForm.Size = new Size(900, 300);
            TlpForm.TabIndex = 0;
            TlpForm.Paint += TlpForm_Paint;
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
            BtnLimpiar.Location = new Point(235, 17);
            BtnLimpiar.Margin = new Padding(0);
            BtnLimpiar.MaximumSize = new Size(100, 40);
            BtnLimpiar.MinimumSize = new Size(100, 40);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(100, 40);
            BtnLimpiar.TabIndex = 2;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // ListBoxAplicacion
            // 
            ListBoxAplicacion.Dock = DockStyle.Fill;
            ListBoxAplicacion.Location = new Point(455, 25);
            ListBoxAplicacion.Margin = new Padding(5, 0, 5, 10);
            ListBoxAplicacion.Name = "ListBoxAplicacion";
            TlpForm.SetRowSpan(ListBoxAplicacion, 6);
            ListBoxAplicacion.SelectionMode = SelectionMode.MultiSimple;
            ListBoxAplicacion.Size = new Size(440, 265);
            ListBoxAplicacion.StateCheckedNormal.Item.Back.Color1 = Color.Crimson;
            ListBoxAplicacion.StateCheckedNormal.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxAplicacion.StateCheckedNormal.Item.Content.LongText.Font = new Font("Segoe UI", 8.5F);
            ListBoxAplicacion.StateCheckedNormal.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxAplicacion.StateCheckedNormal.Item.Content.ShortText.Font = new Font("Segoe UI", 8.5F);
            ListBoxAplicacion.StateCheckedTracking.Item.Back.Color1 = Color.Crimson;
            ListBoxAplicacion.StateCheckedTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxAplicacion.StateCheckedTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxAplicacion.StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            ListBoxAplicacion.StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            ListBoxAplicacion.StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);
            ListBoxAplicacion.StateCommon.Item.Back.Color1 = Color.FromArgb(55, 60, 72);
            ListBoxAplicacion.StateCommon.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxAplicacion.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxAplicacion.StateTracking.Item.Back.Color1 = Color.Crimson;
            ListBoxAplicacion.StateTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxAplicacion.StateTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            ListBoxAplicacion.TabIndex = 70;
            // 
            // LbPerfil
            // 
            LbPerfil.AutoSize = true;
            LbPerfil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbPerfil.ForeColor = Color.FromArgb(220, 220, 220);
            LbPerfil.Location = new Point(3, 0);
            LbPerfil.Margin = new Padding(3, 0, 0, 0);
            LbPerfil.Name = "LbPerfil";
            LbPerfil.Padding = new Padding(0, 0, 2, 0);
            LbPerfil.Size = new Size(54, 23);
            LbPerfil.TabIndex = 12;
            LbPerfil.Text = "Perfil";
            LbPerfil.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbPerfil
            // 
            CbPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbPerfil.BackColor = Color.FromArgb(55, 60, 72);
            CbPerfil.BaseColor = Color.FromArgb(40, 40, 40);
            CbPerfil.BGColor = Color.FromArgb(55, 60, 72);
            CbPerfil.DrawMode = DrawMode.OwnerDrawFixed;
            CbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPerfil.FlatStyle = FlatStyle.Flat;
            CbPerfil.Font = new Font("Segoe UI", 9.5F);
            CbPerfil.ForeColor = Color.FromArgb(230, 230, 230);
            CbPerfil.FormattingEnabled = true;
            CbPerfil.HoverColor = Color.Crimson;
            CbPerfil.HoverFontColor = Color.White;
            CbPerfil.ItemHeight = 24;
            CbPerfil.Location = new Point(5, 25);
            CbPerfil.Margin = new Padding(5, 0, 5, 10);
            CbPerfil.MinimumSize = new Size(190, 0);
            CbPerfil.Name = "CbPerfil";
            CbPerfil.Size = new Size(440, 30);
            CbPerfil.TabIndex = 73;
            // 
            // customLabel1
            // 
            customLabel1.AutoSize = true;
            customLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            customLabel1.Location = new Point(3, 75);
            customLabel1.Name = "customLabel1";
            customLabel1.Padding = new Padding(0, 0, 2, 0);
            customLabel1.Size = new Size(75, 23);
            customLabel1.TabIndex = 74;
            customLabel1.Text = "Permiso";
            customLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbPermiso
            // 
            CbPermiso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbPermiso.BackColor = Color.FromArgb(55, 60, 72);
            CbPermiso.BaseColor = Color.FromArgb(40, 40, 40);
            CbPermiso.BGColor = Color.FromArgb(55, 60, 72);
            CbPermiso.DrawMode = DrawMode.OwnerDrawFixed;
            CbPermiso.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPermiso.FlatStyle = FlatStyle.Flat;
            CbPermiso.Font = new Font("Segoe UI", 9.5F);
            CbPermiso.ForeColor = Color.FromArgb(230, 230, 230);
            CbPermiso.FormattingEnabled = true;
            CbPermiso.HoverColor = Color.Crimson;
            CbPermiso.HoverFontColor = Color.White;
            CbPermiso.ItemHeight = 24;
            CbPermiso.Location = new Point(5, 100);
            CbPermiso.Margin = new Padding(5, 0, 5, 10);
            CbPermiso.MinimumSize = new Size(190, 0);
            CbPermiso.Name = "CbPermiso";
            CbPermiso.Size = new Size(440, 30);
            CbPermiso.TabIndex = 75;
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
            BtnEliminar.Location = new Point(565, 17);
            BtnEliminar.Margin = new Padding(0);
            BtnEliminar.MaximumSize = new Size(100, 40);
            BtnEliminar.MinimumSize = new Size(100, 40);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 40);
            BtnEliminar.TabIndex = 4;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // LbAplicacion
            // 
            LbAplicacion.AutoSize = true;
            LbAplicacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LbAplicacion.ForeColor = Color.FromArgb(220, 220, 220);
            LbAplicacion.Location = new Point(453, 0);
            LbAplicacion.Margin = new Padding(3, 0, 0, 0);
            LbAplicacion.Name = "LbAplicacion";
            LbAplicacion.Padding = new Padding(0, 0, 2, 0);
            LbAplicacion.Size = new Size(111, 23);
            LbAplicacion.TabIndex = 69;
            LbAplicacion.Text = "Aplicaciones";
            LbAplicacion.TextAlign = ContentAlignment.MiddleLeft;
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
            BtnAgregar.Location = new Point(345, 17);
            BtnAgregar.Margin = new Padding(0);
            BtnAgregar.MaximumSize = new Size(100, 40);
            BtnAgregar.MinimumSize = new Size(100, 40);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(100, 40);
            BtnAgregar.TabIndex = 5;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
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
            LbTitulo.Text = "ASIGNAR PERMISOS";
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
            TlpAux3.Location = new Point(0, 450);
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
            TlpFilter.Controls.Add(customButton1, 2, 0);
            TlpFilter.Controls.Add(customTextBox1, 1, 0);
            TlpFilter.Controls.Add(CbFiltro, 0, 0);
            TlpFilter.Dock = DockStyle.Fill;
            TlpFilter.Location = new Point(270, 0);
            TlpFilter.Margin = new Padding(0);
            TlpFilter.Name = "TlpFilter";
            TlpFilter.RowCount = 1;
            TlpFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFilter.Size = new Size(510, 75);
            TlpFilter.TabIndex = 1;
            // 
            // customButton1
            // 
            customButton1.Action = Componentes.ButtonAction.Buscar;
            customButton1.Anchor = AnchorStyles.None;
            customButton1.BackColor = Color.FromArgb(39, 174, 96);
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 104, 57);
            customButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 186, 103);
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(405, 17);
            customButton1.Margin = new Padding(0);
            customButton1.MaximumSize = new Size(100, 40);
            customButton1.MinimumSize = new Size(100, 40);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(100, 40);
            customButton1.TabIndex = 5;
            customButton1.Text = "Buscar";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customTextBox1
            // 
            customTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customTextBox1.BackColor = Color.FromArgb(55, 60, 72);
            customTextBox1.BorderStyle = BorderStyle.FixedSingle;
            customTextBox1.Font = new Font("Segoe UI", 10F);
            customTextBox1.ForeColor = Color.FromArgb(230, 230, 230);
            customTextBox1.Location = new Point(205, 22);
            customTextBox1.Margin = new Padding(5);
            customTextBox1.MaximumSize = new Size(0, 30);
            customTextBox1.MinimumSize = new Size(190, 30);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Size = new Size(190, 30);
            customTextBox1.TabIndex = 7;
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
            // DgvAsignarPermisos
            // 
            DgvAsignarPermisos.AllowUserToAddRows = false;
            DgvAsignarPermisos.AllowUserToResizeColumns = false;
            DgvAsignarPermisos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(42, 44, 49);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            DgvAsignarPermisos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvAsignarPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvAsignarPermisos.BackgroundColor = Color.FromArgb(37, 38, 43);
            DgvAsignarPermisos.BorderStyle = BorderStyle.None;
            DgvAsignarPermisos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvAsignarPermisos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(45, 47, 52);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvAsignarPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvAsignarPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(37, 38, 43);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle6.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(178, 44, 48);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvAsignarPermisos.DefaultCellStyle = dataGridViewCellStyle6;
            DgvAsignarPermisos.Dock = DockStyle.Fill;
            DgvAsignarPermisos.EnableHeadersVisualStyles = false;
            DgvAsignarPermisos.Font = new Font("Segoe UI", 9.5F);
            DgvAsignarPermisos.GridColor = Color.FromArgb(58, 60, 66);
            DgvAsignarPermisos.Location = new Point(0, 525);
            DgvAsignarPermisos.Margin = new Padding(0);
            DgvAsignarPermisos.MultiSelect = false;
            DgvAsignarPermisos.Name = "DgvAsignarPermisos";
            DgvAsignarPermisos.ReadOnly = true;
            DgvAsignarPermisos.RowHeadersVisible = false;
            DgvAsignarPermisos.RowHeadersWidth = 51;
            DgvAsignarPermisos.RowTemplate.Height = 36;
            DgvAsignarPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvAsignarPermisos.Size = new Size(1050, 225);
            DgvAsignarPermisos.TabIndex = 2;
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
            // FrUcAsignarPermisos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(TlpDivFormAndDgv);
            MinimumSize = new Size(1050, 750);
            Name = "FrUcAsignarPermisos";
            Size = new Size(1050, 750);
            TlpDivFormAndDgv.ResumeLayout(false);
            TlpAux1.ResumeLayout(false);
            TlpAux2.ResumeLayout(false);
            TlpFormWithButtons.ResumeLayout(false);
            TlpButtons.ResumeLayout(false);
            TlpForm.ResumeLayout(false);
            TlpForm.PerformLayout();
            TlpTitleLabel.ResumeLayout(false);
            TlpTitleLabel.PerformLayout();
            TlpAux3.ResumeLayout(false);
            TlpFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvAsignarPermisos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpDivFormAndDgv;
        private TableLayoutPanel TlpAux1;
        private TableLayoutPanel TlpAux2;
        private TableLayoutPanel TlpFormWithButtons;
        private TableLayoutPanel TlpForm;
        private Componentes.CustomLabel LbPerfil;
        private Componentes.CustomButton BtnAgregar;
        private TableLayoutPanel TlpTitleLabel;
        private Componentes.CustomTitleLabel LbTitulo;
        private TableLayoutPanel TlpAux3;
        private Componentes.CustomButton BtnBuscar;
        private Componentes.CustomListBox ListBoxAplicacion;
        private Componentes.CustomComboBox CbPerfil;
        private Componentes.CustomTextBox TbFiltro;
        private Componentes.CustomLabel LbAplicacion;
        private TableLayoutPanel TlpFilter;
        private Componentes.CustomButton customButton1;
        private Componentes.CustomTextBox customTextBox1;
        private Componentes.CustomComboBox CbFiltro;
        private TableLayoutPanel TlpButtons;
        private Componentes.CustomButton BtnEliminar;
        private Componentes.CustomButton BtnLimpiar;
        private Componentes.CustomLabel customLabel1;
        private Componentes.CustomComboBox CbPermiso;
        private Componentes.CustomButton BtnCopiar;
        private Componentes.CustomDataGridView DgvAsignarPermisos;
    }
}
