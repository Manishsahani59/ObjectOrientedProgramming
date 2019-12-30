using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using ConsoleTables;

namespace ObjectOrientedProgramming.StockMngt
{
    class stockReport
    {
        public void StockReport()
        {
            try
            {
               int serial = 1;
                char input;
                bool flag;
               string Portfolio = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\StockMngt\JsonFiles\Portfolio.json";
               string Stocks=File.ReadAllText(Portfolio);
               var jsonStcoksdata= JsonConvert.DeserializeObject<Portfolio>(Stocks);
                int TotalStockPrice = 0;
                List<getStockInfromation> TotalStockDetails;
                getStockInfromation stocks;
                Console.WriteLine("Do You Want To Add The Stocks Y/N ?");
                    do
                    {
                        flag = char.TryParse(Console.ReadLine(), out input);
                        if (flag)
                            break;
                        Console.WriteLine("Enter the Proper input");
                    } while (!flag);
                if (input.Equals('Y') || input.Equals('y'))
                {
                    Console.WriteLine("___________________________\tEnter The Number of Stock\t___________________________");
                    int size = Utility.switchinputvalidation();
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("_____________________________ Enter The stock Details of  " + (i + 1) + " __________________________________");
                        if (Portfolio == "")
                        {
                            TotalStockDetails = new List<getStockInfromation>();
                            stocks = CommercialDataProcessingUtility.AddStocksInformation();
                            TotalStockDetails.Add(stocks);
                        }
                        else
                        {
                            TotalStockDetails = jsonStcoksdata.TotalStocks;
                            stocks = CommercialDataProcessingUtility.AddStocksInformation();
                            TotalStockDetails.Add(stocks);
                        }

                    }

                }

                Console.WriteLine("The Total Stocks Is ---");
                var table = new ConsoleTable("seq", "StockName", "NumberofShare", "SharePrice", "TotalValueofTheStock");


                foreach (var stockData in jsonStcoksdata.TotalStocks)
                {
                    TotalStockPrice = TotalStockPrice + stockData.Numberofshare * stockData.shareprice;
                    table.AddRow(serial,stockData.StockName,stockData.Numberofshare,stockData.shareprice,stockData.Numberofshare * stockData.shareprice);
                   

                    serial++;
                }
                table.Write();
                Console.WriteLine();
                Console.Write("Value Of Total Stocks\t ");
                Console.WriteLine(TotalStockPrice);
                string TotalStocks=  JsonConvert.SerializeObject(jsonStcoksdata);
                File.WriteAllText(Portfolio,TotalStocks);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
           


        }
    }
}
