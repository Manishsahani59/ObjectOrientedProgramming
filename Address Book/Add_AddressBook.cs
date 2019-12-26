using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using Newtonsoft.Json;


namespace ObjectOrientedProgramming.Address_Book
{
    class Add_AddressBook
    {
        public void AddAddress_book()
        {
            string FilePath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Address Book\Address_book.json";
            string jsonAddressBookRecords = File.ReadAllText(FilePath);
            var jsonAddressBookData = JsonConvert.DeserializeObject<AddressBookListinfo>(jsonAddressBookRecords);
            List<GetAddressBookInfo> AddressBook;
            GetAddressBookInfo AddressBookInfromation;
            
            try
            {
                if (jsonAddressBookRecords == "")
                {
                    AddressBook = new List<GetAddressBookInfo>();
                    AddressBookInfromation = AddressBookUtility.AddAddressBook();
                    AddressBook.Add(AddressBookInfromation);
                }
                else {
                    AddressBook = jsonAddressBookData.AddressBook;
                    AddressBookInfromation = AddressBookUtility.AddAddressBook();
                    AddressBook.Add(AddressBookInfromation);
                }
                AddressBookListinfo addresbook = new AddressBookListinfo()
                {
                    AddressBook = AddressBook
                };
                string jsondata = JsonConvert.SerializeObject(addresbook);
                File.WriteAllText(FilePath, jsondata);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
            
            
      
      
        


        }
    }
}
