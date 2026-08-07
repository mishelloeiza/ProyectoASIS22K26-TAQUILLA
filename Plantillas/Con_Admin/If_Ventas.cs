/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Con_Admin
{
    public class If_Ventas
    {
        private readonly Conexion conexion = new Conexion();

        public DataTable Listar()
        {
            const string sql = @"
                SELECT  v.id_venta,
                        v.id_cliente,
                        v.id_promocion,
                        v.id_usuario,
                        v.id_metodo_pago,
                        v.fecha_hora_venta,
                        v.cantidad_boletos_venta,
                        v.total_venta,
                        mp.nombre_metodo_pago,
                        pr.nombre_promocion
                FROM tbl_venta v
                LEFT JOIN tbl_metodo_pago mp ON mp.id_metodo_pago = v.id_metodo_pago
                LEFT JOIN tbl_promocion   pr ON pr.id_promocion   = v.id_promocion
                ORDER BY v.id_venta;";
            return Consultar(sql);
        }

        public DataTable ListarMetodosPago()
        {
            const string sql = @"SELECT id_metodo_pago AS Id,
                                        nombre_metodo_pago AS Nombre
                                 FROM tbl_metodo_pago
                                 ORDER BY nombre_metodo_pago;";
            return Consultar(sql);
        }

        public DataTable ListarPromociones()
        {
            const string sql = @"SELECT id_promocion AS Id,
                                        nombre_promocion AS Nombre
                                 FROM tbl_promocion
                                 ORDER BY nombre_promocion;";
            return Consultar(sql);
        }

        public int ObtenerSiguienteId()
        {
            const string sql = "SELECT IFNULL(MAX(id_venta), 0) + 1 FROM tbl_venta;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
                return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public DataTable ObtenerCliente(int idCliente)
        {
            const string sql = @"
                SELECT  id_cliente,
                        nombre_cliente,
                        apellido_cliente,
                        identificacion_cliente,
                        correo_cliente
                FROM tbl_cliente
                WHERE id_cliente = @id;";
            return Consultar(sql, new MySqlParameter("@id", idCliente));
        }

        public DataTable ObtenerUsuario(int idUsuario)
        {
            const string sql = @"
                SELECT  id_usuario,
                        nombre_usuario
                FROM tbl_usuario
                WHERE id_usuario = @id;";
            return Consultar(sql, new MySqlParameter("@id", idUsuario));
        }

        public int Insertar(int? idCliente, int? idPromocion, int idUsuario, int idMetodoPago,
                            DateTime fechaHora, int cantidadBoletos, decimal total)
        {
            const string sql = @"
                INSERT INTO tbl_venta
                    (id_cliente, id_promocion, id_usuario, id_metodo_pago,
                     fecha_hora_venta, cantidad_boletos_venta, total_venta)
                VALUES
                    (@cliente, @promocion, @usuario, @metodo,
                     @fechaHora, @cantidad, @total);
                SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@cliente", (object)idCliente ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@promocion", (object)idPromocion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@usuario", idUsuario);
                cmd.Parameters.AddWithValue("@metodo", idMetodoPago);
                cmd.Parameters.AddWithValue("@fechaHora", fechaHora);
                cmd.Parameters.AddWithValue("@cantidad", cantidadBoletos);
                cmd.Parameters.AddWithValue("@total", total);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Actualizar(int id, int? idCliente, int? idPromocion, int idUsuario, int idMetodoPago,
                              DateTime fechaHora, int cantidadBoletos, decimal total)
        {
            const string sql = @"
                UPDATE tbl_venta
                SET id_cliente             = @cliente,
                    id_promocion           = @promocion,
                    id_usuario             = @usuario,
                    id_metodo_pago         = @metodo,
                    fecha_hora_venta       = @fechaHora,
                    cantidad_boletos_venta = @cantidad,
                    total_venta            = @total
                WHERE id_venta = @id;";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@cliente", (object)idCliente ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@promocion", (object)idPromocion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@usuario", idUsuario);
                cmd.Parameters.AddWithValue("@metodo", idMetodoPago);
                cmd.Parameters.AddWithValue("@fechaHora", fechaHora);
                cmd.Parameters.AddWithValue("@cantidad", cantidadBoletos);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int id)
        {
            const string sql = "DELETE FROM tbl_venta WHERE id_venta = @id;";
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