
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ObjectOrientedProgramming
{
    class Utility
    {
        public static void Validation(string userName,string Mobilenumber)
        {

            Regex Name = new Regex(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$");
            Regex mobileNumbner = new Regex(@"^[0-9]{10}$");
            if (Name.IsMatch(userName))
            {
                if (mobileNumbner.IsMatch(Mobilenumber))
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    //Console.WriteLine("it contain only nummeric value up to 10 digit only");
                }
            }
            else
            {
                Console.WriteLine("First And Second Name must be captial, do not contain any special character and numeric value");
            }
        }
       
        /// <summary>
        /// Switch case input validation 
        /// </summary>
        /// <returns></returns>
        public static int switchinputvalidation()
        {
            bool flag;
            int input;
            do {
                flag = int.TryParse(Console.ReadLine(), out input);
                if (flag == true)
                    break;
                Console.WriteLine("Enter the Valid Input");
            } while (!flag);
            return input;
        }
        /// <summary>
        /// Exit validation 
        /// </summary>
        /// <returns></returns>
        public static char Exitinputvalidation()
        {
            bool flag;
            char input;
            do {
                flag = char.TryParse(Console.ReadLine(), out input);
                if (flag == true && (input.Equals('n') || input.Equals('N')))
                {
                    Console.WriteLine("Program Exit");
                    break;
                }
            } while (!flag);

            return input;
        }

  






    }
}
