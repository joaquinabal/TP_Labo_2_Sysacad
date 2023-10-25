using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;

namespace Libreria_Clases_TP_SYSACAD.Tablas
{
    internal class BaseDatosAdministradores
    {
        //Lista que contiene todos los administradores
        private List<Administrador> listaAdministradores = new List<Administrador>();

        /// <summary>
        /// Constructor de la clase BaseDatosAdministradores.
        /// Inicializa la lista de administradores cargándola desde un archivo JSON.
        /// </summary>
        internal BaseDatosAdministradores()
        {
            listaAdministradores = ArchivosJsonAdmins.CargarAdminsDesdeArchivoJson();
        }

        /// <summary>
        /// Busca un usuario en la base de datos por correo y contraseña.
        /// </summary>
        /// <param name="correo">El correo del usuario.</param>
        /// <param name="contrasenia">La contraseña del usuario.</param>
        /// <returns>True si se encuentra un usuario con las credenciales proporcionadas, False si no.</returns>
        internal bool BuscarUsuarioBD(string correo, string contrasenia)
        {
            bool resultadoBusqueda = false;

            foreach (Administrador administrador in listaAdministradores)
            {
                bool comparacionContrasenias = Hash.VerifyPassword(contrasenia, administrador.Contrasenia);

                if (administrador.Correo == correo && comparacionContrasenias)
                {
                    resultadoBusqueda = true;
                }

            }
            return resultadoBusqueda;
        }
    }
}
