﻿using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Unit_Tests
{
    [TestClass]
    internal class CalcularMontoIngresosTotalesTest
    {
        [TestMethod]
        public void CalcularMontoIngresosTotales_DeberiaCalcularSumaCorrecta()
        {
            // Arrange
            List<RegistroDePago> listaRegistros = new List<RegistroDePago>
            {
                new RegistroDePago("13232652", "Eduardo", "Matrícula", 10000.0, DateTime.Now),
                new RegistroDePago("15521254", "Pedro", "Gastos Administrativos", 500.0, DateTime.Now),
                new RegistroDePago("00315265", "Charly", "Bibliografia", 400.0, DateTime.Now)
            };

            double sumaEsperada = 1000.0 + 500.0 + 400.0;

            // Act
            double resultado = EstadisticasReportes.CalcularMontoIngresosTotales(listaRegistros);

            // Assert
            Assert.AreEqual(sumaEsperada, resultado);
        }

    }
}
