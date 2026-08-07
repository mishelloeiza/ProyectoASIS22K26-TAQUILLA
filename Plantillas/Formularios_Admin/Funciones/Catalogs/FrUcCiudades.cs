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

namespace Forms_Admin.Funciones.Catalogs
{
    public partial class FrUcCiudades : UserControl
    {
        private readonly If_Ciudades api = new If_Ciudades();
        private DataTable tablaCiudades;
        public FrUcCiudades()
        {
            InitializeComponent();
            WireEvents();
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

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Nombre");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaCiudades = api.Listar();
            DgvCiudades.DataSource = tablaCiudades;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvCiudades.Columns.Count == 0) return;

            Encabezado("id_ciudad", "ID");
            Encabezado("nombre_ciudad", "Nombre");
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvCiudades.Columns.Contains(columna))
                DgvCiudades.Columns[columna].HeaderText = texto;
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
        }

        private string LeerNombre()
        {
            return TbNombre.Text.Trim();
        }

        private void PonerTexto(Componentes.CustomTextBox tb, string valor)
        {
            tb.Focus();
            tb.Text = valor;
            tb.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(LeerNombre()))
            {
                MessageBox.Show("El nombre de la ciudad es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNombre.Focus();
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                int nuevo = api.Insertar(LeerNombre());

                MessageBox.Show("Ciudad agregada correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Ya existe una ciudad con ese nombre.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la ciudad.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una ciudad de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerNombre());

                MessageBox.Show(ok ? "Ciudad actualizada correctamente." : "No se encontró la ciudad.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Ya existe una ciudad con ese nombre.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la ciudad.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una ciudad de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que deseas eliminar la ciudad \"" + TbNombre.Text.Trim() + "\"?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Ciudad eliminada." : "No se encontró la ciudad.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("No se puede eliminar: la ciudad tiene cines registrados.",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la ciudad.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvCiudades.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una ciudad de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvCiudades.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            int id = Convert.ToInt32(row["id_ciudad"]);

            TbID.Text = id.ToString();
            PonerTexto(TbNombre, row["nombre_ciudad"].ToString());

            DgvCiudades.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaCiudades == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaCiudades.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_ciudad")
                tablaCiudades.DefaultView.RowFilter =
                    "Convert(id_ciudad, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaCiudades.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Nombre" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_ciudad";
                default: return "nombre_ciudad";
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
