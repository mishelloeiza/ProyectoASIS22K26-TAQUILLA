using Con_Admin;
using Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Admin.Funciones
{
    public partial class FrUcPromociones : UserControl
    {
        private readonly If_Promociones api = new If_Promociones();
        private DataTable tablaPromociones;

        public FrUcPromociones()
        {
            InitializeComponent();
            WireEvents();
            ConfigurarRestricciones();

            // Init que toca la BD: protegido para que un fallo de conexión
            // muestre un mensaje amigable en vez de tumbar el control al cargar.
            GestorErrores.EjecutarSeguro(() =>
            {
                CargarCombos();
                CargarFiltro();
                CargarEstado();
                CargarGrilla();
                ModoAgregar();
            }, "Promociones.Inicializar");
        }

        private void CargarEstado()
        {
            customTextBoxestado.Items.Clear();
            customTextBoxestado.Items.Add("Activa");
            customTextBoxestado.Items.Add("Inactiva");
            customTextBoxestado.SelectedIndex = 0;   
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
            // El valor puede ser porcentaje o monto: solo dígitos y un punto decimal.
            RestrictorCampos.SoloDecimal(Tbvalorpromocion, 10);

            RestrictorCampos.LongitudMaxima(ctb_nombre, 100);
            RestrictorCampos.LongitudMaxima(ctb_descripcion, 255);
            RestrictorCampos.RecortarEspacios(ctb_nombre, ctb_descripcion);

            // Combos como lista cerrada (no se puede escribir texto libre).
            RestrictorCampos.ListaCerrada(CbPelicula);
            RestrictorCampos.ListaCerrada(ccb_tipopromocion);
        }

        private void CargarCombos()
        {
            CbPelicula.DataSource = api.ListarPeliculas();
            CbPelicula.DisplayMember = "Nombre";
            CbPelicula.ValueMember = "Id";
            CbPelicula.SelectedIndex = -1;

            ccb_tipopromocion.DataSource = api.ListarTipos();
            ccb_tipopromocion.DisplayMember = "Nombre";
            ccb_tipopromocion.ValueMember = "Id";
            ccb_tipopromocion.SelectedIndex = -1;
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();
            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Nombre");
            CbFiltro.Items.Add("Tipo");
            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaPromociones = api.Listar();
            DgvFunciones.DataSource = tablaPromociones;
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvFunciones.Columns.Count == 0) return;

            Ocultar("id_tipo_promocion");
            Ocultar("codigo_tipo_promocion");

            Encabezado("id_promocion", "ID");
            Encabezado("nombre_promocion", "Nombre");
            Encabezado("descripcion_promocion", "Descripción");
            Encabezado("nombre_tipo_promocion", "Tipo");
            Encabezado("valor_promocion", "Valor");
            Encabezado("fecha_inicio_promocion", "Inicio");
            Encabezado("fecha_fin_promocion", "Fin");
            Encabezado("activa_promocion", "Activa");
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
            ctb_nombre.Clear();
            ctb_descripcion.Clear();
            Tbvalorpromocion.Clear();
            customTextBoxestado.Text = "Activa";
            CbPelicula.SelectedIndex = -1;
            ccb_tipopromocion.SelectedIndex = -1;
            DpFechaincio.Value = DateTime.Today;
            cpfinal.Value = DateTime.Today;
            customTextBoxestado.SelectedItem = "Activa";
        }

        private string LeerNombre()
        {
            return ctb_nombre.Text.Trim();
        }

        private string LeerDescripcion()
        {
            return ctb_descripcion.Text.Trim();
        }

        private int? LeerTipo()
        {
            return IdDe(ccb_tipopromocion.SelectedValue);
        }

        private decimal LeerValor()
        {
            return decimal.TryParse(Tbvalorpromocion.Text.Trim(), out decimal v) ? v : 0m;
        }

        private DateTime LeerFechaInicio()
        {
            return DpFechaincio.Value.Date;
        }

        private DateTime LeerFechaFin()
        {
            return cpfinal.Value.Date;
        }

        private bool LeerActiva()
        {
            return customTextBoxestado.Text.Trim().Equals("Activa", StringComparison.OrdinalIgnoreCase);
        }

        private int[] LeerPeliculas()
        {
            int? id = IdDe(CbPelicula.SelectedValue);
            return id == null ? new int[0] : new[] { id.Value };
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
            var r = new ResultadoValidacion()
                .AgregarSiFalla(Validador.EsRequerido(LeerNombre()),
                    "El nombre de la promoción es obligatorio.")
                .AgregarSiFalla(LeerTipo() != null,
                    Mensajes.SeleccioneOpcion)
                .AgregarSiFalla(Validador.EsDecimalPositivo(Tbvalorpromocion.Text),
                    Mensajes.CostoInvalido)
                .AgregarSiFalla(Validador.EsRangoFechasValido(LeerFechaInicio(), LeerFechaFin()),
                    Mensajes.RangoFechasInvalido);

            return GestorErrores.MostrarValidacion(r);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            GestorErrores.EjecutarSeguro(() =>
            {
                int nuevo = api.Insertar(LeerNombre(), LeerDescripcion(), LeerTipo().Value, LeerValor(),
                    LeerFechaInicio(), LeerFechaFin(), LeerActiva(), LeerPeliculas());

                GestorErrores.MostrarInformacion("Promoción agregada correctamente. ID: " + nuevo);
                CargarGrilla();
                ModoAgregar();
            }, "Promociones.Agregar");
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                GestorErrores.MostrarAdvertencia("Selecciona una promoción de la tabla para actualizar.");
                return;
            }
            if (!Validar()) return;

            GestorErrores.EjecutarSeguro(() =>
            {
                bool ok = api.Actualizar(id, LeerNombre(), LeerDescripcion(), LeerTipo().Value, LeerValor(),
                    LeerFechaInicio(), LeerFechaFin(), LeerActiva(), LeerPeliculas());

                if (ok) GestorErrores.MostrarInformacion("Promoción actualizada correctamente.");
                else GestorErrores.MostrarAdvertencia("No se encontró la promoción.");

                CargarGrilla();
                ModoAgregar();
            }, "Promociones.Actualizar");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbID.Text, out int id) || id <= 0)
            {
                GestorErrores.MostrarAdvertencia("Selecciona una promoción de la tabla para eliminar.");
                return;
            }

            if (!GestorErrores.Confirmar(
                    "¿Seguro que deseas eliminar la promoción \"" + ctb_nombre.Text.Trim() + "\"?"))
                return;

            GestorErrores.EjecutarSeguro(() =>
            {
                bool ok = api.Eliminar(id);
                if (ok) GestorErrores.MostrarInformacion("Promoción eliminada.");
                else GestorErrores.MostrarAdvertencia("No se encontró la promoción.");
                CargarGrilla();
                ModoAgregar();
            }, "Promociones.Eliminar");
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvFunciones.CurrentRow == null)
            {
                GestorErrores.MostrarAdvertencia("Selecciona una promoción de la tabla primero.");
                return;
            }

            GestorErrores.EjecutarSeguro(() =>
            {
                CargarDesdeFila(DgvFunciones.CurrentRow);
                ModoEdicion();
            }, "Promociones.Copiar");
        }

        private void CargarDesdeFila(DataGridViewRow fila)
        {
            var enlace = fila.DataBoundItem as DataRowView;
            if (enlace == null) return;

            DataRow row = enlace.Row;
            int id = Convert.ToInt32(row["id_promocion"]);

            TbID.Text = id.ToString();
            PonerTexto(ctb_nombre, row["nombre_promocion"].ToString());
            PonerTexto(ctb_descripcion, row["descripcion_promocion"] == DBNull.Value ? "" : row["descripcion_promocion"].ToString());
            ccb_tipopromocion.SelectedValue = row["id_tipo_promocion"] == DBNull.Value ? -1 : row["id_tipo_promocion"];
            PonerTexto(Tbvalorpromocion, row["valor_promocion"].ToString());

            DpFechaincio.Value = row["fecha_inicio_promocion"] == DBNull.Value
                ? DateTime.Today
                : Convert.ToDateTime(row["fecha_inicio_promocion"]);

            cpfinal.Value = row["fecha_fin_promocion"] == DBNull.Value
                ? DateTime.Today
                : Convert.ToDateTime(row["fecha_fin_promocion"]);

            bool activa = row["activa_promocion"] != DBNull.Value && Convert.ToBoolean(row["activa_promocion"]);
            customTextBoxestado.SelectedItem = activa ? "Activa" : "Inactiva";

            var peliculas = api.ListarPeliculasDePromocion(id);
            CbPelicula.SelectedValue = peliculas.Rows.Count > 0 ? peliculas.Rows[0]["id_pelicula"] : -1;

            DgvFunciones.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaPromociones == null) return;

            string texto = TbFiltro.Text.Trim().Replace("'", "''");
            if (texto.Length == 0)
            {
                tablaPromociones.DefaultView.RowFilter = string.Empty;
                return;
            }

            string columna = ColumnaFiltro();
            if (columna == "id_promocion")
                tablaPromociones.DefaultView.RowFilter =
                    "Convert(id_promocion, 'System.String') LIKE '%" + texto + "%'";
            else
                tablaPromociones.DefaultView.RowFilter = columna + " LIKE '%" + texto + "%'";
        }

        private string ColumnaFiltro()
        {
            string sel = CbFiltro.SelectedItem == null ? "Nombre" : CbFiltro.SelectedItem.ToString();
            switch (sel)
            {
                case "ID": return "id_promocion";
                case "Tipo": return "nombre_tipo_promocion";
                default: return "nombre_promocion";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbFiltro.Clear();
            CargarGrilla();
            ModoAgregar();
        }

        private void LbSala_Click(object sender, EventArgs e)
        {

        }

        private void customLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LbTipoDeFuncion_Click(object sender, EventArgs e)
        {

        }

        private void customLabel2_Click(object sender, EventArgs e)
        {

        }

        private void customLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}