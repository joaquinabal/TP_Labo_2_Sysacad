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

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasCursos : ConexionBD
    {
        //private static void ActualizarListaDeCodigosFamiliaDeCursos()
        //{
        //    _codigosFamiliaDeCursos.Clear();
        //    HashSet<string> codigosAgregados = new HashSet<string>();

        //    foreach (Curso curso in _listaCursos)
        //    {
        //        string codigoFamilia = curso.CodigoFamilia;

        //        if (!codigosAgregados.Contains(codigoFamilia))
        //        {
        //            _codigosFamiliaDeCursos.Add(codigoFamilia);

        //            codigosAgregados.Add(codigoFamilia);
        //        }
        //    }
        //}

        /// <summary>
        /// Busca un curso en la base de datos por código.
        /// </summary>
        /// <param name="codigo">El código del curso.</param>
        /// <returns>True si se encuentra un curso con el código proporcionado, False si no.</returns>
        internal static bool BuscarCursoBD(string codigo)
        {
            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM Curso WHERE codigo = @codigo";

                command.Parameters.AddWithValue("@codigo", codigo);

                command.Parameters.Clear();

                reader = command.ExecuteReader();

                bool tieneFilas = reader.HasRows;

                return tieneFilas;  // Retorna true si se encontraron filas, de lo contrario, retorna false
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        ////////////////////////////////CRUD DEL CURSO/////////////////////////////////////////////////

        ///////////////////////CONSULTAS INTERNAS
        private int ObtenerTurnoIdSegunTexto(string nombreTurno)
        {
            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM Turno WHERE nombre = @nombre";

                command.Parameters.AddWithValue("@nombre", nombreTurno);

                command.Parameters.Clear();

                int idDelTurno = 0;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idDelTurno = Convert.ToInt32(reader["id"]);
                    }
                }
                
                return idDelTurno;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private int ObtenerDiaIdSegunTexto(string nombreDia)
        {
            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM Dia WHERE nombre = @nombre";

                command.Parameters.AddWithValue("@nombre", nombreDia);

                command.Parameters.Clear();

                int idDelDia = 0;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idDelDia = Convert.ToInt32(reader["id"]);
                    }
                }

                return idDelDia;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private static int DevolverIdDeCodigoFamilia(string codigoFamilia)
        {
            try
            {
                connection.Open();

                command.CommandText = "SELECT id FROM CodigoFamilia WHERE codigo = @codigo";

                command.Parameters.AddWithValue("@codigo", codigoFamilia);

                command.Parameters.Clear();

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return Convert.ToInt32(reader["id"]);
                }
                else
                {
                    // El código de familia no existe en la tabla, lo agrego y obtengo su ID.
                    return AgregarNuevoCodigoDeFamiliaYDevolverSuId(codigoFamilia);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private static int AgregarNuevoCodigoDeFamiliaYDevolverSuId(string codigoFamilia)
        {
            try
            {
                connection.Open();

                command.CommandText = "INSERT INTO CodigoFamilia (codigo) VALUES (@codigo); SELECT SCOPE_IDENTITY();";

                command.Parameters.AddWithValue("@codigo", codigoFamilia);

                command.Parameters.Clear();

                // Ejecuta la consulta y devuelve el ID del código de familia recién agregado.
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar un nuevo código de familia: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        ///////////////////////CREATE

        /// <summary>
        /// Agrega un nuevo curso a la base de datos.
        /// </summary>
        /// <param name="nuevoCurso">El curso a ser agregado.</param>
        internal void IngresarCursoBD(Curso nuevoCurso)
        {
            try
            {
                connection.Open();

                // Secuencia INSERT
                command.CommandText = "INSERT INTO Curso (codigo, nombre, descripcion, cupoMaximo, cupoDisponible, turnoId, aula, diaId, carreraCodigo, creditosRequeridos, promedioRequerido, codigoFamiliaId) " +
                                        "VALUES (@codigo, @nombre, @descripcion, @cupoMaximo, @cupoDisponible, @turnoId, @aula, @diaId, @carreraCodigo, @creditosRequeridos, @promedioRequerido, @codigoFamiliaId)";

                command.Parameters.AddWithValue("@codigo", nuevoCurso.Codigo);
                command.Parameters.AddWithValue("@nombre", nuevoCurso.Nombre);
                command.Parameters.AddWithValue("@descripcion", nuevoCurso.Descripcion);
                command.Parameters.AddWithValue("@cupoMaximo", nuevoCurso.CupoMaximo);
                command.Parameters.AddWithValue("@cupoDisponible", nuevoCurso.CupoDisponible);
                command.Parameters.AddWithValue("@turnoId", ObtenerTurnoIdSegunTexto(nuevoCurso.Turno));
                command.Parameters.AddWithValue("@aula", nuevoCurso.Aula);
                command.Parameters.AddWithValue("@diaId", ObtenerDiaIdSegunTexto(nuevoCurso.Dia)); 
                command.Parameters.AddWithValue("@carreraCodigo", nuevoCurso.Carrera.ToString());
                command.Parameters.AddWithValue("@creditosRequeridos", nuevoCurso.CreditosRequeridos);
                command.Parameters.AddWithValue("@promedioRequerido", nuevoCurso.PromedioRequerido);
                command.Parameters.AddWithValue("@codigoFamiliaId", DevolverIdDeCodigoFamilia(nuevoCurso.CodigoFamilia));

                command.Parameters.Clear();

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        ///////////////////////READ

        //LLAMAR DESDE FORM GESTION REQUISITOS
        public static List<string> ObtenerNombreMateriaPorCadaCodigoDeFamilia()
        {
            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM CodigoFamilia;";

                command.Parameters.Clear();

                List<string> nombresEncontrados = new List<string>();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreDeMateria = reader["codigo"].ToString();
                        nombresEncontrados.Add(nombreDeMateria);
                    }
                }

                return nombresEncontrados;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private static List<string> ObtenerCodigosFamiliaDeCorrelatividadesSegunIdCodigoFamiliaCursoBase(int id)
        {
            try
            {
                connection.Open();

                command.CommandText = @"SELECT *
                                        FROM Correlatividades 
                                        WHERE idFamiliaCursoBase = @id";

                command.Parameters.AddWithValue("@id", id);

                command.Parameters.Clear();

                List<string> codigosFamiliaEncontrados = new List<string>();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string codigoFamilia = reader["codigoFamiliaCorrelatividad"].ToString();
                        codigosFamiliaEncontrados.Add(codigoFamilia);
                    }
                }

                return codigosFamiliaEncontrados;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        //LLAMAR DESDE FORM GESTION REQUISITOS
        public static Dictionary<string, List<string>> ObtenerCorrelatividadesSegunCodigoFamilia(string codigoFamilia)
        {
            int idCodigo = DevolverIdDeCodigoFamilia(codigoFamilia);
            List<string> CodigoFamiliaCorrelatividades = ObtenerCodigosFamiliaDeCorrelatividadesSegunIdCodigoFamiliaCursoBase(idCodigo);

            Dictionary<string, List<string>> correlatividades = new Dictionary<string, List<string>>();

            foreach (string codigoFamiliaDeCorrelatividad in CodigoFamiliaCorrelatividades)
            {
                int idCodigoFamiliaDeCorrelatividad = DevolverIdDeCodigoFamilia(codigoFamiliaDeCorrelatividad);

                try
                {
                    connection.Open();

                    command.CommandText = @"SELECT DISTINCT *
                                            FROM Curso
                                            WHERE codigoFamiliaId = @id";

                    command.Parameters.AddWithValue("@id", idCodigoFamiliaDeCorrelatividad);

                    command.Parameters.Clear();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreDeMateria = reader["nombre"].ToString();
                            string descripcionMateria = reader["descripcion"].ToString();
                            string codigoFamiliaMateria = codigoFamiliaDeCorrelatividad;

                            List<string> valoresDelDiccionario = new List<string>();
                            valoresDelDiccionario.Add(nombreDeMateria);
                            valoresDelDiccionario.Add(descripcionMateria);
                            valoresDelDiccionario.Add(codigoFamiliaMateria);

                            correlatividades[codigoFamiliaMateria] = valoresDelDiccionario;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return correlatividades;
        }

        public static double ObtenerPromedioSegunCodigoFamilia(string codigoFamilia)
        {
            int idCodigoFamilia = DevolverIdDeCodigoFamilia(codigoFamilia);

            try
            {
                connection.Open();

                command.CommandText = @"SELECT DISTINCT codigo, nombre, descripcion, promedioRequerido
                                        FROM Curso
                                        WHERE codigoFamiliaId = @id";

                command.Parameters.AddWithValue("@id", idCodigoFamilia);

                command.Parameters.Clear();

                double promedioEncontrado = 0.0;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        promedioEncontrado = Convert.ToDouble(reader["promedioRequerido"]);
                    }
                }

                return promedioEncontrado;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static int ObtenerCreditosSegunCodigoFamilia(string codigoFamilia)
        {
            int idCodigoFamilia = DevolverIdDeCodigoFamilia(codigoFamilia);

            try
            {
                connection.Open();

                command.CommandText = @"SELECT DISTINCT codigo, nombre, descripcion, creditosRequeridos
                                        FROM Curso
                                        WHERE codigoFamiliaId = @id";

                command.Parameters.AddWithValue("@id", idCodigoFamilia);

                command.Parameters.Clear();

                int creditosEncontrados = 0;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        creditosEncontrados = Convert.ToInt32(reader["creditosRequeridos"]);
                    }
                }

                return creditosEncontrados;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<string> ObtenerCodigoFamiliaCursosNoCorrelativos(List<string> listaCodFamiliaCorrelatividades)
        {
            List<int> listaIdCodFamiliaCorrelatividades = new List<int>();

            foreach (string codigoFamiliaCorrelatividad in listaCodFamiliaCorrelatividades)
            {
                int idCodigoFamilia = DevolverIdDeCodigoFamilia(codigoFamiliaCorrelatividad);
                listaIdCodFamiliaCorrelatividades.Add(idCodigoFamilia);
            }

            List<string> listaCodigoFamiliaCursosNoCorrelativos = new List<string>();

            try
            {
                connection.Open();

                string query = "SELECT codigo FROM CodigoFamilia WHERE id NOT IN (" + string.Join(",", listaIdCodFamiliaCorrelatividades.Select((_, index) => $"@id{index}")) + ")";

                command.CommandText = query;

                for (int i = 0; i < listaIdCodFamiliaCorrelatividades.Count; i++)
                {
                    command.Parameters.AddWithValue("@id" + i, listaIdCodFamiliaCorrelatividades[i]);
                }

                command.Parameters.Clear();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string codigoFamiliaEncontrado = reader["codigo"].ToString();
                        listaCodigoFamiliaCursosNoCorrelativos.Add(codigoFamiliaEncontrado);
                    }
                }

                return listaCodigoFamiliaCursosNoCorrelativos;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Curso ObtenerCursoDesdeCodigo(string codigo)
        {
            foreach (Curso curso in _listaCursos)
            {
                if (curso.Codigo == codigo)
                {
                    return curso;
                }
            }

            return null;
        }

        public string ObtenerCodigoDeFamiliaDesdeNombre(string nombre)
        {
            string codigoDeFamilia = "";

            foreach (Curso curso in _listaCursos)
            {
                if (curso.Nombre == nombre)
                {
                    codigoDeFamilia = curso.CodigoFamilia;
                }
            }

            return codigoDeFamilia;
        }

        public List<Curso> ObtenerCursosDesdeCodigoDeFamilia(string codigoDeFamilia)
        {
            List<Curso> cursosEncontrados = new List<Curso>();

            foreach (Curso curso in _listaCursos)
            {
                if (curso.CodigoFamilia == codigoDeFamilia)
                {
                    cursosEncontrados.Add(curso);
                }
            }

            return cursosEncontrados;
        }

        public Curso ObtenerCursoDesdeCodigoDeFamilia(string codigoDeFamilia)
        {
            foreach (Curso curso in _listaCursos)
            {
                if (curso.CodigoFamilia == codigoDeFamilia)
                {
                    return curso;
                }
            }

            return null;
        }

        public Curso ObtenerCursoAPartirDeNombreYTurno(string nombre, string turno)
        {
            Curso cursoADevolver = null;

            foreach (Curso curso in _listaCursos)
            {
                if (curso.Nombre == nombre && curso.Turno == turno)
                {
                    cursoADevolver = curso;
                }
            }

            return cursoADevolver;
        }

        ///////////////////////UPDATE

        /// <summary>
        /// Edita un curso en la base de datos por su código.
        /// </summary>
        /// <param name="codigoABuscar">El código del curso a ser editado.</param>
        /// <param name="nombre">El nuevo nombre del curso.</param>
        /// <param name="codigo">El nuevo código del curso.</param>
        /// <param name="descripcion">La nueva descripción del curso.</param>
        /// <param name="cupo">El nuevo cupo máximo del curso.</param>
        /// <param name="turno">El nuevo turno del curso.</param>
        /// <param name="dia">El nuevo día del curso.</param>
        /// <param name="aula">La nueva aula del curso.</param>
        public void EditarCursoBD(string codigoABuscar, string nombre, string codigo, string descripcion, int cupo, string turno, string dia, string aula)
        {
            foreach (Curso curso in _listaCursos)
            {
                int cuposOcupados = curso.CupoMaximo - curso.CupoDisponible;

                if (curso.Codigo == codigoABuscar)
                {
                    curso.Nombre = nombre;
                    curso.Codigo = codigo;
                    curso.Descripcion = descripcion;
                    curso.CupoMaximo = cupo;
                    curso.CupoDisponible = cupo - cuposOcupados;
                    curso.Turno = turno;
                    curso.Dia = dia;
                    curso.Aula = aula;
                }
            }

            ActualizarListaDeCodigosFamiliaDeCursos();

            ArchivosJsonCursos.GuardarArchivoJSON(_listaCursos);
        }

        public void ActualizarListaDeEsperaDeCurso(Curso cursoRecibido, Dictionary<string, DateTime> listaEsperaRecibida)
        {
            foreach (Curso curso in _listaCursos)
            {
                if (curso.Codigo == cursoRecibido.Codigo)
                {
                    curso.ListaDeEspera = listaEsperaRecibida;
                }
            }

            ArchivosJsonCursos.GuardarArchivoJSON(_listaCursos);
        }

        public void ActualizarRequisitosACursos(List<Curso> cursosAModificar, List<string> correlatividades, int creditos, double promedio)
        {
            foreach (Curso curso in _listaCursos)
            {
                foreach (Curso cursoAModificar in cursosAModificar)
                {
                    if (curso.CodigoFamilia == cursoAModificar.CodigoFamilia)
                    {
                        curso.Correlatividades = correlatividades;
                        curso.CreditosRequeridos = creditos;
                        curso.PromedioRequerido = promedio;
                    }
                }
            }

            ArchivosJsonCursos.GuardarArchivoJSON(_listaCursos);
        }

        internal void AgregarEstudianteAListaDeEspera(Estudiante estudianteAAgregar, Curso cursoAModificar)
        {
            foreach (Curso curso in _listaCursos)
            {
                if (curso.Codigo == cursoAModificar.Codigo)
                {
                    curso.ListaDeEspera.Add(estudianteAAgregar.Legajo, DateTime.Now);
                }
            }

            ArchivosJsonCursos.GuardarArchivoJSON(_listaCursos);
        }

        /// <summary>
        /// Resta 1 al cupo disponible de un determinado curso.
        /// </summary>
        /// <param name="cursoARestarCupo">El curso al que se le restará un cupo.</param>
        internal void RestarCupoDisponible(Curso cursoARestarCupo)
        {
            for (int i = 0; i < _listaCursos.Count; i++)
            {
                if (_listaCursos[i].Codigo == cursoARestarCupo.Codigo)
                {
                    // Restar 1 al CupoDisponible del objeto Curso
                    _listaCursos[i] -= 1;
                }
            }

            ArchivosJsonCursos.GuardarArchivoJSON(_listaCursos);
        }

        ///////////////////////DELETE

        /// <summary>
        /// Elimina un curso de la base de datos por su código.
        /// </summary>
        /// <param name="codigoABuscar">El código del curso a ser eliminado.</param>
        public void EliminarCursoBD(string codigoABuscar)
        {
            List<Curso> cursosAEliminar = new List<Curso>();

            foreach (Curso curso in _listaCursos)
            {
                if (curso.Codigo == codigoABuscar)
                {
                    cursosAEliminar.Add(curso);
                }
            }

            foreach (Curso curso in cursosAEliminar)
            {
                _listaCursos.Remove(curso);
            }

            Sistema.BaseDatosEstudiantes.EliminarCursoAEstudiante(codigoABuscar);

            ActualizarListaDeCodigosFamiliaDeCursos();

            ArchivosJsonCursos.GuardarArchivoJSON(_listaCursos);
        }

        //Getters y setters
        public List<Curso> Cursos { get { return _listaCursos; } }

        public List<string> CodigosFamiliaDeCursos { get { return _codigosFamiliaDeCursos; } }
    }
}
