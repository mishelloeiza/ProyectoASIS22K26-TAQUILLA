using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace Con_Admin
{
    public class If_Salas
    {
        private readonly Conexion conexion = new Conexion();

        public int ObtenerSiguienteId()
        {
            var con = conexion.GetConnection();

            using (var reset = new MySqlCommand(
                "SET SESSION information_schema_stats_expiry = 0;", con))
            {
                try { reset.ExecuteNonQuery(); }
                catch { }
            }

            const string sql = @"
                SELECT AUTO_INCREMENT
                FROM information_schema.TABLES
                WHERE TABLE_SCHEMA = DATABASE()
                AND TABLE_NAME='tbl_sala';";

            using (var cmd = new MySqlCommand(sql, con))
            {
                object r = cmd.ExecuteScalar();
                return (r == null || r == DBNull.Value)
                    ? 1
                    : Convert.ToInt32(r);
            }
        }

        public DataTable Listar()
        {
            const string sql = @"
            SELECT
                s.id_sala,
                s.numero_sala,
                s.capacidad_sala,
                s.id_tipo_sala,
                ts.nombre_tipo_sala,
                s.id_cine,
                c.nombre_cine
            FROM tbl_sala s
            INNER JOIN tbl_tipo_sala ts
                ON ts.id_tipo_sala=s.id_tipo_sala
            INNER JOIN tbl_cine c
                ON c.id_cine=s.id_cine
            ORDER BY s.numero_sala;";

            return Consultar(sql);
        }

        public DataTable Buscar(string texto)
        {
            const string sql = @"
            SELECT
                s.id_sala,
                s.numero_sala,
                s.capacidad_sala,
                s.id_tipo_sala,
                ts.nombre_tipo_sala,
                s.id_cine,
                c.nombre_cine
            FROM tbl_sala s
            INNER JOIN tbl_tipo_sala ts
                ON ts.id_tipo_sala=s.id_tipo_sala
            INNER JOIN tbl_cine c
                ON c.id_cine=s.id_cine
            WHERE c.nombre_cine LIKE @texto
               OR ts.nombre_tipo_sala LIKE @texto
               OR s.numero_sala LIKE @texto
            ORDER BY s.numero_sala;";

            DataTable tabla = new DataTable();

            var con = conexion.GetConnection();

            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@texto",
                    "%" + (texto ?? "") + "%");

                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable ObtenerPorId(int idSala)
        {
            const string sql = @"
            SELECT *
            FROM tbl_sala
            WHERE id_sala=@id
            LIMIT 1;";

            DataTable tabla = new DataTable();

            var con = conexion.GetConnection();

            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idSala);

                using (var da = new MySqlDataAdapter(cmd))
                    da.Fill(tabla);
            }

            return tabla;
        }

        public bool Insertar(
            int idTipoSala,
            int idCine,
            int numeroSala,
            int capacidad)
        {
            const string sql = @"
            INSERT INTO tbl_sala
            (
                id_tipo_sala,
                id_cine,
                numero_sala,
                capacidad_sala
            )
            VALUES
            (
                @tipo,
                @cine,
                @numero,
                @capacidad
            );";

            var con = conexion.GetConnection();

            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@tipo", idTipoSala);
                cmd.Parameters.AddWithValue("@cine", idCine);
                cmd.Parameters.AddWithValue("@numero", numeroSala);
                cmd.Parameters.AddWithValue("@capacidad", capacidad);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Actualizar(
            int idSala,
            int idTipoSala,
            int idCine,
            int numeroSala,
            int capacidad)
        {
            const string sql = @"
            UPDATE tbl_sala
            SET
                id_tipo_sala=@tipo,
                id_cine=@cine,
                numero_sala=@numero,
                capacidad_sala=@capacidad
            WHERE id_sala=@id;";

            var con = conexion.GetConnection();

            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idSala);
                cmd.Parameters.AddWithValue("@tipo", idTipoSala);
                cmd.Parameters.AddWithValue("@cine", idCine);
                cmd.Parameters.AddWithValue("@numero", numeroSala);
                cmd.Parameters.AddWithValue("@capacidad", capacidad);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int idSala)
        {
            const string sql =
                "DELETE FROM tbl_sala WHERE id_sala=@id;";

            var con = conexion.GetConnection();

            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idSala);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ListarTiposSala()
        {
            return ListarCatalogo(
                "SELECT id_tipo_sala AS Id," +
                " nombre_tipo_sala AS Nombre" +
                " FROM tbl_tipo_sala" +
                " ORDER BY nombre_tipo_sala;");
        }

        public DataTable ListarCines()
        {
            return ListarCatalogo(
                "SELECT id_cine AS Id," +
                " nombre_cine AS Nombre" +
                " FROM tbl_cine" +
                " ORDER BY nombre_cine;");
        }

        private DataTable Consultar(string sql)
        {
            DataTable tabla = new DataTable();

            var con = conexion.GetConnection();

            using (var cmd = new MySqlCommand(sql, con))
            using (var da = new MySqlDataAdapter(cmd))
            {
                da.Fill(tabla);
            }

            return tabla;
        }

        private DataTable ListarCatalogo(string sql)
        {
            DataTable tabla = new DataTable();

            var con = conexion.GetConnection();

            using (var cmd = new MySqlCommand(sql, con))
            using (var da = new MySqlDataAdapter(cmd))
            {
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}
