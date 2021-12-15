using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyveim
{
    class Program
    {
        static void Main(string[] args)
        {
            Könyv konyv = new Könyv("Piszkos Fred a kapitány", "Rejtő Jenő", Ertekelesek.NagyonJó);
            Console.WriteLine(konyv.ToString());
        }
    }
}
