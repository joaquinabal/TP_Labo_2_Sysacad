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
                command.CommandText = "SELECT * FROM Curso WHERE codigo = @codigo";

                // Borrar cualquier parámetro existente en el comando.
                command.Parameters.Clear();

                // Agregar el nuevo parámetro.
                command.Parameters.AddWithValue("@codigo", codigo);

                connection.Open();
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        ////////////////////////////////CRUD DEL CURSO/////////////////////////////////////////////////

        ///////////////////////CONSULTAS INTERNAS
        private int ObtenerTurnoIdSegunTexto(string nombreTurno)
        {
            try
            {
                command.CommandText = "SELECT * FROM Turno WHERE nombre = @nombre";

                // Borrar cualquier parámetro existente en el comando.
                command.Parameters.Clear();

                // Agregar el nuevo parámetro.
                command.Parameters.AddWithValue("@nombre", nombreTurno);

                connection.Open();
                reader = command.ExecuteReader();

                int idDelTurno = 0;

                while (reader.Read())
                {
                    idDelTurno = Convert.ToInt32(reader["id"]);
                }
                
                return idDelTurno;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private int ObtenerDiaIdSegunTexto(string nombreDia)
        {
            try
            {
                command.CommandText = "SELECT * FROM Dia WHERE nombre = @nombre";

                // Borrar cualquier parámetro existente en el comando.
                command.Parameters.Clear();

                // Agregar el nuevo parámetro.
                command.Parameters.AddWithValue("@nombre", nombreDia);

                connection.Open();
                reader = command.ExecuteReader();

                int idDelDia = 0;

                while (reader.Read())
                {
                    idDelDia = Convert.ToInt32(reader["id"]);
                }

                return idDelDia;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private int ObtenerCarreraSegunTexto(string nombreDia)
        {
            try
            {
                command.CommandText = "SELECT * FROM Dia WHERE nombre = @nombre";

                // Borrar cualquier parámetro existente en el comando.
                command.Parameters.Clear();

                // Agregar el nuevo parámetro.
                command.Parameters.AddWithValue("@nombre", nombreDia);

                connection.Open();
                reader = command.ExecuteReader();

                int idDelDia = 0;

                while (reader.Read())
                {
                    idDelDia = Convert.ToInt32(reader["id"]);
                }

                return idDelDia;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private int DevolverIdDeCodigoFamilia(string codigoFamilia)
        {
            try
            {
                command.CommandText = "SELECT id FROM CodigoFamilia WHERE codigo = @codigo";

                // Borrar cualquier parámetro existente en el comando.
                command.Parameters.Clear();

                // Agregar el nuevo parámetro.
                command.Parameters.AddWithValue("@codigo", codigoFamilia);

                connection.Open();
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private int AgregarNuevoCodigoDeFamiliaYDevolverSuId(string codigoFamilia)
        {
            try
            {
                command.CommandText = "INSERT INTO CodigoFamilia (codigo) VALUES (@codigo); SELECT SCOPE_IDENTITY();";

                // Borra los parámetros anteriores.
                command.Parameters.Clear();

                // Agrega el nuevo parámetro.
                command.Parameters.AddWithValue("@codigo", codigoFamilia);

                connection.Open();

                // Ejecuta la consulta y devuelve el ID del código de familia recién agregado.
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar un nuevo código de familia: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
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
                using (connection)
                {
                    // Secuencia INSERT
                    command.CommandText = "INSERT INTO Curso (codigo, nombre, descripcion, cupoMaximo, cupoDisponible, turnoId, aula, diaId, carreraCodigo, creditosRequeridos, promedioRequerido, codigoFamiliaId) " +
                                          "VALUES (@codigo, @nombre, @descripcion, @cupoMaximo, @cupoDisponible, @turnoId, @aula, @diaId, @carreraCodigo, @creditosRequeridos, @promedioRequerido, @codigoFamiliaId)";

                    // Borrar cualquier parámetro existente en el comando.
                    command.Parameters.Clear();

                    // Agrego los parametros
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

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
        }

        ///////////////////////READ

        public List<Curso> ObtenerUnCursoPorCadaCodigoDeFamilia()
        {
            
            
            // Almaceno un curso por cada código de familia dentro del diccionario
            Dictionary<string, Curso> cursosPorCodigoFamilia = new Dictionary<string, Curso>();

            // Recorro la lista de cursos
            foreach (Curso curso in _listaCursos)
            {
                // Si el diccionario no contiene el codigo de familia aun
                if (!cursosPorCodigoFamilia.ContainsKey(curso.CodigoFamilia))
                {
                    // Agrego el curso al diccionario junto a su codigo de familia
                    cursosPorCodigoFamilia[curso.CodigoFamilia] = curso;
                }
            }

            // Paso los valores del diccionario a una lista de cursos
            List<Curso> cursosUnicos = cursosPorCodigoFamilia.Values.ToList();

            // Devuelvo la lista de cursos únicos
            return cursosUnicos;
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
                    if (!nombresAgregados.Contains(curso.Nombre))
                    {
                        nombresAgregados.Add(curso.Nombre);
                    }
                }
            }

            return nombresAgregados;
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
