using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.StockMngt
{
    class CommercialDataProcessingIndex
    {
        public void Index()
        {
            int choice;
            char input;
            bool flag;
            do
            {
                Console.WriteLine("_____________________________ Login To Commercial data processing ____________________________");
                Console.WriteLine("1 Create Acoount if you Have already an Account, Ignore");
                Console.WriteLine("2 Login");
                Console.WriteLine("______________________________________________________________________________________________");
                choice = Utility.switchinputvalidation();
                switch (choice)
                {
                    case 1:
                        CommercialDataProcessingUtility createAccount = new CommercialDataProcessingUtility();
                        createAccount.CreateAccount();
                        break;
                    case 2:
                        CommercialDataProcessingUtility LoginUser = new CommercialDataProcessingUtility();
                        LoginUser.Login();
                        break;
                    default:
                        Console.WriteLine("You Enter The Wrong Option");
                        break;
                }


                do
                {
                    Console.WriteLine("Do You Want Continue Y/N ?");
                    flag = char.TryParse(Console.ReadLine(), out input);
                    if (flag)
                        break;
                    Console.WriteLine("Please Enter the proper Input");
                } while (!flag);
            } while (input.Equals('Y') || input.Equals('y'));
           

        }
    }
}
