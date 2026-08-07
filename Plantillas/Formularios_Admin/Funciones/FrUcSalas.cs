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

namespace Forms_Admin.Funciones
{
    public partial class FrUcSalas : UserControl
    {
        private readonly If_Salas api = new If_Salas();
        private DataTable tablaSalas;
        public FrUcSalas()
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
            BtnCopiar.Click += BtnCopiar_Click;
            BtnBuscar.Click += BtnBuscar_Click;
            BtnLimpiar.Click += BtnLimpiar_Click;
        }

        private void CargarCombos()
        {
            CbTipoSala.DataSource = api.ListarTiposSala();
            CbTipoSala.DisplayMember = "Nombre";
            CbTipoSala.ValueMember = "Id";
            CbTipoSala.SelectedIndex = -1;

            CbCine.DataSource = api.ListarCines();
            CbCine.DisplayMember = "Nombre";
            CbCine.ValueMember = "Id";
            CbCine.SelectedIndex = -1;

            CbCapacidadDeSala.Items.Clear();

            for (int i = 20; i <= 300; i += 10)
                CbCapacidadDeSala.Items.Add(i);

            CbCapacidadDeSala.SelectedIndex = -1;
        }

        private void CargarFiltro()
        {
            CbFiltro.Items.Clear();

            CbFiltro.Items.Add("ID");
            CbFiltro.Items.Add("Tipo");
            CbFiltro.Items.Add("Cine");
            CbFiltro.Items.Add("Número");

            CbFiltro.SelectedIndex = 1;
        }

        private void CargarGrilla()
        {
            tablaSalas = api.Listar();

            DgvSalas.DataSource = tablaSalas;

            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (DgvSalas.Columns.Count == 0)
                return;

            Ocultar("id_tipo_sala");
            Ocultar("id_cine");

            Encabezado("id_sala", "ID");
            Encabezado("nombre_tipo_sala", "Tipo");
            Encabezado("nombre_cine", "Cine");
            Encabezado("numero_sala", "Número");
            Encabezado("capacidad_sala", "Capacidad");
        }

        private void Ocultar(string columna)
        {
            if (DgvSalas.Columns.Contains(columna))
                DgvSalas.Columns[columna].Visible = false;
        }

        private void Encabezado(string columna, string texto)
        {
            if (DgvSalas.Columns.Contains(columna))
                DgvSalas.Columns[columna].HeaderText = texto;
        }

        private void ModoAgregar()
        {
            LimpiarCampos();

            TbID.Text = api.ObtenerSiguienteId().ToString();

            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnCopiar.Enabled = true;
        }

        private void ModoEdicion()
        {
            BtnAgregar.Enabled = false;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnCopiar.Enabled = true;
        }

        private void LimpiarCampos()
        {
            TbID.Clear();

            CbTipoSala.SelectedIndex = -1;
            CbCine.SelectedIndex = -1;
            CbCapacidadDeSala.SelectedIndex = -1;

            customTextBox2.Clear();
        }

        private int LeerTipoSala()
        {
            return Convert.ToInt32(CbTipoSala.SelectedValue);
        }

        private int LeerCine()
        {
            return Convert.ToInt32(CbCine.SelectedValue);
        }

        private int LeerNumero()
        {
            return int.TryParse(customTextBox2.Text, out int n) ? n : 0;
        }

        private int LeerCapacidad()
        {
            return Convert.ToInt32(CbCapacidadDeSala.Text);
        }

        private bool Validar()
        {
            if (CbTipoSala.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de sala.");
                return false;
            }

            if (CbCine.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cine.");
                return false;
            }

            if (LeerNumero() <= 0)
            {
                MessageBox.Show("Ingrese el número de sala.");
                return false;
            }

            if (CbCapacidadDeSala.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la capacidad.");
                return false;
            }

            return true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbFiltro.Clear();

            CargarGrilla();

            ModoAgregar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            try
            {
                api.Insertar(
                    LeerTipoSala(),
                    LeerCine(),
                    LeerNumero(),
                    LeerCapacidad());

                MessageBox.Show("Sala agregada correctamente.");

                CargarGrilla();
                ModoAgregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (DgvSalas.CurrentRow == null)
                return;

            DataRowView fila = (DataRowView)DgvSalas.CurrentRow.DataBoundItem;

            TbID.Text = fila["id_sala"].ToString();

            CbTipoSala.SelectedValue = fila["id_tipo_sala"];

            CbCine.SelectedValue = fila["id_cine"];

            customTextBox2.Text = fila["numero_sala"].ToString();

            CbCapacidadDeSala.Text = fila["capacidad_sala"].ToString();

            ModoEdicion();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            int id = Convert.ToInt32(TbID.Text);

            api.Actualizar(
                id,
                LeerTipoSala(),
                LeerCine(),
                LeerNumero(),
                LeerCapacidad());

            MessageBox.Show("Sala actualizada.");

            CargarGrilla();
            ModoAgregar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TbID.Text == "")
                return;

            if (MessageBox.Show(
                "¿Desea eliminar esta sala?",
                "Confirmar",
                MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                api.Eliminar(Convert.ToInt32(TbID.Text));

                CargarGrilla();
                ModoAgregar();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string texto = TbFiltro.Text.Trim();

            if (texto == "")
            {
                tablaSalas.DefaultView.RowFilter = "";
                return;
            }

            switch (CbFiltro.Text)
            {
                case "ID":
                    tablaSalas.DefaultView.RowFilter =
                        "Convert(id_sala,'System.String') LIKE '%" + texto + "%'";
                    break;

                case "Tipo":
                    tablaSalas.DefaultView.RowFilter =
                        "nombre_tipo_sala LIKE '%" + texto + "%'";
                    break;

                case "Cine":
                    tablaSalas.DefaultView.RowFilter =
                        "nombre_cine LIKE '%" + texto + "%'";
                    break;

                case "Número":
                    tablaSalas.DefaultView.RowFilter =
                        "Convert(numero_sala,'System.String') LIKE '%" + texto + "%'";
                    break;
            }
        }
    }
}
