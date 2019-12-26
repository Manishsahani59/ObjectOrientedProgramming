using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;


namespace ObjectOrientedProgramming
{
    class InventoryDataCreateion
    {

        public void invontery()
        {
            try
            {
                StreamReader r = new StreamReader(@"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\InventeryMngt\invertorydetails.json");
                StreamWriter Reicipt = new StreamWriter(@"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\InventeryMngt\TotalPrice.json");
                var jsondata = r.ReadToEnd();
                var Items = JsonConvert.DeserializeObject<products>(jsondata);
                int _totalrice = 0;
                int _totalwheat = 0;
                int _totalpulse = 0;
                foreach (var products in Items.Rice)
                {
                    _totalrice = _totalrice + products.price * products.weight;
                }
                
                foreach (var products in Items.Pulse)
                {
                    _totalpulse = _totalpulse + products.price * products.weight;
                }
                foreach (var products in Items.Wheat)
                {
                    _totalwheat = _totalrice + products.price * products.weight;
                }
                Console.WriteLine();
                Console.WriteLine("The Total Price of the Rice is \t\t" +_totalrice);
                Console.WriteLine("The Total Price of the Wheat is\t\t" +_totalwheat);
                Console.WriteLine("The Total Price of the Pulses is \t" +_totalpulse);
                Price rice = new Price() { Name = "Rice", Totalprice = _totalrice };
                Price pulse = new Price() { Name = "Wheat", Totalprice = _totalwheat };
                Price wheat = new Price() { Name = "Pulse", Totalprice = _totalpulse };
                string jsonRice = JsonConvert.SerializeObject(rice);
                string jsonpulse = JsonConvert.SerializeObject(pulse);
                string jsonwheat = JsonConvert.SerializeObject(wheat);
                 List<Price> TotalPrice = new List<Price>()
                   {
                       new Price(){ Name ="Rice", Totalprice=_totalrice},
                       new Price(){ Name="Wheat", Totalprice=_totalwheat},
                       new Price(){ Name="pulse", Totalprice=_totalpulse},
                   };
                 totalInverntoryprice price = new totalInverntoryprice()
                {
                    TotalPrice = TotalPrice
                };
                
               string PriceData = JsonConvert.SerializeObject(price);
               Reicipt.WriteLine(PriceData);
               Reicipt.Flush();
               Reicipt.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
