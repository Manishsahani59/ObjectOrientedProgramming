using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace ObjectOrientedProgramming
{
    class RegularExpression
    {
        public void Regularexpression()
        {
            string FirstName,secondName;
            string MobileNo;
            bool flag;
            string todayDate = DateTime.Today.ToString("dd/MM/yyyy");
            Console.WriteLine(todayDate);

            try
            {
                Regex mobileNumber = new Regex(@"^?\d{10}$");
                Regex Name = new Regex(@"^[A-Z][a-zA-Z]{3,20}$");
                Regex FullName = new Regex(@"^[A-Z][\sa-zA-Z ]{3,30}$");
                string samplestring = File.ReadAllText(@"C:\Users\User\Desktop\RegularExpression.txt");
                Console.WriteLine("The Sample String Is--  ");
                Console.WriteLine(samplestring);
              
                Console.WriteLine(samplestring);
                Console.WriteLine("The File Read Successfully .............");
                Console.WriteLine("Enter Your Frist Name");
                do {
                    FirstName = Console.ReadLine();
                    flag = Name.IsMatch(FirstName);
                    if (flag)
                    break;
                    Console.WriteLine("Please Enter the Valid Name");
                } while (!flag);
                Console.WriteLine("Enter Your FullName");
                do {
                    secondName = Console.ReadLine();
                    flag = FullName.IsMatch(secondName);
                    if (flag)
                    break;
                    Console.WriteLine("Please Enter the Valid Name");
                } while (!flag);
               
                Console.WriteLine("Enter the Mobile Number");
                do
                {
                    MobileNo = Console.ReadLine();
                    flag = mobileNumber.IsMatch(MobileNo);
                    if (flag)
                        break;
                      Console.WriteLine("Enter the Valid Mobile Number");
                } while (!flag);

                samplestring = samplestring.Replace("<<name>>", FirstName);
                samplestring = samplestring.Replace("<<full name>>", secondName);
                samplestring = samplestring.Replace("xxxxxxxxxx", MobileNo);
                samplestring = samplestring.Replace("01/01/2016", todayDate);
                File.WriteAllText("RegularExpression.txt", samplestring);
                File.WriteAllText(@"C:\Users\User\Desktop\RegularExpression.txt", samplestring);
                Console.WriteLine(samplestring);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

          







            //   Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));


        }

    }
}
