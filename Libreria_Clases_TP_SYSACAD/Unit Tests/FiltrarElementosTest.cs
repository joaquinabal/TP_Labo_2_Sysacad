using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Unit_Tests
{
    [TestClass]
    internal class FiltrarElementosTest
    {
        [TestMethod]
        public void FiltrarElementos_DeberiaFiltrarDevolviendoUnaLista_SegunElPredicado()
        {
            // Arrange
            List<Curso> lista = new List<Curso>
            {
                new Curso("Matematica", "MateM", "asdasd", 120, "Mañana", "120", "Lunes", Carrera.TUP),
                new Curso("Ingenieria", "ASDada", "asdasd", 150, "Noche", "190", "Martes", Carrera.TUSI),
                new Curso("Estadistica", "EstaM", "asdasd", 130, "Mañana", "120", "Jueves", Carrera.TUP)
            };

            string codigo = "MateM";

            Predicate<Curso> predicado = curso => curso.Codigo == codigo;

            // Act
            List<Curso> elementosFiltrados = ConsultasGenericas.FiltrarElementos(lista, predicado);

            // Assert
            Assert.IsNotNull(elementosFiltrados);
            CollectionAssert.Contains(elementosFiltrados, lista[0]);
            CollectionAssert.DoesNotContain(elementosFiltrados, lista[1]);
            CollectionAssert.DoesNotContain(elementosFiltrados, lista[2]);
        }
    }
}
