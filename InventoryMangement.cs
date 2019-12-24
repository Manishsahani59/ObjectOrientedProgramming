using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedProgramming
{
    class InventoryMangement
    {
        public void invontery()
        {
            try
            {
                StreamReader r = new StreamReader(@"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\invertorydetails.json");
                StreamWriter Reicipt = new StreamWriter(@"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\TotalPrice.json");
                var jsondata = r.ReadToEnd();
                var Items = JsonConvert.DeserializeObject<products>(jsondata);
                int _totalrice = 0;
                int _totalwheat = 0;
                int _totalpulse = 0;
                int _Riceserial = 1, _Wheatserial = 1,_pulseserail=1 ;
                Console.WriteLine("-----------------------------------Rice Stock-------------------------------------");
                Console.WriteLine("Serial No\t"+"Name\t\t\t" + "Price\t\t\t" + "Weight");
                
                foreach (var products in Items.Rice)
                {
                     Console.WriteLine(_Riceserial +"\t\t" + products.Name + "\t\t\t" + products.price + "\t\t\t" + products.weight + "/kg.");
                    _Riceserial++;
                    _totalrice =_totalrice+ products.price* products.weight;
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------Pulse Stock-------------------------------------");
                Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                foreach (var products in Items.Pulse)
                {
                    Console.WriteLine(_pulseserail + "\t\t" + products.Name + "\t\t\t" + products.price + "\t\t\t" + products.weight + "/kg.");
                    _pulseserail++;
                    _totalpulse = _totalpulse + products.price * products.weight;
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------Wheat Stock-------------------------------------");
                Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                foreach (var products in Items.Wheat)
                {
                     Console.WriteLine(_Wheatserial + "\t\t" + products.Name + "\t\t\t" + products.price + "\t\t\t" + products.weight + "/kg.");
                    _Wheatserial++;
                }

                Console.WriteLine();
                Console.WriteLine("select the Item, you Want to Buy");
                Console.WriteLine("1 Rice");
                Console.WriteLine("2 Pulse");
                Console.WriteLine("3 Wheat");
                int choice = Utility.switchinputvalidation();
                
                switch (choice)
                {
                    case 1:
                        int _RiceselectSerail=1;
                        Console.WriteLine("-----------------------------------You Select Rices-------------------------------------");
                        Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");

                        foreach (var products in Items.Rice)
                        {
                             Console.WriteLine(_RiceselectSerail + "\t\t" + products.Name + "\t\t\t" + products.price + "\t\t\t" + products.weight + "/kg.");
                            _RiceselectSerail++;
                        }

                        Console.WriteLine("Select The Option What Rice You Want");
                        Console.WriteLine("1  "+Items.Rice[0].Name);
                        Console.WriteLine("2  "+Items.Rice[1].Name);
                        Console.WriteLine("3  " + Items.Rice[2].Name);
                        Console.WriteLine();
                        int RiceChoice = Utility.switchinputvalidation();
                        switch (RiceChoice)
                        {
                            case 1:
                                char input;
                                do {
                                    Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                    Console.WriteLine(RiceChoice + "\t\t" + Items.Rice[0].Name + "\t\t\t" + Items.Rice[0].price + "\t\t\t" + Items.Rice[0].weight + "/kg.");

                                    Console.WriteLine("Enter the Quantaty of Rice in Kg.");
                                    Console.WriteLine();
                                    int quantaty = Utility.switchinputvalidation();
                                    if (quantaty > Items.Rice[0].price && quantaty<Items.Rice[0].weight)
                                    {
                                        int updatedWeight = Items.Rice[0].weight - quantaty;
                                        Console.WriteLine("You Have Sold " + quantaty + "kg");
                                        Items.Rice[0].weight = updatedWeight;
                                        Console.WriteLine("The Updated Quantaty You have  " + updatedWeight + "/kg.");
                                        Console.WriteLine("Please You Give me " + Items.Rice[0].price * quantaty);
                                        Console.WriteLine();
                                        Console.WriteLine("---------------------------------There is Your Updated List ---------------------");
                                        Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                        Console.WriteLine(RiceChoice + "\t\t" + Items.Rice[0].Name + "\t\t\t" + Items.Rice[0].price + "\t\t\t" + Items.Rice[0].weight + "/kg.");

                                      
                                    }
                                    else
                                    {
                                        Console.WriteLine("You No Sufficenet Money to But This");
                                    }
                                    Console.WriteLine("Do You Want Keep buy continue---");
                                    input = Utility.Exitinputvalidation();
                                } while (input.Equals('Y')||input.Equals('y'));
                                

                                break;
                            case 2:
                                Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                Console.WriteLine(RiceChoice + "\t\t" + Items.Rice[1].Name + "\t\t\t" + Items.Rice[1].price + "\t\t\t" + Items.Rice[1].weight +"/kg.");
                                break;
                            case 3:
                                Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                Console.WriteLine(RiceChoice + "\t\t" + Items.Rice[2].Name + "\t\t\t" + Items.Rice[2].price + "\t\t\t" + Items.Rice[2].weight + "/kg.");
                                break;
                            default:
                                Console.WriteLine("I have Not Avaliable More Products");
                                break;
                        }




                        break;
                    case 2:
                        int _PulseselectSerail = 1;
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------You Select Pulses-------------------------------------");
                        Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                        foreach (var products in Items.Pulse)
                        {
                            Console.WriteLine(_PulseselectSerail + "\t\t" + products.Name + "\t\t\t" + products.price + "\t\t\t" + products.weight + "/kg.");
                            _PulseselectSerail++;
                            _totalpulse = _totalpulse + products.price * products.weight;
                        }
                        break;
                    case 3:
                        int _WheatselectSerail = 1;
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------You Select Wheats-------------------------------------");
                        Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                        foreach (var products in Items.Wheat)
                        {
                            Console.WriteLine(_WheatselectSerail + "\t\t" + products.Name + "\t\t\t" + products.price + "\t\t\t" + products.weight + "/kg.");
                            _WheatselectSerail++;
                            _totalwheat = _totalwheat + products.price * products.weight;
                        }

                        break;
                    default:
                        Console.WriteLine("I have Not Avbaliable");
                        break;
                }



                
            /*    Console.WriteLine("The Total Price of the Rice is \t\t" +_totalrice);
                Console.WriteLine("The Total Price of the Wheat is\t\t" +_totalwheat);
                Console.WriteLine("The Total Price of the Pulses is \t" +_totalpulse);
                */

             



                Price rice = new Price() { Name = "Rice", Totalprice = _totalrice };
                Price pulse = new Price() { Name = "Wheat", Totalprice = _totalwheat };
                Price wheat = new Price() { Name = "Pulse", Totalprice = _totalpulse };

                string jsonRice=JsonConvert.SerializeObject(rice);
                string jsonpulse=JsonConvert.SerializeObject(pulse);
                string jsonwheat=JsonConvert.SerializeObject(wheat);
           //     Console.WriteLine(jsonRice);
             //   Console.WriteLine(jsonpulse);
               // Console.WriteLine(jsonwheat);

                /*      List<Price> prices = new List<Price>();
                      prices.Add(rice);
                      prices.Add(wheat);
                      prices.Add(pulse);

                      totalInverntoryprice InventryPrices = new totalInverntoryprice();

                      InventryPrices.prices = prices;
    
                string InventryData =JsonConvert.SerializeObject(InventryPrices.prices);   */

                   List<Price> newpriceList = new List<Price>()
                   {
                       new Price(){ Name ="Rice", Totalprice=_totalrice},
                       new Price(){ Name="Wheat", Totalprice=_totalwheat},
                       new Price(){ Name="pulse", Totalprice=_totalpulse},
                   };

                 string priclist=JsonConvert.SerializeObject(newpriceList); 
            //     Console.WriteLine(priclist);
                


                Reicipt.WriteLine(priclist);
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
