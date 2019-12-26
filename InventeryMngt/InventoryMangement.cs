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
                char input;
                string path= @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\InventeryMngt\invertorydetails.json";
                var jsondata = File.ReadAllText(path);
                var Items = JsonConvert.DeserializeObject<products>(jsondata);
                int _totalrice = 0;
                int _totalwheat = 0;
                int _totalpulse = 0;
                int _Riceserial = 1, _Wheatserial = 1,_pulseserail=1 ;
                Console.WriteLine("-----------------------------------Rice Stock-------------------------------------");
                Console.WriteLine("Serial No\t"+"Name\t\t\t\t" + "Price\t\t\t\t" + "Weight");
                
                foreach (var products in Items.Rice)
                {
                     Console.WriteLine(_Riceserial +"\t\t" + products.Name + "\t\t\t" + products.price + "\t\t\t" + products.weight + "/kg.");
                    _Riceserial++;
                    _totalrice =_totalrice+ products.price* products.weight;
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------Pulse Stock-------------------------------------");
                Console.WriteLine("Serial No\t" + "Name\t\t\t\t" + "Price\t\t" + "\tWeight");
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
                               
                                do {
                                    Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                    Console.WriteLine(RiceChoice + "\t\t" + Items.Rice[0].Name + "\t\t\t" + Items.Rice[0].price + "\t\t\t" + Items.Rice[0].weight + "/kg.");
                                    Console.WriteLine("Enter the Quantaty of Rice in Kg.");
                                    Console.WriteLine();
                                    int quantaty = Utility.switchinputvalidation();
                                    if (quantaty != 0)
                                    {
                                        if (quantaty < Items.Rice[0].weight)
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
                                            Console.WriteLine("We Don`t Have Sufficient Product");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" You Entered The Wrong Qunatity please Enter the Valid Quantity");
                                    }
                                    string updateList=JsonConvert.SerializeObject(Items);
                                   // Console.WriteLine(updateList);
                                    File.WriteAllText(path,updateList);
                                   
                                    Console.WriteLine("Do You Want Keep buy continue? Y/N");
                                    input = Utility.Exitinputvalidation();
                                } while (input.Equals('Y')||input.Equals('y'));
                                break;
                            case 2:
                                do
                                {
                                    Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                    Console.WriteLine(RiceChoice + "\t\t" + Items.Rice[1].Name + "\t\t\t" + Items.Rice[1].price + "\t\t\t" + Items.Rice[1].weight + "/kg.");
                                    Console.WriteLine("Enter the Quantaty of Rice in Kg.");
                                    Console.WriteLine();
                                    int quantaty = Utility.switchinputvalidation();
                                    if (quantaty != 0)
                                    {
                                        if (quantaty < Items.Rice[1].weight)
                                        {
                                            int updatedWeight = Items.Rice[1].weight - quantaty;
                                            Console.WriteLine("You Have Sold " + quantaty + "kg");
                                            Items.Rice[1].weight = updatedWeight;
                                            Console.WriteLine("The Updated Quantaty You have  " + updatedWeight + "/kg.");
                                            Console.WriteLine("Please You Give me " + Items.Rice[1].price * quantaty);
                                            Console.WriteLine();
                                            Console.WriteLine("---------------------------------There is Your Updated List ---------------------");
                                            Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                            Console.WriteLine(RiceChoice + "\t\t" + Items.Rice[1].Name + "\t\t\t" + Items.Rice[1].price + "\t\t\t" + Items.Rice[1].weight + "/kg.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("We Don`t Have Sufficient Product");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" You Entered The Wrong Qunatity please Enter the Valid Quantity");
                                    }
                                    string updateList = JsonConvert.SerializeObject(Items);
                                    File.WriteAllText(path, updateList);
                                    Console.WriteLine("Do You Want Keep buy continue? Y/N");
                                    input = Utility.Exitinputvalidation();
                                } while (input.Equals('Y') || input.Equals('y'));
                                break;
                            case 3:
                                do
                                {
                                    Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                    Console.WriteLine(RiceChoice + "\t\t" + Items.Rice[2].Name + "\t\t\t" + Items.Rice[2].price + "\t\t\t" + Items.Rice[2].weight + "/kg.");
                                    Console.WriteLine("Enter the Quantaty of Rice in Kg.");
                                    Console.WriteLine();
                                    int quantaty = Utility.switchinputvalidation();
                                    if (quantaty != 0)
                                    {
                                        if (quantaty < Items.Rice[2].weight)
                                        {
                                            int updatedWeight = Items.Rice[2].weight - quantaty;
                                            Console.WriteLine("You Have Sold " + quantaty + "kg");
                                            Items.Rice[2].weight = updatedWeight;
                                            Console.WriteLine("The Updated Quantaty You have  " + updatedWeight + "/kg.");
                                            Console.WriteLine("Please You Give me " + Items.Rice[2].price * quantaty);
                                            Console.WriteLine();
                                            Console.WriteLine("---------------------------------There is Your Updated List ---------------------");
                                            Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                            Console.WriteLine(RiceChoice + "\t\t" + Items.Rice[2].Name + "\t\t\t" + Items.Rice[2].price + "\t\t\t" + Items.Rice[2].weight + "/kg.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("We Don`t Have Sufficient Product");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" You Entered The Wrong Qunatity please Enter the Valid Quantity");
                                    }
                                    string updateList = JsonConvert.SerializeObject(Items);
                                    File.WriteAllText(path, updateList);
                                    Console.WriteLine("Do You Want Keep buy continue? Y/N");
                                    input = Utility.Exitinputvalidation();
                                } while (input.Equals('Y') || input.Equals('y'));
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
                        Console.WriteLine("Select The Option Which Pulse You Want to Buy");
                        Console.WriteLine("1  " + Items.Pulse[0].Name);
                        Console.WriteLine("2  " + Items.Pulse[1].Name);
                        Console.WriteLine("3  " + Items.Pulse[2].Name);
                        Console.WriteLine();
                        int PulseChoice = Utility.switchinputvalidation();
                        switch (PulseChoice)
                        {
                            case 1:

                                do
                                {
                                    Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                    Console.WriteLine(PulseChoice + "\t\t" + Items.Pulse[0].Name + "\t\t\t" + Items.Pulse[0].price + "\t\t\t" + Items.Pulse[0].weight + "/kg.");
                                    Console.WriteLine("Enter the Quantaty of Rice in Kg.");
                                    Console.WriteLine();
                                    int quantaty = Utility.switchinputvalidation();
                                    if (quantaty != 0)
                                    {
                                        if (quantaty < Items.Rice[0].weight)
                                        {
                                            int updatedWeight = Items.Pulse[0].weight - quantaty;
                                            Console.WriteLine("You Have Sold " + quantaty + "kg");
                                            Items.Pulse[0].weight = updatedWeight;
                                            Console.WriteLine("The Updated Quantaty You have  " + updatedWeight + "/kg.");
                                            Console.WriteLine("Please You Give me " + Items.Pulse[0].price * quantaty);
                                            Console.WriteLine();
                                            Console.WriteLine("---------------------------------There is Your Updated List ---------------------");
                                            Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                            Console.WriteLine(PulseChoice + "\t\t" + Items.Pulse[0].Name + "\t\t\t" + Items.Pulse[0].price + "\t\t\t" + Items.Pulse[0].weight + "/kg.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("We Don`t Have Sufficient Product");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" You Entered The Wrong Qunatity please Enter the Valid Quantity");
                                    }
                                    string updateList = JsonConvert.SerializeObject(Items);
                                    File.WriteAllText(path, updateList);
                                    Console.WriteLine("Do You Want Keep buy continue? Y/N");
                                    input = Utility.Exitinputvalidation();
                                } while (input.Equals('Y') || input.Equals('y'));
                                break;
                            case 2:

                                do
                                {
                                    Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                    Console.WriteLine(PulseChoice + "\t\t" + Items.Pulse[1].Name + "\t\t\t" + Items.Pulse[1].price + "\t\t\t" + Items.Pulse[1].weight + "/kg.");
                                    Console.WriteLine("Enter the Quantaty of Rice in Kg.");
                                    Console.WriteLine();
                                    int quantaty = Utility.switchinputvalidation();
                                    if (quantaty != 0)
                                    {
                                        if (quantaty < Items.Pulse[1].weight)
                                        {
                                            int updatedWeight = Items.Pulse[1].weight - quantaty;
                                            Console.WriteLine("You Have Sold " + quantaty + "kg");
                                            Items.Pulse[1].weight = updatedWeight;
                                            Console.WriteLine("The Updated Quantaty You have  " + updatedWeight + "/kg.");
                                            Console.WriteLine("Please You Give me " + Items.Pulse[1].price * quantaty);
                                            Console.WriteLine();
                                            Console.WriteLine("---------------------------------There is Your Updated List ---------------------");
                                            Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                            Console.WriteLine(PulseChoice + "\t\t" + Items.Pulse[1].Name + "\t\t\t" + Items.Pulse[1].price + "\t\t\t" + Items.Pulse[1].weight + "/kg.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("We Don`t Have Sufficient Product");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" You Entered The Wrong Qunatity please Enter the Valid Quantity");
                                    }
                                    string updateList = JsonConvert.SerializeObject(Items);
                                    File.WriteAllText(path, updateList);
                                    Console.WriteLine("Do You Want Keep buy continue? Y/N");
                                    input = Utility.Exitinputvalidation();
                                } while (input.Equals('Y') || input.Equals('y'));
                                break;
                            case 3:
                                do
                                {
                                    Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                    Console.WriteLine(PulseChoice + "\t\t" + Items.Pulse[2].Name + "\t\t\t" + Items.Pulse[2].price + "\t\t\t" + Items.Pulse[2].weight + "/kg.");
                                    Console.WriteLine("Enter the Quantaty of Rice in Kg.");
                                    Console.WriteLine();
                                    int quantaty = Utility.switchinputvalidation();
                                    if (quantaty != 0)
                                    {
                                        if (quantaty < Items.Pulse[2].weight)
                                        {
                                            int updatedWeight = Items.Pulse[2].weight - quantaty;
                                            Console.WriteLine("You Have Sold " + quantaty + "kg");
                                            Items.Pulse[2].weight = updatedWeight;
                                            Console.WriteLine("The Updated Quantaty You have  " + updatedWeight + "/kg.");
                                            Console.WriteLine("Please You Give me " + Items.Pulse[2].price * quantaty);
                                            Console.WriteLine();
                                            Console.WriteLine("---------------------------------There is Your Updated List ---------------------");
                                            Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                            Console.WriteLine(PulseChoice + "\t\t" + Items.Pulse[2].Name + "\t\t\t" + Items.Pulse[2].price + "\t\t\t" + Items.Pulse[2].weight + "/kg.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("We Don`t Have Sufficient Product");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" You Entered The Wrong Qunatity please Enter the Valid Quantity");
                                    }
                                    string updateList = JsonConvert.SerializeObject(Items);
                                    File.WriteAllText(path, updateList);
                                    Console.WriteLine("Do You Want Keep buy continue? Y/N");
                                    input = Utility.Exitinputvalidation();
                                } while (input.Equals('Y') || input.Equals('y'));
                                break;
                            default:
                                Console.WriteLine("I have Not Avaliable More Products");
                                break;
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


                        Console.WriteLine("Select The Option Which Wheat You Want to Buy ?");
                        Console.WriteLine("1  " + Items.Wheat[0].Name);
                        Console.WriteLine("2  " + Items.Wheat[1].Name);
                        Console.WriteLine("3  " + Items.Wheat[2].Name);
                        Console.WriteLine();
                        int WheatChoice = Utility.switchinputvalidation();
                        switch (WheatChoice)
                        {
                            case 1:

                                do
                                {
                                    Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                    Console.WriteLine(WheatChoice + "\t\t" + Items.Wheat[0].Name + "\t\t\t" + Items.Wheat[0].price + "\t\t\t" + Items.Wheat[0].weight + "/kg.");
                                    Console.WriteLine("Enter the Quantaty of Rice in Kg.");
                                    Console.WriteLine();
                                    int quantaty = Utility.switchinputvalidation();
                                    if (quantaty != 0)
                                    {
                                        if (quantaty < Items.Wheat[0].weight)
                                        {
                                            int updatedWeight = Items.Wheat[0].weight - quantaty;
                                            Console.WriteLine("You Have Sold " + quantaty + "kg");
                                            Items.Wheat[0].weight = updatedWeight;
                                            Console.WriteLine("The Updated Quantaty You have  " + updatedWeight + "/kg.");
                                            Console.WriteLine("Please You Give me " + Items.Wheat[0].price * quantaty);
                                            Console.WriteLine();
                                            Console.WriteLine("---------------------------------There is Your Updated List ---------------------");
                                            Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                            Console.WriteLine(WheatChoice + "\t\t" + Items.Wheat[0].Name + "\t\t\t" + Items.Wheat[0].price + "\t\t\t" + Items.Wheat[0].weight + "/kg.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("We Don`t Have Sufficient Product");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" You Entered The Wrong Qunatity please Enter the Valid Quantity");
                                    }
                                    string updateList = JsonConvert.SerializeObject(Items);
                                    File.WriteAllText(path, updateList);
                                    Console.WriteLine("Do You Want Keep buy continue? Y/N");
                                    input = Utility.Exitinputvalidation();
                                } while (input.Equals('Y') || input.Equals('y'));
                                break;
                            case 2:

                                do
                                {
                                    Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                    Console.WriteLine(WheatChoice + "\t\t" + Items.Wheat[1].Name + "\t\t\t" + Items.Wheat[1].price + "\t\t\t" + Items.Wheat[1].weight + "/kg.");
                                    Console.WriteLine("Enter the Quantaty of Rice in Kg.");
                                    Console.WriteLine();
                                    int quantaty = Utility.switchinputvalidation();
                                    if (quantaty != 0)
                                    {
                                        if (quantaty < Items.Wheat[1].weight)
                                        {
                                            int updatedWeight = Items.Wheat[1].weight - quantaty;
                                            Console.WriteLine("You Have Sold " + quantaty + "kg");
                                            Items.Wheat[1].weight = updatedWeight;
                                            Console.WriteLine("The Updated Quantaty You have  " + updatedWeight + "/kg.");
                                            Console.WriteLine("Please You Give me " + Items.Wheat[1].price * quantaty);
                                            Console.WriteLine();
                                            Console.WriteLine("---------------------------------There is Your Updated List ---------------------");
                                            Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                            Console.WriteLine(WheatChoice + "\t\t" + Items.Wheat[1].Name + "\t\t\t" + Items.Wheat[1].price + "\t\t\t" + Items.Wheat[1].weight + "/kg.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("We Don`t Have Sufficient Product");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" You Entered The Wrong Qunatity please Enter the Valid Quantity");
                                    }
                                    string updateList = JsonConvert.SerializeObject(Items);
                                    File.WriteAllText(path, updateList);
                                    Console.WriteLine("Do You Want Keep buy continue? Y/N");
                                    input = Utility.Exitinputvalidation();
                                } while (input.Equals('Y') || input.Equals('y'));
                                break;
                            case 3:
                                do
                                {
                                    Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                    Console.WriteLine(WheatChoice + "\t\t" + Items.Wheat[2].Name + "\t\t\t" + Items.Wheat[2].price + "\t\t\t" + Items.Wheat[2].weight + "/kg.");
                                    Console.WriteLine("Enter the Quantaty of Rice in Kg.");
                                    Console.WriteLine();
                                    int quantaty = Utility.switchinputvalidation();
                                    if (quantaty != 0)
                                    {
                                        if (quantaty < Items.Wheat[2].weight)
                                        {
                                            int updatedWeight = Items.Wheat[2].weight - quantaty;
                                            Console.WriteLine("You Have Sold " + quantaty + "kg");
                                            Items.Wheat[2].weight = updatedWeight;
                                            Console.WriteLine("The Updated Quantaty You have  " + updatedWeight + "/kg.");
                                            Console.WriteLine("Please You Give me " + Items.Wheat[2].price * quantaty);
                                            Console.WriteLine();
                                            Console.WriteLine("---------------------------------There is Your Updated List ---------------------");
                                            Console.WriteLine("Serial No\t" + "Name\t\t\t" + "Price\t\t\t" + "Weight");
                                            Console.WriteLine(WheatChoice + "\t\t" + Items.Wheat[2].Name + "\t\t\t" + Items.Wheat[2].price + "\t\t\t" + Items.Wheat[2].weight + "/kg.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("We Don`t Have Sufficient Product");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" You Entered The Wrong Qunatity please Enter the Valid Quantity");
                                    }
                                    string updateList = JsonConvert.SerializeObject(Items);
                                    File.WriteAllText(path, updateList);
                                    Console.WriteLine("Do You Want Keep buy continue? Y/N");
                                    input = Utility.Exitinputvalidation();
                                } while (input.Equals('Y') || input.Equals('y'));
                                break;
                            default:
                                Console.WriteLine("I have Not Avaliable More Products");
                                break;
                        }

                        break;
                    default:
                        Console.WriteLine("I have Not Avbaliable");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

    }
}
