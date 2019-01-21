using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    //sealed class Carro - A keyword sealed indica que a
    //classe não pode ser derivada.
    class Carro
    {
        public int velocidade;
        public Carro() { }
        public Carro(int _velocidade)
        {
            velocidade = _velocidade;
        }
        public void Acelerar(int quantidade)
        {
            velocidade += quantidade;
        }

        public void Travar(int quantidade)
        {
            velocidade -= quantidade;
        }
        public void Parar()
        {
            velocidade = 0;
        }
        public static void MetodoStatic()
        {

        }
        protected void MetodoProtected()
        {
            //Scopes de Visibilidade dos elementos:
            //private - é visivel na propria classe
            //protected - é visivel na propria classe e nas classes derivadas
            //public  - é visivel em todo o namespace
        }
        public virtual void MetodoVirtual()
        {
            Console.WriteLine("Classe Carro");
            //Um metodo virtual, é um metodo que pode ser reescrito
            //nas classes derivadas (filhas). No entanto, fornece
            //uma implementação predefinida, caso o metodo não seja
            //reescrito na classe derivada é executado o conteudo 
            //do metodo da classe "original"
        }
    }
}
