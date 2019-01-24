using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes03
{
    class Animal
    {
        public  virtual void Talk()
        {
            Console.WriteLine("Animal!");
        }
    }

    class Cao : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Huff!");
        }
    }

    class Gato : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Meow!");
        }
    }
}
