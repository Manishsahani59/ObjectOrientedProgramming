using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedProgramming.Clinique_Management
{
    class DoctorsByName
    {
        public void DoctorbyName()
        {
            int serail = 1; 
            string path = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\DoctorsInformation.json";
            string DoctorDetails = File.ReadAllText(path);
            var DoctorjsonData = JsonConvert.DeserializeObject<DoctoreList>(DoctorDetails);
             
            Console.WriteLine("Serial No\tId\t\tName\t\tSpecialization\t\tAvalialblity\tMobileNo\t\tAge");
            foreach (var Doctors in DoctorjsonData.Doctors)
            {
                Console.WriteLine(serail + "\t\t" + Doctors.Id+ "\t\t" + Doctors.Name + "\t\t" + Doctors.Specialization + "\t\t" + Doctors.Availability + "\t\t" + Doctors.MobileNo + "\t\t" + Doctors.Age + "\t\t");
                serail++;
            }

        }
        
    }
}
