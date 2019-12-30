using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using ConsoleTables;

namespace ObjectOrientedProgramming.StockMngt
{
    class StockMngtUtility
    {
        public void BuyShare()
          {
            int serial = 1;
            string PortfolioPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\StockMngt\JsonFiles\Portfolio.json";
            string PortfolioData = File.ReadAllText(PortfolioPath);
            var jsonAccountHolder = JsonConvert.DeserializeObject<Portfolio>(PortfolioData);
            Console.WriteLine("You have Avaliable Stocks ...");
            Console.WriteLine();
            var table = new ConsoleTable("seq", "StockName", "NumberofShare", "SharePrice", "TotalValueofTheStock");


            foreach (var stockData in jsonAccountHolder.TotalStocks)
            {
                table.AddRow(serial, stockData.StockName, stockData.Numberofshare, stockData.shareprice, stockData.Numberofshare * stockData.shareprice);
                serial++;
            }
            table.Write();
            Console.WriteLine();
            Console.WriteLine("Enter the StockName to Buy the Share ");
            string Choice = Console.ReadLine();
            var table1 = new ConsoleTable("seq", "StockName", "NumberofShare", "SharePrice", "TotalValueofTheStock");
            Console.WriteLine("You Selected The "+Choice);
            foreach (var stockData in jsonAccountHolder.TotalStocks)
            {
                if (stockData.StockName.Contains(Choice))
                {
                    table1.AddRow(serial, stockData.StockName, stockData.Numberofshare, stockData.shareprice, stockData.Numberofshare * stockData.shareprice);
                    serial++;
                    table1.Write();
                    Console.WriteLine();
                    Console.WriteLine("Enter the how Much Amout of Share You want to Buy");
                    int AmountofShare = Utility.switchinputvalidation();
                    string StockName = stockData.StockName;
                    int NumberofShare = AmountofShare / stockData.shareprice;
                    Console.WriteLine("Amount " + AmountofShare);
                    Console.WriteLine("The Number of Share " + NumberofShare);
                    Console.WriteLine("The Stock Name" + StockName);
                }
               
            


            }
            
            Console.WriteLine("Enter the How Much Share You Want to Buy");


        }
    }
}
