using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Polimorfismo : "Muitas formas"
 * O polimorfismo indica que um metodo pode assumir multiplas "formas".
 * O polimorfismo é alcançado através de overload e override, em que podemos
 * reescrever o comportamente de um metodo.
 * 
 * Override: permite reescrever o corpo de um metodo alterando o seu
 * comportamente.
 * Esta tecnica pode ser usada em metodos virtuais ou abstratos, sendo
 * obrigatoria nos abstratos, pois estes não têm corpo. No caso dos
 * metodos virtuais, se não forem reescritos é executado o corpo do metodo
 * da classe mãe.
 */

namespace Classes03
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Talk();

            Animal cao = new Cao();
            cao.Talk();
            //Podemos criar um animal e especializar num cão pois a classe
            //cão herda todos os metodos e atributos da classe animal.

            //Gato gato = new Animal();
            //gato.Talk();
            //Não é possivel criar um gato como sendo um animal, pois os
            //mecanismos de herança não garantem que o animal tenha
            //acesso aos metodos existentes na classe cão, pois este
            //mecanismo é unidirecional. A classe gato herda os atributos
            // e metodos da classe animal, enquanto a classe animal não
            //herda nenhum metodo ou atributo da classe gato.

            Console.Read();
        }
    }
}
