/* Inicio de Codigo de Diana Mishel Loeiza Ramírez con carnet: 9959-23-3457 en la
 * fecha de: 05/08/2026 */

using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Con_Admin
{
    public class If_Bitacora
    {
        private readonly Conexion conexion = new Conexion();

        public DataTable Listar()
        {
            const string sql = @"
                SELECT  b.id_bitacora AS Id,
                        u.nombre_usuario AS Usuario,
                        CONCAT(ap.nombre_accion_permiso, ' - ', apl.nombre_aplicacion) AS Permiso,
                        n.nombre_pc      AS Equipo,
                        b.fecha_bitacora AS Fecha,
                        b.hora_bitacora  AS Hora,
                        b.ip_bitacora    AS IP
                FROM tbl_bitacora b
                JOIN tbl_usuario u              ON u.id_usuario = b.id_usuario
                LEFT JOIN tbl_permiso p         ON p.id_permiso = b.id_permiso
                LEFT JOIN tbl_accion_permiso ap ON ap.id_accion_permiso = p.id_accion_permiso
                LEFT JOIN tbl_aplicacion apl    ON apl.id_aplicacion = p.id_aplicacion
                LEFT JOIN tbl_nombre_pc n       ON n.id_nombre_pc = b.id_nombre_pc
                ORDER BY b.fecha_bitacora DESC, b.hora_bitacora DESC;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            using (var da = new MySqlDataAdapter(cmd))
            {
                da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable Buscar(string texto)
        {
            const string sql = @"
                SELECT  b.id_bitacora AS Id,
                        u.nombre_usuario AS Usuario,
                        CONCAT(ap.nombre_accion_permiso, ' - ', apl.nombre_aplicacion) AS Permiso,
                        n.nombre_pc      AS Equipo,
                        b.fecha_bitacora AS Fecha,
                        b.hora_bitacora  AS Hora,
                        b.ip_bitacora    AS IP
                FROM tbl_bitacora b
                JOIN tbl_usuario u              ON u.id_usuario = b.id_usuario
                LEFT JOIN tbl_permiso p         ON p.id_permiso = b.id_permiso
                LEFT JOIN tbl_accion_permiso ap ON ap.id_accion_permiso = p.id_accion_permiso
                LEFT JOIN tbl_aplicacion apl    ON apl.id_aplicacion = p.id_aplicacion
                LEFT JOIN tbl_nombre_pc n       ON n.id_nombre_pc = b.id_nombre_pc
                WHERE u.nombre_usuario LIKE @texto
                   OR ap.nombre_accion_permiso LIKE @texto
                   OR apl.nombre_aplicacion LIKE @texto
                   OR n.nombre_pc LIKE @texto
                   OR b.ip_bitacora LIKE @texto
                ORDER BY b.fecha_bitacora DESC, b.hora_bitacora DESC;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@texto", "%" + (texto ?? "") + "%");
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable BuscarPorFecha(DateTime desde, DateTime hasta)
        {
            const string sql = @"
                SELECT  b.id_bitacora AS Id,
                        u.nombre_usuario AS Usuario,
                        CONCAT(ap.nombre_accion_permiso, ' - ', apl.nombre_aplicacion) AS Permiso,
                        n.nombre_pc      AS Equipo,
                        b.fecha_bitacora AS Fecha,
                        b.hora_bitacora  AS Hora,
                        b.ip_bitacora    AS IP
                FROM tbl_bitacora b
                JOIN tbl_usuario u              ON u.id_usuario = b.id_usuario
                LEFT JOIN tbl_permiso p         ON p.id_permiso = b.id_permiso
                LEFT JOIN tbl_accion_permiso ap ON ap.id_accion_permiso = p.id_accion_permiso
                LEFT JOIN tbl_aplicacion apl    ON apl.id_aplicacion = p.id_aplicacion
                LEFT JOIN tbl_nombre_pc n       ON n.id_nombre_pc = b.id_nombre_pc
                WHERE b.fecha_bitacora BETWEEN @desde AND @hasta
                ORDER BY b.fecha_bitacora DESC, b.hora_bitacora DESC;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@desde", desde.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Date);
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}
/* Fin de Codigo de Diana Mishel Loeiza Ramírez con carnet: 9959-23-3457 en la
 * fecha de: 05/08/2026 */