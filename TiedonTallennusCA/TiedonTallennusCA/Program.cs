using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennusCA
{
    class Program
    {
        static void Main(string[] args)
        {
            int lämpötila = 0;
            //Console.Write("Anna uusi lämpötila: ");
            //string syöte = Console.Readline();
            lämpötila = int.Parse(syöte);

            //tiedostoon kirjoittaminen
            string tiedosto = @"C:\Temp\Lämpötila.txt";
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");

            //odottaa enterin painamista
            Console.ReadLine();
        }
    }
}
