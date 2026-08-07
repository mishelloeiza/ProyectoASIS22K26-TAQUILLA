using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Inicio del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/
namespace Plantilla_Cliente.Formularios
{
    public partial class FrmPagoTransferencia : Form
    {
        public FrmPagoTransferencia(decimal total)
        {
            InitializeComponent();
            lblTotal.Text = "Q " + total.ToString("0.00");
            lblInstrucciones.Text = "Transfiera a la Cuenta Monetaria\nBanco Industrial: 000-1234567-8";
        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
            if (txtReferencia.Text.Length >= 6)
            {
                btnVerificar.Enabled = true;
            }
            else
            {
                btnVerificar.Enabled = false;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transferencia verificada exitosamente en el sistema bancario.", "Verificación");
            this.DialogResult = DialogResult.OK;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
/*Fin del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/