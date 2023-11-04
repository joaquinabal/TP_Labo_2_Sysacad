using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasProfesores : ConexionBD
    {
        private static List<Profesor> _listaProfesores = new List<Profesor>();

        /////////////////// RECONSTRUCCION DE LA LISTA DE PROFESORES A PARTIR DE BD

        internal static void CrearInstanciasDeProfesoresAPartirDeBD()
        {
            _listaProfesores.Clear();
            _listaProfesores = CargaDeInstanciasDesdeBD.CrearInstanciasDeProfesoresAPartirDeBD();
        }

        ///////////////////////CREATE
        internal static void IngresarNuevoProfesor(Profesor profesorNuevo)
        {
            string query = "INSERT INTO Profesores (nombre, direccion, telefono, correo, especializacion) " +
                  "VALUES (@nombre, @direccion, @telefono, @correo, @especializacion)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@nombre", profesorNuevo.Nombre },
                { "@direccion", profesorNuevo.Direccion },
                { "@telefono", profesorNuevo.Telefono },
                { "@correo", profesorNuevo.Correo },
                { "@especializacion", profesorNuevo.Especializacion }
            };

            ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        ///////////////////////READ

        internal static bool BuscarProfesorExistenteBD(string correo)
        {
            bool resultadoBusqueda = false;

            foreach (Profesor profesor in _listaProfesores)
            {
                if (profesor.Correo == correo)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        ///////////////////////UPDATE

        public static void EditarProfesor(string correo, string direccion, string especializacion, string nombre, string telefono, string correoOriginal)
        {
            string query = "UPDATE Profesores SET nombre = @nombre, direccion = @direccion, telefono = @telefono, correo = @correo, especializacion = @especializacion WHERE correo = @correoOriginal";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@nombre", nombre },
                { "@direccion", direccion },
                { "@telefono", telefono },
                { "@correo", correo },
                { "@especializacion", especializacion },
                { "@correoOriginal", correoOriginal }
            };

            ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        public static void AgregarCursoAProfesor(string correoProfesor, string codigoCurso)
        {
            string query = "INSERT INTO ProfesoresEnCursos (correoProfesor, codigoCurso) " +
                   "VALUES (@correo, @codigo)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@correo", correoProfesor },
                { "@codigo", codigoCurso }
            };

            ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        ///////////////////////DELETE

        public static void EliminarProfesorBD(string correo)
        {
            string query = @"DELETE FROM Profesores WHERE correo = @correo";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@correo", correo }
            };

            ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        //Getters y setters
        public static List<Profesor> Profesores { get { return _listaProfesores; } }
    }
}
