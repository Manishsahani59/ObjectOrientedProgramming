using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Address_Book
{
    class Address_Book
    {
        public void AddressBook()
        {
            char input;
            bool flag;

            do
            {
                Console.WriteLine("**********************\t Address Book\t**********************");
                Console.WriteLine(" 1 Create address book information");
                Console.WriteLine(" 2 Update book information");
                Console.WriteLine(" 3 Delete address book information");
                Console.WriteLine(" 4 Sort By Name address book information");
                Console.WriteLine(" 5 Sort By Zip address book information");
                int choice = Utility.switchinputvalidation();

                switch (choice)
                {
                    case 1:
                        Add_AddressBook addAddressBook = new Add_AddressBook();
                        addAddressBook.AddAddress_book();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("You Entered The Wrong Option please Try Other");
                        break;

                }
                Console.WriteLine("Do You Want to Continue Y/N");
                do
                {
                    flag = char.TryParse(Console.ReadLine(), out input);
                    if (flag)
                        break;
                    Console.WriteLine("Enter The valid Character");
                } while (!flag);
            } while (input.Equals('Y') || input.Equals('y'));
           
        }
    }
}
