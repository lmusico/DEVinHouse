using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex9
{
    public static class Calculadora
    {
        public static void Soma(double num1, double num2){
            Console.WriteLine(num1 + num2);
        }

        public static void Subtracao(double num1, double num2){
            Console.WriteLine(num1 - num2);
        }

        public static void Multiplicacao(double num1, double num2){
            Console.WriteLine(num1 * num2);
        }

        public static void Divisao(double num1, double num2){
            Console.WriteLine(num1 / num2);
        }
    }
}