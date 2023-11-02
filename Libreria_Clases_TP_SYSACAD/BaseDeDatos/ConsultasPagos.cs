using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasPagos : ConexionBD
    {
        private List<RegistroDePago> _listaRegistrosPagos = new List<RegistroDePago>();

        ///////////////////RECONSTRUCCION DE LA LISTA DE PAGOS A PARTIR DE BD

        internal void CrearInstanciasDeInscripcionesAPartirDeBD()
        {
            _listaRegistrosPagos.Clear();

            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM RegistroPago";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string concepto = reader["conceptoNombre"].ToString();
                        string legajo = reader["legajoEstudiante"].ToString();
                        string nombreAlumno = ConsultasInscripciones.ObtenerNombreAlumnoDesdeLegajo(legajo);
                        double ingreso = Double.Parse(reader["ingreso"].ToString());
                        DateTime fechaPago = DateTime.Parse(reader["fechaPago"].ToString());
                        
                        RegistroDePago registroPagoReconstruido = new RegistroDePago(legajo, nombreAlumno, concepto, ingreso, fechaPago);

                        _listaRegistrosPagos.Add(registroPagoReconstruido);
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

        //////////////////////CREATE
        public void IngresarNuevoPago(List<RegistroDePago> nuevosPagos)
        {
            foreach (RegistroDePago registro in nuevosPagos)
            {
                try
                {
                    command.CommandText = "INSERT INTO RegistroDePago (legajoEstudiante, conceptoNombre, ingreso, fechaPago)" +
                        " VALUES (@legajoEstudiante, @conceptoNombre, @ingreso, @fechaPago)";

                    command.Parameters.AddWithValue("@legajoEstudiante", registro.Legajo);
                    command.Parameters.AddWithValue("@conceptoNombre", registro.Concepto);
                    command.Parameters.AddWithValue("@ingreso", registro.Ingreso);
                    command.Parameters.AddWithValue("@fechaPago", registro.Fecha);

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

            CrearInstanciasDeInscripcionesAPartirDeBD();
        }

        //////////////////////READ
        public List<RegistroDePago> ObtenerIngresosSegunConceptoYFecha(DateTime fechaDesde, DateTime fechaHasta, string concepto)
        {
            List<RegistroDePago> listaIngresosSegunConceptoYFecha = new List<RegistroDePago>();

            foreach (RegistroDePago registro in _listaRegistrosPagos)
            {
                if (registro.Fecha >= fechaDesde && registro.Fecha <= fechaHasta && registro.Concepto == concepto)
                {
                    listaIngresosSegunConceptoYFecha.Add(registro);
                }
            }

            return listaIngresosSegunConceptoYFecha;
        }

        //Getters y Setters
        public List<RegistroDePago> Pagos { get { return _listaRegistrosPagos; } }
    }
}
