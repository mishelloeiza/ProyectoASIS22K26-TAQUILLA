/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Data;
using System.Windows.Forms;
using Con_Admin;

namespace Forms_Admin.Ventas
{
    public partial class FrUcBoletos : UserControl
    {
        private readonly If_Boletos api = new If_Boletos();
        private DataTable tablaBoletos;

        public FrUcBoletos()
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
            BtnBuscarFuncion.Click += BtnBuscarFuncion_Click;
            BtnBuscarVenta.Click += BtnBuscarVenta_Click;
            TbAsientoCodificado.Leave += TbAsientoCodificado_Leave;
        }

        private void CargarCombos()
        {
            CbEstado.DataSource = api.ListarEstados();
            CbEstado.DisplayMember = "Nombre";
            CbEstado.ValueMember = "Id";
            CbEstado.SelectedIndex = -1;
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Venta");
            CbFiltro.Items.Add("Función");
            CbFiltro.Items.Add("Estado");
            CbFiltro.Items.Add("Asiento");
            CbFiltro.SelectedIndex = 0;
        }

        private void CargarGrilla()
        {
            tablaBoletos = api.Listar();
            DgvBoletos.DataSource = tablaBoletos;
            FormatearGrilla();
        }


        private void FormatearGrilla()
        {
            if (DgvBoletos.Columns.Count == 0) return;

            Ocultar("id_venta");
            Ocultar("id_funcion");
            Ocultar("id_estado_boleto");

            Encabezado("id_boleto", "ID");
            Encabezado("numero_boleto", "Boleto");
            Encabezado("nombre_estado_boleto", "Estado");
            Encabezado("titulo_pelicula", "Película");
            Encabezado("fecha_funcion", "Función");
        }

        private void Ocultar(string columna)
        {
            if (DgvBoletos.Columns.Contains(columna))
                DgvBoletos.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvBoletos.Columns.Contains(columna))
                DgvBoletos.Columns[columna].HeaderText = texto;
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
            TbIdVenta.Clear();
            TbIdFuncion.Clear();
            TbAsientoCodificado.Clear();
            TbAsientoDecodificado.Clear();
            RtbDatosVenta.Clear();
            RtbDatosFuncion.Clear();
            CbEstado.SelectedIndex = -1;
        }


        private int LeerIdVenta()
        {
            return int.TryParse(TbIdVenta.Text.Trim(), out int v) ? v : 0;
        }

        private int LeerIdFuncion()
        {
            return int.TryParse(TbIdFuncion.Text.Trim(), out int v) ? v : 0;
        }

        private int LeerEstado()
        {
            return IdDe(CbEstado.SelectedValue) ?? 0;
        }

        private int LeerAsiento()
        {
            return int.TryParse(TbAsientoCodificado.Text.Trim(), out int v) ? v : 0;
        }

        private static int? IdDe(object valor)
        {
            if (valor == null || valor is DBNull) return null;
            if (valor is int i) return i;
            return int.TryParse(valor.ToString(), out int r) ? (int?)r : (int?)null;
        }

        private bool Validar()
        {
            if (LeerIdVenta() <= 0)
            {
                MessageBox.Show("Indica una venta válida (usa Buscar).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbIdVenta.Focus();
                return false;
            }
            if (LeerIdFuncion() <= 0)
            {
                MessageBox.Show("Indica una función válida (usa Buscar).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbIdFuncion.Focus();
                return false;
            }
            if (LeerEstado() <= 0)
            {
                MessageBox.Show("Selecciona un estado.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbEstado.Focus();
                return false;
            }
            if (LeerAsiento() <= 0)
            {
                MessageBox.Show("El número de asiento debe ser mayor que cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbAsientoCodificado.Focus();
                return false;
            }
            return true;
        }


        private void BtnBuscarFuncion_Click(object sender, EventArgs e)
        {
            int id = LeerIdFuncion();
            if (id <= 0)
            {
                MessageBox.Show("Escribe un ID de función.", "Buscar función",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = api.ObtenerFuncion(id);
                if (dt.Rows.Count == 0)
                {
                    RtbDatosFuncion.Text = "Función no encontrada.";
                    return;
                }
                RtbDatosFuncion.Text = FormatearDatos(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo buscar la función.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarVenta_Click(object sender, EventArgs e)
        {
            int id = LeerIdVenta();
            if (id <= 0)
            {
                MessageBox.Show("Escribe un ID de venta.", "Buscar venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = api.ObtenerVenta(id);
                if (dt.Rows.Count == 0)
                {
                    RtbDatosVenta.Text = "Venta no encontrada.";
                    return;
                }
                RtbDatosVenta.Text = FormatearDatos(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo buscar la venta.\n\n" + ex.Message, "Error",
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

        private void TbAsientoCodificado_Leave(object sender, EventArgs e)
        {
            TbAsientoDecodificado.Text = DecodificarAsiento(TbAsientoCodificado.Text.Trim());
        }

        private static string DecodificarAsiento(string codificado)
        {
            if (!int.TryParse(codificado?.Trim(), out int n) || n <= 0)
                return "";

            int grupo = (n - 1) / 10;        
            int asiento = n - grupo * 10;
            char letra = (char)('A' + grupo);
            return letra.ToString() + asiento;
        }

        // ---------------- CRUD ----------------

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                int nuevo = api.Insertar(LeerIdVenta(), LeerIdFuncion(), LeerEstado(), LeerAsiento());
                MessageBox.Show("Boleto agregado correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el boleto.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un boleto de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerIdVenta(), LeerIdFuncion(), LeerEstado(), LeerAsiento());
                MessageBox.Show(ok ? "Boleto actualizado correctamente." : "No se encontró el boleto.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el boleto.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un boleto de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show("¿Seguro que deseas eliminar el boleto " + id + "?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Boleto eliminado." : "No se encontró el boleto.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el boleto.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvBoletos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un boleto de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvBoletos.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            TbID.Text = row["id_boleto"].ToString();
            TbIdVenta.Text = row["id_venta"] == DBNull.Value ? "" : row["id_venta"].ToString();
            TbIdFuncion.Text = row["id_funcion"] == DBNull.Value ? "" : row["id_funcion"].ToString();

            string asiento = row["numero_asiento"] == DBNull.Value ? "" : row["numero_asiento"].ToString();
            TbAsientoCodificado.Text = asiento;
            TbAsientoDecodificado.Text = DecodificarAsiento(asiento);

            CbEstado.SelectedValue = row["id_estado_boleto"] == DBNull.Value ? -1 : row["id_estado_boleto"];

            DgvBoletos.Focus();
        }

        // ---------------- Filtro ----------------

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaBoletos == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaBoletos.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_boleto" || columna == "id_venta" ||
                columna == "id_funcion" || columna == "numero_asiento")
                tablaBoletos.DefaultView.RowFilter =
                    "Convert(" + columna + ", 'System.String') LIKE '%" + texto + "%'";
            else
                tablaBoletos.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "ID" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "Venta": return "id_venta";
                case "Función": return "id_funcion";
                case "Estado": return "nombre_estado_boleto";
                case "Asiento": return "numero_asiento";
                default: return "id_boleto";
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