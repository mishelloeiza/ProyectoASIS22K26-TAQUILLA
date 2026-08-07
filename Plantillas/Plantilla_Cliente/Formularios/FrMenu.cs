using System.Drawing.Drawing2D;
using Plantillas.Carteleras;
using System.Diagnostics;

//Carlos Andres Arriaza Lara 0901-23-13862
//Creación de prototipo de interfaz para menu de cliente
namespace Plantilla_Cliente
{
    public partial class FrMenu : Form
    {
        Carteleras cartelera = new Carteleras(1);
        public FrMenu()
        {
            InitializeComponent();

            Cartelera carteleraControl = new Cartelera();
            carteleraControl.CambiaraReserva += CargarPanelReserva;
            Reservas reservas = new Reservas();
            reservas.CambiarCartelera += CargarPanelCartelera;

            CargarPanel(carteleraControl);

        }
        /* Inicio de Codigo de Carlos Andres Arriaza Lara en la fecha de: 20/07/2026 */
        private void CargarPanel(UserControl pagina)
        {
            Pnl_Menu.Controls.Clear();

            pagina.Dock = DockStyle.Fill;
            Pnl_Menu.Controls.Add(pagina);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarPanelReserva(int idPelicula, int idCiudad)
        {
            Reservas reservas = new Reservas(idPelicula, idCiudad);
            reservas.CambiarCartelera += CargarPanelCartelera;
            CargarPanel(reservas);
        }
        private void CargarPanelCartelera()
        {
            Cartelera cartelera = new Cartelera();
            cartelera.CambiaraReserva += CargarPanelReserva;

            CargarPanel(cartelera);
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            CargarPanel(reservas);
        }

        /* Final de Codigo de Carlos Andres Arriaza Lara en la fecha de: 20/07/2026 */
    }
}

