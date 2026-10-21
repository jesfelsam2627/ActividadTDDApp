using ActividadTDDApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        private readonly Funciones _funciones = new Funciones();

        
            [TestMethod]
            public void CalcularFactorial_NumeroNegativo_RetornaMenosUno()
            {
                // Arrange
                int n = -5;
                long esperado = -1;

                // Act
                long resultado = _funciones.CalcularFactorial(n);

                // Assert
                Assert.AreEqual(esperado, resultado);
            }

            [TestMethod]
            public void CalcularFactorial_Cero_RetornaUno()
            {
                // Arrange
                int n = 0;
                long esperado = 1;

                // Act
                long resultado = _funciones.CalcularFactorial(n);

                // Assert
                Assert.AreEqual(esperado, resultado);
            }

            [TestMethod]
            public void CalcularFactorial_NumeroPositivoCinco_RetornaCientoVeinte()
            {
                // Arrange
                int n = 5; // 5! = 5 * 4 * 3 * 2 * 1 = 120
                long esperado = 120;

                // Act
                long resultado = _funciones.CalcularFactorial(n);

                // Assert
                Assert.AreEqual(esperado, resultado);
            }
    }
}
