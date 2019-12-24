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
            bool flag;
            string fullName,address, city,_zip,_Mobile,_email,state;
           
            Regex Name = new Regex(@"^[A-Z][\sa-zA-z]{3,30}$");
            Regex Address = new Regex(@"^[A-za-z0-9 .,()]*$");
            Regex City = new Regex(@"^[A-za-z .]*$");
            Regex Zip = new Regex(@"^[0-9]{6}$");
            Regex Phone = new Regex(@"^\d{10}$");
            Regex Email = new Regex(@"[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$");
            Console.WriteLine("Enter Your Full Name !!! ");
            do
            {
                fullName = Console.ReadLine();
                flag = Name.IsMatch(fullName);
                if (flag)
                    break;
                Console.WriteLine("Enter the Name Properly...");

            } while (!flag);
            Console.WriteLine("Enter Your Address !!!");
            do
            {
                address = Console.ReadLine();
                flag = Address.IsMatch(address);
                if (flag)
                    break;
                Console.WriteLine("Please Enter the Address Properly...");

            } while (!flag);
            Console.WriteLine("Enter Your City Name !!!");
            do
            {
                city = Console.ReadLine();
                flag = City.IsMatch(city);
                if (flag)
                    break;
                Console.WriteLine("Please Enter the CityName Properly...");

            } while (!flag);
            Console.WriteLine("Enter Your State Name !!!");
            do
            {
                state = Console.ReadLine();
                flag = City.IsMatch(state);
                if (flag)
                    break;
                Console.WriteLine("Please Enter the StateName Properly...");

            } while (!flag);
            Console.WriteLine("Enter the Zip code !!!");
            do
            {
                 _zip = Console.ReadLine();
                flag = Zip.IsMatch(_zip);
                if (flag)
                    break;
                Console.WriteLine("Please Enter the Zip Code Properly...");
            } while (!flag);
            Console.WriteLine("Enter the Phone Number !!!");
            do
            {
                _Mobile = Console.ReadLine();
                flag = Phone.IsMatch(_Mobile);
                if (flag)
                    break;
                Console.WriteLine("Please Enter the Phone Number Properly...");
            } while (!flag);
            /*  Console.WriteLine("Enter the Your Email Id !!!");
              do
              {
                  _email = Console.ReadLine();
                  flag = Email.IsMatch(_email);
                  if (flag)
                      break;
                  Console.WriteLine("Please Enter the Id  Properly ...");
              } while (!flag);
              */
            List<GetAddressBookInfo> AddressBook = new List<GetAddressBookInfo>();
            GetAddressBookInfo AddressBookInfromation = new GetAddressBookInfo();
           
            string FilePath=@"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Address Book\Address_book.json";
          

            try
            {
             
                            
               
                string jsonAddressBookRecords= File.ReadAllText(FilePath);
               // var jsonAddressBookData= JsonConvert.DeserializeObject<AddressBookListinfo>(jsonAddressBookRecords);
               // Console.WriteLine(jsonAddressBookData);
                if (jsonAddressBookRecords == "")
                {
                   
                    AddressBookInfromation.fullName = fullName;
                    AddressBookInfromation.address = address;
                    AddressBookInfromation.city = city;
                    AddressBookInfromation.state = state;
                    AddressBookInfromation._zip = _zip;
                    AddressBookInfromation._Mobile = _Mobile;
                    AddressBook.Add(AddressBookInfromation);

                }
                else
                {
                  //  AddressBook = jsonAddressBookData.AddressBook;
                    AddressBookInfromation = new GetAddressBookInfo();
                    AddressBookInfromation.fullName = fullName;
                    AddressBookInfromation.address = address;
                    AddressBookInfromation.city = city;
                    AddressBookInfromation.state = state;
                    AddressBookInfromation._zip = _zip;
                    AddressBookInfromation._Mobile = _Mobile;
                    AddressBook.Add(AddressBookInfromation);
                }

               
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            string jsondata=JsonConvert.SerializeObject(AddressBook);
            File.WriteAllText(FilePath, jsondata);


        }
    }
}
