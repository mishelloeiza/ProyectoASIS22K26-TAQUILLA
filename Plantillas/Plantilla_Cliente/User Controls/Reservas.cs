using clase_conexion;
using Plantilla_Cliente.Clases;
using Plantillas.Carteleras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace Plantilla_Cliente
{
    public partial class Reservas : UserControl
    {
        private Con_Cliente gconexion;

        // Película seleccionada
        public int IdCine;
        public int idPelicula;
        public int idciudad;
        public string Enlace;
        // Datos de la reserva
        public int id_funcion;
        public int numero_boleto;
        public int id_venta;
        public string estado_boleto = "";
        public int IdSala;

        // Asientos seleccionados
        public List<int> asientosSeleccionados = new List<int>();

        //Lista de boletos Generados
        public List<Boleto> boletosGenerados = new List<Boleto>();

        // Botones para mostrar la fecha y hora seleccionadas
        private Button btnFechaSeleccionada = null;
        private Button btnHoraSeleccionada = null;
        public event Action? CambiarCartelera;

        public Reservas()
        {
            InitializeComponent();
            gconexion = new Con_Cliente();

        }

        public Reservas(int idPelicula, int idciudad)
        {
            InitializeComponent();
            gconexion = new Con_Cliente();
            this.idPelicula = idPelicula;
            this.idciudad = idciudad;

            // Prueba para verificar que el ID se recibió correctamente
            /*MessageBox.Show($"ID recibido: {this.idPelicula}");
            MessageBox.Show($"Ciudad recibida: {this.idciudad}");*/
            Enlace = gconexion.ObtenerEnlacePelicula(idPelicula);
            cargarinfopelicula(this.idPelicula);
            cargarfunciones(this.idPelicula, this.idciudad);
            CargarCines(this.idciudad);
            FlpHorarios.Controls.Clear();
            CargarMiniaturaTrailer(Enlace);
            CargarPoster();

        }

        private void TlP_Reservas_Paint(object sender, PaintEventArgs e)
        {
            AplicarBordeLabel(TxDirector, Color.FromArgb(112, 27, 40));
            AplicarBordeLabel(TxDuracion, Color.FromArgb(112, 27, 40));
            AplicarBordeLabel(TxRestriccion, Color.FromArgb(112, 27, 40));
            AplicarBordeLabel(TxDirectorHead, Color.FromArgb(18, 18, 18));
            AplicarBordeLabel(TxDuracionHead, Color.FromArgb(18, 18, 18));
            AplicarBordeLabel(TxRestriccionHead, Color.FromArgb(18, 18, 18));
            AplicarBordeLabel(TxSeleccionCine, Color.FromArgb(18, 18, 18));
            AplicarBordeLabel(TxFunciones, Color.FromArgb(18, 18, 18));
            AplicarBordeLabel(TxHorarios, Color.FromArgb(18, 18, 18));
        }
        /*Inicio del código 0901-23-13862 Carlos Andres Arriaza Lara el 25/07/2026*/
        private void Btn_Continuar_Click(object sender, EventArgs e)
        {
            using (Butacas butacas = new Butacas(IdSala))
            {
                if (butacas.ShowDialog() == DialogResult.OK)
                {
                    asientosSeleccionados = new List<int>(butacas.ButacasSeleccionadas);

                    List<string> asientosTexto = new List<string>();

                    foreach (int numero in asientosSeleccionados)
                    {
                        asientosTexto.Add(DecodificarAsiento(numero));
                    }

                    MessageBox.Show(
                        "Asientos seleccionados:\n" +
                        string.Join(", ", asientosTexto));

                    MessageBox.Show("Id_Funcion" + id_funcion.ToString());

                    /*Inicio del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/
                    if (asientosSeleccionados.Count > 0)
                    {
                        decimal precioPorBoleto = 45.00m;
                        decimal totalCalculado = asientosSeleccionados.Count * precioPorBoleto;

                        using (Pago formPago = new Pago(totalCalculado))
                        {
                            if (formPago.ShowDialog() == DialogResult.OK)
                            {
                                int metodoPagoSeleccionado = formPago.IdMetodoPagoSeleccionado;

                                GuardarButacas(metodoPagoSeleccionado, totalCalculado);
                            }
                            else
                            {
                                MessageBox.Show("El pago fue cancelado.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No seleccionó ningún asiento.");
                    }

                }
            }
        }
        private void GuardarButacas(int metodoPago, decimal total)
        {
            int idVentaGenerado = gconexion.RegistrarVenta(metodoPago, asientosSeleccionados.Count, total);

            if (idVentaGenerado > 0)
            {
                bool errorBoleto = false;

                foreach (int asiento in asientosSeleccionados)
                {
                    bool resultadoBoleto = gconexion.RegistrarBoleto(id_funcion, idVentaGenerado, asiento);
                    if (!resultadoBoleto)
                    {
                        errorBoleto = true;
                        break;
                    }
                }

                if (!errorBoleto)
                {
                    MessageBox.Show("¡Venta y boletos registrados con éxito en la base de datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    asientosSeleccionados.Clear();
                }
            }
            else
            {
                MessageBox.Show("No se pudo registrar la venta principal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*Fin del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/

        private string DecodificarAsiento(int numeroAsiento)
        {
            int fila = (numeroAsiento - 1) / 10;
            int columna = (numeroAsiento - 1) % 10 + 1;

            char letraFila = (char)('A' + fila);

            return $"{letraFila}{columna}";
        }
        /*Fin del código de 0901-23-13862 Carlos Andres Arriaza Lara el 25/07/2026*/
        private void cargarinfopelicula(int idPelicula)
        {
            String director = "";
            string duracion = "";
            string restriccion = "";
            DataTable pelicula = gconexion.infopelicula(idPelicula);
            TxDirector.Text = pelicula.Rows[0]["director_pelicula"].ToString();
            TxDuracion.Text = pelicula.Rows[0]["duracion_pelicula"].ToString();
            TxRestriccion.Text = pelicula.Rows[0]["clasificacion_pelicula"].ToString();

        }
        private void cargarfunciones(int idPelicula, int idciudad)
        {
            FlpFunciones.Controls.Clear();
            //MessageBox.Show($"Película: {idPelicula}\nCiudad: {idciudad}");
            DataTable funciones = gconexion.cargarfunciones(idPelicula, idciudad);
            //MessageBox.Show($"Filas: {funciones.Rows.Count}");
            HashSet<DateTime> fechas = new HashSet<DateTime>();
            foreach (DataRow fila in funciones.Rows)
            {
                DateTime fecha = Convert.ToDateTime(fila["fecha_funcion"]);

                if (fechas.Contains(fecha))
                    continue;

                fechas.Add(fecha);

                Button btn = new Button();

                btn.AutoSize = true;
                btn.Height = 40;
                btn.Margin = new Padding(5);
                btn.Dock = DockStyle.Fill;
                btn.Text = fecha.ToString("dd/MM");
                btn.Tag = fecha;

                btn.BackColor = Color.FromArgb(197, 155, 39);
                btn.ForeColor = Color.FromArgb(250, 248, 245);
                btn.FlatStyle = FlatStyle.Popup;
                btn.FlatAppearance.BorderSize = 1;

                btn.Click += BtnFecha_Click;

                FlpFunciones.Controls.Add(btn);
            }
        }
        private void CargarHorarios(DateTime fechaSeleccionada)
        {
            //MessageBox.Show("IdCiudad:" + idciudad.ToString());
            FlpHorarios.Controls.Clear();
            //MessageBox.Show($"Película: {idPelicula}\nCiudad: {idciudad}");
            DataTable funciones = gconexion.cargarfunciones(idPelicula, idciudad);
            //MessageBox.Show($"Filas: {funciones.Rows.Count}");
            foreach (DataRow fila in funciones.Rows)
            {
                DateTime fechaFuncion = Convert.ToDateTime(fila["fecha_funcion"]);

                if (fechaFuncion.Date != fechaSeleccionada.Date)
                    continue;

                Button btn = new Button();

                btn.AutoSize = true;
                btn.Height = 40;
                btn.Margin = new Padding(5);

                btn.Text = fila["hora_funcion"].ToString();

                btn.Tag = Convert.ToInt32(fila["id_funcion"]);
                btn.Dock = DockStyle.Fill;
                btn.BackColor = Color.FromArgb(197, 155, 39);
                btn.ForeColor = Color.FromArgb(250, 248, 245);
                btn.FlatStyle = FlatStyle.Popup;
                btn.FlatAppearance.BorderSize = 1;

                btn.Click += BtnHorario_Click;
                //MessageBox.Show($"Creando botón: {fila["hora_funcion"]}");
                FlpHorarios.Controls.Add(btn);
            }
        }
        private void BtnFecha_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btnFechaSeleccionada != null)
            {
                btnFechaSeleccionada.BackColor = Color.FromArgb(197, 155, 39);
                btnFechaSeleccionada.ForeColor = Color.FromArgb(250, 248, 245);
            }
            btn.BackColor = Color.FromArgb(112, 27, 40);


            btnFechaSeleccionada = btn;

            DateTime fecha = (DateTime)btn.Tag;

            CargarHorarios(fecha);
        }
        private void BtnHorario_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btnHoraSeleccionada != null)
            {
                btnHoraSeleccionada.BackColor = Color.FromArgb(197, 155, 39);
                btnHoraSeleccionada.ForeColor = Color.FromArgb(250, 248, 245);
            }


            btn.BackColor = Color.FromArgb(112, 27, 40);
            btn.ForeColor = Color.White;

            btnHoraSeleccionada = btn;

            id_funcion = (int)btn.Tag;
            //MessageBox.Show($"Id función: {id_funcion}");
            IdSala = gconexion.ObtenerIdSala(id_funcion);
            // MessageBox.Show($"Id_Funcion: {id_funcion}\nId_Sala: {IdSala}");
        }

        private void Cbo_Cines_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCine = CboCines.SelectedIndex + 1;
            cargarfunciones(idPelicula, IdCine);

        }

        private void CargarCines(int ciudad)
        {

            DataTable dtCines = gconexion.mostrarcines(ciudad);

            CboCines.DataSource = null;

            CboCines.DisplayMember = "nombre_cine";
            CboCines.ValueMember = "id_cine";

            CboCines.DataSource = dtCines;
            //MessageBox.Show($"Cines cargados: {dtCines.Rows.Count}");
        }
        private void GuardarButacas()
        {
            int idVenta = gconexion.SiguienteIdVenta();
            int ultimoIdBoleto = gconexion.SiguienteIdBoleto();

            foreach (int asiento in asientosSeleccionados)
            {
                int idBoleto = ultimoIdBoleto++;

                boletosGenerados.Add(
                    new Boleto(idBoleto, id_funcion, asiento, idVenta, "Reservado"));
                MessageBox.Show($"Boleto generado: IdBoleto={idBoleto}, IdFuncion={id_funcion}, Asiento={asiento}, IdVenta={idVenta}, Estado=Reservado");
            }
        }
        private void AplicarBordeLabel(Label lbl, Color colorBorde)
        {
            lbl.Paint += (object sender, PaintEventArgs e) =>
            {
                using (Pen pen = new Pen(colorBorde, 2))
                {
                    e.Graphics.DrawRectangle(
                        pen,
                        0,
                        0,
                        lbl.Width - 1,
                        lbl.Height - 1);
                }
            };
        }

        private void PicTrailer_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = Enlace,
                UseShellExecute = true
            });
        }
        private void CargarMiniaturaTrailer(string enlaceYoutube)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(enlaceYoutube))
                {
                    PicTrailer.Image = null;
                    return;
                }

                Uri uri = new Uri(enlaceYoutube);
                string videoId = "";

                if (uri.Host.Contains("youtu.be"))
                {
                    // Ejemplo: https://youtu.be/mY-XSIfhziE?si=xxxx
                    videoId = uri.AbsolutePath.Trim('/');
                }
                else if (uri.Host.Contains("youtube.com"))
                {
                    // Ejemplo: https://www.youtube.com/watch?v=mY-XSIfhziE
                    string query = uri.Query.TrimStart('?');

                    foreach (string parametro in query.Split('&'))
                    {
                        if (parametro.StartsWith("v="))
                        {
                            videoId = parametro.Substring(2);
                            break;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(videoId))
                {
                    PicTrailer.LoadAsync($"https://img.youtube.com/vi/{videoId}/hqdefault.jpg");
                }
                else
                {
                    PicTrailer.Image = null;
                }
            }
            catch
            {
                PicTrailer.Image = null;
            }
        }

        private void TxRestriccion_Click(object sender, EventArgs e)
        {

        }
        private void CargarPoster()
        {

            Carteleras carteleras = new Carteleras(idPelicula);
            String url = carteleras.obtenerUrl();
            PicPelicula.ImageLocation = url;
            PicPelicula.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Btn_Cartelera_Click(object sender, EventArgs e)
        {
            CambiarCartelera?.Invoke();
        }

        private void PicTrailer_Click_1(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = Enlace,
                UseShellExecute = true
            });
        }
    }
}