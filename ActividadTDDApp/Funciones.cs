using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {
        public long CalcularFactorial(int n)
        {
            return n < 0 ? -1
            : n == 0 ? 1
            : Enumerable.Range(1, n).Aggregate(1L, (acc, x) => acc * x);
        }

        public bool EsContrasenyaValida(string contrasenya)
        {
            return !string.IsNullOrEmpty(contrasenya)
            && contrasenya.Length >= 8
            && contrasenya.Contains("#");
        }
    }
}
