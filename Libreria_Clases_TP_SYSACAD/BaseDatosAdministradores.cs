using System;
using System.Collections.Generic;
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
            this.listaAdministradores = ArchivosJson.CargarAdminsDesdeArchivoJson();
        }

        //Metodo que utiliza la clase Administrador al crearse una instancia de la misma
        public void IngresarUsuarioBD(Administrador nuevoAdministrador)
        {
            listaAdministradores.Add(nuevoAdministrador);
            ArchivosJson.GuardarArchivoJSON(listaAdministradores);
        }

        //Busqueda de usuario existente en la base de datos
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

        //Busqueda de credenciales del usuario en la base de datos (SOBRECARGA)
        public bool BuscarUsuarioBD(string correo, string contrasenia)
        {
            bool resultadoBusqueda = false;

            foreach (Administrador administrador in listaAdministradores)
            {
                if (administrador.Correo == correo && administrador.Contrasenia == contrasenia)
                {
                    resultadoBusqueda = true;
                }
            }
            return resultadoBusqueda;
        }

        //Getters
        public List<Administrador> Administradores { get {  return listaAdministradores; } }
    }
}
