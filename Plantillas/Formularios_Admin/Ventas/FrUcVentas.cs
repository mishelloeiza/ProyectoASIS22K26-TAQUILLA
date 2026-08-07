/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Con_Admin;

namespace Forms_Admin.Ventas
{
    public partial class FrUcVentas : UserControl
    {
        private readonly If_Ventas api = new If_Ventas();
        private DataTable tablaVentas;

        public FrUcVentas()
        {
            InitializeComponent();
            WireEvents();
            CargarCombos();
            CargarFiltro();
            CargarGrilla();
            ModoAgregar();
        }

        private void WireEvents()
        {
            BtnAgregar.Click += BtnAgregar_Click;
            BtnActualizar.Click += BtnActualizar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnLimpiar.Click += BtnLimpiar_Click;
            BtnCopiar.Click += BtnCopiar_Click;
            BtnBuscar.Click += BtnBuscar_Click;
            BtnBuscarCliente.Click += BtnBuscarCliente_Click;
            BtnBuscarUsuario.Click += BtnBuscarUsuario_Click;
        }

        private void CargarCombos()
        {
            CbMetodoDePago.DataSource = api.ListarMetodosPago();
            CbMetodoDePago.DisplayMember = "Nombre";
            CbMetodoDePago.ValueMember = "Id";
            CbMetodoDePago.SelectedIndex = -1;

            CbPromocion.DataSource = api.ListarPromociones();
            CbPromocion.DisplayMember = "Nombre";
            CbPromocion.ValueMember = "Id";
            CbPromocion.SelectedIndex = -1;
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Cliente");
            CbFiltro.Items.Add("Usuario");
            CbFiltro.Items.Add("Método de pago");
            CbFiltro.SelectedIndex = 0;
        }

        private void CargarGrilla()
        {
            tablaVentas = api.Listar();
            DgvVentas.DataSource = tablaVentas;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvVentas.Columns.Count == 0) return;

            Ocultar("id_promocion");
            Ocultar("id_metodo_pago");

            Encabezado("id_venta", "ID");
            Encabezado("id_cliente", "Cliente");
            Encabezado("id_usuario", "Usuario");
            Encabezado("fecha_hora_venta", "Fecha / Hora");
            Encabezado("cantidad_boletos_venta", "Boletos");
            Encabezado("total_venta", "Total");
            Encabezado("nombre_metodo_pago", "Método de pago");
            Encabezado("nombre_promocion", "Promoción");
        }

        private void Ocultar(string columna)
        {
            if (DgvVentas.Columns.Contains(columna))
                DgvVentas.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvVentas.Columns.Contains(columna))
                DgvVentas.Columns[columna].HeaderText = texto;
        }

        private void ModoAgregar()
        {
            LimpiarCampos();
            TbID.Text = api.ObtenerSiguienteId().ToString();
            BtnAgregar.Enabled = true;
            BtnCopiar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ModoEdicion()
        {
            BtnAgregar.Enabled = false;
            BtnCopiar.Enabled = true;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void LimpiarCampos()
        {
            TbID.Clear();
            TbIdCliente.Clear();
            TbIdUsuario.Clear();
            TbTotalDeVenta.Clear();
            RtbDatosCliente.Clear();
            RtbDatosUsuario.Clear();
            CbMetodoDePago.SelectedIndex = -1;
            CbPromocion.SelectedIndex = -1;
            DatePickerFecha.Value = DateTime.Today;
        }

        // ---------------- Lectura de campos ----------------

        private int? LeerIdCliente()
        {
            return int.TryParse(TbIdCliente.Text.Trim(), out int v) && v > 0 ? (int?)v : null;
        }

        private int LeerIdUsuario()
        {
            return int.TryParse(TbIdUsuario.Text.Trim(), out int v) ? v : 0;
        }

        private int? LeerPromocion()
        {
            return IdDe(CbPromocion.SelectedValue);
        }

        private int LeerMetodoPago()
        {
            return IdDe(CbMetodoDePago.SelectedValue) ?? 0;
        }

        private decimal LeerTotal()
        {
            return decimal.TryParse(TbTotalDeVenta.Text.Trim(), out decimal v) ? v : 0m;
        }

        // Combina la fecha del DatePicker con la hora del TimePicker (texto "HH:mm" o "HHmm").
        private DateTime LeerFechaHora()
        {
            DateTime fecha = DatePickerFecha.Value.Date;
            string hora = TimePickerHora.Text.Trim();

            if (TimeSpan.TryParseExact(hora, "hh\\:mm", CultureInfo.InvariantCulture, out TimeSpan ts) ||
                TimeSpan.TryParse(hora, CultureInfo.InvariantCulture, out ts))
                return fecha + ts;

            return fecha;
        }

        private static int? IdDe(object valor)
        {
            if (valor == null || valor is DBNull) return null;
            if (valor is int i) return i;
            return int.TryParse(valor.ToString(), out int r) ? (int?)r : (int?)null;
        }

        private bool Validar()
        {
            if (LeerIdUsuario() <= 0)
            {
                MessageBox.Show("Indica un usuario válido (usa Buscar).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbIdUsuario.Focus();
                return false;
            }
            if (LeerMetodoPago() <= 0)
            {
                MessageBox.Show("Selecciona un método de pago.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbMetodoDePago.Focus();
                return false;
            }
            if (LeerTotal() <= 0)
            {
                MessageBox.Show("El total debe ser mayor que cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbTotalDeVenta.Focus();
                return false;
            }
            return true;
        }

        // ---------------- Buscar cliente / usuario ----------------

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbIdCliente.Text.Trim(), out int id) || id <= 0)
            {
                MessageBox.Show("Escribe un ID de cliente.", "Buscar cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = api.ObtenerCliente(id);
                RtbDatosCliente.Text = dt.Rows.Count == 0
                    ? "Cliente no encontrado."
                    : FormatearDatos(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo buscar el cliente.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbIdUsuario.Text.Trim(), out int id) || id <= 0)
            {
                MessageBox.Show("Escribe un ID de usuario.", "Buscar usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = api.ObtenerUsuario(id);
                RtbDatosUsuario.Text = dt.Rows.Count == 0
                    ? "Usuario no encontrado."
                    : FormatearDatos(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo buscar el usuario.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string FormatearDatos(DataRow row)
        {
            var sb = new System.Text.StringBuilder();
            foreach (DataColumn col in row.Table.Columns)
                sb.AppendLine(col.ColumnName + ": " + row[col].ToString());
            return sb.ToString();
        }

        // ---------------- CRUD ----------------

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                int nuevo = api.Insertar(LeerIdCliente(), LeerPromocion(), LeerIdUsuario(),
                    LeerMetodoPago(), LeerFechaHora(), 0, LeerTotal());
                MessageBox.Show("Venta agregada correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la venta.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una venta de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerIdCliente(), LeerPromocion(), LeerIdUsuario(),
                    LeerMetodoPago(), LeerFechaHora(), 0, LeerTotal());
                MessageBox.Show(ok ? "Venta actualizada correctamente." : "No se encontró la venta.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la venta.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una venta de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show("¿Seguro que deseas eliminar la venta " + id + "?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Venta eliminada." : "No se encontró la venta.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("No se puede eliminar: la venta tiene boletos asociados.",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la venta.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvVentas.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una venta de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvVentas.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            TbID.Text = row["id_venta"].ToString();
            TbIdCliente.Text = row["id_cliente"] == DBNull.Value ? "" : row["id_cliente"].ToString();
            TbIdUsuario.Text = row["id_usuario"] == DBNull.Value ? "" : row["id_usuario"].ToString();
            TbTotalDeVenta.Text = row["total_venta"] == DBNull.Value ? "" : row["total_venta"].ToString();

            CbMetodoDePago.SelectedValue = row["id_metodo_pago"] == DBNull.Value ? -1 : row["id_metodo_pago"];
            CbPromocion.SelectedValue = row["id_promocion"] == DBNull.Value ? -1 : row["id_promocion"];

            if (row["fecha_hora_venta"] != DBNull.Value)
            {
                DateTime fh = Convert.ToDateTime(row["fecha_hora_venta"]);
                DatePickerFecha.Value = fh.Date;
                TimePickerHora.Text = fh.ToString("HH:mm");
            }

            RtbDatosCliente.Clear();
            RtbDatosUsuario.Clear();

            DgvVentas.Focus();
        }

        // ---------------- Filtro ----------------

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaVentas == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaVentas.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_venta" || columna == "id_cliente" || columna == "id_usuario")
                tablaVentas.DefaultView.RowFilter =
                    "Convert(" + columna + ", 'System.String') LIKE '%" + texto + "%'";
            else
                tablaVentas.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "ID" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "Cliente": return "id_cliente";
                case "Usuario": return "id_usuario";
                case "Método de pago": return "nombre_metodo_pago";
                default: return "id_venta";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbFiltro.Clear();
            CargarGrilla();
            ModoAgregar();
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */