using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Con_Admin;

namespace Plantilla_Admin.Tabs
{
    public partial class FrUcMainDashboard : UserControl
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Rectangle lParam);

        private const int EM_SETRECT = 0x00B3;

        private static readonly string CarpetaCarteleras = ResolverCarpetaCarteleras();

        private static readonly Color ColorTexto = Color.FromArgb(230, 230, 230);

        private static readonly (string Nombre, string Carne)[] Integrantes =
        {
            ("Diego Fernando Santizo Samayoa", "0901-22-15950"),
            ("Carlos Andrés Arriaza Lara",     "0901-23-13862"),
            ("Pedro José Gómez Villalobos",    "0901-23-4868"),
            ("Miguel David Contreras Jacinto", "0901-21-3878"),
            ("José Pablo Cano Cóbar",          "0901-23-1727"),
            ("Diana Mishel Loeiza Ramírez",    "9959-23-3457"),
        };

        private readonly System.Windows.Forms.Timer _tmReloj = new();
        private readonly System.Windows.Forms.Timer _tmSlideshow = new();

        private PictureBox[] _cajas = Array.Empty<PictureBox>();
        private readonly List<string> _posters = new();

        private readonly Random _rng = new();
        private List<string> _bolsa = new();
        private int _bolsaIndice;

        public event EventHandler? VerCartelera;
        public event EventHandler? VerReportes;
        public event EventHandler? NecesitasAyuda;
        public event EventHandler? AgregarFunciones;

        public FrUcMainDashboard()
        {
            InitializeComponent();

            _cajas = new[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            foreach (var caja in _cajas)
                caja.SizeMode = PictureBoxSizeMode.StretchImage;

            InicializarReloj();
            InicializarSlideshow();
            CargarDatosImportantes();
            CargarDetalles();

            AplicarMargen();
            RcbDatosImportantes.Resize += (s, e) => AplicarMargen();

            Disposed += Limpiar;
        }

        private static string ResolverCarpetaCarteleras()
        {
            try
            {
                var dir = new DirectoryInfo(AppContext.BaseDirectory);
                for (int i = 0; i < 5 && dir != null; i++)
                {
                    string candidato = Path.Combine(dir.FullName, "Recursos", "Carteleras");
                    if (Directory.Exists(candidato)) return candidato;
                    dir = dir.Parent;
                }

                string raiz = Directory.GetParent(AppContext.BaseDirectory)
                    ?.Parent?.Parent?.Parent?.Parent?.FullName;
                if (raiz != null) return Path.Combine(raiz, "Recursos", "Carteleras");
            }
            catch { }

            return Path.Combine(AppContext.BaseDirectory, "Recursos", "Carteleras");
        }

        private void AplicarMargen()
        {
            if (!RcbDatosImportantes.IsHandleCreated) return;

            Rectangle r = RcbDatosImportantes.ClientRectangle;
            r.Inflate(-14, -14);
            SendMessage(RcbDatosImportantes.Handle, EM_SETRECT, 0, ref r);
        }

        private void InicializarReloj()
        {
            ActualizarHora();
            _tmReloj.Interval = 1000;
            _tmReloj.Tick += (s, e) => ActualizarHora();
            _tmReloj.Start();
        }

        private void ActualizarHora()
        {
            DateTime ahora = DateTime.Now;
            LbBienvenida.Text = Saludo(ahora) + Sesion.Usuario;
            LbHora.Text = ahora.ToString("HH:mm:ss");
            LbMensajeDeUsuario.Text = ahora.ToString("dd/MM/yyyy");
        }

        private static string Saludo(DateTime h)
        {
            if (h.Hour < 12) return "Buenos días, ";
            if (h.Hour < 19) return "Buenas tardes, ";
            return "Buenas noches, ";
        }

        private void InicializarSlideshow()
        {
            CargarListaPosters();
            MostrarPosters();

            if (_posters.Count > 0)
            {
                _tmSlideshow.Interval = 3500;
                _tmSlideshow.Tick += (s, e) => MostrarPosters();
                _tmSlideshow.Start();
            }
        }

        private void CargarListaPosters()
        {
            _posters.Clear();
            if (!Directory.Exists(CarpetaCarteleras)) return;

            foreach (string archivo in Directory.EnumerateFiles(CarpetaCarteleras))
            {
                string ext = Path.GetExtension(archivo).ToLowerInvariant();
                if (ext != ".png" && ext != ".jpg" && ext != ".jpeg") continue;

                string nombre = Path.GetFileNameWithoutExtension(archivo).ToLowerInvariant();
                if (nombre == "default") continue;

                _posters.Add(archivo);
            }
        }

        private void MostrarPosters()
        {
            if (_posters.Count == 0)
            {
                string def = Path.Combine(CarpetaCarteleras, "default.jpeg");
                if (File.Exists(def))
                    foreach (var caja in _cajas)
                    {
                        caja.Image?.Dispose();
                        caja.Image = CargarImagen(def);
                    }
                return;
            }

            for (int i = 0; i < _cajas.Length; i++)
            {
                PictureBox caja = _cajas[i];
                caja.Image?.Dispose();
                caja.Image = CargarImagen(SiguientePoster());
            }
        }

        private string SiguientePoster()
        {
            if (_bolsa.Count == 0 || _bolsaIndice >= _bolsa.Count)
                RebarajarBolsa();
            return _bolsa[_bolsaIndice++];
        }

        private void RebarajarBolsa()
        {
            _bolsa = new List<string>(_posters);
            for (int i = _bolsa.Count - 1; i > 0; i--)
            {
                int j = _rng.Next(i + 1);
                (_bolsa[i], _bolsa[j]) = (_bolsa[j], _bolsa[i]);
            }
            _bolsaIndice = 0;
        }

        private static Image? CargarImagen(string ruta)
        {
            try
            {
                using var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                using var temp = Image.FromStream(fs);
                return new Bitmap(temp);
            }
            catch
            {
                return null;
            }
        }

        private void CargarDatosImportantes()
        {
            var rtb = RcbDatosImportantes;
            rtb.Clear();

            AppendLinea(rtb, Sesion.Descripcion(), ColorTexto, 10.5f, FontStyle.Regular);
            AppendLinea(rtb, "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"), ColorTexto, 10.5f, FontStyle.Regular);
            AppendLinea(rtb, "Pósters en cartelera: " + _posters.Count, ColorTexto, 10.5f, FontStyle.Regular);
            rtb.AppendText("\n");

            try
            {
                var api = new If_Reportes();
                int anio = DateTime.Now.Year;
                int mes = DateTime.Now.Month;

                AppendLinea(rtb, "Resumen del mes", Color.Crimson, 12f, FontStyle.Bold);

                DataTable ganancias = api.GananciasMes(anio, mes);
                if (ganancias.Rows.Count > 0)
                {
                    DataRow g = ganancias.Rows[0];
                    AppendLinea(rtb, "Boletos vendidos: " + g["boletos_vendidos"], ColorTexto, 10.5f, FontStyle.Regular);
                    AppendLinea(rtb, "Películas distintas: " + g["peliculas_distintas"], ColorTexto, 10.5f, FontStyle.Regular);
                    AppendLinea(rtb, "Ganancia total: Q" + Convert.ToDecimal(g["ganancia_total"]).ToString("N2"),
                        ColorTexto, 10.5f, FontStyle.Regular);
                }
                else
                {
                    AppendLinea(rtb, "Sin datos de ingresos este mes.", ColorTexto, 10.5f, FontStyle.Regular);
                }

                rtb.AppendText("\n");
                AppendLinea(rtb, "Películas más taquilleras", Color.Crimson, 12f, FontStyle.Bold);

                DataTable top = api.PeliculasTaquillerasMes(anio, mes);
                if (top.Rows.Count > 0)
                {
                    int n = 0;
                    foreach (DataRow r in top.Rows)
                    {
                        AppendLinea(rtb,
                            r["posicion"] + ". " + r["titulo_pelicula"] + "  (" + r["boletos_vendidos"] + " boletos)",
                            ColorTexto, 10.5f, FontStyle.Regular);
                        if (++n == 3) break;
                    }
                }
                else
                {
                    AppendLinea(rtb, "Sin funciones registradas este mes.", ColorTexto, 10.5f, FontStyle.Regular);
                }
            }
            catch
            {
                AppendLinea(rtb, "No se pudieron cargar los reportes.", Color.Goldenrod, 10.5f, FontStyle.Italic);
            }

            rtb.SelectionStart = 0;
            rtb.ScrollToCaret();
        }

        private void CargarDetalles()
        {
            var rtb = RcbDetalles;
            rtb.Clear();
            rtb.SelectionTabs = new[] { 300 };

            rtb.SelectionColor = Color.Crimson;
            rtb.SelectionFont = new Font("Segoe UI", 12f, FontStyle.Bold);
            rtb.AppendText("Grupo # 3\n\n");

            rtb.SelectionColor = ColorTexto;
            rtb.SelectionFont = new Font("Segoe UI", 10.5f, FontStyle.Bold);
            rtb.AppendText("Nombre de Estudiante\tCarné\n");

            rtb.SelectionFont = new Font("Segoe UI", 10.5f, FontStyle.Regular);
            foreach (var it in Integrantes)
                rtb.AppendText(it.Nombre + "\t" + it.Carne + "\n");

            rtb.SelectionStart = 0;
            rtb.ScrollToCaret();
        }

        private static void AppendLinea(RichTextBox rtb, string texto, Color color, float tam, FontStyle estilo)
        {
            rtb.SelectionColor = color;
            rtb.SelectionFont = new Font("Segoe UI", tam, estilo);
            rtb.AppendText(texto + "\n");
        }

        private void Limpiar(object? sender, EventArgs e)
        {
            _tmReloj.Stop();
            _tmReloj.Dispose();
            _tmSlideshow.Stop();
            _tmSlideshow.Dispose();

            foreach (var caja in _cajas)
                caja.Image?.Dispose();
        }
    }
}