using Libreria_Clases_TP_SYSACAD;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using System.Text;

namespace Forms_TP_SYSACAD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Sistema.InicializarSistema();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Application.Run(new Form_Inicio());
        }
    }
}