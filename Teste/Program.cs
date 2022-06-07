using ChequePorExtenso.Dominio;
using System;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HumanizadorValores hv = new HumanizadorValores();
            string result = hv.HumanizarNumero(21);
            string result1 = hv.HumanizarNumero(2);
            string result2 = hv.HumanizarNumero(461);
            string result3 = hv.HumanizarNumero(999);

            Console.ReadLine();

        }
    }
}
