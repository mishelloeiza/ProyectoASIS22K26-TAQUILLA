/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Con_Admin
{
    public class If_Clientes
    {
        private readonly Conexion conexion = new Conexion();

        public DataTable Listar()
        {
            const string sql = @"
                SELECT  id_cliente,
                        nombre_cliente,
                        apellido_cliente,
                        identificacion_cliente,
                        correo_cliente
                FROM tbl_cliente
                ORDER BY id_cliente;";
            return Consultar(sql);
        }

        public int ObtenerSiguienteId()
        {
            const string sql = "SELECT IFNULL(MAX(id_cliente), 0) + 1 FROM tbl_cliente;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
                return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public int Insertar(string nombre, string apellido, string identificacion, string correo)
        {
            const string sql = @"
                INSERT INTO tbl_cliente (nombre_cliente, apellido_cliente, identificacion_cliente, correo_cliente)
                VALUES (@nombre, @apellido, @identificacion, @correo);
                SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@identificacion", identificacion);
                cmd.Parameters.AddWithValue("@correo", correo);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Actualizar(int id, string nombre, string apellido, string identificacion, string correo)
        {
            const string sql = @"
                UPDATE tbl_cliente
                SET nombre_cliente         = @nombre,
                    apellido_cliente       = @apellido,
                    identificacion_cliente = @identificacion,
                    correo_cliente         = @correo
                WHERE id_cliente = @id;";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@identificacion", identificacion);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int id)
        {
            const string sql = "DELETE FROM tbl_cliente WHERE id_cliente = @id;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
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
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */