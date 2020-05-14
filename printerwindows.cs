using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism._1
{
    public interface printerwindows
    {
        void show();
        void print();
    }

    class Epson : printerwindows

    {
        public void show()
        {
            Console.WriteLine("epson display dimension : 10*11");
        }
        public void print()
        {
            Console.WriteLine("epson printer printing.....");
        }
    }

    class canon : printerwindows
    {
        public void show()
        {
            Console.WriteLine("canon display dimension : 9.5*12");
        }
        public void print()
        {
            Console.WriteLine("canon printer printing.....");
        }
    }

    class laserjet : printerwindows
    {
        public void show()
        {
            Console.WriteLine("laserjet display dimension : 12*12");
        }
        public void print()
        {
            Console.WriteLine("laserjet printer printing.....");
        }
    }
}
