using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public abstract class ConsultasPrincipalesGenericas<T>
    {
        protected SqlConnection _connection;
        protected SqlCommand _command;

        public ConsultasPrincipalesGenericas()
        {
            _connection = ConexionBD.connection;
            _command = ConexionBD.command;
        }

        protected T ExecuteReader(string query, Func<IDataRecord, T> mapeo)
        {
            T datoADevolver = default(T);

            try
            {
                _connection.Open();

                _command.CommandText = query;

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        datoADevolver = mapeo(reader);
                    }
                }

                return datoADevolver;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

        protected List<T> ExecuteReader(string query, Func<IDataRecord, T> mapeo)
        {
            var lista = new List<T>();

            try
            {
                _connection.Open();

                _command.CommandText = query;

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T objeto = mapeo(reader);

                        lista.Add(objeto);
                    }

                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

        protected int ExecuteNonQuery()
        {
            try
            {
                _connection.Open();

                var filasAfectadas = _command.ExecuteNonQuery();

                return filasAfectadas;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
