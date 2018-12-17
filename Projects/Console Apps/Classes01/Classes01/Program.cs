using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes01
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro(1);
            c.Acelerar(5);

            Carro a = new Carro(1);
            a.Parar();

            Console.WriteLine("Velocidade Carro C: {0}",c.velocidade);
            Console.WriteLine("Velocidade Carro A: {0}", a.velocidade);

            c = null;

            GC.Collect(); //Para libertar completamente os objetos da memoria
            //recorre-se ao metodo Collect da Classe GC (Garbage Collector)

            Console.Read();
        }
    }
}
