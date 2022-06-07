using System.Collections.Generic;

namespace ChequePorExtenso.Dominio
{
    public static class Extensions
    {
        public static int GetEquivalentKey(this Dictionary<decimal, string> dicionario, int valor, int divisor) {

            while (valor % divisor != 0)
            {
                if(dicionario.ContainsKey(valor) == false)
                    valor--;

            }
            return valor;

        }
    }
}
