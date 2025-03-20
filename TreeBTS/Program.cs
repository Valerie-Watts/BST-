using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBTS
{
    class Program
    {
        static void Main(string[] args)
        {
            BTS arbol = new BTS(5);
            
            arbol.Search(6); 

        }
    }
}
