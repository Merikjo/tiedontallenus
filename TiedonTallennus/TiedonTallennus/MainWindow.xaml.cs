using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TiedonTallennus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static void Main(string[] args)
        {
            int lämpötila = 0;
            //Console.Write("Anna uusi lämpötila: ");
            //string syöte = Console.Readline();
            MessageBox.Show("Anna uusi lämpötila: ");
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
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
