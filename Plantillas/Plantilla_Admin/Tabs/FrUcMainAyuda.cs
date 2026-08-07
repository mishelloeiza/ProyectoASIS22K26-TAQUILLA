/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 04/08/2026 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Plantilla_Admin.Tabs
{
    public partial class FrUcMainAyuda : UserControl
    {

        private readonly Dictionary<string, string> _ayuda = new();

        public FrUcMainAyuda()
        {
            InitializeComponent();

            TvRamasDeAyuda.Nodes.Clear();

            ConstruirArbol();

            TvRamasDeAyuda.AfterSelect += TvRamasDeAyuda_AfterSelect;

            BtnManualTecnico.Click += (_, _) => DescargarManualTecnico();

            TvRamasDeAyuda.ExpandAll();
            if (TvRamasDeAyuda.Nodes.Count > 0)
                TvRamasDeAyuda.SelectedNode = TvRamasDeAyuda.Nodes[0];
        }

        private TreeNode Nodo(TreeNode? padre, string clave, string titulo, string contenido)
        {
            var n = new TreeNode(titulo) { Name = clave };
            _ayuda[clave] = contenido;

            if (padre is null) TvRamasDeAyuda.Nodes.Add(n);
            else padre.Nodes.Add(n);
            return n;
        }

        private void ConstruirArbol()
        {

            Nodo(null, "intro", "Introducción",
                "Bienvenido al menú de ayuda de la Aplicación Administrativa del " +
                "Software de Taquilla.\n\n" +
                "Esta aplicación es independiente de la aplicación de Usuario/Cliente " +
                "y permite gestionar la cartelera (películas, horarios, salas, " +
                "clasificación, precios, etc.), administrar usuarios y sus permisos, " +
                "y generar los reportes para la gerencia.\n\n" +
                "Seleccione un tema en el árbol de la izquierda para ver su explicación. " +
                "También puede descargar el Manual de Usuario o el Manual Técnico con " +
                "los botones de la parte superior.");

            var guia = Nodo(null, "guia", "Guía de Uso",
                "La Aplicación Administrativa se organiza en secciones. A continuación " +
                "se describe cada tarea principal. Seleccione una subrama para ver el detalle.");

            Nodo(guia, "guia_login", "Inicio de sesión",
                "El acceso se controla mediante un inicio de sesión con nombre de usuario " +
                "y contraseña encriptada.\n\n" +
                "1. Ingrese su usuario y contraseña.\n" +
                "2. El sistema valida las credenciales; sólo el personal autorizado ingresa.\n" +
                "3. Según su rol (gerente, cajero o soporte) verá distintas opciones y permisos.\n\n" +
                "Si olvidó su contraseña, contacte al usuario con rol de soporte o al " +
                "administrador del sistema.");

            Nodo(guia, "guia_cartelera", "Gestión de Cartelera",
                "Desde esta sección puede modificar los datos de las películas en exhibición:\n\n" +
                "• Costos y descuentos.\n" +
                "• Horarios y salas de cine.\n" +
                "• Clasificación de contenido (A, B, PG, PG-13, R, NC-17).\n" +
                "• Departamento (Capital, Zacapa, Chiquimula, etc.).\n" +
                "• Centro comercial, establecimiento o teatro.\n" +
                "• Idioma y subtitulado.\n\n" +
                "Todos los cambios se reflejan automáticamente en la aplicación de " +
                "Usuario/Cliente, sin necesidad de modificar su código.");

            Nodo(guia, "guia_usuarios", "Gestión de Usuarios y Roles",
                "Permite crear, actualizar y eliminar usuarios administrativos, así como " +
                "asignar sus permisos.\n\n" +
                "Roles disponibles:\n" +
                "• Gerente: acceso a reportes y a la información confidencial del cine.\n" +
                "• Cajero: operación de ventas y consulta de cartelera.\n" +
                "• Soporte: administración de usuarios y mantenimiento del sistema.\n\n" +
                "Cada rol define permisos específicos dentro de la aplicación.");

            Nodo(guia, "guia_reportes", "Generación de Reportes",
                "La aplicación genera informes para la gerencia:\n\n" +
                "• Películas más taquilleras por semana y por mes.\n" +
                "• Ganancias por semana y por mes.\n\n" +
                "Pasos:\n" +
                "1. Seleccione el tipo de reporte.\n" +
                "2. Indique el año y el periodo (semana o mes). El valor 0 incluye todos.\n" +
                "3. Presione «Generar».\n" +
                "4. Puede imprimir el reporte o exportarlo a formato CSV.");

            Nodo(guia, "guia_ayuda", "Menú de Ayuda",
                "Este menú funciona como guía para el uso y comprensión del programa. " +
                "Incluye un diccionario de conceptos y preguntas frecuentes.\n\n" +
                "Use el árbol de la izquierda para navegar entre los temas y los botones " +
                "superiores para descargar los manuales.");

            var dicc = Nodo(null, "dicc", "Diccionario de Conceptos",
                "Definiciones de los términos utilizados en el sistema. " +
                "Seleccione un concepto para ver su significado.");

            Nodo(dicc, "c_taquilla", "Taquilla",
                "Sitio donde se venden las entradas para acceder a un evento público, como " +
                "el teatro, el estadio o el cine. Este software está enfocado en la taquilla de cine.");

            Nodo(dicc, "c_cartelera", "Cartelera",
                "Conjunto de películas que un cine está presentando, junto con sus horarios, " +
                "formatos e idiomas. La cartelera tiene una vigencia aproximada de una semana " +
                "y se mantiene cambiando.");

            Nodo(dicc, "c_complejo", "Complejo / Cine",
                "Establecimiento (por ejemplo, un centro comercial o teatro) donde se " +
                "proyectan las películas. El usuario puede filtrar la cartelera por los " +
                "complejos de la ciudad seleccionada.");

            Nodo(dicc, "c_funcion", "Función",
                "Proyección de una película en una fecha, horario, sala, formato e idioma " +
                "específicos.");

            Nodo(dicc, "c_sala", "Sala de Cine",
                "Espacio físico con asientos numerados donde se proyecta una función. " +
                "El sistema maneja al menos 3 salas distintas en Guatemala.");

            Nodo(dicc, "c_reservacion", "Reservación",
                "Acción de apartar uno o más asientos para una función. La reservación tiene " +
                "una vigencia de 7 días a partir de la fecha de ingreso al sistema; no se " +
                "puede reservar antes ni después de esa semana.");

            Nodo(dicc, "c_boleto", "Boleto",
                "Entrada para una función. Se pueden comprar hasta 10 boletos por reservación, " +
                "con costos diferenciados para adulto, niño y adulto mayor. El sistema calcula " +
                "el subtotal por grupo y el total.");

            Nodo(dicc, "c_asiento", "Asiento",
                "Lugar numerado dentro de una sala. Los colores indican su estado:\n" +
                "• Rojo: vendido o reservado.\n" +
                "• Verde: asiento que el usuario está por reservar.\n" +
                "• Blanco: disponible.");

            Nodo(dicc, "c_concurrencia", "Control de Concurrencia",
                "Mecanismo que evita que dos usuarios reserven el mismo asiento de forma " +
                "simultánea, garantizando que cada asiento se asigne a una sola persona.");

            Nodo(dicc, "c_clasificacion", "Clasificación de Contenido",
                "Indica la edad recomendada para ver una película:\n" +
                "• A: Apta para todo público.\n" +
                "• B: Dirigida al público general, pero con situaciones que requieren la " +
                "explicación de un adulto (padre o tutor).\n" +
                "• PG: Se sugiere la compañía de un adulto para menores de 10 años.\n" +
                "• PG-13: Se sugiere la compañía de un adulto para menores de 13 años.\n" +
                "• R: No apta para menores de 17 años sin la compañía de un adulto.\n" +
                "• NC-17: Contenido sólo apto para mayores de 18 años.");

            Nodo(dicc, "c_formato", "Formato",
                "Forma en que se proyecta la película: 2D (imagen plana) o 3D (imagen con " +
                "profundidad, que requiere lentes especiales).");

            Nodo(dicc, "c_idioma", "Idioma",
                "Idioma en que se presenta la película:\n" +
                "• DOB (Doblado): el audio está en el idioma local.\n" +
                "• SUB (Subtitulado): el audio original con subtítulos en el idioma local.");

            Nodo(dicc, "c_proyeccion", "Tipo de Proyección",
                "Modalidad de la sala y la experiencia, por ejemplo 4DX, IMAX o VIP, entre otras.");

            Nodo(dicc, "c_factura", "Factura",
                "Documento que se envía al correo del cliente con los datos de su compra: " +
                "cine, asientos, número de boletos, total, etc.");

            Nodo(dicc, "c_reporte", "Reporte",
                "Informe generado para la gerencia con el fin de tomar decisiones (descuentos " +
                "y promociones). Los principales son: películas más taquilleras y ganancias, " +
                "por semana y por mes.");

            Nodo(dicc, "c_rol", "Rol",
                "Perfil que define qué puede hacer un usuario administrativo dentro de la " +
                "aplicación. Los roles son gerente, cajero y soporte.");

            Nodo(dicc, "c_permiso", "Permiso",
                "Autorización específica asociada a un rol para acceder a una función o dato " +
                "del sistema.");

            Nodo(dicc, "c_encriptacion", "Encriptación",
                "Proceso mediante el cual la contraseña de un usuario se almacena de forma " +
                "cifrada, de modo que no pueda leerse directamente, garantizando la seguridad " +
                "del acceso.");

            var faq = Nodo(null, "faq", "Preguntas Frecuentes",
                "Respuestas a las dudas más comunes sobre el sistema. Seleccione una pregunta.");

            Nodo(faq, "q_login", "¿Cómo inicio sesión?",
                "Ingrese su nombre de usuario y contraseña en la pantalla de inicio de sesión. " +
                "Sólo el personal autorizado tiene acceso. Su rol determina las opciones que verá.");

            Nodo(faq, "q_cartelera", "¿Cómo modifico la cartelera?",
                "Desde la sección de Cartelera puede cambiar costos, descuentos, horarios, salas, " +
                "clasificación, departamento, establecimiento, idioma y subtitulado. Los cambios " +
                "se reflejan automáticamente en la aplicación del usuario.");

            Nodo(faq, "q_sync", "¿Los cambios afectan la app del cliente?",
                "Sí. Cualquier cambio en la cartelera o en los precios se ve reflejado en la " +
                "aplicación de Usuario/Cliente sin necesidad de modificar su código.");

            Nodo(faq, "q_reportes", "¿Qué reportes puedo generar?",
                "Puede generar los reportes de películas más taquilleras y de ganancias, tanto " +
                "por semana como por mes. Además puede imprimirlos o exportarlos a CSV.");

            Nodo(faq, "q_usuarios", "¿Cómo administro los usuarios?",
                "En la gestión de usuarios puede crear, actualizar y eliminar usuarios " +
                "administrativos y asignarles un rol (gerente, cajero o soporte) con sus permisos.");

            Nodo(faq, "q_clasificacion", "¿Qué significan las letras de clasificación?",
                "Son la clasificación de contenido: A, B, PG, PG-13, R y NC-17. Consulte el " +
                "concepto «Clasificación de Contenido» en el diccionario para ver el detalle " +
                "de cada una.");

            Nodo(faq, "q_fechas", "¿En qué fechas se puede reservar?",
                "La reservación es válida por 7 días a partir de la fecha actual del sistema; " +
                "no se puede reservar antes ni después de esa semana, ya que la cartelera " +
                "cambia aproximadamente cada semana.");

            Nodo(faq, "q_boletos", "¿Cuántos boletos se pueden comprar?",
                "Un máximo de 10 boletos por reservación, con precios diferenciados para " +
                "adulto, niño y adulto mayor.");

            Nodo(faq, "q_pago", "¿Qué pasa si el cliente no paga a tiempo?",
                "El pago tiene un tiempo límite (por defecto 1 minuto, configurable). Si no se " +
                "completa, los asientos seleccionados vuelven a quedar disponibles.");

            Nodo(faq, "q_manuales", "¿Dónde descargo los manuales?",
                "Use los botones «Descargar Manual de Usuario» y «Descargar Manual Técnico» " +
                "en la parte superior de esta pantalla.");
        }

        private void TvRamasDeAyuda_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            if (e.Node is null) return;

            string cuerpo = _ayuda.TryGetValue(e.Node.Name, out var c)
                ? c
                : "Seleccione un tema del árbol para ver su explicación.";

            MostrarContenido(e.Node.Text, cuerpo);
        }

        private void MostrarContenido(string titulo, string cuerpo)
        {
            RtbTextoAyuda.Clear();

            const int pad = 16;

            RtbTextoAyuda.SelectionIndent = pad;
            RtbTextoAyuda.SelectionRightIndent = pad;

            RtbTextoAyuda.SelectionColor = Color.FromArgb(255, 99, 71);
            RtbTextoAyuda.SelectionFont = new Font("Segoe UI", 14F, FontStyle.Bold);
            RtbTextoAyuda.SelectionAlignment = HorizontalAlignment.Center;
            RtbTextoAyuda.AppendText("\n" + titulo + "\n\n"); 

            RtbTextoAyuda.SelectionColor = Color.FromArgb(230, 230, 230);
            RtbTextoAyuda.SelectionAlignment = HorizontalAlignment.Left;
            RtbTextoAyuda.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            RtbTextoAyuda.SelectionIndent = pad;
            RtbTextoAyuda.SelectionRightIndent = pad;
            RtbTextoAyuda.AppendText(cuerpo + "\n");

            RtbTextoAyuda.SelectionStart = 0;
            RtbTextoAyuda.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e) => DescargarManualUsuario();

        private void DescargarManualUsuario() =>
            DescargarManual("ManualUsuario.pdf", "Manual de Usuario");

        private void DescargarManualTecnico() =>
            DescargarManual("ManualTecnico.pdf", "Manual Técnico");

        private void DescargarManual(string archivoOrigen, string titulo)
        {
            try
            {
                string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Manuales");
                string ruta = Path.Combine(carpeta, archivoOrigen);

                if (!File.Exists(ruta))
                {
                    MessageBox.Show(
                        "No se encontró el archivo del " + titulo + ".\n\n" +
                        "Colóquelo en la carpeta:\n" + carpeta,
                        "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var sfd = new SaveFileDialog
                {
                    Filter = "Documento PDF (*.pdf)|*.pdf",
                    FileName = archivoOrigen,
                    Title = "Descargar " + titulo
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;

                File.Copy(ruta, sfd.FileName, overwrite: true);

                if (MessageBox.Show(
                        "Se descargó el " + titulo + " en:\n" + sfd.FileName +
                        "\n\n¿Desea abrirlo ahora?",
                        "Descarga completa",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(
                        new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo descargar el " + titulo + ".\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 04/08/2026 */