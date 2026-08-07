/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Con_Admin
{
    public class If_Promociones
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
                  AND TABLE_NAME = 'tbl_promocion';";

            using (var cmd = new MySqlCommand(sql, con))
            {
                object r = cmd.ExecuteScalar();
                return (r == null || r == DBNull.Value) ? 1 : Convert.ToInt32(r);
            }
        }

        public DataTable Listar()
        {
            const string sql = @"
                SELECT  pr.id_promocion,
                        pr.nombre_promocion,
                        pr.descripcion_promocion,
                        pr.id_tipo_promocion,
                        t.codigo_tipo_promocion,
                        t.nombre_tipo_promocion,
                        pr.valor_promocion,
                        pr.fecha_inicio_promocion,
                        pr.fecha_fin_promocion,
                        pr.activa_promocion
                FROM tbl_promocion pr
                LEFT JOIN tbl_tipo_promocion t ON t.id_tipo_promocion = pr.id_tipo_promocion
                ORDER BY pr.nombre_promocion;";

            return Consultar(sql);
        }

        public DataTable Buscar(string texto)
        {
            const string sql = @"
                SELECT  pr.id_promocion,
                        pr.nombre_promocion,
                        pr.descripcion_promocion,
                        pr.id_tipo_promocion,
                        t.codigo_tipo_promocion,
                        t.nombre_tipo_promocion,
                        pr.valor_promocion,
                        pr.fecha_inicio_promocion,
                        pr.fecha_fin_promocion,
                        pr.activa_promocion
                FROM tbl_promocion pr
                LEFT JOIN tbl_tipo_promocion t ON t.id_tipo_promocion = pr.id_tipo_promocion
                WHERE pr.nombre_promocion   LIKE @texto
                   OR t.nombre_tipo_promocion LIKE @texto
                ORDER BY pr.nombre_promocion;";

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

        public DataTable ObtenerPorId(int idPromocion)
        {
            const string sql = @"
                SELECT  pr.id_promocion,
                        pr.nombre_promocion,
                        pr.descripcion_promocion,
                        pr.id_tipo_promocion,
                        t.codigo_tipo_promocion,
                        t.nombre_tipo_promocion,
                        pr.valor_promocion,
                        pr.fecha_inicio_promocion,
                        pr.fecha_fin_promocion,
                        pr.activa_promocion
                FROM tbl_promocion pr
                LEFT JOIN tbl_tipo_promocion t ON t.id_tipo_promocion = pr.id_tipo_promocion
                WHERE pr.id_promocion = @id
                LIMIT 1;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPromocion);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarPeliculasDePromocion(int idPromocion)
        {
            const string sql = @"
                SELECT p.id_pelicula, p.titulo_pelicula
                FROM tbl_pelicula_promocion pp
                JOIN tbl_pelicula p ON p.id_pelicula = pp.id_pelicula
                WHERE pp.id_promocion = @id;";

            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPromocion);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarPromocionesDePelicula(int idPelicula)
        {
            const string sql = @"
                SELECT pr.id_promocion, pr.nombre_promocion
                FROM tbl_pelicula_promocion pp
                JOIN tbl_promocion pr ON pr.id_promocion = pp.id_promocion
                WHERE pp.id_pelicula = @id;";

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

        public int Insertar(string nombre, string descripcion, int idTipoPromocion, decimal valor,
                            DateTime fechaInicio, DateTime fechaFin, bool activa, int[] peliculas)
        {
            const string sql = @"
                INSERT INTO tbl_promocion
                    (nombre_promocion, descripcion_promocion, id_tipo_promocion, valor_promocion,
                     fecha_inicio_promocion, fecha_fin_promocion, activa_promocion)
                VALUES
                    (@nombre, @descripcion, @tipo, @valor,
                     @inicio, @fin, @activa);
                SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var tx = con.BeginTransaction())
            {
                try
                {
                    int nuevoId;
                    using (var cmd = new MySqlCommand(sql, con, tx))
                    {
                        CargarParametros(cmd, nombre, descripcion, idTipoPromocion, valor, fechaInicio, fechaFin, activa);
                        nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    GuardarPeliculas(con, tx, nuevoId, peliculas);

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

        public bool Actualizar(int idPromocion, string nombre, string descripcion, int idTipoPromocion, decimal valor,
                              DateTime fechaInicio, DateTime fechaFin, bool activa, int[] peliculas)
        {
            const string sql = @"
                UPDATE tbl_promocion SET
                    nombre_promocion       = @nombre,
                    descripcion_promocion  = @descripcion,
                    id_tipo_promocion      = @tipo,
                    valor_promocion        = @valor,
                    fecha_inicio_promocion = @inicio,
                    fecha_fin_promocion    = @fin,
                    activa_promocion       = @activa
                WHERE id_promocion = @id;";

            var con = conexion.GetConnection();
            using (var tx = con.BeginTransaction())
            {
                try
                {
                    bool ok;
                    using (var cmd = new MySqlCommand(sql, con, tx))
                    {
                        CargarParametros(cmd, nombre, descripcion, idTipoPromocion, valor, fechaInicio, fechaFin, activa);
                        cmd.Parameters.AddWithValue("@id", idPromocion);
                        ok = cmd.ExecuteNonQuery() > 0;
                    }

                    BorrarRelaciones(con, tx, idPromocion);
                    GuardarPeliculas(con, tx, idPromocion, peliculas);

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

        public bool Eliminar(int idPromocion)
        {
            const string sql = "DELETE FROM tbl_promocion WHERE id_promocion = @id;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idPromocion);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ListarPeliculas()
        {
            return ListarCatalogo(
                "SELECT id_pelicula AS Id, titulo_pelicula AS Nombre " +
                "FROM tbl_pelicula ORDER BY titulo_pelicula;");
        }

        public DataTable ListarTipos()
        {
            return ListarCatalogo(
                "SELECT id_tipo_promocion AS Id, nombre_tipo_promocion AS Nombre " +
                "FROM tbl_tipo_promocion ORDER BY nombre_tipo_promocion;");
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

        private void GuardarPeliculas(MySqlConnection con, MySqlTransaction tx, int idPromocion, int[] peliculas)
        {
            if (peliculas == null) return;
            foreach (int idPelicula in peliculas)
            {
                using (var cmd = new MySqlCommand(
                    "INSERT INTO tbl_pelicula_promocion (id_pelicula, id_promocion) VALUES (@p, @pr);", con, tx))
                {
                    cmd.Parameters.AddWithValue("@p", idPelicula);
                    cmd.Parameters.AddWithValue("@pr", idPromocion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void BorrarRelaciones(MySqlConnection con, MySqlTransaction tx, int idPromocion)
        {
            using (var cmd = new MySqlCommand(
                "DELETE FROM tbl_pelicula_promocion WHERE id_promocion = @pr;", con, tx))
            {
                cmd.Parameters.AddWithValue("@pr", idPromocion);
                cmd.ExecuteNonQuery();
            }
        }

        private void CargarParametros(MySqlCommand cmd, string nombre, string descripcion, int idTipoPromocion,
                                      decimal valor, DateTime fechaInicio, DateTime fechaFin, bool activa)
        {
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@descripcion", (object)descripcion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@tipo", idTipoPromocion);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@inicio", fechaInicio.Date);
            cmd.Parameters.AddWithValue("@fin", fechaFin.Date);
            cmd.Parameters.AddWithValue("@activa", activa);
        }
    }
}