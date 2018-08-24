using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.ShowMainMenu();
            Console.WriteLine("opcao main class = " + menu.GetOption());
            Console.WriteLine("dataCollectionState main class = " + menu.GetOption());
            Console.ReadKey();
        }
    }
}
