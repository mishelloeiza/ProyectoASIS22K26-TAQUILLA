/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 27/07/2026 */

using System.Windows.Forms;

namespace Validaciones
{
    public static class RestrictorCampos
    {
        public static void SoloNumeros(TextBox campo, int longitudMaxima = 0)
        {
            if (campo is null) return;

            if (longitudMaxima > 0) campo.MaxLength = longitudMaxima;

            campo.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;  
                }
            };
        }

        public static void SoloLetras(TextBox campo, int longitudMaxima = 0)
        {
            if (campo is null) return;

            if (longitudMaxima > 0) campo.MaxLength = longitudMaxima;

            campo.KeyPress += (s, e) =>
            {
                bool esLetra = char.IsLetter(e.KeyChar);
                bool esEspacio = e.KeyChar == ' ';

                if (!char.IsControl(e.KeyChar) && !esLetra && !esEspacio)
                {
                    e.Handled = true;
                }
            };
        }

        public static void SoloDecimal(TextBox campo, int longitudMaxima = 0)
        {
            if (campo is null) return;

            if (longitudMaxima > 0) campo.MaxLength = longitudMaxima;

            campo.KeyPress += (s, e) =>
            {
                if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;

                if (e.KeyChar == '.' && !campo.Text.Contains('.')) return;

                e.Handled = true;
            };
        }

        public static void SoloAlfanumerico(TextBox campo, int longitudMaxima = 0)
        {
            if (campo is null) return;

            if (longitudMaxima > 0) campo.MaxLength = longitudMaxima;

            campo.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        public static void FormatoTarjeta(TextBox campo)
        {
            if (campo is null) return;

            campo.MaxLength = 16;
            SoloNumeros(campo);
        }

        public static void FormatoVencimiento(TextBox campo)
        {
            if (campo is null) return;

            campo.MaxLength = 5;   // MM/AA

            campo.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            campo.TextChanged += (s, e) =>
            {
                string texto = campo.Text;

                if (texto.Length == 2 && !texto.Contains('/'))
                {
                    campo.Text = texto + "/";
                    campo.SelectionStart = campo.Text.Length;
                }
            };
        }

        public static void FormatoCvv(TextBox campo)
        {
            if (campo is null) return;

            campo.MaxLength = 4;
            campo.UseSystemPasswordChar = true;
            SoloNumeros(campo);
        }

        public static void FormatoContrasena(TextBox campo, int longitudMaxima = 50)
        {
            if (campo is null) return;

            campo.MaxLength = longitudMaxima;
            campo.UseSystemPasswordChar = true;
        }

        public static void RangoSemanaReserva(DateTimePicker selector)
        {
            if (selector is null) return;

            selector.MinDate = DateTime.Today;
            selector.MaxDate = DateTime.Today.AddDays(Validador.DiasVigenciaReserva);
            selector.Value = DateTime.Today;
        }

        public static void RangoBoletos(NumericUpDown control)
        {
            if (control is null) return;

            control.Minimum = 0;
            control.Maximum = Validador.MaximoBoletos;
            control.DecimalPlaces = 0;
            control.Value = 0;
        }

        public static void ListaCerrada(ComboBox combo)
        {
            if (combo is null) return;

            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void LongitudMaxima(TextBox campo, int maximo)
        {
            if (campo is not null && maximo > 0) campo.MaxLength = maximo;
        }

        public static void RecortarEspacios(TextBox campo)
        {
            if (campo is null) return;

            campo.Leave += (s, e) => campo.Text = campo.Text.Trim();
        }

        public static void RecortarEspacios(params TextBox[] campos)
        {
            foreach (TextBox campo in campos)
            {
                RecortarEspacios(campo);
            }
        }
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 