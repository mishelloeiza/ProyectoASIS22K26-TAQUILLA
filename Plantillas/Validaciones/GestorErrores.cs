/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 27/07/2026 */

using System.Data.Common;
using System.Windows.Forms;

namespace Validaciones
{
    public static class GestorErrores
    {
        // ==================== TRADUCCION DE EXCEPCIONES ====================

        public static string Traducir(Exception ex)
        {
            return ex switch
            {
                DbException => TraducirErrorBaseDatos(ex),

                TimeoutException => Mensajes.ErrorTiempoAgotado,
                FormatException => Mensajes.ErrorConversion,
                OverflowException => "El valor ingresado excede el rango permitido.",
                InvalidCastException => Mensajes.ErrorConversion,
                UnauthorizedAccessException => Mensajes.ErrorPermisoArchivo,
                IOException => "No se pudo leer o escribir el archivo solicitado.",
                ArgumentNullException => Mensajes.ErrorInesperado,
                NullReferenceException => Mensajes.ErrorInesperado,
                _ => Mensajes.ErrorInesperado
            };
        }

        private static string TraducirErrorBaseDatos(Exception ex)
        {
            string detalle = ex.Message.ToLowerInvariant();

            if (detalle.Contains("unable to connect")
                || detalle.Contains("host")
                || detalle.Contains("refused"))
            {
                return Mensajes.ErrorConexion;
            }

            if (detalle.Contains("access denied") || detalle.Contains("authentication"))
            {
                return Mensajes.ErrorConexion;
            }

            if (detalle.Contains("timeout"))
            {
                return Mensajes.ErrorTiempoAgotado;
            }

            if (detalle.Contains("duplicate"))
            {
                return "Ya existe un registro con esos datos.";
            }

            if (detalle.Contains("foreign key") || detalle.Contains("constraint"))
            {
                return Mensajes.EliminacionConDependencias;
            }

            return Mensajes.ErrorConsulta;
        }

        // ==================== PRESENTACION AL USUARIO ====================

        public static void Manejar(Exception ex, string origen = "")
        {
            Bitacora.RegistrarError(ex, origen);
            MostrarError(Traducir(ex));
        }

        public static void MostrarError(string mensaje)
            => MessageBox.Show(mensaje, Mensajes.TituloError,
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void MostrarAdvertencia(string mensaje)
            => MessageBox.Show(mensaje, Mensajes.TituloAdvertencia,
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static void MostrarInformacion(string mensaje)
            => MessageBox.Show(mensaje, Mensajes.TituloInformacion,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);


        public static bool Confirmar(string mensaje)
            => MessageBox.Show(mensaje, Mensajes.TituloConfirmacion,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.Yes;



        public static bool MostrarValidacion(ResultadoValidacion resultado)
        {
            if (resultado is null || resultado.EsValido) return true;

            MessageBox.Show(resultado.ObtenerResumen(), Mensajes.TituloValidacion,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // ==================== EJECUCION PROTEGIDA ====================

        public static bool EjecutarSeguro(Action operacion, string origen = "")
        {
            try
            {
                operacion();
                return true;
            }
            catch (Exception ex)
            {
                Manejar(ex, origen);
                return false;
            }
        }


        public static T EjecutarSeguro<T>(Func<T> operacion, T valorPorDefecto, string origen = "")
        {
            try
            {
                return operacion();
            }
            catch (Exception ex)
            {
                Manejar(ex, origen);
                return valorPorDefecto;
            }
        }

        // ==================== MANEJADOR GLOBAL ====================

        public static void RegistrarManejadorGlobal()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += (s, e) =>
            {
                Manejar(e.Exception, "Excepcion no controlada (interfaz)");
            };

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                if (e.ExceptionObject is Exception ex)
                {
                    Manejar(ex, "Excepcion no controlada (dominio)");
                }
            };

            Bitacora.LimpiarAntiguos();
            Bitacora.RegistrarInfo("Aplicacion iniciada.", "Sistema");
        }
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 