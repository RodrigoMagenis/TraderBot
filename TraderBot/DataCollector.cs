using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderBot
{
    public class DataCollector
    {
        public void PerformCollection()
        {
            String currencyCod;
            String price;
            String date;


            using (StreamReader file = new StreamReader(@"C:\oi\db_cotacoes - db_moedas_cotacoes.csv"))
            {
                DataBase dataBase = new DataBase();

                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] values = line.Split(',');

                    if (values[0] != "NA" && values[1] != "NA") // se o código da moeda existir
                    {
                        currencyCod = values[0]; // codigo da moeda

                        date = ((DateTime.UtcNow) - (Convert.ToDateTime("01/01/2000 00:00:00"))).TotalSeconds.ToString(); // pega o total de segundos da data atual
                        string[] dateValues = date.Split(',');
                        date = dateValues[0]; // apenas o valor inteiro dos segundos

                        price = values[1];

                        dataBase.InsertQuotation(currencyCod, date, price);
                    }
                }
            }
        }
    }
}
