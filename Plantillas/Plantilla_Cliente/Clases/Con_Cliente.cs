using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla_Cliente.Clases
{
    internal class Con_Cliente
    {
        private MySqlConnection Conexion;
        private String server = "localhost";
        private String datebase = "taquillas_cine";
        private String user = "root";
        private String password = "root";
        private String pconexion;
        public Con_Cliente()
        {
            pconexion = "Server=" + server +
               ";Database=" + datebase +
               ";Uid=" + user +
               ";Pwd=" + password + ";"; ;

        }

        public MySqlConnection GetConnection()
        {
            if (Conexion == null)
            {
                Conexion = new MySqlConnection(pconexion);
                Conexion.Open();

            }
            return Conexion;
        }
        public DataTable mostrarpelicula()
        {
            DataTable peliculas = new DataTable();

            try
            {
                MySqlConnection con = GetConnection();


                MySqlCommand cmd = new MySqlCommand("sp_cartelera", con);


                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(peliculas);


            }
            catch (Exception ex)
            {
                return peliculas;
            }

            return peliculas;
        }
        public DataTable mostrarciudades()
        {
            DataTable ciudades = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                    id_ciudad,
                    nombre_ciudad
                    FROM tbl_ciudad 
                    ORDER BY id_ciudad";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ciudades);

            return ciudades;
        }


        public DataTable mostrarcines(int? IdCiudad)
        {
            DataTable cines = new DataTable();

            MySqlConnection con = GetConnection();
            string consulta = @"SELECT id_cine, nombre_cine FROM tbl_cine
                WHERE (@idCiudad IS NULL OR id_ciudad = @idCiudad) 
                ORDER BY nombre_cine";

            MySqlCommand cmd = new MySqlCommand(consulta, con);

            cmd.Parameters.AddWithValue("@idCiudad", IdCiudad);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(cines);

            return cines;
        }


        public DataTable FiltrarCartelera(int IdCiudad, int IdCine, int? IdFormato)
        {
            DataTable Cartelera = new DataTable();

            try
            {
                MySqlConnection con = GetConnection();

                MySqlCommand cmd = new MySqlCommand("sp_filtrar_cartelera", con);

                cmd.Parameters.AddWithValue("@p_id_formato", IdFormato);
                cmd.Parameters.AddWithValue("@p_id_ciudad", IdCiudad);
                cmd.Parameters.AddWithValue("@p_id_cine", IdCine);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(Cartelera);

                return Cartelera;
            }
            catch
            {

                return Cartelera;
            }
        }
        /*Inicio de código de Carlos Andres Arriaza Lara 0901-23-13862 el 27/07/2026*/
        public DataTable infopelicula(int idPelicula)
        {
            DataTable peliculas = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                        p.director_pelicula,
                        p.duracion_pelicula,
                        cl.nombre_clasificacion AS clasificacion_pelicula
                        FROM tbl_pelicula p
                        LEFT JOIN tbl_clasificacion cl
                            ON cl.id_clasificacion = p.id_clasificacion
                        WHERE p.id_pelicula = @idPelicula";

            MySqlCommand cmd = new MySqlCommand(consulta, con);

            cmd.Parameters.AddWithValue("@idPelicula", idPelicula);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(peliculas);

            return peliculas;
        }
        /*Fin de código de Carlos Andres Arriaza Lara 0901-23-13862 el 27/07/2026*/
        /*Inicio de código de Carlos Andres Arriaza Lara 0901-23-13862 el 28/07/2026*/
        public DataTable cargarfunciones(int idPelicula, int idCine)
        {
            DataTable funciones = new DataTable();
            MySqlConnection con = GetConnection();
            string consulta = @"SELECT 
                        f.id_funcion,
                        TIME_FORMAT(f.hora_funcion, '%H:%i') AS hora_funcion,
                        f.fecha_funcion
                        FROM tbl_funcion f
                        inner join tbl_sala s ON f.id_sala = s.id_sala
                        inner join tbl_cine c ON s.id_cine = c.id_cine
                        WHERE f.id_pelicula = @idPelicula and c.id_cine = @idCine";
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@idPelicula", idPelicula);
            cmd.Parameters.AddWithValue("@idCine", idCine);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(funciones);
            return funciones;
        }
        /*Fin de código de Carlos Andres Arriaza Lara 0901-23-13862 el 28/07/2026*/
        /*Inicio de código de Carlos Andres Arriaza Lara 0901-23-13862 el 29/07/2026*/
        public int SiguienteIdBoleto()
        {
            MySqlConnection con = GetConnection();

            string consulta = @"SELECT AUTO_INCREMENT
                FROM information_schema.TABLES
                WHERE TABLE_SCHEMA = 'taquillas_cine'
                  AND TABLE_NAME = 'tbl_boleto'";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            object resultado = cmd.ExecuteScalar();

            return (resultado != null && resultado != DBNull.Value)
                   ? Convert.ToInt32(resultado) + 1
                   : 1;
        }
        public int SiguienteIdVenta()
        {
            MySqlConnection con = GetConnection();

            string consulta = @"SELECT AUTO_INCREMENT
                FROM information_schema.TABLES
                WHERE TABLE_SCHEMA = 'taquillas_cine'
                  AND TABLE_NAME = 'tbl_venta'";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            object resultado = cmd.ExecuteScalar();

            return (resultado != null && resultado != DBNull.Value)
                   ? Convert.ToInt32(resultado) + 1
                   : 1;
        }

        /*Fin de código de Carlos Andres Arriaza Lara 0901-23-13862 el 29/07/2026*/
        /*Inicio del código de Carlos Andres Arriaza Lara 0901-23-13862 el 31/07/2026*/
        public int ObtenerIdSala(int idFuncion)
        {
            MySqlConnection con = GetConnection();
            string consulta = @"SELECT id_sala FROM tbl_funcion WHERE id_funcion = @idFuncion";
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@idFuncion", idFuncion);
            object resultado = cmd.ExecuteScalar();
            return (resultado != null && resultado != DBNull.Value)
                ? Convert.ToInt32(resultado)
                : 0;
        }
        public int ObtenerCapacidadSala(int idSala)
        {
            MySqlConnection con = GetConnection();
            string consulta = @"SELECT capacidad_sala FROM tbl_sala WHERE id_sala = @idSala";
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@idSala", idSala);
            object resultado = cmd.ExecuteScalar();
            return (resultado != null && resultado != DBNull.Value)
                ? Convert.ToInt32(resultado)
                : 0;
        }
        /*Fin del código de Carlos Andres Arriaza Lara 0901-23-13862 el 31/07/2026*/
        /*Inicio de código de Carlos Andres Arriaza Lara 0901-23-13862 el 3/08/2026*/
        public string ObtenerEnlacePelicula(int idPelicula)
        {
            MySqlConnection con = GetConnection();
            string consulta = @"SELECT trailer_pelicula FROM tbl_pelicula WHERE id_pelicula = @idPelicula";
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@idPelicula", idPelicula);
            object resultado = cmd.ExecuteScalar();
            return (resultado != null && resultado != DBNull.Value)
                ? Convert.ToString(resultado)
                : string.Empty;
        }
        /*Fin del código de Carlos Andres Arriaza Lara 0901-23-13862 el 3/08/2026*/

        /*Inicio del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/

        public DataTable ObtenerMetodosPago()
        {
            MySqlConnection con = GetConnection();
            string query = "SELECT id_metodo_pago, UPPER(nombre_metodo_pago) as nombre_metodo_pago FROM tbl_metodo_pago";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // Método para registrar la Venta en tbl_venta
        public int RegistrarVenta(int idMetodoPago, int cantidadBoletos, decimal totalVenta)
        {
            try
            {
                MySqlConnection con = GetConnection();
                string query = @"INSERT INTO tbl_venta (id_metodo_pago, cantidad_boletos_venta, total_venta, id_usuario) 
                         VALUES (@metodoPago, @cantidad, @total, 1);
                         SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@metodoPago", idMetodoPago);
                cmd.Parameters.AddWithValue("@cantidad", cantidadBoletos);
                cmd.Parameters.AddWithValue("@total", totalVenta);

                int idVentaGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                return idVentaGenerado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
                return 0;
            }
        }

        public bool RegistrarBoleto(int idFuncion, int idVenta, int numeroBoleto)
        {
            try
            {
                MySqlConnection con = GetConnection();
                string query = @"INSERT INTO tbl_boleto (id_funcion, id_venta, id_estado_boleto, numero_boleto) 
                         VALUES (@idFuncion, @idVenta, 1, @numeroBoleto);";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idFuncion", idFuncion);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                cmd.Parameters.AddWithValue("@numeroBoleto", numeroBoleto);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el boleto: " + ex.Message);
                return false;
            }
        }
        /*Fin del código 0901-23-4868 Pedro José Gómez Villalobos el 5/08/2026*/

    }
}
