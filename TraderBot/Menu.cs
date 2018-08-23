using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderBot
{
    public class Menu
    {
        public int ShowMainMenu()
        {
            Boolean state = true;
            Int16 option = -1;

            Console.WriteLine("Trader bot");
            Console.WriteLine("Select an option");

            // Menu options:
            Console.WriteLine("1. Change data collection state. State: " + state.ToString() );

            //user input
            this.selectOption();
        }

        public void selectOption()
        {
            Boolean validAnswer = false;
            do
            {
                try
                {
                    option = Convert.ToInt16(Console.ReadLine());
                    validAnswer = true;
                }
                catch
                {
                    Console.WriteLine("Incorrect parameter");
                }
            } while (validAnswer == false);
        }
    }
}
