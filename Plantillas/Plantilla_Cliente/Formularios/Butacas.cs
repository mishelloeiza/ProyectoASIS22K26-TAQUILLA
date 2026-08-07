using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Plantilla_Cliente.Clases;

namespace Plantilla_Cliente
{
    public partial class Butacas : Form
    {
        // Lista de números de asiento seleccionados
        public List<int> ButacasSeleccionadas { get; } = new();
        public int id_sala;
        public int capacidad_sala;
        private Con_Cliente gconexion;

        public Butacas(int idSala)
        {
            InitializeComponent();
            gconexion = new Con_Cliente();
            this.id_sala = idSala;
            capacidad_sala = gconexion.ObtenerCapacidadSala(id_sala) / 10;
        }

        private void Butacas_Load(object sender, EventArgs e)
        {

            CrearButacas(capacidad_sala);
        }

        private void CrearButacas(int filas)
        {
            int columnas = 10;

            Tlp_butacaselector.Controls.Clear();
            Tlp_butacaselector.ColumnStyles.Clear();
            Tlp_butacaselector.RowStyles.Clear();

            Tlp_butacaselector.RowCount = filas;
            Tlp_butacaselector.ColumnCount = columnas;

            for (int i = 0; i < columnas; i++)
            {
                Tlp_butacaselector.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 100f / columnas));
            }

            for (int i = 0; i < filas; i++)
            {
                Tlp_butacaselector.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 100f / filas));
            }

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    int numeroButaca = fila * columnas + columna + 1;
                    Button butaca = new Button();

                    butaca.Dock = DockStyle.Fill;
                    butaca.FlatStyle = FlatStyle.Flat;
                    butaca.FlatAppearance.BorderSize = 0;

                    butaca.BackColor = Color.Green;
                    butaca.ForeColor = Color.White;

                    // Número único del asiento
                    int numeroAsiento = fila * 10 + columna + 1;

                    // Se guarda para la BD
                    butaca.Tag = numeroAsiento;

                    // Lo que ve el usuario
                    butaca.Text = DecodificarAsiento(numeroAsiento);

                    butaca.Click += Btn_butaca_Click;

                    Tlp_butacaselector.Controls.Add(butaca, columna, fila);
                }
            }
        }

        private string DecodificarAsiento(int numeroAsiento)
        {
            int fila = (numeroAsiento - 1) / 10;
            int columna = (numeroAsiento - 1) % 10 + 1;

            char letraFila = (char)('A' + fila);

            return $"{letraFila}{columna}";
        }

        private void Btn_butaca_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int numeroAsiento = (int)btn.Tag;

            if (btn.BackColor == Color.Green)
            {
                //añadir el asiento seleccionado a la lista
                btn.BackColor = Color.DeepSkyBlue;
                ButacasSeleccionadas.Add(numeroAsiento);
            }
            else
            {
                //Eliminar el asiento seleccionado de la lista
                btn.BackColor = Color.Green;
                ButacasSeleccionadas.Remove(numeroAsiento);
            }
        }

        private void Btn_Confirmacion_Click(object sender, EventArgs e)
        {
            if (ButacasSeleccionadas.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione al menos una butaca.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            List<string> asientos = new();

            foreach (int numero in ButacasSeleccionadas)
            {
                asientos.Add(DecodificarAsiento(numero));
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro que desea reservar {ButacasSeleccionadas.Count} butacas?\n\n" +
                $"Butacas seleccionadas: {string.Join(", ", asientos)}",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}