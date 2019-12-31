using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedProgramming.Address_Book
{
    class DeleteAddressBook
    {
        public void DeleteRecords()
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
                Console.WriteLine("Select The Record Which You Want to Delete ?");
                int choice = Utility.switchinputvalidation();
                jsonData.AddressBook.RemoveAt(choice - 1);
                string updatedFile = JsonConvert.SerializeObject(jsonData);
                File.WriteAllText(FilePath, updatedFile);
                Console.WriteLine("Record Deleted SuccessFully .......");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
