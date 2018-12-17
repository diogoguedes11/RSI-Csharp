using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes01
{
    class Carro : Veiculo
    {
        //Polimorfismo: dado por overload e override
        //overload - dois ou mais métodos com o mesmo nome
        // mas com uma lista de parametros diferente
        //override - reescrever o comportamento de um metodo
        //o metodo tem de ser virtual ou abstrato

        public int velocidade;
        string cor;

        public Carro() { } //overload de métodos construtores

        public Carro(int _velocidade) // Metodo construtor
        {
            //Permite inicializar uma classe, ou seja, 
            //instanciar um objeto de diferentes formas.
            velocidade = _velocidade;
        }

        public Carro(int _velocidade, string _cor)
        {
            velocidade = _velocidade;
            cor = _cor;
            Console.WriteLine("O objeto carro foi criado");
        }

        ~Carro() //Destrutor
        {
            Console.WriteLine("O objeto foi destruido");
            Console.Read();
            //Assim como é possivel construir objetos, é tambem possivel destruí-los
            //em qualquer momento. Normalmente, isto é feito para libertar os objetos
            //da memoria de forma a otimizar a performance das aplicações
        }

        public override void Acelerar(int quantidade)
        {
            velocidade += quantidade;
        }

        public override void Parar()
        {
            velocidade = 0;
        }

        public override void Travar(int quantidade)
        {
            velocidade -= quantidade;
        }
    }
}
