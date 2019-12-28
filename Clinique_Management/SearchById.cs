using ObjectOrientedProgramming.Address_Book;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Web.Helpers;

namespace ObjectOrientedProgramming.Clinique_Management
{
   public class SearchById
    {
       

       public bool flag = false;
       public int serail = 1;
       public string path = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\DoctorsInformation.json";
      
    }

    class implmentationofSerachID : SearchById
    {
        public void serachById()
        {
            try
            {
                string DoctorDetails = File.ReadAllText(path);
                var DoctorjsonData = JsonConvert.DeserializeObject<DoctoreList>(DoctorDetails);
                Console.WriteLine("Enter The Doctor Id");
                int Id = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < DoctorjsonData.Doctors.Count; i++)
                {
                    if (DoctorjsonData.Doctors[i].Id==Id)
                    {
                        Console.WriteLine("Serial No\tId\t\tName\t\tSpecialization\t\tAvalialblity\tMobileNo\t\tAge");
                        Console.WriteLine(serail + "\t\t" + DoctorjsonData.Doctors[i].Id + "\t\t" + DoctorjsonData.Doctors[i].Name + "\t\t" + DoctorjsonData.Doctors[i].Specialization + "\t\t" + DoctorjsonData.Doctors[i].Availability + "\t\t" + DoctorjsonData.Doctors[i].MobileNo + "\t\t" + DoctorjsonData.Doctors[i].Age + "\t\t");
                        flag = true;
                        serail++;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("There is no any Doctor is this clinique of Id " + Id);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }


    class ImplemntaionofSearchBySpecilaization: SearchById
    {
        public void serachBySepcilaization()
        {
            try
            {
                string DoctorDetails = File.ReadAllText(path);
                var DoctorjsonData = JsonConvert.DeserializeObject<DoctoreList>(DoctorDetails);
                Console.WriteLine("Enter The Doctor Specialization");
                string Sepcialization = Console.ReadLine();
                for (int i = 0; i < DoctorjsonData.Doctors.Count; i++)
                {
                    if (DoctorjsonData.Doctors[i].Specialization.Contains(Sepcialization))
                    {
                        Console.WriteLine("Serial No\tId\t\tName\t\tSpecialization\t\tAvalialblity\tMobileNo\t\tAge");
                        Console.WriteLine(serail + "\t\t" + DoctorjsonData.Doctors[i].Id + "\t\t" + DoctorjsonData.Doctors[i].Name + "\t\t" + DoctorjsonData.Doctors[i].Specialization + "\t\t" + DoctorjsonData.Doctors[i].Availability + "\t\t" + DoctorjsonData.Doctors[i].MobileNo + "\t\t" + DoctorjsonData.Doctors[i].Age + "\t\t");
                        flag = true;
                        serail++;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("There is no any Doctor is this clinique of Specailization " + Sepcialization);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class ImplemntaionofSearchByAvaliablity : SearchById
    {
  
        public void serachByAvaliablity()
        {
            try
            {
                string DoctorDetails = File.ReadAllText(path);
                var DoctorjsonData = JsonConvert.DeserializeObject<DoctoreList>(DoctorDetails);
                string Avaliable = Console.ReadLine();

                for (int i = 0; i < DoctorjsonData.Doctors.Count; i++)
                {
                    if (DoctorjsonData.Doctors[i].Availability == Avaliable)
                    {
                        Console.WriteLine("Serial No\tId\t\tName\t\tSpecialization\t\tAvalialblity\tMobileNo\t\tAge");
                        Console.WriteLine(serail + "\t\t" + DoctorjsonData.Doctors[i].Id + "\t\t" + DoctorjsonData.Doctors[i].Name + "\t\t" + DoctorjsonData.Doctors[i].Specialization + "\t\t" + DoctorjsonData.Doctors[i].Availability + "\t\t" + DoctorjsonData.Doctors[i].MobileNo + "\t\t" + DoctorjsonData.Doctors[i].Age + "\t\t");
                        flag = true;
                        serail++;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("There is no any Doctor is this clinique of Avaliablity " + Avaliable);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }


}
