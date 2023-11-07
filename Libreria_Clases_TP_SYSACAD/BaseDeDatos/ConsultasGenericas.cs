using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    internal class ConsultasGenericas : ConexionBD
    {
        //////////////////////// CONSULTAS INTERNAS
        
        //////// SI SE DEVUELVE UNA LISTA
        internal static List<T> ObtenerListaMedianteQuery<T>(string query, string nombreParametro, object valorParametro, Func<SqlDataReader, T> mapFunc)
        {
            List<T> listaADevolver = new List<T>();

            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            using (var commandAlternativo = new SqlCommand(query, connectionAlternativa))
            {
                commandAlternativo.Parameters.AddWithValue(nombreParametro, valorParametro);

                try
                {
                    connectionAlternativa.Open();

                    using (var readerAlternativo = commandAlternativo.ExecuteReader())
                    {
                        while (readerAlternativo.Read())
                        {
                            listaADevolver.Add(mapFunc(readerAlternativo));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    RegistroExcepciones.RegistrarExcepcion(ex);
                    throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                }
            }

            return listaADevolver;
        }

        //////// SI SE DEVUELVE UN ESCALAR
        internal static T EjecutarEscalar<T>(string query, string nombreParametro, object valorParametro)
        {
            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            using (var commandAlternativo = new SqlCommand(query, connectionAlternativa))
            {
                commandAlternativo.Parameters.AddWithValue(nombreParametro, valorParametro);

                try
                {
                    connectionAlternativa.Open();

                    var result = commandAlternativo.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return (T)result;
                    }
                    else
                    {
                        return default(T);
                    }
                }
                catch (SqlException ex)
                {
                    RegistroExcepciones.RegistrarExcepcion(ex);
                    throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                }
            }
        }

        //////////////////////// CREACION DE INSTANCIAS

        public static List<T> CrearInstanciasDesdeBD<T>(string query, Func<SqlDataReader, T> mapper)
            where T : IEntidadReconstruida
        {
            List<T> listaReconstruida = new List<T>();

            try
            {
                connection.Open();

                command.CommandText = query;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T entidad = mapper(reader);
                        listaReconstruida.Add(entidad);
                    }
                }
            }
            catch (SqlException ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return listaReconstruida;
        }


        ////////// METODO GENERICO PARA LOS READ

        public static List<T> FiltrarElementos<T>(List<T> lista, Predicate<T> predicado)
            where T : IEntidadFiltrada
        {
            List<T> elementosFiltrados = new List<T>();

            foreach (T elemento in lista)
            {
                if (predicado(elemento))
                {
                    elementosFiltrados.Add(elemento);
                }
            }

            return elementosFiltrados;
        }

        ////////// METODOS NON-QUERY (INSERT, UPDATE, DELETE)

        internal static void EjecutarNonQuery(string query, Dictionary<string, object> parametros)
        {
            try
            {
                connection.Open();

                command.CommandText = query;

                foreach (var parametro in parametros)
                {
                    command.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
        }
    }
}
