using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedProgramming.StockMngt
{
    class stockReport
    {
        public void StockReport()
        {
            try
            {
                StreamWriter Portfolio = new StreamWriter(@"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\StockMngt\Portfolio.json");
                int TotalStockPrice = 0;
                List<getStockInfromation> TotalStockDetails = new List<getStockInfromation>();
                Console.WriteLine("****************************\tEnter The Number of Stock\t****************************");
                int size = Utility.switchinputvalidation();
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(" **************************** Enter The stock Details of  " + (i + 1) + " ****************************");
                    getStockInfromation stocks = new getStockInfromation();
                    Console.WriteLine("Enter the Stock Name");
                    stocks.StockName = Console.ReadLine();
                    Console.WriteLine("Enter the Stock Number of Share");
                    stocks.Numberofshare = Utility.switchinputvalidation();
                    Console.WriteLine("Enter the Stock Price");
                    stocks.shareprice = Utility.switchinputvalidation();
                    TotalStockDetails.Add(stocks);
                   
                }
                Console.WriteLine("----------------------\tThe Individual Stock Infromation is\t----------------------");
                for (int i = 0; i < TotalStockDetails.Count; i++)
                {
                    Console.WriteLine(" The Value of  " + TotalStockDetails[i].StockName + " is\t " + TotalStockDetails[i].Numberofshare * TotalStockDetails[i].shareprice);

                    TotalStockPrice = TotalStockPrice + TotalStockDetails[i].Numberofshare * TotalStockDetails[i].shareprice;
                }
                Console.WriteLine("The Value of Total Stock is \t" + TotalStockPrice);

                Portfolio stockDetails = new Portfolio()
                {
                    TotalStocks = TotalStockDetails
                };

                string jsonstockDetails = JsonConvert.SerializeObject(stockDetails);
                Console.WriteLine(jsonstockDetails);
                Portfolio.WriteLine(jsonstockDetails);
                Portfolio.Flush();
                Portfolio.Close();

            }



            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
           


        }
    }
}
