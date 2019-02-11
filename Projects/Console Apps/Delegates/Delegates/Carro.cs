using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Carro
    {
        public event OnExcesso_Handler OnExcesso;

        public int velocidade;

        public void Acelerar(int quantidade)
        {
            velocidade = velocidade + quantidade;
            if (velocidade > 120)
                OnExcesso(this, new EventArgs());
        }
        public void Travar(int quantidade)
        {
            velocidade = velocidade - quantidade;
        }
    }
}
