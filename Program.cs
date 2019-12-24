
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

            do {

                Console.WriteLine();
                Console.WriteLine("*******************  Object Oriented Programming *******************");
                Console.WriteLine();
                Console.WriteLine("1. Inventory Data Creation using Json");
                Console.WriteLine("2. Inventory Management");
                Console.WriteLine("3. Regular Expression");
                Console.WriteLine("4. Stock Report");
                Console.WriteLine("5. Deck Of Card");
                Console.WriteLine("6. Address Book");
                Console.WriteLine();
                Console.WriteLine("Enter your choice");
               
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
                        Address_Book.Address_Book _addressBook = new Address_Book.Address_Book();
                        _addressBook.AddressBook();
                        break;
                    default:
                        Console.WriteLine("Enter the Wrong Option");
                        break;
                }




                Console.WriteLine("do You want to continue Y/N");
                yes_no = Utility.Exitinputvalidation();
            } while (yes_no.Equals('Y') || yes_no.Equals('y'));
           








        
        }
    }
}
