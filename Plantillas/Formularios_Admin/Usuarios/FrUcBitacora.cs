using clase_conexion;
using Con_Admin;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Forms_Admin.Usuarios
{
    public partial class FrUcBitacora : UserControl
    {
        public FrUcBitacora()
        {
            InitializeComponent();
            CargarBitacora();
        }

        private readonly If_Bitacora datosBitacora = new If_Bitacora();

        private void CargarBitacora()
        {
            try
            {
                string sql = @"SELECT b.id_bitacora AS Id,
                       u.nombre_usuario AS Usuario,
                       CONCAT(ap.nombre_accion_permiso, ' - ', apl.nombre_aplicacion) AS Permiso,
                       n.nombre_pc      AS Equipo,
                       b.fecha_bitacora AS Fecha,
                       b.hora_bitacora  AS Hora,
                       b.ip_bitacora    AS IP
                FROM tbl_bitacora b
                JOIN tbl_usuario u        ON u.id_usuario = b.id_usuario
                LEFT JOIN tbl_permiso p         ON p.id_permiso = b.id_permiso
                LEFT JOIN tbl_accion_permiso ap ON ap.id_accion_permiso = p.id_accion_permiso
                LEFT JOIN tbl_aplicacion apl    ON apl.id_aplicacion = p.id_aplicacion
                LEFT JOIN tbl_nombre_pc n       ON n.id_nombre_pc = b.id_nombre_pc
                ORDER BY b.fecha_bitacora DESC, b.hora_bitacora DESC";

                var miConexion = new conexion();
                MySqlConnection cn = miConexion.GetConnection();

                using (var da = new MySqlDataAdapter(sql, cn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    DgvBitacora.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TlpTitleLabel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarBitacora();
        }
    }
}