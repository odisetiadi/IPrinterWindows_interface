﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_2_
{
    public class Epson : IPrinterWindows
    {
        public void Convert(PrinterWindows printer)
        {
            Console.WriteLine("Canon display dimension : {0}", printer.Epson);
        }
    }
}

