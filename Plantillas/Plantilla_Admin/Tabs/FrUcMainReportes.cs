/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */
using Con_Admin;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plantilla_Admin
{
    public partial class FrUcMainReportes : UserControl
    {
        private readonly If_Reportes datos = new If_Reportes();

        private enum Filtro { Semanal, Mensual, Detalle }

        private sealed class Definicion
        {
            public string Nombre = "";
            public Filtro Tipo;
            public string? Monto;
        }

        private readonly Definicion[] _rep =
        {
            new Definicion { Nombre = "Películas más taquilleras por semana", Tipo = Filtro.Semanal, Monto = "recaudacion" },
            new Definicion { Nombre = "Películas más taquilleras por mes",    Tipo = Filtro.Mensual, Monto = "recaudacion" },
            new Definicion { Nombre = "Ganancias por semana",                 Tipo = Filtro.Semanal, Monto = "ganancia_total" },
            new Definicion { Nombre = "Ganancias por mes",                    Tipo = Filtro.Mensual, Monto = "ganancia_total" },
            new Definicion { Nombre = "Recaudación por boleto (detalle)",     Tipo = Filtro.Detalle, Monto = "precio_funcion" },
        };

        private readonly PrintDocument printDoc = new PrintDocument();
        private DataTable? _actual;
        private string _titulo = "";
        private string _subtitulo = "";
        private int _filaImpresion;

        public FrUcMainReportes()
        {
            InitializeComponent();

            printDoc.BeginPrint += (_, _) => _filaImpresion = 0;
            printDoc.PrintPage += ImprimirPagina;

            NudAnio.Minimum = 2000;
            NudAnio.Maximum = 2100;
            NudAnio.Value = DateTime.Now.Year;

            NudMesSemana.Minimum = 0;
            NudMesSemana.Maximum = 53;
            NudMesSemana.Value = 0;

            foreach (var r in _rep)
                CbReporte.Items.Add(r.Nombre);

            CbReporte.SelectedIndexChanged += cboReporte_SelectedIndexChanged;
            btnGenerar.Click += btnGenerar_Click;
            BtnImprimir.Click += btnImprimir_Click;
            BtnExportar.Click += btnExportar_Click;

            CbReporte.SelectedIndex = 0;
        }

        private void cboReporte_SelectedIndexChanged(object? sender, EventArgs e) => AjustarFiltros();
        private void btnGenerar_Click(object? sender, EventArgs e) => Generar();
        private void btnImprimir_Click(object? sender, EventArgs e) => Imprimir();
        private void btnExportar_Click(object? sender, EventArgs e) => ExportarCsv();

        private void AjustarFiltros()
        {
            var rep = _rep[CbReporte.SelectedIndex];

            if (rep.Tipo == Filtro.Detalle)
            {
                LbSemanaMes.Visible = NudMesSemana.Visible = false;
                return;
            }

            LbSemanaMes.Visible = NudMesSemana.Visible = true;

            if (rep.Tipo == Filtro.Semanal)
            {
                LbSemanaMes.Text = "Semana (0=todas)";
                NudMesSemana.Maximum = 53;
            }
            else
            {
                LbSemanaMes.Text = "Mes (0=todos)";
                NudMesSemana.Maximum = 12;
            }

            if (NudMesSemana.Value > NudMesSemana.Maximum)
                NudMesSemana.Value = NudMesSemana.Maximum;
        }

        private void Generar()
        {
            var rep = _rep[CbReporte.SelectedIndex];
            int anio = (int)NudAnio.Value;
            int periodo = (int)NudMesSemana.Value;

            try
            {
                DataTable dt;
                switch (CbReporte.SelectedIndex)
                {
                    case 0: dt = datos.PeliculasTaquillerasSemana(anio, periodo); break;
                    case 1: dt = datos.PeliculasTaquillerasMes(anio, periodo); break;
                    case 2: dt = datos.GananciasSemana(anio, periodo); break;
                    case 3: dt = datos.GananciasMes(anio, periodo); break;
                    default: dt = datos.RecaudacionBoleto(anio); break;
                }

                _actual = dt;
                DgvReporte.DataSource = dt;
                FormatearColumnas(dt);

                _titulo = rep.Nombre;
                _subtitulo = ConstruirSubtitulo(rep, anio, periodo);
                LbTitulo.Text = _titulo;
                LbSubtitulo.Text = _subtitulo;
                LbFecha.Text = "Generado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                MostrarTotales(dt, rep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar el reporte.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ConstruirSubtitulo(Definicion rep, int anio, int periodo)
        {
            string s = "Año " + anio;
            if (rep.Tipo == Filtro.Mensual && periodo > 0) s += "  ·  Mes " + periodo;
            if (rep.Tipo == Filtro.Semanal && periodo > 0) s += "  ·  Semana " + periodo;
            return s;
        }

        private void FormatearColumnas(DataTable dt)
        {
            void Money(string col)
            {
                if (dt.Columns.Contains(col))
                {
                    DgvReporte.Columns[col].DefaultCellStyle.Format = "N2";
                    DgvReporte.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            void Entero(string col)
            {
                if (dt.Columns.Contains(col))
                    DgvReporte.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            Money("recaudacion");
            Money("ganancia_total");
            Money("precio_funcion");
            Entero("boletos_vendidos");
            Entero("peliculas_distintas");
            Entero("posicion");

            if (dt.Columns.Contains("inicio_semana"))
                DgvReporte.Columns["inicio_semana"].DefaultCellStyle.Format = "yyyy-MM-dd";
            if (dt.Columns.Contains("fecha_funcion"))
                DgvReporte.Columns["fecha_funcion"].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private void MostrarTotales(DataTable dt, Definicion rep)
        {
            string texto = dt.Rows.Count + " fila(s)";
            if (rep.Monto != null && dt.Columns.Contains(rep.Monto))
            {
                decimal total = 0m;
                foreach (DataRow r in dt.Rows)
                    if (r[rep.Monto] != DBNull.Value)
                        total += Convert.ToDecimal(r[rep.Monto]);
                texto += "      Total: " + total.ToString("N2");
            }
            LbTotales.Text = texto;
        }

        private void Imprimir()
        {
            if (_actual == null || _actual.Rows.Count == 0)
            {
                MessageBox.Show("Genera un reporte antes de imprimir.",
                    "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using var vista = new PrintPreviewDialog { Document = printDoc, Width = 900, Height = 700 };
            vista.ShowDialog();
        }

        private void ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            if (_actual == null) { e.HasMorePages = false; return; }

            var g = e.Graphics!;
            float left = e.MarginBounds.Left;
            float right = e.MarginBounds.Right;
            float bottom = e.MarginBounds.Bottom;
            float y = e.MarginBounds.Top;

            using var fTitulo = new Font("Segoe UI", 16F, FontStyle.Bold);
            using var fSub = new Font("Segoe UI", 10F);
            using var fFecha = new Font("Segoe UI", 8.5F);
            using var fHead = new Font("Segoe UI", 9F, FontStyle.Bold);
            using var fCell = new Font("Segoe UI", 8.5F);

            g.DrawString(_titulo, fTitulo, Brushes.Black, left, y);
            y += fTitulo.GetHeight(g) + 4;
            g.DrawString(_subtitulo, fSub, Brushes.DimGray, left, y);
            y += fSub.GetHeight(g) + 2;
            g.DrawString("Generado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fFecha, Brushes.Gray, left, y);
            y += fFecha.GetHeight(g) + 10;

            int cols = _actual.Columns.Count;
            float colW = (right - left) / cols;
            float rowH = fCell.GetHeight(g) + 8;

            using var fondoHead = new SolidBrush(Color.FromArgb(38, 50, 66));
            g.FillRectangle(fondoHead, left, y, right - left, rowH);
            var fmt = new StringFormat { LineAlignment = StringAlignment.Center, Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap };
            for (int c = 0; c < cols; c++)
            {
                var celda = new RectangleF(left + c * colW + 4, y, colW - 8, rowH);
                fmt.Alignment = StringAlignment.Near;
                g.DrawString(_actual.Columns[c].ColumnName, fHead, Brushes.White, celda, fmt);
            }
            y += rowH;

            using var lapiz = new Pen(Color.FromArgb(210, 214, 220));
            while (_filaImpresion < _actual.Rows.Count && y + rowH < bottom)
            {
                DataRow fila = _actual.Rows[_filaImpresion];
                if (_filaImpresion % 2 == 1)
                    g.FillRectangle(Brushes.WhiteSmoke, left, y, right - left, rowH);

                for (int c = 0; c < cols; c++)
                {
                    DataColumn col = _actual.Columns[c];
                    string texto = TextoCelda(fila, col);
                    fmt.Alignment = (col.DataType == typeof(decimal) || EsEntero(col)) ? StringAlignment.Far : StringAlignment.Near;
                    var celda = new RectangleF(left + c * colW + 4, y, colW - 8, rowH);
                    g.DrawString(texto, fCell, Brushes.Black, celda, fmt);
                }
                g.DrawLine(lapiz, left, y + rowH, right, y + rowH);
                y += rowH;
                _filaImpresion++;
            }

            e.HasMorePages = _filaImpresion < _actual.Rows.Count;
        }

        private static bool EsEntero(DataColumn c)
        {
            return c.DataType == typeof(int) || c.DataType == typeof(long);
        }

        private static string TextoCelda(DataRow r, DataColumn c)
        {
            object v = r[c];
            if (v == DBNull.Value) return "";
            if (c.DataType == typeof(decimal)) return Convert.ToDecimal(v).ToString("N2");
            if (c.DataType == typeof(DateTime)) return Convert.ToDateTime(v).ToString("yyyy-MM-dd");
            return v.ToString() ?? "";
        }

        private void ExportarCsv()
        {
            if (_actual == null || _actual.Rows.Count == 0)
            {
                MessageBox.Show("Genera un reporte antes de exportar.",
                    "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using var sfd = new SaveFileDialog { Filter = "Archivo CSV (*.csv)|*.csv", FileName = "reporte.csv" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var sb = new StringBuilder();
            sb.AppendLine(string.Join(",", _actual.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));
            foreach (DataRow row in _actual.Rows)
                sb.AppendLine(string.Join(",", row.ItemArray.Select(v =>
                    "\"" + (v?.ToString() ?? "").Replace("\"", "\"\"") + "\"")));

            File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
            MessageBox.Show("Exportado a:\n" + sfd.FileName,
                "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 30/07/2026 */