using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Unit_Tests
{
    [TestClass]
    internal class CredencialesTests
    {
        [TestMethod]
        public void ValidarCredenciales_DeberiaDevolverCamposVacios_CuandoCamposEstanVacios()
        {
            // Arrange
            ValidadorCredenciales validador = new ValidadorCredenciales();
            string correo = string.Empty;
            string contraseña = string.Empty;
            Log modo = Log.Admin;

            // Act
            MensajeRespuestaValidacionCredencialesContraseña resultado = validador.ValidarCredenciales(correo, contraseña, modo);

            // Assert
            Assert.AreEqual(MensajeRespuestaValidacionCredencialesContraseña.camposVacios, resultado);
        }

        [TestMethod]
        public void ValidarCredenciales_DeberiaDevolverOK_CuandoCredencialesSonValidas()
        {
            // Arrange
            ValidadorCredenciales validador = new ValidadorCredenciales();
            string correo = "johntravolta@hotmail.com";
            string contraseña = "666666";
            Log modo = Log.Admin;

            // Act
            MensajeRespuestaValidacionCredencialesContraseña resultado = validador.ValidarCredenciales(correo, contraseña, modo);

            // Assert
            Assert.AreEqual(MensajeRespuestaValidacionCredencialesContraseña.OK, resultado);
        }

        [TestMethod]
        public void ValidarCredenciales_DeberiaDevolverNoEncontrado_CuandoCredencialesNoSonValidas()
        {
            // Arrange
            ValidadorCredenciales validador = new ValidadorCredenciales();
            string correo = "rickyfort@gmail.com";
            string contraseña = "vamobooocaaaaaa";
            Log modo = Log.Admin;

            // Act
            MensajeRespuestaValidacionCredencialesContraseña resultado = validador.ValidarCredenciales(correo, contraseña, modo);

            // Assert
            Assert.AreEqual(MensajeRespuestaValidacionCredencialesContraseña.noEncontrado, resultado);
        }

    }
}
