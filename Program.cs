
using System;
using Newtonsoft.Json;
using System.IO;


namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            char yes_no;
            try
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("*******************  Object Oriented Programming *******************");
                    Console.WriteLine();
                    Console.WriteLine("1. Inventory Data Creation using Json");
                    Console.WriteLine("2. Inventory Management");
                    Console.WriteLine("3. Regular Expression");
                    Console.WriteLine("4. Stock Report");
                    Console.WriteLine("5. Deck Of Card using 2D array");
                    Console.WriteLine("6. Deck Of Card using Queue");
                    Console.WriteLine("7. Address Book");
                    Console.WriteLine("8. Cleanique Management");
                    Console.WriteLine("9.  Commercial data processing");
                    Console.WriteLine("______________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("Enter your choice ?........");
                    input = Utility.switchinputvalidation();
                    switch (input)
                    {
                        case 1:
                            InventoryDataCreateion inventrydataCreate = new InventoryDataCreateion();
                            inventrydataCreate.invontery();
                            break;

                        case 2:
                            InventoryMangement inventoryMngt = new InventoryMangement();
                            inventoryMngt.invontery();

                            break;
                        case 3:
                            RegularExpression regx = new RegularExpression();
                            regx.Regularexpression();
                            break;
                        case 4:
                            StockMngt.stockReport stockmngt = new StockMngt.stockReport();
                            stockmngt.StockReport();
                            break;
                        case 5:
                            DeckOfCard deckofcard = new DeckOfCard();
                            deckofcard.DeckOfcard();
                            break;
                        case 6:
                            DeckOfCards.DeckofCard_Queue queue = new DeckOfCards.DeckofCard_Queue();
                            queue.DeckOfCardqueue();
                            break;
                        case 7:
                            Address_Book.Address_Book _addressBook = new Address_Book.Address_Book();
                            _addressBook.AddressBook();
                            break;
                        case 8:
                            Clinique_Management.Index clinicMngt = new Clinique_Management.Index();
                            clinicMngt.CleniqueIndex();
                            break;
                        case 9:
                            StockMngt.CommercialDataProcessingIndex index = new StockMngt.CommercialDataProcessingIndex();
                            index.Index();
                            break;
                        default:
                            Console.WriteLine("Enter the Wrong Option");
                            break;
                    }
                    Console.WriteLine("do You want to continue Y/N ?");
                    yes_no = Utility.Exitinputvalidation();
                } while (yes_no.Equals('Y') || yes_no.Equals('y'));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
