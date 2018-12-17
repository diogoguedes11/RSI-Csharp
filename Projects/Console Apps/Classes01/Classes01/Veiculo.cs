using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes01
{
    abstract class Veiculo
    {
        // Uma classe declarada como abstrata não pode ser instanciada.
        // As classes abstratas permitem definir membros abstratos, que
        //não fornecem uma implementação predefinida. A implementação desses
        //membros é feita na classe derivada, exceto se a classe derivada for tambem abstrata.

        public abstract void Acelerar(int quantidade);
        public abstract void Travar(int quantidade);
        public abstract void Parar();
    }
}
