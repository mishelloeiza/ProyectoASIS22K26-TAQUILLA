/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Con_Admin
{
    public class If_Boletos
    {
        private readonly Conexion conexion = new Conexion();

        public DataTable Listar()
        {
            const string sql = @"
                SELECT  b.id_boleto,
                        b.id_venta,
                        b.id_funcion,
                        b.id_estado_boleto,
                        b.numero_boleto,
                        eb.nombre_estado_boleto,
                        p.titulo_pelicula,
                        f.fecha_funcion,
                        f.hora_funcion
                FROM tbl_boleto b
                LEFT JOIN tbl_estado_boleto eb ON eb.id_estado_boleto = b.id_estado_boleto
                LEFT JOIN tbl_funcion       f  ON f.id_funcion        = b.id_funcion
                LEFT JOIN tbl_pelicula      p  ON p.id_pelicula       = f.id_pelicula
                ORDER BY b.id_boleto;";
            return Consultar(sql);
        }

        public DataTable ListarEstados()
        {
            const string sql = @"SELECT id_estado_boleto AS Id,
                                        nombre_estado_boleto AS Nombre
                                 FROM tbl_estado_boleto
                                 ORDER BY nombre_estado_boleto;";
            return Consultar(sql);
        }

        public int ObtenerSiguienteId()
        {
            const string sql = "SELECT IFNULL(MAX(id_boleto), 0) + 1 FROM tbl_boleto;";
            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
                return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public DataTable ObtenerFuncion(int idFuncion)
        {
            const string sql = @"
        SELECT  f.id_funcion,
                p.titulo_pelicula,
                f.id_sala,
                f.fecha_funcion,
                f.hora_funcion,
                f.precio_funcion
        FROM tbl_funcion f
        LEFT JOIN tbl_pelicula p ON p.id_pelicula = f.id_pelicula
        WHERE f.id_funcion = @id;";
            return Consultar(sql, new MySqlParameter("@id", idFuncion));
        }

        public DataTable ObtenerVenta(int idVenta)
        {
            const string sql = @"
        SELECT  v.id_venta,
                v.id_cliente,
                v.id_promocion,
                v.id_usuario,
                v.id_metodo_pago,
                v.fecha_hora_venta,
                v.cantidad_boletos_venta,
                v.total_venta
        FROM tbl_venta v
        WHERE v.id_venta = @id;";
            return Consultar(sql, new MySqlParameter("@id", idVenta));
        }

        public int Insertar(int idVenta, int idFuncion, int idEstado, int numeroBoleto)
        {
            const string sql = @"
        INSERT INTO tbl_boleto (id_venta, id_funcion, id_estado_boleto, numero_boleto)
        VALUES (@venta, @funcion, @estado, @numero);
        SELECT LAST_INSERT_ID();";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@venta", idVenta);
                cmd.Parameters.AddWithValue("@funcion", idFuncion);
                cmd.Parameters.AddWithValue("@estado", idEstado);
                cmd.Parameters.AddWithValue("@numero", numeroBoleto);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Actualizar(int id, int idVenta, int idFuncion, int idEstado, int numeroBoleto)
        {
            const string sql = @"
        UPDATE tbl_boleto
        SET id_venta         = @venta,
            id_funcion       = @funcion,
            id_estado_boleto = @estado,
            numero_boleto    = @numero
        WHERE id_boleto = @id;";

            var con = conexion.GetConnection();
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@venta", idVenta);
                cmd.Parameters.AddWithValue("@funcion", idFuncion);
                cmd.Parameters.AddWithValue("@estado", idEstado);
                cmd.Parameters.AddWithValue("@numero", numeroBoleto);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int id)
        {
            const string sql = "DELETE FROM tbl_boleto WHERE id_boleto = @id;";
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