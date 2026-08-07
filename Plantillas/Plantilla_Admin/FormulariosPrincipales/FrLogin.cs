/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 22/07/2026 */


using Con_Admin;
using Plantilla_Admin;
using Plantilla_Admin.FormulariosPrincipales;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;



namespace Plantilla_Cliente
{
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
            //this.AcceptButton = BtnIngresar;
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BtnIngresar.PerformClick();
                    e.Handled = true;
                }
            };
        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            string usuario = TbUsuario.Text.Trim();
            string contrasena = TbContra.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                If_Login api = new If_Login();
                DataTable dt = api.ObtenerUsuario(usuario, contrasena);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string perfil = dt.Rows[0]["nombre_perfil"] == DBNull.Value
                    ? "" : dt.Rows[0]["nombre_perfil"].ToString();

                if (!perfil.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Acceso permitido solo a administradores.", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idUsuario = Convert.ToInt32(dt.Rows[0]["id_usuario"]);
                string nombre = dt.Rows[0]["nombre_usuario"].ToString();
                Sesion.Iniciar(nombre, perfil);
                RegistrarBitacora(idUsuario);

                FrMenuAdmin menu = new FrMenuAdmin();
                menu.FormClosed += (s, args) => this.Close();
                this.Hide();
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar sesión.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //funcargarpagina(new FrUcMainFunciones());
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = TbUsuario.Text.Trim();
            string contrasena = TbContra.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                If_Login api = new If_Login();
                DataTable dt = api.ObtenerUsuario(usuario, contrasena);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                string perfil = dt.Rows[0]["nombre_perfil"] == DBNull.Value
                    ? "" : dt.Rows[0]["nombre_perfil"].ToString();
                /*
               if (!perfil.Equals("admin", StringComparison.OrdinalIgnoreCase))
               {
                   MessageBox.Show("Acceso permitido solo a administradores.", "Login",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   return;
               }*/

                int idUsuario = Convert.ToInt32(dt.Rows[0]["id_usuario"]);
                string nombre = dt.Rows[0]["nombre_usuario"].ToString();
                Sesion.Iniciar(nombre, perfil);
                RegistrarBitacora(idUsuario);

                FrMenu menu = new FrMenu();
                menu.FormClosed += (s, args) => this.Close();
                this.Hide();
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar sesión.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PicLogo_Click(object sender, EventArgs e)
        {

        }

        // ============================================================
        // BITÁCORA — registra el inicio de sesión en tbl_bitacora
        // ============================================================
        private static void RegistrarBitacora(int idUsuario, int? idPermiso = null)
        {
            try
            {
                string ip = ObtenerIpLocal();
                int? idNombrePc = ObtenerOCrearNombrePc(Environment.MachineName);
                //METODO MISHEL LOEIZA

                // Le avisamos a Con_Admin.Conexion quién es el usuario activo,
                // para que cualquier conexión que abra cualquier formulario
                // lleve esta info y los triggers de bitácora puedan usarla
                Con_Admin.Conexion.SesionIdUsuario = idUsuario;
                Con_Admin.Conexion.SesionIdNombrePc = idNombrePc;
                Con_Admin.Conexion.SesionIp = ip;

                var conexion = new Conexion();
                MySqlConnection cn = conexion.GetConnection();

                string sql = @"INSERT INTO tbl_bitacora (id_usuario, id_permiso, id_nombre_pc, ip_bitacora)
                        VALUES (@idUsuario, @idPermiso, @idNombrePc, @ip)";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@idPermiso", (object)idPermiso ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idNombrePc", (object)idNombrePc ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ip", ip);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                // La bitácora nunca debe interrumpir el flujo normal del login (MISHEL LOEIZA 9959-23-3457
            }
        }

        private static int? ObtenerOCrearNombrePc(string nombrePc)
        {
            var conexion = new Conexion();
            MySqlConnection cn = conexion.GetConnection();

            string sqlBuscar = "SELECT id_nombre_pc FROM tbl_nombre_pc WHERE nombre_pc = @nombre";
            using (var cmdBuscar = new MySqlCommand(sqlBuscar, cn))
            {
                cmdBuscar.Parameters.AddWithValue("@nombre", nombrePc);
                var resultado = cmdBuscar.ExecuteScalar();
                if (resultado != null)
                    return Convert.ToInt32(resultado);
            }

            string sqlInsertar = "INSERT INTO tbl_nombre_pc (nombre_pc) VALUES (@nombre); SELECT LAST_INSERT_ID();";
            using (var cmdInsertar = new MySqlCommand(sqlInsertar, cn))
            {
                cmdInsertar.Parameters.AddWithValue("@nombre", nombrePc);
                var nuevoId = cmdInsertar.ExecuteScalar();
                return Convert.ToInt32(nuevoId);
            }
        }

        private static string ObtenerIpLocal()
        {
            try
            {
                string hostName = Dns.GetHostName();
                var ips = Dns.GetHostAddresses(hostName);
                foreach (var ip in ips)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                        return ip.ToString();
                }
            }
            catch { }
            return "0.0.0.0";
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */