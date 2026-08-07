/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Data;
using System.Windows.Forms;
using Con_Admin;
using Validaciones;

namespace Forms_Admin.Ventas
{
    public partial class FrUcClientes : UserControl
    {
        private readonly If_Clientes api = new If_Clientes();
        private DataTable tablaClientes;

        public FrUcClientes()
        {
            InitializeComponent();
            WireEvents();
            ConfigurarRestricciones();

            // Init que toca la BD: protegido para que un fallo de conexión
            // muestre un mensaje amigable en vez de tumbar el control al cargar.
            GestorErrores.EjecutarSeguro(() =>
            {
                CargarFiltro();
                CargarGrilla();
                ModoAgregar();
            }, "Clientes.Inicializar");
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

        private void ConfigurarRestricciones()
        {
            RestrictorCampos.SoloLetras(TbNombre, 60);
            RestrictorCampos.SoloLetras(customTextBox2, 60);   
            RestrictorCampos.SoloNumeros(TbIdentificacion, 20);
            RestrictorCampos.LongitudMaxima(customTextBox3, 100);
            RestrictorCampos.RecortarEspacios(TbNombre, customTextBox2, TbIdentificacion, customTextBox3);
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Nombre");
            CbFiltro.Items.Add("Apellido");
            CbFiltro.Items.Add("Identificación");
            CbFiltro.Items.Add("Correo");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaClientes = api.Listar();
            DgvClientes.DataSource = tablaClientes;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvClientes.Columns.Count == 0) return;

            Encabezado("id_cliente", "ID");
            Encabezado("nombre_cliente", "Nombres");
            Encabezado("apellido_cliente", "Apellidos");
            Encabezado("identificacion_cliente", "Identificación");
            Encabezado("correo_cliente", "Correo");
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvClientes.Columns.Contains(columna))
                DgvClientes.Columns[columna].HeaderText = texto;
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
            customTextBox2.Clear();   
            TbIdentificacion.Clear();
            customTextBox3.Clear();  
        }

        private string LeerNombre() => TbNombre.Text.Trim();
        private string LeerApellido() => customTextBox2.Text.Trim();  
        private string LeerIdentificacion() => TbIdentificacion.Text.Trim();
        private string LeerCorreo() => customTextBox3.Text.Trim();   

        private bool Validar()
        {
            string correo = LeerCorreo();

            var r = new ResultadoValidacion()
                .AgregarSiFalla(Validador.EsSoloLetras(LeerNombre()),
                    Mensajes.NombreInvalido)
                .AgregarSiFalla(Validador.EsSoloLetras(LeerApellido()),
                    Mensajes.ApellidoInvalido)
                .AgregarSiFalla(correo.Length == 0 || Validador.EsCorreoValido(correo),
                    Mensajes.CorreoInvalido);

            return GestorErrores.MostrarValidacion(r);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            GestorErrores.EjecutarSeguro(() =>
            {
                int nuevo = api.Insertar(LeerNombre(), LeerApellido(), LeerIdentificacion(), LeerCorreo());
                GestorErrores.MostrarInformacion("Cliente agregado correctamente. ID: " + nuevo);
                CargarGrilla();
                ModoAgregar();
            }, "Clientes.Agregar");
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                GestorErrores.MostrarAdvertencia("Selecciona un cliente de la tabla para actualizar.");
                return;
            }
            if (!Validar()) return;

            GestorErrores.EjecutarSeguro(() =>
            {
                bool ok = api.Actualizar(id, LeerNombre(), LeerApellido(), LeerIdentificacion(), LeerCorreo());
                if (ok) GestorErrores.MostrarInformacion("Cliente actualizado correctamente.");
                else GestorErrores.MostrarAdvertencia("No se encontró el cliente.");
                CargarGrilla();
                ModoAgregar();
            }, "Clientes.Actualizar");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                GestorErrores.MostrarAdvertencia("Selecciona un cliente de la tabla para eliminar.");
                return;
            }

            if (!GestorErrores.Confirmar(
                    "¿Seguro que deseas eliminar al cliente \"" + LeerNombre() + " " + LeerApellido() + "\"?"))
                return;

            try
            {
                bool ok = api.Eliminar(id);
                if (ok) GestorErrores.MostrarInformacion("Cliente eliminado.");
                else GestorErrores.MostrarAdvertencia("No se encontró el cliente.");
                CargarGrilla();
                ModoAgregar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1451)
            {
                // Clave foránea: el cliente tiene ventas asociadas. Mensaje específico + log.
                Bitacora.RegistrarError(ex, "Clientes.Eliminar");
                GestorErrores.MostrarAdvertencia("No se puede eliminar: el cliente tiene ventas registradas.");
            }
            catch (Exception ex)
            {
                GestorErrores.Manejar(ex, "Clientes.Eliminar");
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.CurrentRow == null)
            {
                GestorErrores.MostrarAdvertencia("Selecciona un cliente de la tabla primero.");
                return;
            }

            GestorErrores.EjecutarSeguro(() =>
            {
                CargarDesdeFila(DgvClientes.CurrentRow);
                ModoEdicion();
            }, "Clientes.Copiar");
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            TbID.Text = row["id_cliente"].ToString();
            TbNombre.Text = row["nombre_cliente"] == DBNull.Value ? "" : row["nombre_cliente"].ToString();
            customTextBox2.Text = row["apellido_cliente"] == DBNull.Value ? "" : row["apellido_cliente"].ToString();
            TbIdentificacion.Text = row["identificacion_cliente"] == DBNull.Value ? "" : row["identificacion_cliente"].ToString();
            customTextBox3.Text = row["correo_cliente"] == DBNull.Value ? "" : row["correo_cliente"].ToString();

            DgvClientes.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaClientes == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaClientes.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_cliente")
                tablaClientes.DefaultView.RowFilter =
                    "Convert(id_cliente, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaClientes.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Nombre" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_cliente";
                case "Apellido": return "apellido_cliente";
                case "Identificación": return "identificacion_cliente";
                case "Correo": return "correo_cliente";
                default: return "nombre_cliente";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbFiltro.Clear();
            GestorErrores.EjecutarSeguro(() =>
            {
                CargarGrilla();
                ModoAgregar();
            }, "Clientes.Limpiar");
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */