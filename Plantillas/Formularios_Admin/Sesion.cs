/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 04/08/2026 */

using System;

namespace Plantilla_Admin
{
    public static class Sesion
    {
        public static string Usuario { get; private set; } = "";
        public static string Perfil { get; private set; } = "";

        public static bool EsAdmin =>
            Perfil.Equals("admin", StringComparison.OrdinalIgnoreCase);

        public static bool EsTaquillero =>
            Perfil.Equals("taquillero", StringComparison.OrdinalIgnoreCase);

        public static bool EsPerfil(string perfil) =>
            Perfil.Equals(perfil, StringComparison.OrdinalIgnoreCase);

        public static void Iniciar(string usuario, string perfil)
        {
            Usuario = usuario;
            Perfil = perfil;
        }

        public static void Cerrar()
        {
            Usuario = "";
            Perfil = "";
        }

        public static string Descripcion() =>
            "Usuario: " + Usuario + " — Perfil: " + Perfil;
    }
}

/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 05/08/2026 */