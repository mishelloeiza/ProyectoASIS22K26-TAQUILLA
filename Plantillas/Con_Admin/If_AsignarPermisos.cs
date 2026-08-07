/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Con_Admin
{
    public class If_AsignarPermisos
    {
        private readonly Conexion conexion = new Conexion();

        public DataTable ListarPerfiles()
        {
            const string sql = @"SELECT id_perfil AS Id, nombre_perfil AS Nombre
                         FROM tbl_perfil
                         WHERE LOWER(nombre_perfil) <> 'admin'
                         ORDER BY nombre_perfil;";
            return Consultar(sql);
        }

        public DataTable ListarAcciones()
        {
            const string sql = @"SELECT id_accion_permiso AS Id, nombre_accion_permiso AS Nombre
                                 FROM tbl_accion_permiso
                                 ORDER BY nombre_accion_permiso;";
            return Consultar(sql);
        }

        public DataTable ListarAplicaciones()
        {
            const string sql = @"SELECT id_aplicacion AS Id, nombre_aplicacion AS Nombre
                                 FROM tbl_aplicacion
                                 ORDER BY nombre_aplicacion;";
            return Consultar(sql);
        }

        public DataTable Listar()
        {
            const string sql = @"
                SELECT  pp.id_perfil,
                        pp.id_permiso,
                        pe.nombre_perfil,
                        pm.id_accion_permiso,
                        ac.nombre_accion_permiso,
                        pm.id_aplicacion,
                        ap.codigo_aplicacion,
                        ap.nombre_aplicacion
                FROM tbl_perfil_permiso pp
                JOIN tbl_perfil        pe ON pe.id_perfil        = pp.id_perfil
                JOIN tbl_permiso       pm ON pm.id_permiso       = pp.id_permiso
                JOIN tbl_accion_permiso ac ON ac.id_accion_permiso = pm.id_accion_permiso
                JOIN tbl_aplicacion    ap ON ap.id_aplicacion    = pm.id_aplicacion
                WHERE LOWER(pe.nombre_perfil) <> 'admin'
                ORDER BY pe.nombre_perfil, ap.nombre_aplicacion, ac.nombre_accion_permiso;";
            return Consultar(sql);
        }

        public bool Asignar(int idPerfil, int idAccion, int idAplicacion)
        {
            var con = conexion.GetConnection();
            int idPermiso = ObtenerOCrearPermiso(con, idAccion, idAplicacion);

            const string existe = @"SELECT COUNT(*) FROM tbl_perfil_permiso
                                    WHERE id_perfil = @p AND id_permiso = @perm;";
            using (var cmd = new MySqlCommand(existe, con))
            {
                cmd.Parameters.AddWithValue("@p", idPerfil);
                cmd.Parameters.AddWithValue("@perm", idPermiso);
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0) return false;
            }

            const string ins = @"INSERT INTO tbl_perfil_permiso (id_perfil, id_permiso)
                                 VALUES (@p, @perm);";
            using (var cmd = new MySqlCommand(ins, con))
            {
                cmd.Parameters.AddWithValue("@p", idPerfil);
                cmd.Parameters.AddWithValue("@perm", idPermiso);
                cmd.ExecuteNonQuery();
            }
            return true;
        }

        public bool Eliminar(int idPerfil, int idAccion, int idAplicacion)
        {
            var con = conexion.GetConnection();

            const string buscar = @"SELECT id_permiso FROM tbl_permiso
                            WHERE id_accion_permiso = @a AND id_aplicacion = @ap
                            LIMIT 1;";
            int idPermiso;
            using (var cmd = new MySqlCommand(buscar, con))
            {
                cmd.Parameters.AddWithValue("@a", idAccion);
                cmd.Parameters.AddWithValue("@ap", idAplicacion);
                var r = cmd.ExecuteScalar();
                if (r == null || r == DBNull.Value) return false;   
                idPermiso = Convert.ToInt32(r);
            }

            const string del = @"DELETE FROM tbl_perfil_permiso
                         WHERE id_perfil = @p AND id_permiso = @perm;";
            using (var cmd = new MySqlCommand(del, con))
            {
                cmd.Parameters.AddWithValue("@p", idPerfil);
                cmd.Parameters.AddWithValue("@perm", idPermiso);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private int ObtenerOCrearPermiso(MySqlConnection con, int idAccion, int idAplicacion)
        {
            const string buscar = @"SELECT id_permiso FROM tbl_permiso
                                    WHERE id_accion_permiso = @a AND id_aplicacion = @ap
                                    LIMIT 1;";
            using (var cmd = new MySqlCommand(buscar, con))
            {
                cmd.Parameters.AddWithValue("@a", idAccion);
                cmd.Parameters.AddWithValue("@ap", idAplicacion);
                var r = cmd.ExecuteScalar();
                if (r != null && r != DBNull.Value) return Convert.ToInt32(r);
            }

            const string crear = @"INSERT INTO tbl_permiso (id_accion_permiso, id_aplicacion)
                                   VALUES (@a, @ap); SELECT LAST_INSERT_ID();";
            using (var cmd = new MySqlCommand(crear, con))
            {
                cmd.Parameters.AddWithValue("@a", idAccion);
                cmd.Parameters.AddWithValue("@ap", idAplicacion);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private DataTable Consultar(string sql, params MySqlParameter[] parametros)
        {
            var tabla = new DataTable();
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);
                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }
            return tabla;
        }
        public int ContarPermisos(string perfil, string aplicacion, string accion = null)
        {
            var con = conexion.GetConnection();
            string sql = @"
        SELECT COUNT(*)
        FROM tbl_perfil_permiso pp
        JOIN tbl_perfil         pe ON pe.id_perfil         = pp.id_perfil
        JOIN tbl_permiso        pm ON pm.id_permiso        = pp.id_permiso
        JOIN tbl_aplicacion     ap ON ap.id_aplicacion     = pm.id_aplicacion
        JOIN tbl_accion_permiso ac ON ac.id_accion_permiso = pm.id_accion_permiso
        WHERE LOWER(pe.nombre_perfil) = LOWER(@perfil)
          AND (LOWER(ap.nombre_aplicacion) = LOWER(@app)
               OR LOWER(ap.codigo_aplicacion) = LOWER(@app))";

            if (!string.IsNullOrWhiteSpace(accion))
                sql += " AND LOWER(ac.nombre_accion_permiso) = LOWER(@accion)";

            sql += ";";

            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@perfil", perfil ?? "");
                cmd.Parameters.AddWithValue("@app", aplicacion ?? "");
                if (!string.IsNullOrWhiteSpace(accion))
                    cmd.Parameters.AddWithValue("@accion", accion);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */