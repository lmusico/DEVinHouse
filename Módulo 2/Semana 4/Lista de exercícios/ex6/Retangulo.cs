using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex6
{
    public class Retangulo
    {
        private int largura;

        public int Largura { get => largura; set => largura = value; }

        private int altura;

        public int Altura { get => altura; set => altura = value; }

        public int CalcularArea(){
            return altura * largura;
        }

    }
}