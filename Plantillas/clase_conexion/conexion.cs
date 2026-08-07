using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Inicio de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 26/07/2026 */
namespace clase_conexion
{
    public class conexion
    {
        private MySqlConnection connecion;
        private String server = "172.20.10.7";
        private String datebase = "taquillas_cine";
        private String user = "root1";
        private String password = "Root";
        private String pconexion;
        public conexion()
        {
            pconexion = "Server=" + server +
               ";Database=" + datebase +
               ";Uid=" + user +
               ";Pwd=" + password + ";"; ;

        }

        public MySqlConnection GetConnection()
        {
            if (connecion == null)
            {
                connecion = new MySqlConnection(pconexion);
                connecion.Open();

            }
            return connecion;
        }

        /* Inicio de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
         * fecha de: 27/07/2026 */

        public DataTable mostrarpelicula()
        {
            DataTable peliculas = new DataTable();

            try
            {
                MySqlConnection con = GetConnection();

                string consulta = @"
            SELECT
                p.id_pelicula AS IdPelicula,
                p.titulo_pelicula AS Titulo,
                p.duracion_pelicula AS Duracion,
                p.clasificacion_pelicula AS Clasificacion,
                g.nombre_genero AS Genero,
                p.fecha_estreno AS `Fecha de estreno`
            FROM PELICULA p
            LEFT JOIN GENERO g
                ON p.id_genero = g.id_genero
            ORDER BY p.titulo_pelicula";

                MySqlCommand cmd = new MySqlCommand(consulta, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(peliculas);

                return peliculas;

            }

            catch { return peliculas; }


        }

        public DataTable mostrarciudades()
        {
            DataTable ciudades = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                    id_ciudad,
                    nombre_ciudad
                    FROM CIUDAD 
                    ORDER BY nombre_ciudad";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ciudades);

            return ciudades;
        }


        public DataTable mostrarcines(int idCiudad)
        {
            DataTable cines = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                        id_cine,
                        nombre_cine
                        FROM CINE
                        WHERE id_ciudad = @idCiudad
                        ORDER BY nombre_cine";

            MySqlCommand cmd = new MySqlCommand(consulta, con);

            cmd.Parameters.AddWithValue("@idCiudad", idCiudad);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(cines);

            return cines;
        }


        public DataTable FiltrarCartelera(int idCiudad, int idCine, int idTipo)
        {
            DataTable tabla = new DataTable();

            try
            {
                MySqlConnection con = GetConnection();

                string consulta = @"
        SELECT
            p.id_pelicula AS IdPelicula,
            p.titulo_pelicula AS Titulo,
            p.duracion_pelicula AS Duracion,
            p.clasificacion_pelicula AS Clasificacion,
            g.nombre_genero AS Genero,
            p.fecha_estreno AS 'Fecha de Estreno'
        FROM CARTELERA ca

        INNER JOIN CINE c
            ON ca.id_cine = c.id_cine

        INNER JOIN CIUDAD ci
            ON c.id_ciudad = ci.id_ciudad

        INNER JOIN PELICULA p
            ON ca.id_pelicula = p.id_pelicula

        INNER JOIN GENERO g
            ON p.id_genero = g.id_genero

        WHERE
            ci.id_ciudad = @ciudad
            AND c.id_cine = @cine
            AND p.id_tipo_pelicula = @tipo

        ORDER BY p.titulo_pelicula;";

                MySqlCommand cmd = new MySqlCommand(consulta, con);

                cmd.Parameters.AddWithValue("@ciudad", idCiudad);
                cmd.Parameters.AddWithValue("@cine", idCine);
                cmd.Parameters.AddWithValue("@tipo", idTipo);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(tabla);

                return tabla;
            }
            catch
            {

                return tabla;
            }
        }
        public DataTable mostrarGeneros()
        {
            DataTable generos = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                            id_genero,
                            nombre_genero
                            FROM GENERO
                            ORDER BY nombre_genero";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(generos);

            return generos;
        }

        public DataTable mostrarTipoPelicula()
        {
            DataTable formatos = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                    id_tipo_pelicula,
                    nombre_tipo_pelicula
                    FROM TIPO_PELICULA
                    ORDER BY id_tipo_pelicula";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(formatos);

            return formatos;
        }

        public DataTable mostrarCartelera(string nombre = "", int idGenero = 0, int idTipoPelicula = 0, int id = 0)
        {
            DataTable dt = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"
                SELECT
                    p.id_pelicula           AS ID,
                    p.titulo_pelicula       AS Nombre,
                    tp.nombre_tipo_pelicula AS Formato,
                    g.nombre_genero         AS Generos,
                    p.fecha_estreno         AS FechaEstreno
                FROM PELICULA p
                LEFT JOIN GENERO g          ON g.id_genero = p.id_genero
                LEFT JOIN TIPO_PELICULA tp  ON tp.id_tipo_pelicula = p.id_tipo_pelicula
                WHERE 1 = 1";

            if (id > 0)
                consulta += " AND p.id_pelicula = @id";
            if (!string.IsNullOrWhiteSpace(nombre))
                consulta += " AND p.titulo_pelicula LIKE @nombre";
            if (idGenero > 0)
                consulta += " AND p.id_genero = @idGenero";
            if (idTipoPelicula > 0)
                consulta += " AND p.id_tipo_pelicula = @idTipoPelicula";

            consulta += " ORDER BY p.fecha_estreno";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            if (id > 0) cmd.Parameters.AddWithValue("@id", id);
            if (!string.IsNullOrWhiteSpace(nombre)) cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            if (idGenero > 0) cmd.Parameters.AddWithValue("@idGenero", idGenero);
            if (idTipoPelicula > 0) cmd.Parameters.AddWithValue("@idTipoPelicula", idTipoPelicula);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public int insertarPelicula(
                        string titulo,
                        int duracion,
                        string clasificacion,
                        int idGenero,
                        int idTipoPelicula,
                        string director,
                        string trailer,
                        string estado,
                        DateTime fechaEstreno)
        {
            MySqlConnection con = GetConnection();

            string consulta = @"
        INSERT INTO PELICULA
            (titulo_pelicula, duracion_pelicula, clasificacion_pelicula,
             id_genero, id_tipo_pelicula, director_pelicula, trailer_pelicula,
             estado_pelicula, fecha_estreno)
        VALUES
            (@titulo, @duracion, @clasificacion,
             @idGenero, @idTipoPelicula, @director, @trailer,
             @estado, @fechaEstreno)";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@duracion", duracion);
            cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
            cmd.Parameters.AddWithValue("@idGenero", idGenero);
            cmd.Parameters.AddWithValue("@idTipoPelicula", idTipoPelicula);
            cmd.Parameters.AddWithValue("@director", director);
            cmd.Parameters.AddWithValue("@trailer", trailer);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@fechaEstreno", fechaEstreno);

            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public int siguienteIdPelicula()
        {
            MySqlConnection con = GetConnection();

            string consulta = "SELECT IFNULL(MAX(id_pelicula), 0) + 1 FROM PELICULA";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            object resultado = cmd.ExecuteScalar();

            return Convert.ToInt32(resultado);
        }

        public DataTable obtenerPelicula(int id)
        {
            DataTable dt = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                    id_pelicula,
                    titulo_pelicula,
                    duracion_pelicula,
                    clasificacion_pelicula,
                    id_genero,
                    id_tipo_pelicula,
                    director_pelicula,
                    trailer_pelicula,
                    estado_pelicula,
                    fecha_estreno
                    FROM PELICULA
                    WHERE id_pelicula = @id";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public void actualizarPelicula(
                            int id, string titulo, int duracion, string clasificacion,
                            int idGenero, int idTipoPelicula, string director, string trailer,
                            string estado, DateTime fechaEstreno)
        {
            MySqlConnection con = GetConnection();

            string consulta = @"
        UPDATE PELICULA SET
            titulo_pelicula        = @titulo,
            duracion_pelicula      = @duracion,
            clasificacion_pelicula = @clasificacion,
            id_genero              = @idGenero,
            id_tipo_pelicula       = @idTipoPelicula,
            director_pelicula      = @director,
            trailer_pelicula       = @trailer,
            estado_pelicula        = @estado,
            fecha_estreno          = @fechaEstreno
        WHERE id_pelicula = @id";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@duracion", duracion);
            cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
            cmd.Parameters.AddWithValue("@idGenero", idGenero);
            cmd.Parameters.AddWithValue("@idTipoPelicula", idTipoPelicula);
            cmd.Parameters.AddWithValue("@director", director);
            cmd.Parameters.AddWithValue("@trailer", trailer);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@fechaEstreno", fechaEstreno);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        // FUNCIONES

        public DataTable mostrarPeliculasCombo()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();

            string consulta = @"SELECT id_pelicula, titulo_pelicula
                        FROM PELICULA
                        ORDER BY titulo_pelicula";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

        public DataTable mostrarSalasCombo()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                            s.id_sala,
                            CONCAT('Sala ', s.numero_sala, ' - ', c.nombre_cine) AS descripcion_sala,
                            s.id_tipo_sala
                        FROM SALA s
                        JOIN CINE c ON c.id_cine = s.id_cine
                        ORDER BY c.nombre_cine, s.numero_sala";

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }


        public DataTable obtenerPeliculaParaFuncion(int idPelicula)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();
            return dt;
        }

        /* fin de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
     * fecha de: 27/07/2026 */
    
    public DataTable infopelicula(int idPelicula)
        {
            DataTable peliculas = new DataTable();

            MySqlConnection con = GetConnection();

            string consulta = @"SELECT 
                        director_pelicula,
                        duracion_pelicula,
                        clasificacion_pelicula
                        FROM PELICULA
                        WHERE id_pelicula = @idPelicula";

            MySqlCommand cmd = new MySqlCommand(consulta, con);

            cmd.Parameters.AddWithValue("@idPelicula", idPelicula);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(peliculas);

            return peliculas;
        }
    } 
}
/* Fin de Codigo de Miguel David Contreras Jacinto con carnet: 0901-21-3878 en la
 * fecha de: 26/07/2026 */