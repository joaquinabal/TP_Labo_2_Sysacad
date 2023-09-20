namespace Libreria_Clases_TP_SYSACAD
{
    public class Administrador
    {
        private string _correo;
        private string _contraseña;

        //El administrador cuenta con correo y contraseña para Registrarse/Logearse
        public Administrador(string correo, string contraseña)
        {
            _correo = correo;
            _contraseña = contraseña;
            RegistrarAdministrador(this);
        }

        //Al crear el administrador, se registra automaticamente en la base de datos
        public static void RegistrarAdministrador(Administrador nuevoAdministrador)
        {
            Sistema.BaseDatosAdministradores.IngresarUsuarioBD(nuevoAdministrador);
        }

        public string Correo 
        {
            get
            {
                return _correo;
            }
        }
    }
}