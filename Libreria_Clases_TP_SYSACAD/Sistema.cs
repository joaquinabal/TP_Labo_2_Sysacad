using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public static class Sistema
    {
        //Creo esta clase estatica que se inicia sin necesidad de instanciarla, para poder
        //crear las bases de datos.

        private static BaseDatosAdministradores _baseDatosAdministradores = new BaseDatosAdministradores();
        private static BaseDatosEstudiantes _baseDatosEstudiantes = new BaseDatosEstudiantes();
        private static BaseDatosCursos _baseDatosCursos = new BaseDatosCursos();

        public static BaseDatosAdministradores BaseDatosAdministradores 
        { 
            get 
            { 
                return _baseDatosAdministradores; 
            } 
        }

        public static BaseDatosEstudiantes BaseDatosEstudiantes
        {
            get
            {
                return _baseDatosEstudiantes;
            }
        }
        public static BaseDatosCursos BaseDatosCursos
        {
            get
            {
                return _baseDatosCursos;
            }
        }


    }
}
