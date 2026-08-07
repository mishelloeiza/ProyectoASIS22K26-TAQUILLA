using Con_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Con_Admin;

namespace Forms_Admin
{
    public partial class FrUcCines : UserControl
    {

        private readonly If_Cines api = new If_Cines();
        private DataTable tablaCines;
        public FrUcCines()
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
            CbCiudad.DataSource = api.ListarCiudades();
            CbCiudad.DisplayMember = "Nombre";
            CbCiudad.ValueMember = "Id";
            CbCiudad.SelectedIndex = -1;
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Nombre");
            CbFiltro.Items.Add("Ciudad");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaCines = api.Listar();
            DgvCines.DataSource = tablaCines;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvCines.Columns.Count == 0) return;

            Ocultar("id_ciudad");

            Encabezado("id_cine", "ID");
            Encabezado("nombre_cine", "Nombre");
            Encabezado("nombre_ciudad", "Ciudad");
        }

        private void Ocultar(string columna)
        {
            if (DgvCines.Columns.Contains(columna))
                DgvCines.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvCines.Columns.Contains(columna))
                DgvCines.Columns[columna].HeaderText = texto;
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
            TbNombre.Clear();
            CbCiudad.SelectedIndex = -1;
        }

        private string LeerNombre()
        {
            return TbNombre.Text.Trim();
        }

        private int? LeerCiudad()
        {
            return IdDe(CbCiudad.SelectedValue);
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
            if (string.IsNullOrWhiteSpace(LeerNombre()))
            {
                MessageBox.Show("El nombre del cine es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNombre.Focus();
                return false;
            }
            if (LeerCiudad() == null)
            {
                MessageBox.Show("Debes seleccionar una ciudad.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbCiudad.Focus();
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                int nuevo = api.Insertar(LeerCiudad().Value, LeerNombre());

                MessageBox.Show("Cine agregado correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el cine.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un cine de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerCiudad().Value, LeerNombre());

                MessageBox.Show(ok ? "Cine actualizado correctamente." : "No se encontró el cine.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el cine.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona un cine de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que deseas eliminar el cine \"" + TbNombre.Text.Trim() + "\"?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Cine eliminado." : "No se encontró el cine.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("No se puede eliminar: el cine tiene salas registradas.",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el cine.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvCines.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un cine de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvCines.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            int id = Convert.ToInt32(row["id_cine"]);

            TbID.Text = id.ToString();
            PonerTexto(TbNombre, row["nombre_cine"].ToString());
            CbCiudad.SelectedValue = row["id_ciudad"] == DBNull.Value ? -1 : row["id_ciudad"];

            DgvCines.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaCines == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaCines.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_cine")
                tablaCines.DefaultView.RowFilter =
                    "Convert(id_cine, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaCines.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Nombre" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_cine";
                case "Ciudad": return "nombre_ciudad";
                default: return "nombre_cine";
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
