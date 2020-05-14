using System;

namespace Polymorphism._1
{
    class Program
    {
        static void Main(string[] args)
        {
            printerwindows printer;

            Console.WriteLine("pilihan pointer anda");
            Console.WriteLine("1=>epson");
            Console.WriteLine("2=>canon");
            Console.WriteLine("3=>laserjet");

            Console.WriteLine("pilihan anda 1,2,3 : ");
            int nomorprinter = Convert.ToInt32(Console.ReadLine());

            if (nomorprinter == 1)
            {
                printer = new Epson();
            }
            else if (nomorprinter == 2)
            {
                printer = new canon();
            }
            else
            {
                printer = new laserjet();
            }

                printer.show();
                printer.print();

            Console.ReadKey();
        }
    }
}