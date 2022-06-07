using System;
using System.Collections.Generic;
using System.Linq;

namespace ChequePorExtenso.Dominio
{
    public class HumanizadorValores
    {
        private Dictionary<int, string> valores = new Dictionary<int, string>()
        {   {1, "um"},           {2, "dois"},         {3, "três"},
            {4, "quatro"},       {5, "cinco"},        {6, "seis"},         {7, "sete"},
            {8, "oito"},         {9, "nove"},         {10, "dez"},         {11, "onze"},
            {12, "doze"},        {13, "treze"},       {14, "quatorze"},    {15, "quinze"},
            {16, "dezesseis"},   {17, "dezessete"},   {18, "dezoito"},     {19, "dezenove"},
            {20, "vinte"},       {30, "trinta"},      {40, "quarenta"},    {50, "cinquenta"},
            {60, "sessenta"},    {70, "setenta"},     {80, "oitenta"},     {90, "noventa"},
            {100, "cem"},        {200, "duzentos"},   {300, "trezentos"},  {400, "quatrocentos"},
            {500, "quinhentos"}, {600, "seiscentos"}, {700, "setecentos"}, {800, "oitocentos"},
            {900, "novecentos"}
        };

        private List<int> chaves = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,
            30,40,50,60,70,80,90,100,200,300,400,500,600,700,800,900
        };

        public string HumanizarNumero(int numero)
        {
            string resultado = "";

            // >1000
            var valorMil = ConverterMil(numero);

            numero -= valorMil * 1000;
            
            if(resultado != "")
                resultado += " e ";
            
            if(valorMil > 1)
                resultado += EscreverCheque(valorMil) + " milhões";
            else
                resultado += EscreverCheque(valorMil) + "um milhão";

            resultado += EscreverCheque(numero) + " reais";
            
            return resultado;
        }

        private int ConverterMil(int numero)
        {
            int resultado = 0;

            string numeroStr = Convert.ToString(numero);

            var texto = numeroStr.SkipLast(3);

            string itemStr = "";

            foreach (var item in texto)
                itemStr += item;

            resultado = Convert.ToInt32(itemStr);

            return resultado;
        }

        public string EscreverCheque(int numero)
        {
            int cont = chaves.Count;
            string resultado = "";

            while (numero > 0)
            {
                while (numero / chaves[cont - 1] >= 1)
                {
                    int valor = chaves[cont - 1];
                    numero -= valor;
                    resultado += valores[valor];
                    cont = chaves.Count;
                    if (numero > 0)
                    {
                        resultado += " e ";
                    }
                }
                cont--;
            }
            return resultado;
        }

        //public string HumanizarNumeroString(decimal numero)
        //{
        //    var numeroString = Convert.ToString(numero);

        //    var numeroAntesVirgula = numeroString.Split('.');

        //    var resultado = "";

        //    var qtdNumeros = numeroAntesVirgula.Length;

        //    if (numeroAntesVirgula.Length == 1)
        //    {
        //        var chave = Convert.ToInt32(numeroAntesVirgula);
        //        resultado = valores[chave] + " " + ".";
        //    }

        //    return resultado;
        //}
    }
}
