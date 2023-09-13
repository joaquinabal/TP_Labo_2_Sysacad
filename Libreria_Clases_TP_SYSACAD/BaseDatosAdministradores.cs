using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class BaseDatosAdministradores
    {
        private List<Administrador> listaAdministradores = new List<Administrador>();

        public void IngresarUsuarioBD(Administrador nuevoAdministrador)
        {
            listaAdministradores.Add(nuevoAdministrador);
        }

        public List<Administrador> Administradores 
        {
            get
            {
                return listaAdministradores;
            }
        }
    }
}
