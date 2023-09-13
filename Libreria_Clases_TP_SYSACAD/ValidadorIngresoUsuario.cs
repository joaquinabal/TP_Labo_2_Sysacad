using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public static class ValidadorIngresoUsuario
    {
        public static bool ValidarCorreoYContraseña(string correo, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ComprobarSiUsuarioExiste(string correo, string contraseña)
        {
            bool resultadoBusqueda = false;

            foreach (Administrador administrador in Sistema.baseDatosAdministradores.Administradores)
            {
                if (administrador.Correo == correo) 
                {
                    resultadoBusqueda = true;
                }
            }
            
            return resultadoBusqueda;
        }

        public static bool ComprobarSiEstudianteExiste(string correo, string legajo)
        {
            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in Sistema.baseDatosEstudiantes.Estudiantes)
            {
                if (estudiante.Correo == correo || estudiante.Legajo == legajo)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        public static bool ValidarIngresoDatosEstudiante(string nombre, string legajo, string direccion, string telefono, string correo, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(legajo) 
                || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(telefono) 
                || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}
