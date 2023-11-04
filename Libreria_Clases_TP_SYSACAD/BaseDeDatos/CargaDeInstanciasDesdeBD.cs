using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    internal class CargaDeInstanciasDesdeBD : ConexionBD
    {
        /////////////////// RECONSTRUCCION DE LA LISTA DE CURSOS A PARTIR DE BD
        private static List<string> DevolverListaDeCorrelatividadesSegunCFId(int CFid)
        {
            string query = "SELECT codigoFamiliaCorrelatividad FROM Correlatividades WHERE idFamiliaCursoBase = @CFid";
            return ConsultasGenericas.ObtenerListaMedianteQuery(query, "@CFid", CFid, readerAlternativo => readerAlternativo["codigoFamiliaCorrelatividad"].ToString());
        }

        private static Dictionary<string, DateTime> DevolverListaEsperaSegunCodigoCurso(string codigo)
        {
            Dictionary<string, DateTime> listaEspera = new Dictionary<string, DateTime>();

            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo = new SqlCommand("SELECT legajoEstudiante, fechaIngreso FROM AlumnosEnListaDeEspera WHERE codigoCurso = @codigo", connectionAlternativa))
                {
                    commandAlternativo.Parameters.AddWithValue("@codigo", codigo);

                    try
                    {
                        connectionAlternativa.Open();

                        using (var readerAlternativo = commandAlternativo.ExecuteReader())
                        {
                            while (readerAlternativo.Read())
                            {
                                string legajoEstudiante = readerAlternativo["legajoEstudiante"].ToString();
                                DateTime fechaInscripcion = DateTime.Parse(readerAlternativo["fechaIngreso"].ToString());

                                listaEspera[legajoEstudiante] = fechaInscripcion;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }

            return listaEspera;
        }

        internal static List<Curso> CrearInstanciasDeCursoAPartirDeBD()
        {
            string query = "SELECT C.*, T.nombre AS nombreTurno, D.nombre AS nombreDia, CF.codigo AS codigoCF FROM Curso C " +
                    "INNER JOIN Turno T ON C.turnoId = T.id " +
                    "INNER JOIN Dia D ON C.diaId = D.id " +
                    "INNER JOIN CodigoFamilia CF ON C.codigoFamiliaId = CF.id";

            Func<SqlDataReader, Curso> mapper = reader =>
            {
                string nombre = reader["nombre"].ToString();
                string codigo = reader["codigo"].ToString();
                string descripcion = reader["descripcion"].ToString();
                int cupoMaximo = Convert.ToInt32(reader["cupoMaximo"]);
                int cupoDisponible = Convert.ToInt32(reader["cupoDisponible"]);
                string turno = reader["nombreTurno"].ToString();
                string aula = reader["aula"].ToString();
                string dia = reader["nombreDia"].ToString();
                Carrera carrera = (Carrera)Enum.Parse(typeof(Carrera), reader["carreraCodigo"].ToString());
                int creditosRequeridos = Convert.ToInt32(reader["creditosRequeridos"]);
                double promedioRequerido = Double.Parse(reader["promedioRequerido"].ToString());
                string codigoFamilia = reader["codigoCF"].ToString();

                List<string> codigosCorrelatividades = DevolverListaDeCorrelatividadesSegunCFId(Convert.ToInt32(reader["codigoFamiliaId"]));
                Dictionary<string, DateTime> alumnosEnListaDeEspera = DevolverListaEsperaSegunCodigoCurso(codigo);

                Curso cursoReconstruido = new Curso(nombre, codigo, descripcion,
                    cupoMaximo, cupoDisponible, turno, aula, dia, carrera, codigosCorrelatividades,
                    creditosRequeridos, promedioRequerido, codigoFamilia, alumnosEnListaDeEspera);

                return cursoReconstruido;
            };

            // Llama al método 'CrearInstanciasDesdeBD' con la consulta y el 'mapper' adecuados.
            List<Curso> listaReconstruida = ConsultasGenericas.CrearInstanciasDesdeBD(query, mapper);

            return listaReconstruida;
        }

        /////////////////// RECONSTRUCCION DE LA LISTA DE ESTUDIANTES A PARTIR DE BD

        private static List<string> DevolverListaConCodigosCursosInscriptos(string legajo)
        {
            string query = "SELECT codigoCurso FROM RegistroInscripcion WHERE legajo = @legajo";
            return ConsultasGenericas.ObtenerListaMedianteQuery(query, "@legajo", legajo, readerAlternativo => readerAlternativo["codigoCurso"].ToString());
        }

        private static List<ConceptoDePago> DevolverListaConConceptosDePagoDeEstudiante(string legajo)
        {
            string query = "SELECT CP.nombre AS nombreConceptoPago, CP.montoInicial, CPE.montoPendiente FROM ConceptosDePagoDeEstudiante CPE " +
                   "INNER JOIN ConceptoDePago CP ON CPE.conceptoNombre = CP.nombre " +
                   "WHERE CPE.legajoEstudiante = @legajo";

            return ConsultasGenericas.ObtenerListaMedianteQuery(query, "@legajo", legajo, readerAlternativo =>
            {
                string nombre = readerAlternativo["nombreConceptoPago"].ToString();
                double montoInicial = Double.Parse(readerAlternativo["montoInicial"].ToString());
                double montoPendiente = Double.Parse(readerAlternativo["montoPendiente"].ToString());
                return new ConceptoDePago(nombre, montoInicial, montoPendiente);
            });
        }

        private static List<string> DevolverCFCursosCompletados(string legajo)
        {
            string query = "SELECT codigoFamiliaCurso FROM RegistroCursosCompletados WHERE legajo = @legajo";
            return ConsultasGenericas.ObtenerListaMedianteQuery(query, "@legajo", legajo, readerAlternativo => readerAlternativo["codigoFamiliaCurso"].ToString());
        }

        internal static List<Estudiante> CrearInstanciasDeEstudiantesAPartirDeBD()
        {
            string query = "SELECT * FROM Estudiante";

            Func<SqlDataReader, Estudiante> mapper = reader =>
            {
                string nombre = reader["nombre"].ToString();
                string legajo = reader["legajo"].ToString();
                string direccion = reader["direccion"].ToString();
                string numeroTelefono = reader["numeroTelefono"].ToString();
                string correo = reader["correo"].ToString();
                string contrasenia = reader["contrasenia"].ToString();
                Guid identificadorUnico = Guid.Parse(reader["identificadorUnico"].ToString());
                bool debeCambiarContrasenia = Convert.ToBoolean(reader["debeCambiarContrasenia"]);
                int creditos = Convert.ToInt32(reader["creditos"]);
                double promedio = Double.Parse(reader["promedio"].ToString());

                List<string> _codigoCursosInscriptos = DevolverListaConCodigosCursosInscriptos(legajo);
                List<ConceptoDePago> _conceptosAPagar = DevolverListaConConceptosDePagoDeEstudiante(legajo);
                List<string> _codigosDeFamiliaDeCursosCompletados = DevolverCFCursosCompletados(legajo);

                Estudiante estudianteReconstruido = new Estudiante(nombre, legajo, direccion, numeroTelefono,
                    correo, contrasenia, debeCambiarContrasenia, creditos, promedio,
                    _codigoCursosInscriptos, _conceptosAPagar, _codigosDeFamiliaDeCursosCompletados);

                return estudianteReconstruido;
            };

            // Llama al método 'ConsultasGenericas.CrearInstanciasDesdeBD' con la consulta y el 'mapper' adecuados.
            List<Estudiante> listaReconstruida = ConsultasGenericas.CrearInstanciasDesdeBD(query, mapper);

            return listaReconstruida;
        }

        /////////////////// RECONSTRUCCION DE LA LISTA DE INSCRIPCIONES A PARTIR DE BD
        internal static string ObtenerNombreAlumnoDesdeLegajo(string legajo)
        {
            string query = "SELECT nombre FROM Estudiante WHERE legajo = @legajo";
            return ConsultasGenericas.EjecutarEscalar<string>(query, "@legajo", legajo);
        }

        private static string ObtenerNombreCursoDesdeCodigo(string codigo)
        {
            string query = "SELECT nombre FROM Curso WHERE codigo = @codigo";
            return ConsultasGenericas.EjecutarEscalar<string>(query, "@codigo", codigo);
        }

        internal static Carrera DevolverCarreraDedeCodigoCurso(string codigoCurso)
        {
            string query = "SELECT carreraCodigo FROM Curso WHERE codigo = @codigoCurso";
            string carrera = ConsultasGenericas.EjecutarEscalar<string>(query, "@codigoCurso", codigoCurso);

            return (Carrera)Enum.Parse(typeof(Carrera), carrera);
        }

        internal static List<RegistroDeInscripcion> CrearInstanciasDeInscripcionesAPartirDeBD()
        {
            string query = "SELECT * FROM RegistroInscripcion";

            Func<SqlDataReader, RegistroDeInscripcion> mapper = reader =>
            {
                string legajo = reader["legajo"].ToString();
                string codigoCurso = reader["codigoCurso"].ToString();
                DateTime fechaInscripcion = DateTime.Parse(reader["fechaInscripcion"].ToString());

                string nombreAlumno = ObtenerNombreAlumnoDesdeLegajo(legajo);
                string nombreCurso = ObtenerNombreCursoDesdeCodigo(codigoCurso);
                Carrera carrera = DevolverCarreraDedeCodigoCurso(codigoCurso);

                RegistroDeInscripcion registroInscripcionReconstruido = new RegistroDeInscripcion(legajo, nombreAlumno, nombreCurso, codigoCurso, carrera, fechaInscripcion);

                return registroInscripcionReconstruido;
            };

            // Llama al método 'ConsultasGenericas.CrearInstanciasDesdeBD' con la consulta y el 'mapper' adecuados.
            List<RegistroDeInscripcion> listaReconstruida = ConsultasGenericas.CrearInstanciasDesdeBD(query, mapper);

            return listaReconstruida;
        }

        /////////////////// RECONSTRUCCION DE LA LISTA DE PAGOS A PARTIR DE BD
        internal static List<RegistroDePago> CrearInstanciasDePagosAPartirDeBD()
        {
            string query = "SELECT * FROM RegistroDePago";

            Func<SqlDataReader, RegistroDePago> mapper = reader =>
            {
                string concepto = reader["conceptoNombre"].ToString();
                string legajo = reader["legajoEstudiante"].ToString();
                string nombreAlumno = ObtenerNombreAlumnoDesdeLegajo(legajo);
                double ingreso = Double.Parse(reader["ingreso"].ToString());
                DateTime fechaPago = DateTime.Parse(reader["fechaPago"].ToString());

                RegistroDePago registroPagoReconstruido = new RegistroDePago(legajo, nombreAlumno, concepto, ingreso, fechaPago);

                return registroPagoReconstruido;
            };

            // Llama al método 'ConsultasGenericas.CrearInstanciasDesdeBD' con la consulta y el 'mapper' adecuados.
            List<RegistroDePago> listaReconstruida = ConsultasGenericas.CrearInstanciasDesdeBD(query, mapper);

            return listaReconstruida;
        }

        /////////////////// RECONSTRUCCION DE LA LISTA DE PROFESORES A PARTIR DE BD

        private static List<string> DevolverCursosDeProfesor(string correo)
        {
            string query = "SELECT codigoCurso FROM ProfesoresEnCursos WHERE correoProfesor = @correo";
            return ConsultasGenericas.ObtenerListaMedianteQuery(query, "@correo", correo, readerAlternativo => readerAlternativo["codigoCurso"].ToString());
        }

        internal static List<Profesor> CrearInstanciasDeProfesoresAPartirDeBD()
        {
            string query = "SELECT * FROM Profesores";

            Func<SqlDataReader, Profesor> mapper = reader =>
            {
                string nombre = reader["nombre"].ToString();
                string direccion = reader["direccion"].ToString();
                string telefono = reader["telefono"].ToString();
                string correo = reader["correo"].ToString();
                string especializacion = reader["especializacion"].ToString();

                List<string> _codigosCursosDeProfesor = DevolverCursosDeProfesor(correo);

                Profesor profesorReconstruido = new Profesor(nombre, direccion, telefono, correo, especializacion, _codigosCursosDeProfesor);

                return profesorReconstruido;
            };

            // Llama al método 'ConsultasGenericas.CrearInstanciasDesdeBD' con la consulta y el 'mapper' adecuados.
            List<Profesor> listaReconstruida = ConsultasGenericas.CrearInstanciasDesdeBD(query, mapper);

            return listaReconstruida;
        }
    }
}
