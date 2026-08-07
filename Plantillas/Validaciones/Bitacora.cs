/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 27/07/2026 */

using System.Text;

namespace Validaciones
{

    public static class Bitacora
    {
        private static readonly object Candado = new();

        private static readonly string CarpetaBitacora =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bitacora");

        public static string ArchivoActual =>
            Path.Combine(CarpetaBitacora, $"errores_{DateTime.Now:yyyy-MM-dd}.log");

        public static void RegistrarError(Exception ex, string origen = "")
        {
            if (ex is null) return;

            StringBuilder sb = new();
            sb.AppendLine("======================================================");
            sb.AppendLine($"FECHA   : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine($"NIVEL   : ERROR");
            sb.AppendLine($"ORIGEN  : {(string.IsNullOrWhiteSpace(origen) ? "No especificado" : origen)}");
            sb.AppendLine($"TIPO    : {ex.GetType().FullName}");
            sb.AppendLine($"MENSAJE : {ex.Message}");

            if (ex.InnerException is not null)
            {
                sb.AppendLine($"INTERNA : {ex.InnerException.Message}");
            }

            sb.AppendLine("TRAZA   :");
            sb.AppendLine(ex.StackTrace ?? "  (sin traza disponible)");
            sb.AppendLine();

            Escribir(sb.ToString());
        }

        public static void RegistrarInfo(string mensaje, string origen = "")
        {
            StringBuilder sb = new();
            sb.AppendLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] INFO  " +
                          $"{(string.IsNullOrWhiteSpace(origen) ? "" : $"({origen}) ")}{mensaje}");

            Escribir(sb.ToString());
        }

        public static void RegistrarIntentoFallido(string usuario, string accion, int numeroIntento)
        {
            RegistrarInfo(
                $"Intento fallido #{numeroIntento} de '{accion}' para el usuario '{usuario}'.",
                "Seguridad");
        }

        private static void Escribir(string contenido)
        {
            try
            {
                lock (Candado)
                {
                    if (!Directory.Exists(CarpetaBitacora))
                    {
                        Directory.CreateDirectory(CarpetaBitacora);
                    }

                    File.AppendAllText(ArchivoActual, contenido, Encoding.UTF8);
                }
            }
            catch
            {
                
            }
        }


        public static void LimpiarAntiguos(int diasAConservar = 30)
        {
            try
            {
                if (!Directory.Exists(CarpetaBitacora)) return;

                DateTime limite = DateTime.Now.AddDays(-diasAConservar);

                foreach (string archivo in Directory.GetFiles(CarpetaBitacora, "errores_*.log"))
                {
                    if (File.GetLastWriteTime(archivo) < limite)
                    {
                        File.Delete(archivo);
                    }
                }
            }
            catch
            {
                
            }
        }
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 