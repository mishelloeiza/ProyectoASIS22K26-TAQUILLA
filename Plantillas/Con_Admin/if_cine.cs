/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Con_Admin
{
    public class If_Cines
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
                  AND TABLE_NAME = 'tbl_cine';";

            using (var cmd = new MySqlCommand(sql, con))
            {
                object r = cmd.ExecuteScalar();
                return (r == null || r == DBNull.Value) ? 1 : Convert.ToInt32(r);
            }
        }

        public DataTable Listar()
        {
            const string sql = @"
                SELECT  c.id_cine,
                        c.id_ciudad,
                        ciu.nombre_ciudad,
                        c.nombre_cine
                FROM tbl_cine c
                LEFT JOIN tbl_ciudad ciu ON ciu.id_ciudad = c.id_ciudad
                ORDER BY c.nombre_cine;";

            return Consultar(sql);
        }

        public DataTable Buscar(string texto)
        {
            const string sql = @"
                SELECT  c.id_cine,
                        c.id_ciudad,
                        ciu.nombre_ciudad,
                        c.nombre_cine
                FROM tbl_cine c
                LEFT JOIN tbl_ciudad ciu ON ciu.id_ciudad = c.id_ciudad
                WHERE c.nombre_cine  LIKE @texto
                   OR ciu.nombre_ciudad LIKE @texto
                ORDER BY c.nombre_cine;";

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

        public DataTable ObtenerPorId(int idCine)
        {
            const string sql = @"
                SELECT  c.id_cine,
                        c.id_ciudad,
                        ciu.nombre_ciudad,
                        c.nombre_cine
                FROM tbl_cine c
                LEFT JOIN tbl_ciudad ciu ON ciu.id_ciudad = c.id_ciudad
                WHERE c.id_cine = @id
                LIMIT 1;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idCine);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public int Insertar(int idCiudad, string nombreCine)
        {
            const string sql = @"
                INSERT INTO tbl_cine (id_ciudad, nombre_cine)
                VALUES (@ciudad, @nombre);
                SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ciudad", idCiudad);
                cmd.Parameters.AddWithValue("@nombre", nombreCine);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Actualizar(int idCine, int idCiudad, string nombreCine)
        {
            const string sql = @"
                UPDATE tbl_cine SET
                    id_ciudad   = @ciudad,
                    nombre_cine = @nombre
                WHERE id_cine = @id;";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ciudad", idCiudad);
                cmd.Parameters.AddWithValue("@nombre", nombreCine);
                cmd.Parameters.AddWithValue("@id", idCine);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int idCine)
        {
            const string sql = "DELETE FROM tbl_cine WHERE id_cine = @id;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idCine);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ListarCiudades()
        {
            return ListarCatalogo(
                "SELECT id_ciudad AS Id, nombre_ciudad AS Nombre " +
                "FROM tbl_ciudad ORDER BY nombre_ciudad;");
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

        private DataTable ListarCatalogo(string sql)
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