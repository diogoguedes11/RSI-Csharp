using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        //Conceitos fundamentais das linguagens POO
        // - Polimorfismo, hereditariedade, encapsulamento
        static void Main(string[] args)
        {
            //Exercicio.Media();
            //Console.WriteLine(Exercicio.Paridade(float.Parse(Console.ReadLine())));
            Exercicio.ContadorDecrescente(1000000);
            Console.Read();

            //--------------------------------------
            //Math math = new Math();
            //int resultado = math.Soma(1, 2);

            //Console.WriteLine(resultado);
            //Console.Read();

            //float rslt = Math.Media(1,2);

            //--------------------------------------
            //Carro vw = new Carro();
            //vw.Acelerar(10);

            //Carro c1 = new Carro();
            //c1.Parar();

            //Console.WriteLine(vw.velocidade);
            //Console.WriteLine(c1.velocidade);
            //Console.Read();
        }
    }
}
