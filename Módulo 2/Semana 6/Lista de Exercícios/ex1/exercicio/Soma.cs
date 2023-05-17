using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio
{
    public class Soma
    {
        public static double Somar(List<double> valores)
        {
            double soma = 0;

            foreach (var item in valores)
            {
                soma += item;
            }
            return soma;
        }
    }
}