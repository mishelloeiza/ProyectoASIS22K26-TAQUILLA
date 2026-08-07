/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Con_Admin
{
    public class If_Ciudades
    {
        private readonly Conexion conexion = new Conexion();

        public int ObtenerSiguienteId()
        {
            var con = conexion.GetConnection();

            using (var reset = new MySqlCommand("SET SESSION information_schema_stats_expiry = 0;", con))
            {
                try { reset.ExecuteNonQuery(); }
                catch { }
            }

            const string sql = @"
                SELECT AUTO_INCREMENT
                FROM information_schema.TABLES
                WHERE TABLE_SCHEMA = DATABASE()
                  AND TABLE_NAME = 'tbl_ciudad';";

            using (var cmd = new MySqlCommand(sql, con))
            {
                object r = cmd.ExecuteScalar();
                return (r == null || r == DBNull.Value) ? 1 : Convert.ToInt32(r);
            }
        }

        public DataTable Listar()
        {
            const string sql = @"
                SELECT id_ciudad, nombre_ciudad
                FROM tbl_ciudad
                ORDER BY nombre_ciudad;";

            return Consultar(sql);
        }

        public DataTable Buscar(string texto)
        {
            const string sql = @"
                SELECT id_ciudad, nombre_ciudad
                FROM tbl_ciudad
                WHERE nombre_ciudad LIKE @texto
                ORDER BY nombre_ciudad;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@texto", "%" + (texto ?? "") + "%");
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ObtenerPorId(int idCiudad)
        {
            const string sql = @"
                SELECT id_ciudad, nombre_ciudad
                FROM tbl_ciudad
                WHERE id_ciudad = @id
                LIMIT 1;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idCiudad);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public int Insertar(string nombreCiudad)
        {
            const string sql = @"
                INSERT INTO tbl_ciudad (nombre_ciudad)
                VALUES (@nombre);
                SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nombre", nombreCiudad);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Actualizar(int idCiudad, string nombreCiudad)
        {
            const string sql = @"
                UPDATE tbl_ciudad SET
                    nombre_ciudad = @nombre
                WHERE id_ciudad = @id;";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nombre", nombreCiudad);
                cmd.Parameters.AddWithValue("@id", idCiudad);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int idCiudad)
        {
            const string sql = "DELETE FROM tbl_ciudad WHERE id_ciudad = @id;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idCiudad);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private DataTable Consultar(string sql)
        {
            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            using (var da = new MySqlDataAdapter(cmd))
                da.Fill(tabla);
            return tabla;
        }
    }
}