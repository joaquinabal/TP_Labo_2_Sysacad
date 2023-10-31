using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConexionBD
    {
        protected static SqlConnection connection; // Puente.
        protected static SqlCommand command;      // Quien lleva la consulta.
        protected static SqlDataReader reader;   // Quien trae los datos.

        static ConexionBD()
        {
            connection = new SqlConnection(@"Data Source=(local); 
                Database=TestSYSACAD; 
                Trusted_Connection = True;");

            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
        }
    }
}
