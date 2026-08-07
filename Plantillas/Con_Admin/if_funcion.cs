/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using Con_Admin;

namespace Con_Admin
{
    public class If_Funciones
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
                  AND TABLE_NAME = 'tbl_funcion';";

            using (var cmd = new MySqlCommand(sql, con))
            {
                object r = cmd.ExecuteScalar();
                return (r == null || r == DBNull.Value) ? 1 : Convert.ToInt32(r);
            }
        }

        public DataTable Listar()
        {
            const string sql = @"
                SELECT  f.id_funcion,
                        f.id_pelicula,
                        p.titulo_pelicula,
                        f.id_sala,
                        s.numero_sala,
                        s.id_cine,
                        c.nombre_cine,
                        f.fecha_funcion,
                        f.hora_funcion,
                        f.precio_funcion
                FROM tbl_funcion f
                LEFT JOIN tbl_pelicula p ON p.id_pelicula = f.id_pelicula
                LEFT JOIN tbl_sala     s ON s.id_sala     = f.id_sala
                LEFT JOIN tbl_cine     c ON c.id_cine     = s.id_cine
                ORDER BY f.fecha_funcion DESC, f.hora_funcion;";

            return Consultar(sql);
        }

        public DataTable Buscar(string texto)
        {
            const string sql = @"
                SELECT  f.id_funcion,
                        f.id_pelicula,
                        p.titulo_pelicula,
                        f.id_sala,
                        s.numero_sala,
                        s.id_cine,
                        c.nombre_cine,
                        f.fecha_funcion,
                        f.hora_funcion,
                        f.precio_funcion
                FROM tbl_funcion f
                LEFT JOIN tbl_pelicula p ON p.id_pelicula = f.id_pelicula
                LEFT JOIN tbl_sala     s ON s.id_sala     = f.id_sala
                LEFT JOIN tbl_cine     c ON c.id_cine     = s.id_cine
                WHERE p.titulo_pelicula LIKE @texto
                   OR c.nombre_cine     LIKE @texto
                ORDER BY f.fecha_funcion DESC, f.hora_funcion;";

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

        public DataTable ObtenerPorId(int idFuncion)
        {
            const string sql = @"
                SELECT  f.id_funcion,
                        f.id_pelicula,
                        p.titulo_pelicula,
                        f.id_sala,
                        s.numero_sala,
                        s.id_cine,
                        c.nombre_cine,
                        f.fecha_funcion,
                        f.hora_funcion,
                        f.precio_funcion
                FROM tbl_funcion f
                LEFT JOIN tbl_pelicula p ON p.id_pelicula = f.id_pelicula
                LEFT JOIN tbl_sala     s ON s.id_sala     = f.id_sala
                LEFT JOIN tbl_cine     c ON c.id_cine     = s.id_cine
                WHERE f.id_funcion = @id
                LIMIT 1;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idFuncion);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarPorPelicula(int idPelicula)
        {
            const string sql = @"
                SELECT  f.id_funcion,
                        f.id_sala,
                        s.numero_sala,
                        s.id_cine,
                        c.nombre_cine,
                        f.fecha_funcion,
                        f.hora_funcion,
                        f.precio_funcion
                FROM tbl_funcion f
                LEFT JOIN tbl_sala s ON s.id_sala = f.id_sala
                LEFT JOIN tbl_cine c ON c.id_cine = s.id_cine
                WHERE f.id_pelicula = @id
                ORDER BY f.fecha_funcion, f.hora_funcion;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPelicula);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarPorSala(int idSala)
        {
            const string sql = @"
                SELECT  f.id_funcion,
                        f.id_pelicula,
                        p.titulo_pelicula,
                        f.fecha_funcion,
                        f.hora_funcion,
                        f.precio_funcion
                FROM tbl_funcion f
                LEFT JOIN tbl_pelicula p ON p.id_pelicula = f.id_pelicula
                WHERE f.id_sala = @id
                ORDER BY f.fecha_funcion, f.hora_funcion;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idSala);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public int Insertar(int idPelicula, int idSala, DateTime fechaFuncion,
                            TimeSpan horaFuncion, decimal precioFuncion)
        {
            const string sql = @"
                INSERT INTO tbl_funcion
                    (id_pelicula, id_sala, fecha_funcion, hora_funcion, precio_funcion)
                VALUES
                    (@pelicula, @sala, @fecha, @hora, @precio);
                SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var tx = con.BeginTransaction())
            {
                try
                {
                    int nuevoId;
                    using (var cmd = new MySqlCommand(sql, con, tx))
                    {
                        CargarParametros(cmd, idPelicula, idSala, fechaFuncion, horaFuncion, precioFuncion);
                        nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    tx.Commit();
                    return nuevoId;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public bool Actualizar(int idFuncion, int idPelicula, int idSala, DateTime fechaFuncion,
                              TimeSpan horaFuncion, decimal precioFuncion)
        {
            const string sql = @"
                UPDATE tbl_funcion SET
                    id_pelicula    = @pelicula,
                    id_sala        = @sala,
                    fecha_funcion  = @fecha,
                    hora_funcion   = @hora,
                    precio_funcion = @precio
                WHERE id_funcion = @id;";

            var con = conexion.GetConnection();
            using (var tx = con.BeginTransaction())
            {
                try
                {
                    bool ok;
                    using (var cmd = new MySqlCommand(sql, con, tx))
                    {
                        CargarParametros(cmd, idPelicula, idSala, fechaFuncion, horaFuncion, precioFuncion);
                        cmd.Parameters.AddWithValue("@id", idFuncion);
                        ok = cmd.ExecuteNonQuery() > 0;
                    }

                    tx.Commit();
                    return ok;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public bool Eliminar(int idFuncion)
        {
            const string sql = "DELETE FROM tbl_funcion WHERE id_funcion = @id;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idFuncion);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ListarPeliculas()
        {
            return ListarCatalogo(
                "SELECT id_pelicula AS Id, titulo_pelicula AS Nombre " +
                "FROM tbl_pelicula ORDER BY titulo_pelicula;");
        }

        public DataTable ListarSalas()
        {
            return ListarCatalogo(@"
                SELECT  s.id_sala AS Id,
                        CONCAT(c.nombre_cine, ' - Sala ', s.numero_sala) AS Nombre
                FROM tbl_sala s
                LEFT JOIN tbl_cine c ON c.id_cine = s.id_cine
                ORDER BY c.nombre_cine, s.numero_sala;");
        }

        public DataTable ListarCines()
        {
            return ListarCatalogo(
                "SELECT id_cine AS Id, nombre_cine AS Nombre " +
                "FROM tbl_cine ORDER BY nombre_cine;");
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

        private void CargarParametros(MySqlCommand cmd, int idPelicula, int idSala,
                                      DateTime fechaFuncion, TimeSpan horaFuncion, decimal precioFuncion)
        {
            cmd.Parameters.AddWithValue("@pelicula", idPelicula);
            cmd.Parameters.AddWithValue("@sala", idSala);
            cmd.Parameters.AddWithValue("@fecha", fechaFuncion.Date);
            cmd.Parameters.AddWithValue("@hora", horaFuncion);
            cmd.Parameters.AddWithValue("@precio", precioFuncion);
        }
    }
}
