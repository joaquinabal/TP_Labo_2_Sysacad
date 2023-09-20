﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class Estudiante
    {
        //Atributos del estudiante
        private string _nombre;
        private string _legajo;
        private string _direccion;
        private string _numeroTelefono;
        private string _correo;
        private string _contraseñaProvisional;
        private Guid _identificadorUnico;
        private bool _debeCambiarContraseña;
        private List<Curso> _cursosInscriptos;

        public Estudiante(string nombre, string legajo, string direccion, string telefono,
            string correo, string contraseñaProv, bool debeCambiarContraseña)
        {
            _nombre = nombre;
            _legajo = legajo;
            _direccion = direccion;
            _numeroTelefono = telefono;
            _correo = correo;
            _contraseñaProvisional = contraseñaProv;
            _debeCambiarContraseña = debeCambiarContraseña;
            _cursosInscriptos = new List<Curso>();
        }

        //Este metodo se llama desde el forms, tras validar el estudiante, para ingresarlo a la BD.
        public void RegistrarEstudiante(Estudiante nuevoEstudiante)
        {
            Sistema.BaseDatosEstudiantes.IngresarUsuarioBD(nuevoEstudiante);
        }

        public void InscribirEstudianteACurso(Estudiante estudiante, Curso curso)
        {
            estudiante.CursosInscriptos.Add(curso);
        }

        public string Legajo 
        { 
            get 
            {
                return _legajo;
            } 
        }

        public string Correo
        {
            get
            {
                return _correo;
            }
        }

        public Guid IdentificadorUnico
        {
            set
            {
                _identificadorUnico = value;
            }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Direccion
        {
            get { return _direccion; }
        }

        public string NumeroTelefono
        {
            get { return _numeroTelefono; }
        }

        public string ContraseñaProvisional
        {
            get { return _contraseñaProvisional; }
        }

        public List<Curso> CursosInscriptos
        {
            get { return _cursosInscriptos; }
        }
    }
}
