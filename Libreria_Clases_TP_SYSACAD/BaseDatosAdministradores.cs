using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class BaseDatosAdministradores
    {
        //Lista que contiene todos los administradores
        private List<Administrador> listaAdministradores = new List<Administrador>();

        public BaseDatosAdministradores()
        {
            listaAdministradores = ArchivosJsonAdmins.CargarAdminsDesdeArchivoJson();
        }

        //Busqueda de credenciales del usuario en la base de datos (SOBRECARGA)
        public bool BuscarUsuarioBD(string correo, string contrasenia)
        {
            Debug.WriteLine($"Contrasenia recibida: {contrasenia}");

            bool resultadoBusqueda = false;

            foreach (Administrador administrador in listaAdministradores)
            {
                bool comparacionContrasenias = Hash.VerifyPassword(contrasenia ,administrador.Contrasenia);

                if (administrador.Correo == correo && comparacionContrasenias)
                {
                    resultadoBusqueda = true;
                }

            }
            return resultadoBusqueda;
        }

        public bool BuscarUsuarioBD(string correo)
        {
            bool resultadoBusqueda = false;

            foreach (Administrador administrador in listaAdministradores)
            {
                if (administrador.Correo == correo)
                {
                    resultadoBusqueda = true;
                }
            }
            return resultadoBusqueda;
        }
    }
}
