using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plantilla_Cliente.Formularios;
using Plantilla_Cliente.Clases;
/*Inicio del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/
namespace Plantilla_Cliente
{
    public partial class Pago : Form
    {
        private decimal totalAPagar;
        public int IdMetodoPagoSeleccionado { get; private set; }
        private Con_Cliente gconexion;

        public Pago(decimal total)
        {
            InitializeComponent();
            gconexion = new Con_Cliente();
            totalAPagar = total;

            lblTotal.Text = "Total a Pagar: Q " + totalAPagar.ToString("0.00");

            try
            {
                DataTable dtMetodos = gconexion.ObtenerMetodosPago();
                if (dtMetodos != null && dtMetodos.Rows.Count > 0)
                {
                    cboMetodoPago.DataSource = dtMetodos;
                    cboMetodoPago.DisplayMember = "nombre_metodo_pago";
                    cboMetodoPago.ValueMember = "id_metodo_pago";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar métodos de pago: " + ex.Message);
            }
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtMetodos = gconexion.ObtenerMetodosPago();
                if (dtMetodos != null && dtMetodos.Rows.Count > 0)
                {
                    cboMetodoPago.DataSource = dtMetodos;
                    cboMetodoPago.DisplayMember = "nombre_metodo_pago";
                    cboMetodoPago.ValueMember = "id_metodo_pago";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar métodos de pago: " + ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboMetodoPago.SelectedValue != null)
            {
                int idMetodo = Convert.ToInt32(cboMetodoPago.SelectedValue);
                bool pagoExitoso = false;

                // 1 = efectivo, 2 = tarjeta, 3 = transferencia (según tu tabla tbl_metodo_pago)
                if (idMetodo == 1)
                {
                    using (FrmPagoEfectivo frm = new FrmPagoEfectivo(totalAPagar))
                    {
                        if (frm.ShowDialog() == DialogResult.OK) pagoExitoso = true;
                    }
                }
                else if (idMetodo == 2)
                {
                    using (FrmPagoTarjeta frm = new FrmPagoTarjeta(totalAPagar))
                    {
                        if (frm.ShowDialog() == DialogResult.OK) pagoExitoso = true;
                    }
                }
                else if (idMetodo == 3)
                {
                    using (FrmPagoTransferencia frm = new FrmPagoTransferencia(totalAPagar))
                    {
                        if (frm.ShowDialog() == DialogResult.OK) pagoExitoso = true;
                    }
                }

                if (pagoExitoso)
                {
                    IdMetodoPagoSeleccionado = idMetodo;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El proceso de pago no fue completado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un método de pago de la lista.");
            }
        }
    }
}
/*Fin del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/