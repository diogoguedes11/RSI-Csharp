using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionStatus();
            Console.Read();
        }

        static void ConnectionStatus()
        {
            DbConnection db = new DbConnection();
            string result = db.ConnectionStatus();

            Console.WriteLine(result);
        }
    }
}
