using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    //Herança:
    //Através desta tecnica é possivel construir classes
    //derivadas noutras já existentes. Assim, a classe original
    //é considerada de nivel superior sendo designada por classe
    //mãe, a classe gerada a partir da original é considerada de
    //nivel inferior e designada por classe filha.
    //Como a classe filha consegue herdar todos os metodos e
    //atributos da classe mãe, a herança apresenta a vantagem de 
    //evitar a duplicidade de código.
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Acelerar(10);
            

            ////Um metodo declarado como static indica que não é
            ////necessário criar uma instancia da classe para o chamar
            //Carro.MetodoStatic();

            Cabrio cabrio = new Cabrio();
            cabrio.MetodoVirtual();

            Console.Read();
        }
    }
}
