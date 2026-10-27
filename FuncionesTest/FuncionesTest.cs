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

        [TestMethod]
        [DataRow(null, false, DisplayName = "Contraseña nula debe ser falsa")]
        [DataRow("", false, DisplayName = "Contraseña vacía debe ser falsa")]
        [DataRow("abc#123", false, DisplayName = "Contraseña menor a 8 caracteres debe ser falsa")]
        [DataRow("abcdefghi", false, DisplayName = "Contraseña sin '#' debe ser falsa")]
        [DataRow("abcdefg#", true, DisplayName = "Contraseña exacta de 8 caracteres con '#' debe ser verdadera")]
        [DataRow("MiPassword#Segura1", true, DisplayName = "Contraseña válida larga con '#' debe ser verdadera")]
        public void EsContrasenyaValida_DebeRetornarEsperado(string contrasenya, bool resultadoEsperado)
        {
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
