using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak11
{
   
    public class Epson : PrinterWindows
    {
       
        public override void Print(Printer jenis)
        {
            Console.WriteLine("Printer Epson printing...");
        }
        public override void Show(Printer jenis)
        {
            Console.WriteLine("Dimensi display Epson: 10*11");
        }
    }
}
