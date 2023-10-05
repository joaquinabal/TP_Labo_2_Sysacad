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
            listaAdministradores = ArchivosJson.CargarAdminsDesdeArchivoJson();
        }

        //Busqueda de credenciales del usuario en la base de datos (SOBRECARGA)
        public bool BuscarUsuarioBD(string correo, string contrasenia)
        {
            bool resultadoBusqueda = false;

            //Hasheo la contrasenia que ingresa en el LogIn
            //string contraseniaHasheada = Hash.GetHash(contrasenia);
            //string contraseniaHasheada = Hash.HashearPassword(correo);

            foreach (Administrador administrador in listaAdministradores)
            {
                //Comparo la contrasenia ingresada en el LogIn con la existente en la BD
                //bool comparacionContrasenias = Hash.CompararHash(contraseniaHasheada, administrador.Contrasenia);

                //bool comparacionContrasenias = Hash.VerificarHasheo(contraseniaHasheada, administrador.Contrasenia);

                if (administrador.Correo == correo && administrador.Contrasenia == contrasenia /*comparacionContrasenias*/)
                {
                    resultadoBusqueda = true;
                }

                //if (administrador.Correo == correo && comparacionContrasenias)
                //{
                //    resultadoBusqueda = true;
                //}

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
