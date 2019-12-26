using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedProgramming.Address_Book
{
    class updateAddressBook
    {
        AddressBookUtility utility = new AddressBookUtility();
        public void AddressBook()
        {

            try
            {
                int serial = 1;
                bool flag;
                char input;
                string FilePath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Address Book\Address_book.json";
                string AddressBookInformation = File.ReadAllText(FilePath);
                var jsonData = JsonConvert.DeserializeObject<AddressBookListinfo>(AddressBookInformation);
                Console.WriteLine("SerialNo\t   Full Name\t  Address\t\t  City\t  State\t  Zip\t  Mobile");
                foreach (var IndividualData in jsonData.AddressBook)
                {
                    Console.WriteLine(serial + "\t\t" + IndividualData.fullName + "\t\t" + IndividualData.address + "\t\t\t" + IndividualData.city + "\t\t" + IndividualData.state + "\t\t" + IndividualData._zip + "\t\t" + IndividualData._Mobile);
                    serial++;
                }
                Console.WriteLine("Select The Record Which You Want to Update ?");
                int choice = Utility.switchinputvalidation();
                Console.WriteLine("1\t\t" + jsonData.AddressBook[choice-1].fullName + "\t\t" + jsonData.AddressBook[choice-1].address + "\t\t\t" + jsonData.AddressBook[choice-1].city + "\t\t" + jsonData.AddressBook[choice-1].state + "\t\t" + jsonData.AddressBook[choice-1]._zip + "\t\t" + jsonData.AddressBook[choice-1]._Mobile + "\t\t");
                do
                {
                    Console.WriteLine("Select What You want to Update");
                    Console.WriteLine("1 .Name");
                    Console.WriteLine("2 .Address");
                    Console.WriteLine("3 .City");
                    Console.WriteLine("4 .State");
                    Console.WriteLine("5 .Zip");
                    Console.WriteLine("6 .Mobile Number");
                    int select = Utility.switchinputvalidation();
                    switch (select)
                    {
                        case 1:
                            string name = utility.FullName();
                            jsonData.AddressBook[choice].fullName = name;
                            break;
                        case 2:
                            string Address = utility.Addressvalidation();
                            jsonData.AddressBook[choice].address = Address;
                            break;
                        case 3:
                            string City = utility.CityValidation();
                            jsonData.AddressBook[choice].city = City;
                            break;
                        case 4:
                            string State = utility.StateValidation();
                            jsonData.AddressBook[choice].state = State;
                            break;
                        case 5:
                            string Zip = utility.Zipvalidation();
                            jsonData.AddressBook[choice]._zip = Zip;
                            break;
                        case 6:
                            string phoneNumber = utility.phoneNumber();
                            jsonData.AddressBook[choice]._Mobile = phoneNumber;
                            break;
                        default:
                            Console.WriteLine("There is No Other Avaliable Option");
                            break;

                    }

                    Console.WriteLine("Your Information Have been Successfully updated ....... Your Updated List is Given Below ");
                    Console.WriteLine("1\t\t" + jsonData.AddressBook[choice].fullName + "\t\t" + jsonData.AddressBook[choice].address + "\t\t\t" + jsonData.AddressBook[choice].city + "\t\t" + jsonData.AddressBook[choice].state + "\t\t" + jsonData.AddressBook[choice]._zip + "\t\t" + jsonData.AddressBook[choice]._Mobile + "\t\t");
                    Console.WriteLine("Your File Successfully updated....................");
                    string updateFile = JsonConvert.SerializeObject(jsonData);
                    File.WriteAllText(FilePath, updateFile);

                    Console.WriteLine("Do You Want to Continue Y/N ?.....");
                    do
                    {
                        flag = char.TryParse(Console.ReadLine(), out input);
                        if (flag)
                            break;
                        Console.WriteLine("Enter The Valid Character !!!");
                    } while (!flag);

                } while (input.Equals('Y') || input.Equals('y'));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
