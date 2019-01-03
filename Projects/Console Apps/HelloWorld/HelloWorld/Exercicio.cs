using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Exercicio
    {
        public static void Media()
        {
            float rslt = 0;

            for(int i = 0; i<5; i++)
            {
                rslt = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Media: {0}", rslt / 5);
        }

        public static bool Paridade(float num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }

        public static void ContadorDecrescente(int num)
        {
            while(num>0)
            {
                Console.WriteLine("Valor: {0}", num);
                num--;
            }
        }
    }
}
