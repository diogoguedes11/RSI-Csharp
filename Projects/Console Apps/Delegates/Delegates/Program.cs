using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void OnExcesso_Handler(object sender, EventArgs e);
    // Um delegate é um apontador de métodos.
    // Um evento é um delegate com o return type void.

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            Carro c1 = new Carro();

            c1.OnExcesso += C1_OnExcesso;

            do
            {
                k = Console.ReadKey(true);
                switch (k.Key)
                {
                    case ConsoleKey.UpArrow:
                        c1.Acelerar(5);
                        Console.WriteLine("Velocidade: {0}", c1.velocidade);
                        break;
                    case ConsoleKey.DownArrow:
                        c1.Travar(5);
                        Console.WriteLine("Velocidade: {0}", c1.velocidade);
                        break;
                }
            }
            while (k.Key != ConsoleKey.Escape);

            Console.Read();
        }

        private static void C1_OnExcesso(object sender, EventArgs e)
        {
            Console.WriteLine("Excesso de Velocidade!");
        }
    }
}
