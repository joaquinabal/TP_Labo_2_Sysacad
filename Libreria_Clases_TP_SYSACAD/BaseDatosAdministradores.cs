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

        //Metodo que utiliza la clase Administrador al crearse una instancia de la misma
        public void IngresarUsuarioBD(Administrador nuevoAdministrador)
        {
            listaAdministradores.Add(nuevoAdministrador);
        }

        //Getters
        public List<Administrador> Administradores { get {  return listaAdministradores; } }
    }
}
