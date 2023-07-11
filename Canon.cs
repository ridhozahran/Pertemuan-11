using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak11
{
    
    public class Canon : PrinterWindows
    {
       
        public override void Print(Printer jenis)
        {
            Console.WriteLine("Printer Canon printing...");
        }
        public override void Show(Printer jenis)
        {
            Console.WriteLine("Dimensi display Printer Canon: 9.5*12");
        }
    }
}
