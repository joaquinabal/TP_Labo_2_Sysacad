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

        /////////////////// RECONSTRUCCION DE LA LISTA DE CURSOS A PARTIR DE BD

        private static List<string> DevolverListaConCodigosCursosInscriptos(string legajo)
        {
            List<string> listaCodigoCursosInscriptos = new List<string>();

            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo = new SqlCommand("SELECT codigoCurso FROM RegistroInscripcion WHERE legajo = @legajo", connectionAlternativa))
                {
                    commandAlternativo.Parameters.AddWithValue("@legajo", legajo);

                    try
                    {
                        connectionAlternativa.Open();

                        using (var readerAlternativo = commandAlternativo.ExecuteReader())
                        {
                            while (readerAlternativo.Read())
                            {
                                string codigoCurso = readerAlternativo["codigoCurso"].ToString();
                                listaCodigoCursosInscriptos.Add(codigoCurso);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }

            return listaCodigoCursosInscriptos;
        }

        private static List<ConceptoDePago> DevolverListaConConceptosDePagoDeEstudiante(string legajo)
        {
            List<ConceptoDePago> listaConceptosDePagoDeEstudiante = new List<ConceptoDePago>();

            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo = new SqlCommand("SELECT CP.nombre AS nombreConceptoPago, CP.montoInicial, CPE.montoPendiente FROM ConceptosDePagoDeEstudiante CPE " +
                                    "INNER JOIN ConceptoDePago CP ON CPE.conceptoNombre = CP.nombre " +
                                    "WHERE CPE.legajoEstudiante = @legajo", connectionAlternativa))
                {
                    commandAlternativo.Parameters.AddWithValue("@legajo", legajo);

                    try
                    {
                        connectionAlternativa.Open();

                        using (var readerAlternativo = commandAlternativo.ExecuteReader())
                        {
                            while (readerAlternativo.Read())
                            {
                                string nombre = readerAlternativo["nombreConceptoPago"].ToString();
                                double montoInicial = Double.Parse(readerAlternativo["montoInicial"].ToString());
                                double montoPendiente = Double.Parse(readerAlternativo["montoPendiente"].ToString());

                                ConceptoDePago nuevoConceptoPagoRecreado = new ConceptoDePago(nombre, montoInicial, montoPendiente);
                                listaConceptosDePagoDeEstudiante.Add(nuevoConceptoPagoRecreado);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }

            return listaConceptosDePagoDeEstudiante;
        }

        private static List<string> DevolverCFCursosCompletados(string legajo)
        {
            List<string> listaCFCursosCompletados = new List<string>();

            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo = new SqlCommand("SELECT codigoFamiliaCurso FROM RegistroCursosCompletados WHERE legajo = @legajo", connectionAlternativa))
                {
                    commandAlternativo.Parameters.AddWithValue("@legajo", legajo);

                    try
                    {
                        connectionAlternativa.Open();

                        using (var readerAlternativo = commandAlternativo.ExecuteReader())
                        {
                            while (readerAlternativo.Read())
                            {
                                string CFCursoCompletado = readerAlternativo["codigoFamiliaCurso"].ToString();
                                listaCFCursosCompletados.Add(CFCursoCompletado);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }

            return listaCFCursosCompletados;
        }

        internal static void CrearInstanciasDeEstudiantesAPartirDeBD()
        {
            _listaEstudiantes.Clear();

            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM Estudiante";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
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
                        double promedio= Double.Parse(reader["promedio"].ToString());

                        List<string> _codigoCursosInscriptos = DevolverListaConCodigosCursosInscriptos(legajo);
                        List<ConceptoDePago> _conceptosAPagar = DevolverListaConConceptosDePagoDeEstudiante(legajo);
                        List<string> _codigosDeFamiliaDeCursosCompletados = DevolverCFCursosCompletados(legajo);


                        Estudiante estudianteReconstruido = new Estudiante(nombre, legajo, direccion, numeroTelefono,
                            correo, contrasenia, debeCambiarContrasenia, creditos, promedio, 
                            _codigoCursosInscriptos, _conceptosAPagar, _codigosDeFamiliaDeCursosCompletados);

                        _listaEstudiantes.Add(estudianteReconstruido);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
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
                try
                {
                    connection.Open();

                    command.CommandText = "INSERT INTO ConceptosDePagoDeEstudiante (legajoEstudiante, conceptoNombre, montoPendiente)" +
                                          "VALUES (@legajoEstudiante, @conceptoNombre, @montoPendiente)";

                    command.Parameters.AddWithValue("@legajoEstudiante", legajo);
                    command.Parameters.AddWithValue("@conceptoNombre", parKeyValue.Key);
                    command.Parameters.AddWithValue("@montoPendiente", parKeyValue.Value);

                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                }
                finally
                {
                    command.Parameters.Clear();
                    connection.Close();
                }
            }
        }

        internal static void IngresarUsuarioBD(Estudiante nuevoEstudiante)
        {
            try
            {
                connection.Open();

                Guid nuevoGuid = Guid.NewGuid();
                nuevoEstudiante.IdentificadorUnico = nuevoGuid;
                nuevoEstudiante.Contrasenia = Hash.HashPassword(nuevoEstudiante.Contrasenia);

                command.CommandText = "INSERT INTO Estudiante (legajo, nombre, direccion, numeroTelefono, correo, " +
                                      "contrasenia, identificadorUnico, debeCambiarContrasenia, creditos, promedio) " +
                                      "VALUES (@legajoEstudiante, @nombreEstudiante, @direccionEstudiante, " +
                                      "@telefonoEstudiante, @correoEstudiante, @contraseniaEstudiante, " +
                                      "@identifiadorUnicoEstudiante, @debeCambiarContraseniaEstudiante, " +
                                      "@creditosEstudiante, @promedioEstudiante)";

                command.Parameters.AddWithValue("@legajoEstudiante", nuevoEstudiante.Legajo);
                command.Parameters.AddWithValue("@nombreEstudiante", nuevoEstudiante.Nombre);
                command.Parameters.AddWithValue("@direccionEstudiante", nuevoEstudiante.Direccion);
                command.Parameters.AddWithValue("@telefonoEstudiante", nuevoEstudiante.NumeroTelefono);
                command.Parameters.AddWithValue("@correoEstudiante", nuevoEstudiante.Correo);
                command.Parameters.AddWithValue("@contraseniaEstudiante", nuevoEstudiante.Contrasenia);
                command.Parameters.AddWithValue("@identifiadorUnicoEstudiante", nuevoEstudiante.IdentificadorUnico);
                command.Parameters.AddWithValue("@debeCambiarContraseniaEstudiante", nuevoEstudiante.DebeCambiarContrasenia);
                command.Parameters.AddWithValue("@creditosEstudiante", nuevoEstudiante.Creditos);
                command.Parameters.AddWithValue("@promedioEstudiante", nuevoEstudiante.Promedio);

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            AñadirConceptosDePagoIniciales(nuevoEstudiante.Legajo);
            CrearInstanciasDeEstudiantesAPartirDeBD();
        }

        ///////////////////////READ
        internal static bool BuscarUsuarioCredencialesBD(string correo, string contrasenia)
        {
            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in _listaEstudiantes)
            {
                bool comparacionContrasenias = Hash.VerifyPassword(contrasenia, estudiante.Contrasenia);

                if (estudiante.Correo == correo && comparacionContrasenias)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        internal static bool BuscarUsuarioExistenteBD(string correo, string legajo)
        {
            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in _listaEstudiantes)
            {
                if (estudiante.Correo == correo || estudiante.Legajo == legajo)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        public static bool BuscarSiUsuarioDebeCambiarContrasenia(string correo)
        {
            bool resultadoBusqueda = false;

            foreach (Estudiante estudiante in _listaEstudiantes)
            {
                if (estudiante.Correo == correo && estudiante.DebeCambiarContrasenia == true)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        public static Estudiante ObtenerEstudianteSegunLegajo(string legajo)
        {
            Estudiante estudianteADevolver = null;

            foreach (Estudiante estudiante in _listaEstudiantes)
            {
                if (estudiante.Legajo == legajo)
                {
                    estudianteADevolver = estudiante;
                }
            }

            return estudianteADevolver;
        }

        ///////////////////////UPDATE

        // QUEDA REEMPLAZADO POR EL NUEVO REGISTRO EN CONSULTAS REGISTROS
        //internal void AgregarCursoAEstudiante(Estudiante estudianteQueSeInscribe, Curso curso)
        //{
        //    foreach (Estudiante estudiante in listaEstudiante)
        //    {
        //        if (estudiante.IdentificadorUnico == estudianteQueSeInscribe.IdentificadorUnico)
        //        {
        //            estudiante.CursosInscriptos.Add(curso);
        //        }
        //    }
        //    ArchivosJsonEstudiantes.GuardarArchivoJSON(listaEstudiante);
        //}

        public static void CambiarContraseñaAEstudiante(string correo, string nuevaContrasenia)
        {
            string nuevaContraseniaHasheada = Hash.HashPassword(nuevaContrasenia);

            try
            {
                connection.Open();

                command.CommandText = "UPDATE Estudiante SET contrasenia = @nuevaContraseniaHasheada, debeCambiarContrasenia = 'False' WHERE correo = @correo";

                command.Parameters.AddWithValue("@nuevaContraseniaHasheada", nuevaContraseniaHasheada);
                command.Parameters.AddWithValue("@correo", correo);

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            CrearInstanciasDeEstudiantesAPartirDeBD();
        }

        //Getters y setters
        public static List<Estudiante> Estudiantes { get { return _listaEstudiantes; } }
    }
}
