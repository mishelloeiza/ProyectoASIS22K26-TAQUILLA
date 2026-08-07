/* Inicio de código de José Pablo Cano Cóbar 
 * Carnet: 0901-23-1727
 * Fecha: 27/07/2026 */

namespace Validaciones
{
    public static class Mensajes
    {
        // ---------- Generales ----------
        public const string CampoRequerido = "Este campo es obligatorio.";
        public const string SeleccioneOpcion = "Debe seleccionar una opcion de la lista.";
        public const string SoloLetras = "Este campo solo puede contener letras.";
        public const string SoloNumeros = "Este campo solo puede contener numeros.";
        public const string SoloAlfanumerico = "Este campo solo admite letras y numeros.";
        public const string FormatoInvalido = "El formato ingresado no es valido.";

        // ---------- Cliente: seleccion ----------
        public const string CiudadRequerida = "Debe seleccionar una ciudad.";
        public const string CineRequerido = "Debe seleccionar un cine.";
        public const string FuncionRequerida = "Debe seleccionar un horario de funcion.";
        public const string FechaFueraDeRango =
            "Solo puede reservar dentro de los proximos 7 dias a partir de hoy.";
        public const string HorarioNoDisponible =
            "El horario seleccionado ya no esta disponible.";

        // ---------- Cliente: boletos ----------
        public const string CantidadInvalida = "Ingrese una cantidad valida.";
        public const string BoletosFueraDeRango = "Debe comprar entre 1 y 10 boletos.";
        public const string SinBoletos = "Debe seleccionar al menos un boleto.";

        // ---------- Cliente: butacas ----------
        public const string ButacaOcupada = "La butaca {0} ya se encuentra reservada.";
        public const string ButacasNoCoinciden =
            "Debe seleccionar exactamente {0} butaca(s), segun el numero de boletos.";
        public const string ButacaTomadaPorOtro =
            "Otro usuario reservo la butaca {0} mientras usted decidia. Seleccione otra.";

        // ---------- Cliente: pago ----------
        public const string NombreInvalido = "El nombre solo puede contener letras.";
        public const string ApellidoInvalido = "El apellido solo puede contener letras.";
        public const string CorreoInvalido = "Ingrese un correo electronico valido.";
        public const string TarjetaInvalida = "El numero de tarjeta no es valido.";
        public const string TarjetaVencida = "La tarjeta esta vencida.";
        public const string VencimientoInvalido =
            "La fecha de vencimiento debe tener el formato MM/AA.";
        public const string CvvInvalido = "El codigo de seguridad debe tener 3 o 4 digitos.";
        public const string TitularRequerido = "Ingrese el nombre del titular de la tarjeta.";
        public const string TiempoAgotado =
            "Se agoto el tiempo para completar el pago. Las butacas fueron liberadas.";
        public const string IntentosExcedidos =
            "Ha excedido el numero maximo de intentos de pago permitidos.";
        public const string PagoEnProceso =
            "Ya hay un pago en proceso. Espere a que finalice.";

        // ---------- Admin: login y usuarios ----------
        public const string UsuarioRequerido = "Ingrese su nombre de usuario.";
        public const string ContrasenaRequerida = "Ingrese su contrasena.";
        public const string CredencialesIncorrectas = "Usuario o contrasena incorrectos.";
        public const string CuentaBloqueada =
            "Cuenta bloqueada por exceder los intentos fallidos permitidos.";
        public const string UsuarioDuplicado = "Ese nombre de usuario ya existe.";
        public const string UsuarioLongitud =
            "El usuario debe tener entre 4 y 20 caracteres alfanumericos.";
        public const string ContrasenaDebil =
            "La contrasena debe tener al menos 8 caracteres, una mayuscula y un numero.";
        public const string ContrasenasNoCoinciden = "Las contrasenas no coinciden.";
        public const string RolRequerido = "Debe asignar un rol al usuario.";
        public const string SinPermisos = "No cuenta con permisos para realizar esta accion.";

        // ---------- Admin: cartelera y funciones ----------
        public const string TituloRequerido = "El titulo de la pelicula es obligatorio.";
        public const string DuracionInvalida = "La duracion debe estar entre 1 y 300 minutos.";
        public const string CostoInvalido = "El costo debe ser un valor mayor a cero.";
        public const string DescuentoInvalido = "El descuento debe estar entre 0 y 100.";
        public const string ClasificacionRequerida =
            "Seleccione una clasificacion (A, B, PG, PG-13, R o NC-17).";
        public const string TrailerInvalido = "El enlace del trailer no es una URL valida.";
        public const string HoraFinAnterior =
            "La hora de finalizacion debe ser posterior a la hora de inicio.";
        public const string FuncionTraslapada =
            "Ya existe una funcion programada en esa sala y horario.";
        public const string SedeIncompleta = "Complete todos los datos de la sede.";

        // ---------- Admin: reportes ----------
        public const string RangoFechasInvalido =
            "La fecha inicial no puede ser posterior a la fecha final.";
        public const string SinDatosReporte =
            "No se encontraron datos para el rango seleccionado.";

        // ---------- Operaciones de datos ----------
        public const string ConfirmarEliminacion =
            "Esta seguro de eliminar este registro? Esta accion no se puede deshacer.";
        public const string EliminacionConDependencias =
            "No se puede eliminar el registro porque tiene informacion asociada.";
        public const string GuardadoExitoso = "Los datos se guardaron correctamente.";

        // ---------- Excepciones tecnicas ----------
        public const string ErrorConexion =
            "No se pudo conectar con el servidor de base de datos. Verifique su conexion.";
        public const string ErrorConsulta =
            "Ocurrio un problema al consultar la informacion. Intente nuevamente.";
        public const string ErrorTiempoAgotado =
            "La operacion tardo demasiado tiempo. Intente nuevamente.";
        public const string ErrorConversion =
            "Uno de los valores ingresados no tiene el formato esperado.";
        public const string ErrorPermisoArchivo =
            "No se tienen permisos para acceder al archivo solicitado.";
        public const string ErrorInesperado =
            "Ocurrio un error inesperado. El detalle fue registrado en la bitacora.";

        // ---------- Titulos de ventana ----------
        public const string TituloError = "Error";
        public const string TituloAdvertencia = "Advertencia";
        public const string TituloInformacion = "Informacion";
        public const string TituloConfirmacion = "Confirmacion";
        public const string TituloValidacion = "Datos incompletos o invalidos";
    }
}

/* Fin de Código de José Pablo Cano Cóbar */ 