using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedProgramming.Clinique_Management
{
   public class DoctorsByName
    {
        public void DoctorbyName()
        {       
            try
            {
                bool flag=false;
                int serail = 1;
                string path = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\DoctorsInformation.json";
                string DoctorDetails = File.ReadAllText(path);
                var DoctorjsonData = JsonConvert.DeserializeObject<DoctoreList>(DoctorDetails);
                Console.WriteLine("Enter the Doctor Name");
                string Name = Console.ReadLine();
               
                for (int i = 0; i < DoctorjsonData.Doctors.Count; i++)
                {

                    if (DoctorjsonData.Doctors[i].Name.Contains(Name))
                    {
                        Console.WriteLine("Serial No\tId\t\tName\t\tSpecialization\t\tAvalialblity\tMobileNo\t\tAge");
                        Console.WriteLine(serail + "\t\t" + DoctorjsonData.Doctors[i].Id + "\t\t" + DoctorjsonData.Doctors[i].Name + "\t\t" + DoctorjsonData.Doctors[i].Specialization + "\t\t" + DoctorjsonData.Doctors[i].Availability + "\t\t" + DoctorjsonData.Doctors[i].MobileNo + "\t\t" + DoctorjsonData.Doctors[i].Age + "\t\t");
                        flag = true;
                    }
                   
                }
                if (flag == false)
                {
                    Console.WriteLine("There is no any Doctor is this clinique of Name " +Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


