namespace Libreria_Clases_TP_SYSACAD
{
    public class Administrador
    {
        private string _correo;
        private string _contraseña;

        public Administrador(string correo, string contraseña)
        {
            _correo = correo;
            _contraseña = contraseña;
            RegistrarAdministrador(this);
        }

        public static void RegistrarAdministrador(Administrador nuevoAdministrador)
        {
            Sistema.baseDatosAdministradores.IngresarUsuarioBD(nuevoAdministrador);
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