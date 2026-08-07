/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */
using System;
using System.Collections.Generic;
using Con_Admin;

namespace Plantilla_Admin
{
    public class PermisosAux
    {
        private readonly If_AsignarPermisos api = new If_AsignarPermisos();
        private readonly Dictionary<string, bool> cache =
            new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);

        public string Perfil { get; set; }
        public string Aplicacion { get; set; }

        public PermisosAux() { }

        public PermisosAux(string perfil, string aplicacion)
        {
            Perfil = perfil;
            Aplicacion = aplicacion;
        }

        public static PermisosAux DeSesion(string aplicacion) =>
            new PermisosAux(Sesion.Perfil, aplicacion);

        public bool Permitido(string accion)
        {
            if (string.IsNullOrWhiteSpace(Perfil) ||
                string.IsNullOrWhiteSpace(Aplicacion) ||
                string.IsNullOrWhiteSpace(accion))
                return false;

            if (Perfil.Equals("admin", StringComparison.OrdinalIgnoreCase))
                return true;

            string clave = Perfil + "|" + Aplicacion + "|" + accion;
            if (cache.TryGetValue(clave, out bool valor))
                return valor;

            bool permitido;
            try
            {
                permitido = api.ContarPermisos(Perfil, Aplicacion, accion) > 0;
            }
            catch
            {
                permitido = false;
            }

            cache[clave] = permitido;
            return permitido;
        }

        public void Refrescar() => cache.Clear();
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la  
 * fecha de: 05/08/2026 */