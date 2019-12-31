using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedProgramming.Address_Book
{
    class SortByName
    {
        public void SortbyName()
        {
            try
            {
                string TempFullName;
                string TempAddress;
                string TempZip;
                string TempMobile;
                string TempCity;
                string TempState;
                int serial = 1;
                string FilePath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Address Book\Address_book.json";
                string FileWritePath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Address Book\AddressBookSortByName.json";
                string AddressBookInformation = File.ReadAllText(FilePath);
                var jsonData = JsonConvert.DeserializeObject<AddressBookListinfo>(AddressBookInformation);
                for (int i = 0; i < jsonData.AddressBook.Count; i++)
                {
                    for (int j = 0; j < jsonData.AddressBook.Count; j++)
                    {
                        if ((jsonData.AddressBook[i].fullName).CompareTo(jsonData.AddressBook[j].fullName) < 0)
                        {
                            TempFullName = jsonData.AddressBook[i].fullName;
                            TempAddress = jsonData.AddressBook[i].address;
                            TempCity = jsonData.AddressBook[i].city;
                            TempState = jsonData.AddressBook[i].state;
                            TempZip = jsonData.AddressBook[i]._zip;
                            TempMobile = jsonData.AddressBook[i]._Mobile;

                            jsonData.AddressBook[i].fullName = jsonData.AddressBook[j].fullName;
                            jsonData.AddressBook[i].address = jsonData.AddressBook[j].address;
                            jsonData.AddressBook[i].city = jsonData.AddressBook[j].city;
                            jsonData.AddressBook[i].state = jsonData.AddressBook[j].state;
                            jsonData.AddressBook[i]._zip = jsonData.AddressBook[j]._zip;
                            jsonData.AddressBook[i]._Mobile = jsonData.AddressBook[j]._Mobile;

                            jsonData.AddressBook[j].fullName = TempFullName;
                            jsonData.AddressBook[j].address = TempAddress;
                            jsonData.AddressBook[j].city = TempCity;
                            jsonData.AddressBook[j].state = TempState;
                            jsonData.AddressBook[j]._zip = TempZip;
                            jsonData.AddressBook[j]._Mobile = TempMobile;
                        }
                    }
                }
                string sortedAddressBookList = JsonConvert.SerializeObject(jsonData);
                File.WriteAllText(FileWritePath, sortedAddressBookList);
                Console.WriteLine("You AddressBook List Succssfully sorted By Zip");
                Console.WriteLine();
                Console.WriteLine("SerialNo\t   Full Name\t  Address\t\t  City\t\t  State\t\t  Zip\t\t  Mobile");
                Console.WriteLine();
                foreach (var IndividualData in jsonData.AddressBook)
                {
                    Console.WriteLine(serial + "\t\t" + IndividualData.fullName + "\t\t" + IndividualData.address + "\t\t" + IndividualData.city + "\t\t" + IndividualData.state + "\t\t" + IndividualData._zip + "\t\t" + IndividualData._Mobile);
                    serial++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
