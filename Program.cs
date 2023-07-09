using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrogramanweek11
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows canon = new Canon();
            PrinterWindows epson = new Epson();
            PrinterWindows LaserJet = new LaserJet();

            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("\nNomor Printer[1...3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
            {
                epson.Show();
                epson.Print();
            }
            else if (nomorPrinter == 2)
            {
                canon.Show();
                canon.Print();
            }
            else if (nomorPrinter == 3)
            {
                LaserJet.Show();
                LaserJet.Print();
            }
            else
            {
                Console.WriteLine("\nJenis Printer yang kamu pilih {0} tidak ada pada PrinterWindows", nomorPrinter);
            }

            Console.ReadKey();
        }
    }
}