/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Con_Admin;

namespace Formularios_Admin
{
    public partial class FrUcAsignarPermisos : UserControl
    {
        private readonly If_AsignarPermisos api = new If_AsignarPermisos();
        private DataTable tabla;

        public FrUcAsignarPermisos()
        {
            InitializeComponent();
            WireEvents();
            CargarCombos();
            CargarFiltro();
            CargarGrilla();
        }

        private void WireEvents()
        {
            BtnAgregar.Click += BtnAgregar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnLimpiar.Click += BtnLimpiar_Click;
            BtnCopiar.Click += BtnCopiar_Click;
            customButton1.Click += BtnBuscar_Click;
        }

        private void CargarCombos()
        {
            CbPerfil.DataSource = api.ListarPerfiles();
            CbPerfil.DisplayMember = "Nombre";
            CbPerfil.ValueMember = "Id";
            CbPerfil.SelectedIndex = -1;

            CbPermiso.DataSource = api.ListarAcciones();
            CbPermiso.DisplayMember = "Nombre";
            CbPermiso.ValueMember = "Id";
            CbPermiso.SelectedIndex = -1;

            ListBoxAplicacion.DataSource = api.ListarAplicaciones();
            ListBoxAplicacion.DisplayMember = "Nombre";
            ListBoxAplicacion.ValueMember = "Id";
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("Perfil");
            CbFiltro.Items.Add("Permiso");
            CbFiltro.Items.Add("Aplicación");
            CbFiltro.Items.Add("Código");
            CbFiltro.SelectedIndex = 0;
        }

        private void CargarGrilla()
        {
            tabla = api.Listar();
            DgvAsignarPermisos.DataSource = tabla;
            DgvAsignarPermisos.MultiSelect = true;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvAsignarPermisos.Columns.Count == 0) return;

            Ocultar("id_perfil");
            Ocultar("id_permiso");
            Ocultar("id_accion_permiso");
            Ocultar("id_aplicacion");

            Encabezado("nombre_perfil", "Perfil");
            Encabezado("nombre_accion_permiso", "Permiso");
            Encabezado("codigo_aplicacion", "Código");
            Encabezado("nombre_aplicacion", "Aplicación");
        }

        private void Ocultar(string columna)
        {
            if (DgvAsignarPermisos.Columns.Contains(columna))
                DgvAsignarPermisos.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvAsignarPermisos.Columns.Contains(columna))
                DgvAsignarPermisos.Columns[columna].HeaderText = texto;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int? idPerfil = IdDe(CbPerfil.SelectedValue);
            int? idAccion = IdDe(CbPermiso.SelectedValue);

            if (idPerfil == null)
            {
                MessageBox.Show("Selecciona un perfil.", "Asignar permisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idAccion == null)
            {
                MessageBox.Show("Selecciona un permiso.", "Asignar permisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[] apps = LeerAplicacionesMarcadas();
            if (apps.Length == 0)
            {
                MessageBox.Show("Marca al menos una aplicación.", "Asignar permisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int nuevos = 0, existentes = 0;
                foreach (int idApp in apps)
                {
                    if (api.Asignar(idPerfil.Value, idAccion.Value, idApp)) nuevos++;
                    else existentes++;
                }

                string msg = "Permisos asignados: " + nuevos +
                             (existentes > 0 ? ("\nYa existían: " + existentes) : "");
                MessageBox.Show(msg, "Asignar permisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron asignar los permisos.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? idPerfil = IdDe(CbPerfil.SelectedValue);
            int? idAccion = IdDe(CbPermiso.SelectedValue);

            if (idPerfil == null)
            {
                MessageBox.Show("Selecciona un perfil.", "Asignar permisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idAccion == null)
            {
                MessageBox.Show("Selecciona un permiso.", "Asignar permisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[] apps = LeerAplicacionesMarcadas();
            if (apps.Length == 0)
            {
                MessageBox.Show("Marca al menos una aplicación.", "Asignar permisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                apps.Length == 1
                    ? "¿Quitar la asignación seleccionada?"
                    : "¿Quitar las " + apps.Length + " asignaciones seleccionadas?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar != DialogResult.Yes) return;

            try
            {
                int eliminadas = 0, noExistian = 0;
                foreach (int idApp in apps)
                {
                    if (api.Eliminar(idPerfil.Value, idAccion.Value, idApp)) eliminadas++;
                    else noExistian++;
                }

                string msg = "Asignaciones eliminadas: " + eliminadas +
                             (noExistian > 0 ? ("\nNo estaban asignadas: " + noExistian) : "");
                MessageBox.Show(msg, "Asignar permisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron eliminar las asignaciones.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            var drv = DgvAsignarPermisos.CurrentRow?.DataBoundItem as DataRowView;
            if (drv == null)
            {
                MessageBox.Show("Selecciona una asignación de la tabla.", "Asignar permisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CbPerfil.SelectedValue = drv["id_perfil"];
            CbPermiso.SelectedValue = drv["id_accion_permiso"];
            MarcarSoloAplicacion(Convert.ToInt32(drv["id_aplicacion"]));
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tabla == null) return;

            string texto = customTextBox1.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tabla.DefaultView.RowFilter = string.Empty;
                return;
            }

            tabla.DefaultView.RowFilter = ColumnaFiltro() + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Perfil" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "Permiso": return "nombre_accion_permiso";
                case "Aplicación": return "nombre_aplicacion";
                case "Código": return "codigo_aplicacion";
                default: return "nombre_perfil";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            customTextBox1.Clear();
            CargarGrilla();
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            CbPerfil.SelectedIndex = -1;
            CbPermiso.SelectedIndex = -1;
            DesmarcarAplicaciones();
        }

        private int[] LeerAplicacionesMarcadas()
        {
            var ids = new List<int>();
            foreach (var item in ListBoxAplicacion.SelectedItems)
            {
                if (item is DataRowView drv && drv["Id"] != DBNull.Value)
                    ids.Add(Convert.ToInt32(drv["Id"]));
            }
            return ids.ToArray();
        }

        private void MarcarSoloAplicacion(int idAplicacion)
        {
            ListBoxAplicacion.ClearSelected();
            for (int i = 0; i < ListBoxAplicacion.Items.Count; i++)
            {
                if (ListBoxAplicacion.Items[i] is DataRowView drv &&
                    drv["Id"] != DBNull.Value &&
                    Convert.ToInt32(drv["Id"]) == idAplicacion)
                {
                    ListBoxAplicacion.SetSelected(i, true);
                    break;
                }
            }
        }

        private void DesmarcarAplicaciones()
        {
            ListBoxAplicacion.ClearSelected();
        }

        private static int? IdDe(object valor)
        {
            if (valor == null || valor is DBNull) return null;
            if (valor is int i) return i;
            return int.TryParse(valor.ToString(), out int r) ? (int?)r : (int?)null;
        }

        private void TlpForm_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */