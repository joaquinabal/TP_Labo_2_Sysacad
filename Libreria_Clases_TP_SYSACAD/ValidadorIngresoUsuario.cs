using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public static class ValidadorIngresoUsuario
    {
        //Esta clase servirá para validar TEXTBOX EN BLANCO y datos duplicados en la BD. REFORMULAR

        //Utilizo este metodo desde el formulario de logIn del admin y tambien desde registro del admin
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

        //Utilizo este metodo desde el formulario de logIn del admin y tambien desde registro del admin
        public static bool ComprobarSiUsuarioExiste(string correo)
        {
            bool resultadoBusqueda = false;

            foreach (Administrador administrador in Sistema.BaseDatosAdministradores.Administradores)
            {
                if (administrador.Correo == correo) 
                {
                    resultadoBusqueda = true;
                }
            }
            
            return resultadoBusqueda;
        }

        public static bool ValidarLogInAdmin(string correo, string contraseña)
        {
            bool resultadoBusqueda = false;

            foreach (Administrador administrador in Sistema.BaseDatosAdministradores.Administradores)
            {
                if (administrador.Correo == correo && administrador.Contraseña == contraseña)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        public static bool ComprobarSiEstudianteEstaRegistrado(string correo, string contraseña)
        {
            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in Sistema.BaseDatosEstudiantes.Estudiantes)
            {
                if (estudiante.Correo == correo && estudiante.ContraseñaProvisional == contraseña)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        //Utilizo este metodo desde el formulario de registro del estudiante
        public static bool ComprobarSiEstudianteExiste(string correo, string legajo)
        {
            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in Sistema.BaseDatosEstudiantes.Estudiantes)
            {
                if (estudiante.Correo == correo || estudiante.Legajo == legajo)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        //Utilizo este metodo desde el formulario de agregar el curso
        public static bool ComprobarSiCursoExiste(string codigo)
        {
            bool resultadoBusqueda = false;

            foreach (Curso curso in Sistema.BaseDatosCursos.Cursos)
            {
                if (curso.Codigo == codigo)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        //Utilizo este metodo desde el formulario de registro de estudiantes
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

        //Utilizo este metodo desde el formulario de agregar curso
        public static bool ValidarIngresoDatosCurso(string nombre, string codigo, string descripcion, int cupo)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(codigo)
                || string.IsNullOrEmpty(descripcion) || cupo == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ComprobarSiHayCuposDisponiblesEnCurso(Curso cursoSeleccionado)
        {
            List<Curso> lista_cursos_disponibles = Sistema.BaseDatosCursos.Cursos;
            bool respuestaCuposDisponibles = false;

            foreach (Curso cursoDisponible in lista_cursos_disponibles)
            {
                if (cursoSeleccionado.Codigo == cursoDisponible.Codigo)
                {
                    if (cursoDisponible.CupoDisponible > 0)
                    {
                        respuestaCuposDisponibles = true;
                    }
                }
            }

            return respuestaCuposDisponibles;
        }

    }
}
