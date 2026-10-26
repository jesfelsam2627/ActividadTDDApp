using ActividadTDDApp;

namespace FuncionesTest
{
    [TestClass]
    public sealed class FuncionesTest
    {
        Funciones Funciones = new Funciones();

        [TestMethod]
        [DataRow(-1, -1)]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        [DataRow(6, 720)]
        public void CalcularFactorial_DebeRetornarResultadoEsperado(int n, long resultadoEsperado)
        {
            long resultado = Funciones.CalcularFactorial(n);
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
