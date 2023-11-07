﻿using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
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
    public class ConsultasAdministradores : ConexionBD
    {
        internal static bool BuscarUsuarioBD(string correo, string contrasenia)
        {
            try
            {
                connection.Open();

                command.CommandText = "SELECT correo, contrasenia FROM Administrador WHERE correo = @correo";

                command.Parameters.AddWithValue("@correo", correo);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string contraseniaEnBD = reader["contrasenia"].ToString();
                        bool comparacionContrasenias = Hash.VerifyPassword(contrasenia, contraseniaEnBD);

                        if (comparacionContrasenias)
                        {
                            return true;
                        }
                    }
                }

                return false;
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
