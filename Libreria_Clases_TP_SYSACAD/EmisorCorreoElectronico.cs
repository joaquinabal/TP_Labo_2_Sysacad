using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public static class EmisorCorreoElectronico
    {
        //Esta clase se encarga de enviar el email con las credenciales de inicio de sesion
        //al usuario que se registra. Si se realiza de manera exitosa devuelve true, sino false.
        //En base al booleano muestro un mensaje de error o de exito.

        //Este metodo lo llamo desde el Forms de registro de estudiante si todo sale ok y la validacion
        //es correcta.
        public static bool EnviarCorreoElectronico(Estudiante estudianteReceptor)
        {
            try
            {
                // Configura las credenciales y detalles del servidor SMTP
                string servidorSmtp = "smtp-mail.outlook.com"; // Reemplaza con tu servidor SMTP
                int puertoSmtp = 587; // Reemplaza con el puerto correcto de tu servidor SMTP
                string usuarioSmtp = "tp_sysacad_661@outlook.com"; // Reemplaza con tu dirección de correo
                string contraseñaSmtp = "tpsysacad123"; // Reemplaza con tu contraseña de correo

                // Crea una instancia de la clase SmtpClient
                SmtpClient clienteSmtp = new SmtpClient(servidorSmtp, puertoSmtp);

                // Configura las credenciales
                clienteSmtp.Credentials = new NetworkCredential(usuarioSmtp, contraseñaSmtp);

                // Habilita SSL si es necesario (por ejemplo, para Gmail)
                clienteSmtp.EnableSsl = true;

                // Crea un objeto MailMessage
                MailMessage mensaje = new MailMessage(usuarioSmtp, estudianteReceptor.Correo);

                // Asigna el asunto y el cuerpo del correo
                mensaje.Subject = "SYSACAD - Credenciales de Inicio de Sesion";
                mensaje.Body = "Hola " + estudianteReceptor.Nombre + ", a continuacion sus credenciales de inicio: \n" +
                    $"Correo: {estudianteReceptor.Correo} \n" +
                    $"Contraseña: {estudianteReceptor.Contrasenia}";

                // Envía el correo
                clienteSmtp.Send(mensaje);

                // Limpia recursos
                mensaje.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
                return false;
            }
        }
    }
}
