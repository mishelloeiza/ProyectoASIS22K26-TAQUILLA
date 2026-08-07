/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using System.Windows.Forms;
using Con_Admin;

namespace Forms_Admin.Funciones
{
    public partial class FrUcFunciones : UserControl
    {
        private readonly If_Funciones api = new If_Funciones();
        private DataTable tablaFunciones;

        public FrUcFunciones()
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
        }

        private void CargarCombos()
        {
            CbPelicula.DataSource = api.ListarPeliculas();
            CbPelicula.DisplayMember = "Nombre";
            CbPelicula.ValueMember = "Id";
            CbPelicula.SelectedIndex = -1;

            CbSala.DataSource = api.ListarSalas();
            CbSala.DisplayMember = "Nombre";
            CbSala.ValueMember = "Id";
            CbSala.SelectedIndex = -1;
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Película");
            CbFiltro.Items.Add("Cine");
            CbFiltro.Items.Add("Fecha");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaFunciones = api.Listar();
            DgvFunciones.DataSource = tablaFunciones;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvFunciones.Columns.Count == 0) return;

            Ocultar("id_pelicula");
            Ocultar("id_sala");
            Ocultar("id_cine");

            Encabezado("id_funcion", "ID");
            Encabezado("titulo_pelicula", "Película");
            Encabezado("numero_sala", "Sala");
            Encabezado("nombre_cine", "Cine");
            Encabezado("fecha_funcion", "Fecha");
            Encabezado("hora_funcion", "Hora");
            Encabezado("precio_funcion", "Precio");
        }

        private void Ocultar(string columna)
        {
            if (DgvFunciones.Columns.Contains(columna))
                DgvFunciones.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvFunciones.Columns.Contains(columna))
                DgvFunciones.Columns[columna].HeaderText = texto;
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
            TbPrecioFuncion.Clear();
            CbPelicula.SelectedIndex = -1;
            CbSala.SelectedIndex = -1;
            DatePickerFecha.Value = DateTime.Today;
            TimePickerHora.Value = TimeSpan.Zero;
        }

        private int? LeerPelicula()
        {
            return IdDe(CbPelicula.SelectedValue);
        }

        private int? LeerSala()
        {
            return IdDe(CbSala.SelectedValue);
        }

        private DateTime LeerFecha()
        {
            return DatePickerFecha.Value.Date;
        }

        private TimeSpan LeerHora()
        {
            return TimePickerHora.Value;
        }

        private decimal LeerPrecio()
        {
            return decimal.TryParse(TbPrecioFuncion.Text.Trim(), out decimal p) ? p : 0m;
        }

        private void PonerTexto(Componentes.CustomTextBox tb, string valor)
        {
            tb.Focus();
            tb.Text = valor;
            tb.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private static int? IdDe(object valor)
        {
            if (valor == null || valor is DBNull) return null;
            if (valor is int i) return i;
            return int.TryParse(valor.ToString(), out int r) ? (int?)r : (int?)null;
        }

        private bool Validar()
        {
            if (LeerPelicula() == null)
            {
                MessageBox.Show("Debes seleccionar una película.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbPelicula.Focus();
                return false;
            }
            if (LeerSala() == null)
            {
                MessageBox.Show("Debes seleccionar una sala.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbSala.Focus();
                return false;
            }
            if (LeerFecha().Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de la función no puede ser anterior a hoy.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DatePickerFecha.Focus();
                return false;
            }
            if (LeerPrecio() <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor que cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbPrecioFuncion.Focus();
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                int nuevo = api.Insertar(LeerPelicula().Value, LeerSala().Value,
                    LeerFecha(), LeerHora(), LeerPrecio());

                MessageBox.Show("Función agregada correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la función.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una función de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerPelicula().Value, LeerSala().Value,
                    LeerFecha(), LeerHora(), LeerPrecio());

                MessageBox.Show(ok ? "Función actualizada correctamente." : "No se encontró la función.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la función.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una función de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que deseas eliminar esta función?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Función eliminada." : "No se encontró la función.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("No se puede eliminar: la función tiene registros asociados (ej. boletos vendidos).",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la función.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvFunciones.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una función de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvFunciones.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            int id = Convert.ToInt32(row["id_funcion"]);

            TbID.Text = id.ToString();
            CbPelicula.SelectedValue = row["id_pelicula"] == DBNull.Value ? -1 : row["id_pelicula"];
            CbSala.SelectedValue = row["id_sala"] == DBNull.Value ? -1 : row["id_sala"];

            DatePickerFecha.Value = row["fecha_funcion"] == DBNull.Value
                ? DateTime.Today
                : Convert.ToDateTime(row["fecha_funcion"]);

            TimePickerHora.Value = row["hora_funcion"] == DBNull.Value
                ? TimeSpan.Zero
                : (TimeSpan)row["hora_funcion"];

            PonerTexto(TbPrecioFuncion, row["precio_funcion"] == DBNull.Value ? "" : row["precio_funcion"].ToString());

            DgvFunciones.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaFunciones == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaFunciones.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_funcion")
                tablaFunciones.DefaultView.RowFilter =
                    "Convert(id_funcion, 'System.String') LIKE '%" + texto + "%'";
            else if (columna == "fecha_funcion")
                tablaFunciones.DefaultView.RowFilter =
                    "Convert(fecha_funcion, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaFunciones.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Película" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_funcion";
                case "Cine": return "nombre_cine";
                case "Fecha": return "fecha_funcion";
                default: return "titulo_pelicula";
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