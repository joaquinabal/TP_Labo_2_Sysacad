using System.Net.Mail;
using System.Net;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;

namespace Libreria_Clases_TP_SYSACAD.Herramientas
{

    public class EmisorCorreoElectronico
    {
        //public event EventHandler EnviarCorreo;



        //Esta clase se encarga de enviar el email con las credenciales de inicio de sesion
        //al usuario que se registra. Si se realiza de manera exitosa devuelve true, sino false.
        //En base al booleano muestro un mensaje de error o de exito.

        //Este metodo lo llamo desde el Forms de registro de estudiante si todo sale ok y la validacion
        //es correcta.
        //public static bool EnviarCorreoElectronico(Estudiante estudianteReceptor, string contrasenia)
        //{
        //    try
        //    {
        //        // Configura las credenciales y detalles del servidor SMTP
        //        string servidorSmtp = "smtp-mail.outlook.com"; // Reemplaza con tu servidor SMTP
        //        int puertoSmtp = 587; // Reemplaza con el puerto correcto de tu servidor SMTP
        //        string usuarioSmtp = "tp_sysacad_661@outlook.com"; // Reemplaza con tu dirección de correo
        //        string contraseñaSmtp = "tpsysacad123"; // Reemplaza con tu contraseña de correo

        //        // Crea una instancia de la clase SmtpClient
        //        SmtpClient clienteSmtp = new SmtpClient(servidorSmtp, puertoSmtp);

        //        // Configura las credenciales
        //        clienteSmtp.Credentials = new NetworkCredential(usuarioSmtp, contraseñaSmtp);

        //        // Habilita SSL si es necesario (por ejemplo, para Gmail)
        //        clienteSmtp.EnableSsl = true;

        //        // Crea un objeto MailMessage
        //        MailMessage mensaje = new MailMessage(usuarioSmtp, estudianteReceptor.Correo);

        //        // Asigna el asunto y el cuerpo del correo
        //        mensaje.Subject = "SYSACAD - Credenciales de Inicio de Sesion";
        //        mensaje.Body = "Hola " + estudianteReceptor.Nombre + ", a continuacion sus credenciales de inicio: \n" +
        //            $"Correo: {estudianteReceptor.Correo} \n" +
        //            $"Contraseña: {contrasenia}";

        //        // Envía el correo
        //        clienteSmtp.Send(mensaje);

        //        // Limpia recursos
        //        mensaje.Dispose();

        //        return true;
        //    }
        //    catch (SmtpException smtpEx)
        //    {
        //        // El programa no se detiene, sino que devuelve false al form
        //        // para que mostrar el error mediante un messageBox. Se registra
        //        // la excepcion en el JSON
        //        RegistroExcepciones.RegistrarExcepcion(smtpEx);
        //        return false;
        //    }


        //}

        public delegate void DelegadoEnviarMail(object sender, EventArgs e);

        public event DelegadoEnviarMail? EnviarMail;

        public bool EnviarCorreoElectronico(string correo, string subject, string body)
        {

            try
            {
                // Configura las credenciales y detalles del servidor SMTP
                string servidorSmtp = "smtp-mail.outlook.com"; // Reemplaza con tu servidor SMTP
                int puertoSmtp = 587; // Reemplaza con el puerto correcto de tu servidor SMTP
                string usuarioSmtp = "me89xx@outlook.com"; // Reemplaza con tu dirección de correo
                string contraseñaSmtp = "Pata1871"; // Reemplaza con tu contraseña de correo

                // Crea una instancia de la clase SmtpClient
                SmtpClient clienteSmtp = new SmtpClient(servidorSmtp, puertoSmtp);

                // Configura las credenciales
                clienteSmtp.Credentials = new NetworkCredential(usuarioSmtp, contraseñaSmtp);

                // Habilita SSL si es necesario (por ejemplo, para Gmail)
                clienteSmtp.EnableSsl = true;

                // Crea un objeto MailMessage
                MailMessage mensaje = new MailMessage(usuarioSmtp, correo);

                // Asigna el asunto y el cuerpo del correo
                mensaje.Subject = subject;
                mensaje.Body = body;

                // Envía el correo
                clienteSmtp.Send(mensaje);

                // Limpia recursos
                mensaje.Dispose();

                return true;
            }
            catch (SmtpException smtpEx)
            {
                // El programa no se detiene, sino que devuelve false al form
                // para que mostrar el error mediante un messageBox. Se registra
                // la excepcion en el JSON
                RegistroExcepciones.RegistrarExcepcion(smtpEx);
                return false;
            }

        }


        public void EnlistarCorreosUsuarios(List<Estudiante> estudiantes, ElementosCorreoElectronico datosCorreo)
        {
            foreach (var item in estudiantes)
            {
                EnviarCorreoElectronico(item.Correo, datosCorreo.Subject, datosCorreo.Body);
            }
        }


        protected virtual void OnEnviarMail()
        {
            EnviarMail?.Invoke(this, EventArgs.Empty);
        }
    }
}
