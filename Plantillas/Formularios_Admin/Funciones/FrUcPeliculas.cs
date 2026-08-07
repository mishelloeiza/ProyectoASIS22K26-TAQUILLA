/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Con_Admin;
using System.Diagnostics;
using Plantilla_Admin;

namespace Formularios_Admin
{
    public partial class FrUcPeliculas : UserControl
    {
        private readonly If_Peliculas api = new If_Peliculas();
        private DataTable tablaPeliculas;
        private string urlYoutube = "";
        
        public FrUcPeliculas()
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
            var permisos = PermisosAux.DeSesion("Películas");

            if (!permisos.Permitido("Buscar"))
            {
                MessageBox.Show("No tienes permiso para esta sección.");
                return;
            }
            BtnBuscar.Click += BtnBuscar_Click;
            BtnLimpiar.Click += BtnLimpiar_Click;
            BtnCopiar.Click += BtnCopiar_Click;

            if (permisos.Permitido("Agregar"))
                BtnAgregar.Click += BtnAgregar_Click;
            else
                BtnAgregar.Click += (s, e) => MessageBox.Show("No tienes permiso para agregar.");

            if (permisos.Permitido("Actualizar"))
                BtnActualizar.Click += BtnActualizar_Click;
            else
                BtnActualizar.Click += (s, e) => MessageBox.Show("No tienes permiso para actualizar.");

            if (permisos.Permitido("Eliminar"))
                BtnEliminar.Click += BtnEliminar_Click;
            else
                BtnEliminar.Click += (s, e) => MessageBox.Show("No tienes permiso para eliminar.");
        }

        private readonly PermisosAux permisos = PermisosAux.DeSesion("Películas");

        private void CargarCombos()
        {
            CbClasificacion.DataSource = api.ListarClasificaciones();
            CbClasificacion.DisplayMember = "Nombre";
            CbClasificacion.ValueMember = "Id";
            CbClasificacion.SelectedIndex = -1;

            CbEstado.DataSource = api.ListarEstados();
            CbEstado.DisplayMember = "Nombre";
            CbEstado.ValueMember = "Id";
            CbEstado.SelectedIndex = -1;

            ListBoxGeneros.DataSource = api.ListarGeneros();
            ListBoxGeneros.DisplayMember = "Nombre";
            ListBoxGeneros.ValueMember = "Id";
            ListBoxGeneros.ClearSelected();

            ListBoxFormatos.DataSource = api.ListarFormatos();
            ListBoxFormatos.DisplayMember = "Nombre";
            ListBoxFormatos.ValueMember = "Id";
            ListBoxFormatos.ClearSelected();
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Título");
            CbFiltro.Items.Add("Director");
            CbFiltro.Items.Add("Clasificación");
            CbFiltro.Items.Add("Estado");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaPeliculas = api.Listar();
            DgvPeliculas.DataSource = tablaPeliculas;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvPeliculas.Columns.Count == 0) return;

            Ocultar("id_clasificacion");
            Ocultar("id_estado_pelicula");
            Ocultar("trailer_pelicula");
            Ocultar("descripcion_pelicula");

            Encabezado("id_pelicula", "ID");
            Encabezado("titulo_pelicula", "Título");
            Encabezado("duracion_pelicula", "Duración");
            Encabezado("nombre_clasificacion", "Clasificación");
            Encabezado("nombre_estado_pelicula", "Estado");
            Encabezado("director_pelicula", "Director");
            Encabezado("fecha_estreno", "Estreno");
        }

        private void Ocultar(string columna)
        {
            if (DgvPeliculas.Columns.Contains(columna))
                DgvPeliculas.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvPeliculas.Columns.Contains(columna))
                DgvPeliculas.Columns[columna].HeaderText = texto;
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
            TbTitulo.Clear();
            TbDuracion.Clear();
            TbDirector.Clear();
            TbTrailer.Clear();
            TbDescripcion.Clear();
            CbClasificacion.SelectedIndex = -1;
            CbEstado.SelectedIndex = -1;
            ListBoxGeneros.ClearSelected();
            ListBoxFormatos.ClearSelected();
            DatePickerEstreno.Value = DateTime.Today;
        }

        private string LeerTitulo()
        {
            return TbTitulo.Text.Trim();
        }

        private int LeerDuracion()
        {
            return int.TryParse(TbDuracion.Text.Trim(), out int d) ? d : 0;
        }

        private int? LeerClasificacion()
        {
            return IdDe(CbClasificacion.SelectedValue);
        }

        private int LeerEstado()
        {
            return IdDe(CbEstado.SelectedValue) ?? 0;
        }

        private DateTime LeerEstreno()
        {
            return DatePickerEstreno.Value.Date;
        }

        private void PonerTexto(Componentes.CustomTextBox tb, string valor)
        {
            tb.Focus();
            tb.Text = valor;
            tb.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private int[] LeerIds(Krypton.Toolkit.KryptonListBox lista)
        {
            var ids = new List<int>();
            foreach (var item in lista.SelectedItems)
            {
                var drv = item as DataRowView;
                if (drv != null && drv["Id"] != DBNull.Value)
                    ids.Add(Convert.ToInt32(drv["Id"]));
            }
            return ids.ToArray();
        }

        private void SeleccionarVarios(Krypton.Toolkit.KryptonListBox lista, DataTable seleccion, string columnaId)
        {
            lista.ClearSelected();
            if (seleccion == null) return;

            var objetivo = new HashSet<int>();
            foreach (DataRow r in seleccion.Rows)
                if (r[columnaId] != DBNull.Value)
                    objetivo.Add(Convert.ToInt32(r[columnaId]));

            for (int i = 0; i < lista.Items.Count; i++)
            {
                var drv = lista.Items[i] as DataRowView;
                if (drv != null && drv["Id"] != DBNull.Value && objetivo.Contains(Convert.ToInt32(drv["Id"])))
                    lista.SetSelected(i, true);
            }
        }

        private static int? IdDe(object valor)
        {
            if (valor == null || valor is DBNull) return null;
            if (valor is int i) return i;
            return int.TryParse(valor.ToString(), out int r) ? (int?)r : (int?)null;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(LeerTitulo()))
            {
                MessageBox.Show("El título es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbTitulo.Focus();
                return false;
            }
            if (LeerDuracion() <= 0)
            {
                MessageBox.Show("La duración debe ser un número mayor que cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbDuracion.Focus();
                return false;
            }
            if (LeerEstado() <= 0)
            {
                MessageBox.Show("Debes seleccionar un estado.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbEstado.Focus();
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            try
            {
                int nuevo = api.Insertar(LeerTitulo(), LeerDuracion(), LeerClasificacion(), LeerEstado(),
                    TbDirector.Text.Trim(), TbDescripcion.Text.Trim(), TbTrailer.Text.Trim(),
                    LeerEstreno(), LeerIds(ListBoxGeneros), LeerIds(ListBoxFormatos));

                MessageBox.Show("Película agregada correctamente. ID: " + nuevo, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la película.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una película de la tabla para actualizar.", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;

            try
            {
                bool ok = api.Actualizar(id, LeerTitulo(), LeerDuracion(), LeerClasificacion(), LeerEstado(),
                    TbDirector.Text.Trim(), TbDescripcion.Text.Trim(), TbTrailer.Text.Trim(),
                    LeerEstreno(), LeerIds(ListBoxGeneros), LeerIds(ListBoxFormatos));

                MessageBox.Show(ok ? "Película actualizada correctamente." : "No se encontró la película.",
                    "Actualizar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la película.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Selecciona una película de la tabla para eliminar.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que deseas eliminar la película \"" + TbTitulo.Text.Trim() + "\"?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                bool ok = api.Eliminar(id);
                MessageBox.Show(ok ? "Película eliminada." : "No se encontró la película.",
                    "Eliminar", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("No se puede eliminar: la película tiene funciones programadas.",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la película.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvPeliculas.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una película de la tabla primero.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDesdeFila(DgvPeliculas.CurrentRow);
            ModoEdicion();
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            int id = Convert.ToInt32(row["id_pelicula"]);

            TbID.Text = id.ToString();
            PonerTexto(TbTitulo, row["titulo_pelicula"].ToString());
            PonerTexto(TbDuracion, row["duracion_pelicula"].ToString());
            PonerTexto(TbDirector, row["director_pelicula"] == DBNull.Value ? "" : row["director_pelicula"].ToString());
            PonerTexto(TbTrailer, row["trailer_pelicula"] == DBNull.Value ? "" : row["trailer_pelicula"].ToString());
            TbDescripcion.Text = row["descripcion_pelicula"] == DBNull.Value ? "" : row["descripcion_pelicula"].ToString();

            CbClasificacion.SelectedValue = row["id_clasificacion"] == DBNull.Value ? -1 : row["id_clasificacion"];
            CbEstado.SelectedValue = row["id_estado_pelicula"] == DBNull.Value ? -1 : row["id_estado_pelicula"];

            SeleccionarVarios(ListBoxGeneros, api.ListarGenerosDePelicula(id), "id_genero");
            SeleccionarVarios(ListBoxFormatos, api.ListarFormatosDePelicula(id), "id_formato_pelicula");

            DatePickerEstreno.Value = row["fecha_estreno"] == DBNull.Value
                ? DateTime.Today
                : Convert.ToDateTime(row["fecha_estreno"]);

            DgvPeliculas.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaPeliculas == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaPeliculas.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_pelicula")
                tablaPeliculas.DefaultView.RowFilter =
                    "Convert(id_pelicula, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaPeliculas.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Título" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_pelicula";
                case "Director": return "director_pelicula";
                case "Clasificación": return "nombre_clasificacion";
                case "Estado": return "nombre_estado_pelicula";
                default: return "titulo_pelicula";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbFiltro.Clear();
            CargarGrilla();
            ModoAgregar();
        }
        private string ObtenerVideoID(string url)
        {
            if (url.Contains("watch?v="))
            {
                string[] partes = url.Split(new string[] { "watch?v=" },
                                            StringSplitOptions.None);

                return partes[1].Split('&')[0];
            }

            if (url.Contains("youtu.be/"))
            {
                return url.Substring(url.LastIndexOf("/") + 1);
            }

            return "";
        }
        private void CargarMiniatura()
        {
            string id = ObtenerVideoID(TbTrailer.Text);

            if (id == "")
            {
                MessageBox.Show("El enlace no es válido.");
                return;
            }

            urlYoutube = TbTrailer.Text;

            string imagen =
                "https://img.youtube.com/vi/" + id + "/hqdefault.jpg";

            PictureBoxTrailer.Load(imagen);
        }



        private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListBoxFormatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {

        }

        private void TbTrailer_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBoxTrailer_DragLeave(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = TbTrailer.Text.Trim(),
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TbTrailer_Leave(object sender, EventArgs e)
        {
            CargarMiniatura();
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */