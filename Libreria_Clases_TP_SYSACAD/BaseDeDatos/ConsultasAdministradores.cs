using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    internal class ConsultasAdministradores : ConexionBD
    {

        internal static bool BuscarUsuarioBD(string correo, string contrasenia)
        {
            try
            {
                command.CommandText = "SELECT correo, contrasenia FROM Administrador WHERE correo = @correo";

                // Borrar cualquier parámetro existente en el comando.
                command.Parameters.Clear();

                // Agregar el nuevo parámetro.
                command.Parameters.AddWithValue("@correo", correo);

                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string contraseniaEnBD = reader["contrasenia"].ToString();
                    bool comparacionContrasenias = Hash.VerifyPassword(contrasenia, contraseniaEnBD);

                    if (comparacionContrasenias)
                    {
                        return true;
                    }
                }

                return false;
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
    }
}
