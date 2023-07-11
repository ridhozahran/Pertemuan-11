using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak11
{ 
    public class LaserJett : PrinterWindows
    {
      
        public override void Print(Printer jenis)
        {
            Console.WriteLine("Printer LaserJett printing...");
        }
        public override void Show(Printer jenis)
        {
            Console.WriteLine("Dimensi display Printer LaserJett: 12*12");
        }
    }
}
