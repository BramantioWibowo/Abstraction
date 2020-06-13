using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Makanan Makanan;

            Console.WriteLine("Pilih Makanan:");
            Console.WriteLine("1. Rendang");
            Console.WriteLine("2. Gudeg");

            Console.Write("Nomor Makanan [1..2]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorMakanan == 1)
            {
                printer = new Rendang();
            }
            else if (nomorMakanan == 2)
            {
                printer = new Gudeg();
            }

            printer.Show();
            printer.Print();

        }
    }
}
