namespace Libreria_Clases_TP_SYSACAD
{
    /// <summary>
    /// Clase que contiene las validaciones correspondientes a la entidad estudiante
    /// </summary>
    class ValidacionesEstudiante : ValidarEntidades
    {
        /// <summary>
        /// Valida si existe un estudiante dentro de la lista de estos
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="legajo"></param>
        /// <returns>
        /// Retorna true si pudo encontrar al estudiante en la lista, caso contrario retorna false
        /// </returns>
        public static bool ComprobarSiEstudianteExiste(string correo, string legajo)
        {
            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in BaseDatosEstudiantes.Estudiantes)
            {
                if (estudiante.Correo == correo || estudiante.Legajo == legajo)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        /// <summary>
        /// Valida los datos ingresados del estudiante, llama a los metodos correspondientes validantes de cada campo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="legajo"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="contraseña"></param>
        /// <returns> true si todos los campos estan bien, caso contrario devuelve false</returns>
        public static bool ValidarDatosEstudiante(string nombre, string legajo, string direccion, string telefono, string correo, string contraseña)
        {
            if (ValidarNombre(nombre) || ValidarLegajo(legajo) || 
                ValidarDireccion(direccion) || ValidarTelefono(telefono) || 
                ValidarCorreo(correo) || ValidarContrasenia(contraseña))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Valida que el nombre ingresado no sea null
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>retorna false si es null, caso contrario devuelve true</returns>
        public static bool ValidarNombre(string nombre)
        {
            if (ValidarIngresoNull(nombre))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Valida que el legajo sea distinto de null
        /// </summary>
        /// <param name="legajo"></param>
        /// <returns>retorna false si es null, caso contrario devuelve true</returns>
        public static bool ValidarLegajo(string legajo)
        {
            if (ValidarIngresoNull(legajo))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Valida que la direccion no sea null y que solamente sean letras y numeros
        /// </summary>
        /// <param name="direccion"></param>
        /// <returns></returns>
        public static bool ValidarDireccion(string direccion)
        {
            if (ValidarIngresoNull(direccion) || ValidarIngresos.ValidacionesString.LetrasNumeros((direccion)))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Valida que el telefono tenga formato de celular o fijo, tambien si el ingreso es null
        /// </summary>
        /// <param name="telefono"></param>
        /// <returns>Retorna true si el formato es correcto, caso contrario false</returns>
        public static bool ValidarTelefono(string telefono)
        {
            if (ValidarIngresoNull(telefono) || ValidarIngresos.ValidacionesString.TelefonoFijo(telefono) || ValidarIngresos.ValidacionesString.TelefonoMovil(telefono))
                return false;
            else
                return true;
        }
    }
}
