/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 27/07/2026 */

using System.Text;

namespace Validaciones
{

    public class ResultadoValidacion
    {
        private readonly List<string> _errores = new();
        public bool EsValido => _errores.Count == 0;
        public int TotalErrores => _errores.Count;
        public IReadOnlyList<string> Errores => _errores.AsReadOnly();
        public string PrimerError => _errores.Count > 0 ? _errores[0] : string.Empty;
        public ResultadoValidacion Agregar(string mensaje)
        {
            if (!string.IsNullOrWhiteSpace(mensaje) && !_errores.Contains(mensaje))
            {
                _errores.Add(mensaje);
            }
            return this;
        }

        /// <example>
        /// resultado.AgregarSiFalla(Validador.EsCorreoValido(txt.Text), Mensajes.CorreoInvalido);
        /// </example>

        public ResultadoValidacion AgregarSiFalla(bool condicion, string mensaje)
        {
            if (!condicion)
            {
                Agregar(mensaje);
            }
            return this;
        }

        public ResultadoValidacion Combinar(ResultadoValidacion otro)
        {
            if (otro is not null)
            {
                foreach (string error in otro.Errores)
                {
                    Agregar(error);
                }
            }
            return this;
        }
        public void Limpiar() => _errores.Clear();

        public string ObtenerResumen()
        {
            if (EsValido)
            {
                return string.Empty;
            }

            StringBuilder sb = new();
            sb.AppendLine("Se encontraron los siguientes problemas:");
            sb.AppendLine();

            for (int i = 0; i <_errores.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {_errores[i]}");
            }
            
            return sb.ToString();
        }

        public override string ToString() => ObtenerResumen();
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 