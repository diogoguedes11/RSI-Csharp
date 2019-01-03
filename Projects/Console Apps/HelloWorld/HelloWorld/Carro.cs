using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Carro
    {
        //Uma classe é um plano para a criação de um objeto

        //Atributos - Propriedades
        public int cilindrada, cavalos, velocidade;
        public string cor;

        public void Acelerar(int quantidade)
        {
            velocidade += quantidade;
            //velocidade = velocidade + quantidade;
        }
        void Travar(int quantidade)
        {
            velocidade -= quantidade;
        }
        public void Parar()
        {
            velocidade = 0;
        }
    }
}
