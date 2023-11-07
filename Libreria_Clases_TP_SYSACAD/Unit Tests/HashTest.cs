﻿using Libreria_Clases_TP_SYSACAD.Herramientas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Unit_Tests
{
    [TestClass]
    internal class HashTest
    {
        [TestMethod]
        public void HashPassword_DeberiaGenerarUnHashValido()
        {
            // Arrange
            string password = "MiContraseña123";

            // Act
            string hashedPassword = Hash.HashPassword(password);

            // Assert
            Assert.IsNotNull(hashedPassword);
            Assert.AreNotEqual(string.Empty, hashedPassword);
            Assert.AreEqual(64, hashedPassword.Length); // El hash SHA-256 debe tener 64 caracteres en hexadecimal
        }
    }
}
