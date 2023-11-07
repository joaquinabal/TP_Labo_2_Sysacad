using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasEstudiantes : ConexionBD
    {
        private static List<Estudiante> _listaEstudiantes = new List<Estudiante>();

        /////////////////// RECONSTRUCCION DE LA LISTA DE ESTUDIANTES A PARTIR DE BD

        internal static void CrearInstanciasDeEstudiantesAPartirDeBD()
        {
            _listaEstudiantes.Clear();
            _listaEstudiantes = CargaDeInstanciasDesdeBD.CrearInstanciasDeEstudiantesAPartirDeBD();
        }

        ///////////////////////CREATE
        private static void AñadirConceptosDePagoIniciales(string legajo)
        {
            Dictionary<string, double> conceptosIniciales = new Dictionary<string, double>
            {
                { "Matricula de Ingreso", 20000 },
                { "Matricula del Primer Cuatrimestre", 15000 },
                { "Cargos Administrativos primer cuatrimestre", 5000 },
                { "Bibliografia Primer Cuatrimestre", 5000 }
            };

            foreach (var parKeyValue in conceptosIniciales)
            {
                string query = "INSERT INTO ConceptosDePagoDeEstudiante (legajoEstudiante, conceptoNombre, montoPendiente) " +
                       "VALUES (@legajoEstudiante, @conceptoNombre, @montoPendiente)";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@legajoEstudiante", legajo },
                    { "@conceptoNombre", parKeyValue.Key },
                    { "@montoPendiente", parKeyValue.Value }
                };

                ConsultasGenericas.EjecutarNonQuery(query, parametros);
            }
        }

        internal static void IngresarUsuarioBD(Estudiante nuevoEstudiante)
        {
            Guid nuevoGuid = Guid.NewGuid();
            nuevoEstudiante.IdentificadorUnico = nuevoGuid;
            nuevoEstudiante.Contrasenia = Hash.HashPassword(nuevoEstudiante.Contrasenia);

            string query = "INSERT INTO Estudiante (legajo, nombre, direccion, numeroTelefono, correo, " +
                   "contrasenia, identificadorUnico, debeCambiarContrasenia, creditos, promedio) " +
                   "VALUES (@legajoEstudiante, @nombreEstudiante, @direccionEstudiante, " +
                   "@telefonoEstudiante, @correoEstudiante, @contraseniaEstudiante, " +
                   "@identifiadorUnicoEstudiante, @debeCambiarContraseniaEstudiante, " +
                   "@creditosEstudiante, @promedioEstudiante)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@legajoEstudiante", nuevoEstudiante.Legajo },
                { "@nombreEstudiante", nuevoEstudiante.Nombre },
                { "@direccionEstudiante", nuevoEstudiante.Direccion },
                { "@telefonoEstudiante", nuevoEstudiante.NumeroTelefono },
                { "@correoEstudiante", nuevoEstudiante.Correo },
                { "@contraseniaEstudiante", nuevoEstudiante.Contrasenia },
                { "@identifiadorUnicoEstudiante", nuevoEstudiante.IdentificadorUnico },
                { "@debeCambiarContraseniaEstudiante", nuevoEstudiante.DebeCambiarContrasenia },
                { "@creditosEstudiante", nuevoEstudiante.Creditos },
                { "@promedioEstudiante", nuevoEstudiante.Promedio }
            };

            ConsultasGenericas.EjecutarNonQuery(query, parametros);

            AñadirConceptosDePagoIniciales(nuevoEstudiante.Legajo);
            CrearInstanciasDeEstudiantesAPartirDeBD();
        }

        ///////////////////////READ
        internal static bool BuscarUsuarioCredencialesBD(string correo, string contrasenia)
        {
            Predicate<Estudiante> predicado = estudiante => estudiante.Correo == correo && Hash.VerifyPassword(contrasenia, estudiante.Contrasenia);

            List<Estudiante> estudiantesFiltrados = ConsultasGenericas.FiltrarElementos(_listaEstudiantes, predicado);
            return estudiantesFiltrados.Count > 0;
        }

        internal static bool BuscarUsuarioExistenteBD(string correo, string legajo)
        {
            Predicate<Estudiante> predicado = estudiante => estudiante.Correo == correo || estudiante.Legajo == legajo;

            List<Estudiante> estudiantesFiltrados = ConsultasGenericas.FiltrarElementos(_listaEstudiantes, predicado);
            return estudiantesFiltrados.Count > 0;
        }

        public static bool BuscarSiUsuarioDebeCambiarContrasenia(string correo)
        {
            Predicate<Estudiante> predicado = estudiante => estudiante.Correo == correo && estudiante.DebeCambiarContrasenia == true;

            List<Estudiante> estudiantesFiltrados = ConsultasGenericas.FiltrarElementos(_listaEstudiantes, predicado);
            return estudiantesFiltrados.Count > 0;
        }

        public static Estudiante ObtenerEstudianteSegunLegajo(string legajo)
        {
            Predicate<Estudiante> predicado = estudiante => estudiante.Legajo == legajo;

            //Uso .FirstOrDefault() para agarrar al primer curso que encuentre que tenga el legajo.
            List<Estudiante> estudiantesFiltrados = ConsultasGenericas.FiltrarElementos(_listaEstudiantes, predicado);
            return estudiantesFiltrados.FirstOrDefault();
        }

        ///////////////////////UPDATE

        public static void CambiarContraseñaAEstudiante(string correo, string nuevaContrasenia)
        {
            string nuevaContraseniaHasheada = Hash.HashPassword(nuevaContrasenia);

            string query = "UPDATE Estudiante SET contrasenia = @nuevaContraseniaHasheada, debeCambiarContrasenia = 'False' WHERE correo = @correo";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@nuevaContraseniaHasheada", nuevaContraseniaHasheada },
                { "@correo", correo }
            };

            ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeEstudiantesAPartirDeBD();
        }

        //Getters y setters
        public static List<Estudiante> Estudiantes { get { return _listaEstudiantes; } }
    }
}
