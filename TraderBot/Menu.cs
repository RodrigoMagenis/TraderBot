using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderBot
{
    public class Menu
    {
        Boolean dataCollectionState = false;
        Int16 option = -1;

        public void SetOption (Int16 newOption)
        {
            this.option = newOption;
        }

        public Int16 GetOption()
        {
            return this.option;
        }

        public void SetdataCollectionState(Boolean newDataCollectionState)
        {
            this.dataCollectionState = newDataCollectionState;
        }

        public Boolean GetdataCollectionState()
        {
            return this.dataCollectionState;
        }

        public void ShowMainMenu()
        {
            do
            {
                Console.WriteLine("Trader bot");
                Console.WriteLine("Select an option");

                // Menu options:
                Console.WriteLine("1. Change data collection state. State: " + dataCollectionState.ToString());

                // User integration
                try
                {
                    SetOption(Convert.ToInt16(Console.ReadLine()));
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect parameter");
                }

                // System Output
                this.SelectOption(option);
            } while (option == -1);
        }

        public void SelectOption( Int16 selectedOption )
        {
            switch( selectedOption )
            {
                case 1:
                    ChangeDataCollectionState();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine( "Undefined option, try again" );
                    option = -1;
                    break;
            }
        }

        public void ChangeDataCollectionState()
        {
            if (dataCollectionState == true)
            {
                Boolean valid;
                do
                {
                    valid = true;
                    Console.WriteLine("Do you want stop the data collection?");
                    Console.WriteLine("1. yes");
                    Console.WriteLine("2. no");

                    if (Console.ReadLine() == "1")
                    {
                        Console.Clear();
                        dataCollectionState = false;
                    }
                    else if (Console.ReadLine() != "2")
                    {
                        Console.Clear();
                        valid = false;
                        Console.Clear();
                        Console.WriteLine("Invalid option, try again");
                    }
                } while (valid == false);
            }
            else
            {
                Boolean valid;
                do
                {
                    valid = true;
                    Console.WriteLine("Do you want Start the data collection?");
                    Console.WriteLine("1. yes");
                    Console.WriteLine("2. no");
                    String answer = Console.ReadLine();
                    Console.Clear();
                    if ( answer == "1")
                    {
                        dataCollectionState = true;
                    }
                    else if ( answer != "2")
                    {
                        valid = false;
                        Console.WriteLine("Invalid option, try again");
                    }
                } while (valid == false);
            }
        }
    }
}
