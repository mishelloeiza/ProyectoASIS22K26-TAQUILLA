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
using System.Windows.Forms;
/*Inicio del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/
namespace Plantilla_Cliente.Formularios
{
    public partial class FrmPagoEfectivo : Form
    {
        private decimal totalAPagar;

        public FrmPagoEfectivo(decimal total)
        {
            InitializeComponent();
            totalAPagar = total;

            lblTotal.Text = totalAPagar.ToString("0.00");
            lblTotal.Enabled = false;

            btnPagar.Enabled = false;

            txtEfectivoRecibido.TextChanged += TxtEfectivoRecibido_TextChanged;
            btnPagar.Click += BtnPagar_Click;
        }

        private void TxtEfectivoRecibido_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtEfectivoRecibido.Text, out decimal recibido))
            {
                decimal vuelto = recibido - totalAPagar;

                if (vuelto >= 0)
                {
                    lblVuelto.Text = "Q " + vuelto.ToString("0.00");
                    lblVuelto.ForeColor = Color.Green; 
                    btnPagar.Enabled = true; 
                }
                else
                {
                    lblVuelto.Text = "Q " + Math.Abs(vuelto).ToString("0.00");
                    lblVuelto.ForeColor = Color.Red; 
                    btnPagar.Enabled = false; 
                }
            }
            else
            {
                lblVuelto.Text = "";
                lblVuelto.ForeColor = Color.Black;
                btnPagar.Enabled = false;
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago en efectivo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
/*Fin del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/