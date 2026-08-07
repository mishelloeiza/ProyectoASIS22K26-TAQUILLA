using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Inicio de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 28/07/2026 */
namespace Con_Admin
{
    public class Conexion
    {
        /*
        private MySqlConnection connecion;
        private String server = "172.20.10.7";
        private String datebase = "taquillas_cine";
        private String user = "root1";
        private String password = "Root";
        private String pconexion;
        */

        private MySqlConnection connecion;
        private String server = "localhost";
        private String datebase = "taquillas_cine";
        private String user = "root";
        private String password = "root";
        private String pconexion;

        // Datos de sesión usados por los triggers de bitácora para saber
        // quién y desde qué equipo/ip se realizó cada acción
        public static int SesionIdUsuario { get; set; }
        public static int? SesionIdNombrePc { get; set; }
        public static string SesionIp { get; set; }

        public Conexion()
        {
            pconexion = "Server=" + server +
               ";Database=" + datebase +
               ";Uid=" + user +
               ";Pwd=" + password +
               ";Allow User Variables=True;";
        }

        public MySqlConnection GetConnection()
        {
            if (connecion == null)
            {
                connecion = new MySqlConnection(pconexion);
                connecion.Open();

                // Le avisamos a MySQL quién es el usuario activo, para que//MISHEL LOEIZA
                // los triggers de bitácora sepan a quién atribuir la acción
                if (SesionIdUsuario > 0)
                {
                    using (var cmd = new MySqlCommand(
                        "SET @bitacora_usuario = @uid, @bitacora_pc = @pcid, @bitacora_ip = @ip;",
                        connecion))
                    {
                        cmd.Parameters.AddWithValue("@uid", SesionIdUsuario);
                        cmd.Parameters.AddWithValue("@pcid", (object)SesionIdNombrePc ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ip", SesionIp ?? "0.0.0.0");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            return connecion;
        }
    }
}