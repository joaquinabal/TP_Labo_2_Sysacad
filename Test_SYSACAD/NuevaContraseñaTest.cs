using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SYSACAD
{
    [TestClass]
    public class NuevaContraseñaTest
    {
        [TestMethod]
        public void ValidarNuevaContrasenia_DeberiaDevolverCamposVacios_CuandoContraseniaEsVacia()
        {
            // Arrange
            ValidadorInputNuevaContrasenia validador = new ValidadorInputNuevaContrasenia();
            string contrasenia = string.Empty;

            // Act
            MensajeRespuestaValidacionCredencialesContraseña resultado = validador.ValidarNuevaContrasenia(contrasenia);

            // Assert
            Assert.AreEqual(MensajeRespuestaValidacionCredencialesContraseña.camposVacios, resultado);
        }

        [TestMethod]
        public void ValidarNuevaContrasenia_DeberiaDevolverOK_CuandoContraseniaEsValida()
        {
            // Arrange
            ValidadorInputNuevaContrasenia validador = new ValidadorInputNuevaContrasenia();
            string contrasenia = "Abc123";

            // Act
            MensajeRespuestaValidacionCredencialesContraseña resultado = validador.ValidarNuevaContrasenia(contrasenia);

            // Assert
            Assert.AreEqual(MensajeRespuestaValidacionCredencialesContraseña.OK, resultado);
        }

        [TestMethod]
        public void ValidarNuevaContrasenia_DeberiaDevolverError_CuandoContraseniaNoCumpleElPatron()
        {
            // Arrange
            ValidadorInputNuevaContrasenia validador = new ValidadorInputNuevaContrasenia();
            string contrasenia = "ab"; // Contraseña demasiado corta

            // Act
            MensajeRespuestaValidacionCredencialesContraseña resultado = validador.ValidarNuevaContrasenia(contrasenia);

            // Assert
            Assert.AreEqual(MensajeRespuestaValidacionCredencialesContraseña.ERROR, resultado);
        }
    }
}
