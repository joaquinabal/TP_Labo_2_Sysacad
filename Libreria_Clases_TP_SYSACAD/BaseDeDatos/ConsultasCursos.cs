using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using System.Security.Cryptography;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasCursos : ConexionBD
    {
        private static List<Curso> _listaCursos = new List<Curso>();

        /////////////////// RECONSTRUCCION DE LA LISTA DE CURSOS A PARTIR DE BD

        internal static void CrearInstanciasDeCursoAPartirDeBD()
        {
            _listaCursos.Clear();
            _listaCursos = CargaDeInstanciasDesdeBD.CrearInstanciasDeCursoAPartirDeBD();
        }

        //////////////////////////////////CREATE

        private static int ObtenerIdDesdeTexto(string tabla, string campo, string valor)
        {
            string query = $"SELECT id FROM {tabla} WHERE {campo} = @valor";
            return ConsultasGenericas.EjecutarEscalar<int>(query, "@valor", valor);
        }

        private static int ObtenerTurnoIdSegunTexto(string nombreTurno)
        {
            return ObtenerIdDesdeTexto("Turno", "nombre", nombreTurno);
        }

        private static int ObtenerDiaIdSegunTexto(string nombreDia)
        {
            return ObtenerIdDesdeTexto("Dia", "nombre", nombreDia);
        }

        private static async Task<int> ObtenerIdDeCodigoFamilia(string codigoFamilia)
        {
            int? codigoFamiliaId = ObtenerIdDesdeTexto("CodigoFamilia", "codigo", codigoFamilia);

            if (codigoFamiliaId != 0)
            {
                return codigoFamiliaId.Value; // Devuelve el ID existente si se encontró.
            }
            else
            {
                // El código de familia no existe en la tabla, lo agrego y obtengo su ID.
                //return AgregarNuevoCodigoDeFamiliaYDevolverSuId(codigoFamilia);
                return await AgregarNuevoCodigoDeFamiliaYDevolverSuId(codigoFamilia);
            }
        }

        private static async Task<int> AgregarNuevoCodigoDeFamiliaYDevolverSuId(string codigoFamilia)
        {
            using (var connectionAlternativa2 = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo2 = new SqlCommand("INSERT INTO CodigoFamilia (codigo) VALUES (@codigo); SELECT SCOPE_IDENTITY();", connectionAlternativa2))
                {
                    commandAlternativo2.Parameters.AddWithValue("@codigo", codigoFamilia);
                    //connectionAlternativa2.Open();
                    await connectionAlternativa2.OpenAsync();

                    try
                    {
                        // Ejecuta la consulta y devuelve el ID del código de familia recién agregado.
                        var result = await commandAlternativo2.ExecuteScalarAsync();
                        return Convert.ToInt32(result);

                        //return Convert.ToInt32(commandAlternativo2.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                        RegistroExcepciones.RegistrarExcepcion(ex);
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }
        }

        internal static async Task IngresarCursoBD(Curso nuevoCurso)
        {
            string query = "INSERT INTO Curso (codigo, nombre, descripcion, cupoMaximo, cupoDisponible, turnoId, aula, diaId, carreraCodigo, creditosRequeridos, promedioRequerido, codigoFamiliaId) " +
                   "VALUES (@codigo, @nombre, @descripcion, @cupoMaximo, @cupoDisponible, @turnoId, @aula, @diaId, @carreraCodigo, @creditosRequeridos, @promedioRequerido, @codigoFamiliaId)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigo", nuevoCurso.Codigo },
                { "@nombre", nuevoCurso.Nombre },
                { "@descripcion", nuevoCurso.Descripcion },
                { "@cupoMaximo", nuevoCurso.CupoMaximo },
                { "@cupoDisponible", nuevoCurso.CupoDisponible },
                { "@turnoId", ObtenerTurnoIdSegunTexto(nuevoCurso.Turno) },
                { "@aula", nuevoCurso.Aula },
                { "@diaId", ObtenerDiaIdSegunTexto(nuevoCurso.Dia) },
                { "@carreraCodigo", nuevoCurso.Carrera.ToString() },
                { "@creditosRequeridos", nuevoCurso.CreditosRequeridos },
                { "@promedioRequerido", nuevoCurso.PromedioRequerido },
                { "@codigoFamiliaId", await ObtenerIdDeCodigoFamilia(nuevoCurso.CodigoFamilia) }
            };

            //ConsultasGenericas.EjecutarNonQuery(query, parametros);

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        /////////////////////////////////////READ

        public static bool BuscarCursoBD(string codigo)
        {
            Predicate<Curso> predicado = curso => curso.Codigo == codigo;

            //Uso .Any() para verificar si por lo menos existe un curso con ese codigo
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado).Any();
        }

        public List<Curso> ObtenerUnCursoPorCadaCodigoDeFamilia()
        {
            Predicate<Curso> predicado = curso => true; // No voy a filtrar ningun curso. Los agarro todos

            Dictionary<string, Curso> cursosUnicos = new Dictionary<string, Curso>();

            // Utiliza FiltrarElementos sin modificarlo
            foreach (var curso in ConsultasGenericas.FiltrarElementos(_listaCursos, predicado))
            {
                // Verifica si ya hay un curso con el mismo código de familia
                if (!cursosUnicos.ContainsKey(curso.CodigoFamilia))
                {
                    // Agrega el curso al diccionario si no existe
                    cursosUnicos.Add(curso.CodigoFamilia, curso);
                }
            }

            // Convierte los valores del diccionario de nuevo a una lista
            List<Curso> resultado = cursosUnicos.Values.ToList();

            return resultado;
        }


        public static Curso? ObtenerCursoDesdeCodigo(string codigo)
        {
            Predicate<Curso> predicado = curso => curso.Codigo == codigo;

            //Uso .FirstOrDefault() para agarrar al primer curso que encuentre que tenga el codigo.
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado).FirstOrDefault();
        }

        public string ObtenerCodigoDeFamiliaDesdeNombre(string nombre)
        {
            Predicate<Curso> predicado = curso => curso.Nombre == nombre;

            //Uso .FirstOrDefault() para agarrar al primer curso que encuentre que tenga el codigo pasado.
            //Uso .CodigoFamilia para acceder al codigo de familia del curso que encontre
            //Uso ?? "" para darle un valor predeterminado vacio si no lo encuentra
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado).FirstOrDefault()?.CodigoFamilia ?? "";
        }

        public static List<Curso> ObtenerCursosDesdeCodigoDeFamilia(string codigoDeFamilia)
        {
            Predicate<Curso> predicado = curso => curso.CodigoFamilia == codigoDeFamilia;
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado);
        }

        public Curso? ObtenerCursoDesdeCodigoDeFamilia(string codigoDeFamilia)
        {
            Predicate<Curso> predicado = curso => curso.CodigoFamilia == codigoDeFamilia;

            //Uso .FirstOrDefault() para agarrar al primer curso que encuentre que tenga el codigo de familia.
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado).FirstOrDefault();
        }

        public Curso? ObtenerCursoAPartirDeNombreYTurno(string nombre, string turno)
        {
            Predicate<Curso> predicado = curso => curso.Nombre == nombre && curso.Turno == turno;

            //Uso .FirstOrDefault() para agarrar al primer curso que encuentre que tenga el nombre y turno.
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado).FirstOrDefault();
        }

        public static List<Curso> ObtenerListaCursosDesdeListaCodigos(List<string> listaCodigos)
        {
            Predicate<Curso> predicado = curso => listaCodigos.Contains(curso.Codigo);
            return ConsultasGenericas.FiltrarElementos(_listaCursos, predicado);
        }

        public HashSet<string> ObtenerNombresDeCursosNoCorrelativos(Curso cursoSeleccionado)
        {
            HashSet<string> nombresAgregados = new HashSet<string>();

            foreach (Curso curso in _listaCursos)
            {
                // Si el curso iterado no se encuentra ya dentro de las correlatividades de la familia
                // del curso seleccionado y el curso iterado no se encuentra en la familia del
                // curso seleccionado.
                if (!cursoSeleccionado.Correlatividades.Contains(curso.CodigoFamilia) &&
                    curso.CodigoFamilia != cursoSeleccionado.CodigoFamilia)
                {
                    if (!nombresAgregados.Contains(curso.CodigoFamilia))
                    {
                        nombresAgregados.Add(curso.Nombre);
                    }
                }
            }

            return nombresAgregados;
        }

        public static bool HallarSiHayAlgunCursoConListaDeEspera()
        {
            bool hayCursoConListaDeEspera = false;

            foreach (Curso curso in _listaCursos)
            {
                if (curso.ListaDeEspera.Count > 0)
                {
                    hayCursoConListaDeEspera = true;
                    break;
                }
            }

            return hayCursoConListaDeEspera;
        }

        public Dictionary<Curso, Dictionary<string, DateTime>> DevolverDiccionarioConRegistrosListaDeEsperaSegunFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            Dictionary<Curso, Dictionary<string, DateTime>> cursosConListaDeEspera = new Dictionary<Curso, Dictionary<string, DateTime>>();

            foreach (Curso curso in _listaCursos)
            {
                if (curso.ListaDeEspera.Count > 0)
                {
                    Dictionary<string, DateTime> registrosFiltrados = new Dictionary<string, DateTime>();

                    foreach (var registro in curso.ListaDeEspera)
                    {
                        if (registro.Value >= fechaDesde && registro.Value <= fechaHasta)
                        {
                            registrosFiltrados.Add(registro.Key, registro.Value);
                        }
                    }

                    if (registrosFiltrados.Count > 0)
                    {
                        cursosConListaDeEspera[curso] = registrosFiltrados;
                    }
                }
            }

            return cursosConListaDeEspera;
        }

        public static string ObtenerCodigoDeFamilia(string nombre)
        {
            string codigoDeFamilia = nombre.Trim().ToUpper();
            codigoDeFamilia = codigoDeFamilia.Replace(" ", "");

            return codigoDeFamilia;
        }

        ///////////////////////////////////UPDATE

        ///////UPDATE REQUISITOS
        private static async Task EliminarCorrelatividadesDeCursoSeleccionado(int idCodigoFamilia)
        {
            string query = "DELETE FROM Correlatividades WHERE idFamiliaCursoBase = @CFId";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@CFId", idCodigoFamilia }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);
        }

        private static async Task AgregarNuevasCorrelatividadesACursoSeleccionado(string CFCursoAModificar, List<string> CFNuevasCorrelatividades)
        {
            int idCodigoFamilia = await ObtenerIdDeCodigoFamilia(CFCursoAModificar);

            foreach (string CF in CFNuevasCorrelatividades)
            {
                string query = "INSERT INTO Correlatividades (idFamiliaCursoBase, codigoFamiliaCorrelatividad) VALUES (@id, @CF)";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@id", idCodigoFamilia },
                    { "@CF", CF }
                };

                await ConsultasGenericas.EjecutarNonQuery(query, parametros);
            }
        }

        public async Task ActualizarRequisitosACursos(string CFCursoAModificar, List<string> CFcorrelatividades, int creditos, double promedio)
        {
            int idCodigoFamilia = await ObtenerIdDeCodigoFamilia(CFCursoAModificar);

            string updateQuery = "UPDATE Curso SET creditosRequeridos = @creditos, promedioRequerido = @promedio WHERE codigoFamiliaId = @valorABuscar";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@creditos", creditos },
                { "@promedio", promedio },
                { "@valorABuscar", idCodigoFamilia }
            };

            await ConsultasGenericas.EjecutarNonQuery(updateQuery, parametros);

            await EliminarCorrelatividadesDeCursoSeleccionado(idCodigoFamilia);
            await AgregarNuevasCorrelatividadesACursoSeleccionado(CFCursoAModificar, CFcorrelatividades);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        ///////UPDATE TABLA CURSOS

        public static async Task EditarCursoBD(string codigoABuscar, string nombre, string codigo, string descripcion, int cupoMaximo, string turno, string dia, string aula)
        {
            int idTurno = ObtenerTurnoIdSegunTexto(turno);
            int idDia = ObtenerDiaIdSegunTexto(dia);

            string updateQuery = "UPDATE Curso SET codigo = @codigo, nombre = @nombre, descripcion = @descripcion," +
                "cupoMaximo = @cupoMaximo, cupoDisponible = @cupoMaximo, turnoId = @turnoId, aula = @aula, " +
                "diaId = @diaId WHERE codigo = @valorABuscar";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigo", codigo },
                { "@nombre", nombre },
                { "@descripcion", descripcion },
                { "@cupoMaximo", cupoMaximo },
                { "@turnoId", idTurno },
                { "@aula", aula },
                { "@diaId", idDia },
                { "@valorABuscar", codigoABuscar }
            };

            await ConsultasGenericas.EjecutarNonQuery(updateQuery, parametros);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        public static async Task EditarCursoBD(string codigoABuscar, string nombre, string codigo, string descripcion, int cupoMaximo, string turno, string dia, string aula, string codigoFamilia)
        {
            int idTurno = ObtenerTurnoIdSegunTexto(turno);
            int idDia = ObtenerDiaIdSegunTexto(dia);
            int CFid = await ObtenerIdDeCodigoFamilia(codigoFamilia);

            string updateQuery = "UPDATE Curso SET codigo = @codigo, nombre = @nombre, descripcion = @descripcion," +
                "cupoMaximo = @cupoMaximo, cupoDisponible = @cupoMaximo, turnoId = @turnoId, aula = @aula, " +
                "diaId = @diaId, codigoFamiliaId = @codigoFamilia WHERE codigo = @valorABuscar";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigo", codigo },
                { "@nombre", nombre },
                { "@descripcion", descripcion },
                { "@cupoMaximo", cupoMaximo },
                { "@turnoId", idTurno },
                { "@aula", aula },
                { "@diaId", idDia },
                { "@codigoFamilia", CFid },
                { "@valorABuscar", codigoABuscar }
            };

            await ConsultasGenericas.EjecutarNonQuery(updateQuery, parametros);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        ///////UPDATE TABLA ALUMNOS EN LISTA DE ESPERA
        private static async Task EliminarListaEsperaDeCursoSeleccionado(string codigoCurso)
        {
            string query = "DELETE FROM AlumnosEnListaDeEspera WHERE codigoCurso = @codigoCurso";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigoCurso", codigoCurso }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);
        }

        private static async Task AgregarNuevaListaEsperaACursoSeleccionado(string codigoCurso, Dictionary<string, DateTime> listaEsperaRecibida)
        {
            foreach (var parKeyValue in listaEsperaRecibida)
            {
                string query = "INSERT INTO AlumnosEnListaDeEspera (legajoEstudiante, codigoCurso, fechaIngreso) VALUES (@legajo, @codigoCurso, @fechaIngreso)";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@legajo", parKeyValue.Key },
                    { "@codigoCurso", codigoCurso },
                    { "@fechaIngreso", parKeyValue.Value }
                };

                await ConsultasGenericas.EjecutarNonQuery(query, parametros);
            }
        }

        public static async Task ActualizarListaDeEsperaDeCurso(Curso cursoRecibido, Dictionary<string, DateTime> listaEsperaRecibida)
        {
            await EliminarListaEsperaDeCursoSeleccionado(cursoRecibido.Codigo);
            await AgregarNuevaListaEsperaACursoSeleccionado(cursoRecibido.Codigo, listaEsperaRecibida);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        ////// AGREGAR ESTUDIANTE A LISTA DE ESPERA
        internal static async Task AgregarEstudianteAListaDeEspera(string codigoCurso, string legajoEstudiante)
        {
            string query = "INSERT INTO AlumnosEnListaDeEspera (legajoEstudiante, codigoCurso, fechaIngreso) VALUES (@legajo, @codigoCurso, @fechaIngreso)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@legajo", legajoEstudiante },
                { "@codigoCurso", codigoCurso },
                { "@fechaIngreso", DateTime.Now }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            CrearInstanciasDeCursoAPartirDeBD();
        }


        ///////UPDATE UNICAMENTE CUPOS DISPONIBLES
        internal static async Task RestarCupoDisponible(Curso cursoARestarCupo)
        {
            string updateQuery = "UPDATE Curso SET cupoDisponible = cupoDisponible - 1 WHERE codigo = @valorABuscar";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@valorABuscar", cursoARestarCupo.Codigo }
            };

            await ConsultasGenericas.EjecutarNonQuery(updateQuery, parametros);

            CrearInstanciasDeCursoAPartirDeBD();
        }

        ///////////////////////DELETE
        
        private static async Task CorroborarSiHayCFSinCursosCorrespondientesYBorrarlos()
        {
            string query = "DELETE FROM CodigoFamilia WHERE id NOT IN (SELECT DISTINCT codigoFamiliaId FROM Curso)";

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);
        }

        public static async Task EliminarCursoBD(string codigoABuscar)
        {
            string query = "DELETE FROM Curso WHERE codigo = @codigoABuscar";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigoABuscar", codigoABuscar }
            };

            await ConsultasGenericas.EjecutarNonQuery(query, parametros);

            await CorroborarSiHayCFSinCursosCorrespondientesYBorrarlos();
            CrearInstanciasDeCursoAPartirDeBD();
            ConsultasInscripciones.RefrescarEstudianteLogueado();
        }

        //Getters y setters
        public static List<Curso> Cursos { get { return _listaCursos; } }
    }
}
