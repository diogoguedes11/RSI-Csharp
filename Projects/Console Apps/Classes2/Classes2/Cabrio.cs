using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Cabrio : Carro
    {
        bool teto;
        public Cabrio() { }
        //public Cabrio() : base() { }
        public Cabrio(bool _teto) : base()
        {
            teto = _teto;
            MetodoProtected();
        }
        public Cabrio(bool _teto, int _velocidade) : base(_velocidade)
        {
            teto = _teto;
        }

        public override void MetodoVirtual()
        {
            Console.WriteLine("Classe Cabrio");
        }
    }
}
