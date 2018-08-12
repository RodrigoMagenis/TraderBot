using System;
using System.Collections.Generic;
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
            List<String> currencyCod = new List<String>();
            List<Decimal> price = new List<Decimal>();
            List<DateTime> quotationSchedule = new List<DateTime>();

            using (StreamReader file = new StreamReader(@"c:\users\rodrigo magenis\downloads\db_cotacoes - db_moedas_cotacoes (7).csv"))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] values = line.Split(',');

                    if (values[0] != "NA") // se o código da moeda existir
                    {
                        string[] currencyValues = values[1].Split('.'); //separa o valor da moeda por pontos

                        currencyCod.Add(values[0]);
                        price.Add(Convert.ToDecimal(currencyValues[0] + "," + currencyValues[1])); //Concatena os inteiros com as partes inserindo virgula no meio
                        quotationSchedule.Add(DateTime.Now);
                    }
                }
            }

            for (int i = 0; i < currencyCod.Count; i++)
            {
                Console.WriteLine("código = " + currencyCod[i] + " valor = " + price[i] + " horário = " + quotationSchedule[i].ToString() + "\n");
            }

            Console.ReadKey();
        }
    }
}
