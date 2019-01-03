using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Math
    {
        public int Soma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static float Media(float num1, float num2)
        {
            return (num1 + num2) / 2;
        }

        void SomaV(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
            Console.Read();
        }
    }
}
