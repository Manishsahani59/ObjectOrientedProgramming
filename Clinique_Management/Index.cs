using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Clinique_Management
{
    class Index
    {
        public void CleniqueIndex()
        {
            try
            {
                bool flag;
                int choice;
                Console.WriteLine("Choose To Manage the List of");
                Console.WriteLine(" 1   Patients");
                Console.WriteLine(" 2  Docrtors");
                Console.WriteLine("Enter your Choice");
                do
                {
                 flag = int.TryParse(Console.ReadLine(), out choice);
                    if (flag)
                        break;
                    Console.WriteLine("You don`t Enter Proper Input ");
                } while (!flag);
                switch (choice)
                {
                    case 1:
                        Doctor doctorMngt = new Doctor();
                        doctorMngt.Doctors();
                        break;
                    case 2:
                        Patinets PatientMngt = new Patinets();
                        PatientMngt.Patients();
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

    }
}
