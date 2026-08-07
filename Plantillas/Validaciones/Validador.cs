/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 27/07/2026 */

using System.Globalization;
using System.Text.RegularExpressions;

namespace Validaciones
{

    public static class Validador
    {
        // Clasificaciones de contenido permitidas segun el documento de requerimientos.
        public static readonly string[] ClasificacionesValidas =
            { "A", "B", "PG", "PG-13", "R", "NC-17" };

        // Dias de vigencia de la cartelera a partir de la fecha actual del sistema.
        public const int DiasVigenciaReserva = 7;

        // Limites de compra de boletos.
        public const int MinimoBoletos = 1;
        public const int MaximoBoletos = 10;

        private static readonly Regex RegexCorreo = new(
            @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
            RegexOptions.Compiled);

        private static readonly Regex RegexSoloLetras = new(
            @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\s]+$",
            RegexOptions.Compiled);

        private static readonly Regex RegexAlfanumerico = new(
            @"^[a-zA-Z0-9]+$",
            RegexOptions.Compiled);

        // ==================== TEXTO ====================

        public static bool EsRequerido(string? texto)
            => !string.IsNullOrWhiteSpace(texto);

        public static bool EsSoloLetras(string? texto)
            => EsRequerido(texto) && RegexSoloLetras.IsMatch(texto!.Trim());

        public static bool EsSoloNumeros(string? texto)
            => EsRequerido(texto) && texto!.Trim().All(char.IsDigit);

        public static bool EsAlfanumerico(string? texto)
            => EsRequerido(texto) && RegexAlfanumerico.IsMatch(texto!.Trim());

        public static bool LongitudEntre(string? texto, int minimo, int maximo)
        {
            if (texto is null) return false;
            int longitud = texto.Trim().Length;
            return longitud >= minimo && longitud <= maximo;
        }

        public static bool EsCorreoValido(string? correo)
            => EsRequerido(correo)
               && correo!.Trim().Length <= 254
               && RegexCorreo.IsMatch(correo.Trim());

        public static bool EsUrlValida(string? url)
        {
            if (!EsRequerido(url)) return false;

            return Uri.TryCreate(url!.Trim(), UriKind.Absolute, out Uri? resultado)
                   && (resultado.Scheme == Uri.UriSchemeHttp
                       || resultado.Scheme == Uri.UriSchemeHttps);
        }

        // ==================== NUMEROS ====================

        public static bool EsEnteroEnRango(string? texto, int minimo, int maximo)
            => int.TryParse(texto?.Trim(), out int valor)
               && valor >= minimo
               && valor <= maximo;

        public static bool EsDecimalPositivo(string? texto)
            => decimal.TryParse(texto?.Trim(),
                                NumberStyles.Number,
                                CultureInfo.InvariantCulture,
                                out decimal valor)
               && valor > 0;

        public static bool EsPorcentajeValido(string? texto)
            => decimal.TryParse(texto?.Trim(),
                                NumberStyles.Number,
                                CultureInfo.InvariantCulture,
                                out decimal valor)
               && valor >= 0
               && valor <= 100;

        public static bool EsDuracionValida(string? texto)
            => EsEnteroEnRango(texto, 1, 300);

        // ==================== FECHAS ====================

        public static bool EsFechaEnRangoReserva(DateTime fecha)
        {
            DateTime hoy = DateTime.Today;
            DateTime limite = hoy.AddDays(DiasVigenciaReserva);
            return fecha.Date >= hoy && fecha.Date <= limite;
        }

        public static bool EsRangoFechasValido(DateTime inicio, DateTime fin)
            => inicio.Date <= fin.Date;

        public static bool EsRangoHorasValido(TimeSpan inicio, TimeSpan fin)
            => fin > inicio;

        public static bool HayTraslape(
            DateTime inicioA, DateTime finA, DateTime inicioB, DateTime finB)
            => inicioA < finB && inicioB < finA;

        // ==================== BOLETOS Y BUTACAS ====================

        public static bool EsCantidadBoletosValida(int adultos, int ninos, int adultosMayores)
        {
            if (adultos < 0 || ninos < 0 || adultosMayores < 0) return false;

            int total = adultos + ninos + adultosMayores;
            return total >= MinimoBoletos && total <= MaximoBoletos;
        }

        public static bool ButacasCoincidenConBoletos(int butacasSeleccionadas, int totalBoletos)
            => butacasSeleccionadas == totalBoletos && totalBoletos > 0;

        // ==================== TARJETA DE CREDITO ====================

        /// <summary>
        /// Valida un numero de tarjeta mediante el algoritmo de Luhn (modulo 10),
        /// Acepta el numero con espacios o guiones.
        /// </summary>
        public static bool EsTarjetaValida(string? numero)
        {
            if (!EsRequerido(numero)) return false;

            string digitos = new(numero!.Where(char.IsDigit).ToArray());

            if (digitos.Length is < 13 or > 19) return false;

            int suma = 0;
            bool duplicar = false;

            for (int i = digitos.Length - 1; i >= 0; i--)
            {
                int valor = digitos[i] - '0';

                if (duplicar)
                {
                    valor *= 2;
                    if (valor > 9) valor -= 9;
                }

                suma += valor;
                duplicar = !duplicar;
            }

            return suma % 10 == 0;
        }

        public static bool EsCvvValido(string? cvv)
        {
            if (!EsSoloNumeros(cvv)) return false;
            int longitud = cvv!.Trim().Length;
            return longitud is 3 or 4;
        }

        public static bool EsVencimientoValido(string? vencimiento)
        {
            if (!EsRequerido(vencimiento)) return false;

            string texto = vencimiento!.Trim();
            string[] partes = texto.Split('/');

            if (partes.Length != 2) return false;
            if (!int.TryParse(partes[0], out int mes)) return false;
            if (!int.TryParse(partes[1], out int anio)) return false;
            if (mes is < 1 or > 12) return false;

            if (partes[1].Trim().Length == 2) anio += 2000;

            DateTime finVigencia = new DateTime(anio, mes, 1).AddMonths(1).AddDays(-1);

            return finVigencia.Date >= DateTime.Today;
        }

        // ==================== SEGURIDAD ====================

        public static bool EsNombreUsuarioValido(string? usuario)
            => EsAlfanumerico(usuario) && LongitudEntre(usuario, 4, 20);

        public static bool EsContrasenaSegura(string? contrasena)
        {
            if (contrasena is null || contrasena.Length < 8) return false;

            return contrasena.Any(char.IsUpper)
                && contrasena.Any(char.IsLower)
                && contrasena.Any(char.IsDigit);
        }

        public static bool ContrasenasCoinciden(string? contrasena, string? confirmacion)
            => EsRequerido(contrasena) && string.Equals(contrasena, confirmacion, StringComparison.Ordinal);

        // ==================== LISTAS CERRADAS ====================

        public static bool EsClasificacionValida(string? clasificacion)
            => EsRequerido(clasificacion)
               && ClasificacionesValidas.Contains(clasificacion!.Trim().ToUpperInvariant());

        public static bool HaySeleccion(int indiceSeleccionado)
            => indiceSeleccionado >= 0;
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 