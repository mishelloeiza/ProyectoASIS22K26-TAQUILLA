using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
/*Inicio del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/
namespace Plantilla_Cliente.Formularios
{
    public partial class FrmPagoTarjeta : Form
    {
        public FrmPagoTarjeta(decimal total)
        {
            InitializeComponent();
            lblTotal.Text = "Q " + total.ToString("0.00");

            if (picMarcaTarjeta != null) picMarcaTarjeta.Image = null;

            txtNumeroTarjeta.TextChanged += TxtNumeroTarjeta_TextChanged;
            btnProcesar.Click += btnProcesar_Click;
        }

        private void TxtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
            string numero = txtNumeroTarjeta.Text.Replace(" ", "").Replace("-", "");

            if (numero.StartsWith("4"))
            {
                picMarcaTarjeta.Image = Properties.Resources.VisaLogo;
            }
            else if (numero.StartsWith("5"))
            {
                picMarcaTarjeta.Image = Properties.Resources.MasterCardLogo;
            }
            else
            {
                picMarcaTarjeta.Image = null;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string numero = txtNumeroTarjeta.Text.Replace(" ", "").Replace("-", "");
            string cvv = txtCVV.Text.Trim();
            string fecha = txtFechaExpiracion.Text.Trim();

            if (numero.Length < 13 || numero.Length > 19 || !numero.All(char.IsDigit))
            {
                MessageBox.Show("El número de tarjeta es inválido. Ingrese solo números (entre 13 y 19 dígitos).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (!ValidarLuhn(numero))
            {
                MessageBox.Show("El número de tarjeta no es válido matemáticamente.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cvv.Length != 3 || !cvv.All(char.IsDigit))
            {
                MessageBox.Show("El código de seguridad (CVV) debe tener exactamente 3 dígitos numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarFechaVencimiento(fecha))
            {
                MessageBox.Show("La fecha de vencimiento es inválida o la tarjeta está vencida. Use el formato MM/AA.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // APROBACIÓN FINAL
            MessageBox.Show("Transacción aprobada por el banco emisor.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Algoritmo matemático para validar tarjetas reales
        private bool ValidarLuhn(string numeroTarjeta)
        {
            int sum = 0;
            bool alternate = false;
            for (int i = numeroTarjeta.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(numeroTarjeta.Substring(i, 1));
                if (alternate)
                {
                    n *= 2;
                    if (n > 9) n -= 9;
                }
                sum += n;
                alternate = !alternate;
            }
            return (sum % 10 == 0);
        }

        private bool ValidarFechaVencimiento(string fecha)
        {
            if (string.IsNullOrWhiteSpace(fecha)) return false;

            string[] partes = fecha.Split(new char[] { '/', '-' });
            if (partes.Length != 2) return false;

            if (int.TryParse(partes[0], out int mes) && int.TryParse(partes[1], out int anio))
            {
                if (mes < 1 || mes > 12) return false;

                if (anio < 100) anio += 2000;

                DateTime fechaVencimiento = new DateTime(anio, mes, 1).AddMonths(1).AddDays(-1);

                if (fechaVencimiento >= DateTime.Now)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
/*Fin del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/