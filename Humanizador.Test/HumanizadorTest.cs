using ChequePorExtenso.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Humanizador.Test
{
    [TestClass]
    public class HumanizadorTest
    {
        [TestMethod]
        [DataRow(1, "um reais")]
        [DataRow(3, "três reais")]
        [DataRow(7, "sete reais")]
        [DataRow(8, "oito reais")]
        [DataRow(9, "nove reais")]
        [DataRow(11, "onze reais")]
        [DataRow(12, "doze reais")]
        [DataRow(15, "quinze reais")]
        [DataRow(17, "dezessete reais")]
        [DataRow(18, "dezoito reais")]
        [DataRow(19, "dezenove reais")]
        [DataRow(99, "noventa e nove reais")]
        [DataRow(20, "vinte reais")]
        [DataRow(30, "trinta reais")]
        [DataRow(60, "sessenta reais")]
        [DataRow(70, "setenta reais")]
        [DataRow(90, "noventa reais")]
        [DataRow(21, "vinte e um reais")]
        [DataRow(22, "vinte e dois reais")]
        [DataRow(35, "trinta e cinco reais")]
        [DataRow(57, "cinquenta e sete reais")]
        [DataRow(68, "sessenta e oito reais")]
        [DataRow(79, "setenta e nove reais")]
        [DataRow(83, "oitenta e três reais")]
        [DataRow(200, "duzentos reais")]
        [DataRow(300, "trezentos reais")]
        [DataRow(600, "seiscentos reais")]
        [DataRow(700, "setecentos reais")]
        [DataRow(900, "novecentos reais")]
        [DataRow(210, "duzentos e dez reais")]
        [DataRow(350, "trezentos e cinquenta reais")]
        [DataRow(570, "quinhentos e setenta reais")]
        [DataRow(680, "seiscentos e oitenta reais")]
        [DataRow(790, "setecentos e noventa reais")]
        [DataRow(830, "oitocentos e trinta reais")]
        [DataRow(920, "novecentos e vinte reais")]
        [DataRow(990, "novecentps e noventa reais")]
        [DataRow(92, "noventa e dois reais")]
        public void Deve_Converter_Unidades_De_Real(int valor, string resultadoEsperado)
        {
            HumanizadorValores hv = new HumanizadorValores();

            string result = hv.HumanizarNumero(valor);

            Assert.AreEqual(resultadoEsperado, result);
        }
    }
}
