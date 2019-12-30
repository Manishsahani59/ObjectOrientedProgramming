using ObjectOrientedProgramming.Address_Book;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using ObjectOrientedProgramming.Clinique_Management.JsonFileofDoctors;

namespace ObjectOrientedProgramming.Clinique_Management
{

    class PatientUtiltiy
    {
        AddressBookUtility validations = new AddressBookUtility();    
        public static Patientinfo AddPatient()
        {
            AddressBookUtility validations = new AddressBookUtility();
            Patientinfo patientdata = new Patientinfo();
            Random _Id = new Random();
            patientdata.Id = _Id.Next(000000, 999999);
            string Name= validations.FullName();
            patientdata.Name = Name;
            string MobileNo = validations.phoneNumber();
            patientdata.MobileNo = MobileNo;
            string age = validations.Agevalidation();
            patientdata.Age = age;
            return patientdata;
        }

        public void SerachByName()
        {
            try
            {
                int serail = 1;
                bool flag=false;
                string patientPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\Patients.json";
                string patientlist = File.ReadAllText(patientPath);
                var jsondata = JsonConvert.DeserializeObject<PatientList>(patientlist);
                string Name = validations.FullName();
                for (int i = 0; i < jsondata.Patinets.Count; i++)
                {
                    if (jsondata.Patinets[i].Name.Contains(Name))
                    {
                        Console.WriteLine("Seq.\t\tId\t\tName\t\tMobile Number\t\tAge");
                        Console.WriteLine(serail+"\t\t"+jsondata.Patinets[i].Id +"\t\t"+ jsondata.Patinets[i].Name + "\t\t"+jsondata.Patinets[i].MobileNo + "\t\t"+ jsondata.Patinets[i].Age + "\t\t");
                        serail++;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("There is No Any patient in this Clinique of Name " + Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        public void SearchById()
        {
            try
            {
                int serail = 1,_Id;
                bool flag = false;
                string patientPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\Patients.json";
                string patientlist = File.ReadAllText(patientPath);
                var jsondata = JsonConvert.DeserializeObject<PatientList>(patientlist);
                do {
                    Console.WriteLine("Enter the Patient Id");
                    flag = int.TryParse(Console.ReadLine(), out _Id);
                    if (flag)
                        break;
                     Console.WriteLine("Enter the Proper Id");

                } while (!flag);
               
                for (int i = 0; i < jsondata.Patinets.Count; i++)
                {
                    if (jsondata.Patinets[i].Id==_Id)
                    {
                        Console.WriteLine("Seq.\t\tId\t\tName\t\tMobile Number\t\tAge");
                        Console.WriteLine(serail + "\t\t" + jsondata.Patinets[i].Id + "\t\t" + jsondata.Patinets[i].Name + "\t\t" + jsondata.Patinets[i].MobileNo + "\t\t" + jsondata.Patinets[i].Age + "\t\t");
                        serail++;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("There is No Any patient in this Clinique of Id " + _Id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SearchByMobileNo()
        {

            try
            {
                int serail = 1;
                bool flag = false;
                string patientPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\Patients.json";
                string patientlist = File.ReadAllText(patientPath);
                var jsondata = JsonConvert.DeserializeObject<PatientList>(patientlist);
                string mobileNo = validations.phoneNumber();

                for (int i = 0; i < jsondata.Patinets.Count; i++)
                {
                    if (jsondata.Patinets[i].MobileNo.Contains(mobileNo))
                    {
                        Console.WriteLine("Seq.\t\tId\t\tName\t\tMobile Number\t\tAge");
                        Console.WriteLine(serail + "\t\t" + jsondata.Patinets[i].Id + "\t\t" + jsondata.Patinets[i].Name + "\t\t" + jsondata.Patinets[i].MobileNo + "\t\t" + jsondata.Patinets[i].Age + "\t\t");
                        serail++;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("There is No Any patient in this Clinique of Mobile Number " + mobileNo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void PatientList()
        {

            try
            {
                int serail = 1;
                bool flag = false;
                string patientPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\Patients.json";
                string patientlist = File.ReadAllText(patientPath);
                var jsondata = JsonConvert.DeserializeObject<PatientList>(patientlist);
               
                Console.WriteLine("Seq.\t\tId\t\tName\t\tMobile Number\t\tAge");
                for (int i = 0; i < jsondata.Patinets.Count; i++)
                {
                       
                        Console.WriteLine(serail + "\t\t" + jsondata.Patinets[i].Id + "\t\t" + jsondata.Patinets[i].Name + "\t\t" + jsondata.Patinets[i].MobileNo + "\t\t" + jsondata.Patinets[i].Age + "\t\t");
                        serail++;
                        flag = true;
                   
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

/// <summary>
///     Add The patient Details in the List 
/// </summary>
/// <returns></returns>
        public static PatientAppointment AddPatientAppointment()
        {
            PatientAppointment Appointment = new PatientAppointment();
            AddressBookUtility validatations = new AddressBookUtility();
            Console.WriteLine("Enter the Doctor Name");
            string DoctorName = validatations.CustomName();
            Appointment.Avaliablity = validatations.ValidationAvaliablity();
            Appointment.specialization = validatations.Specialization();
            Appointment.DoctorName = DoctorName;
            Random _Id = new Random();
            Appointment.patientId = _Id.Next(0000000, 9999999);
            Console.WriteLine("Enter the Patient Name");
            string PatientName = validatations.CustomName();
            Appointment.PatientName = PatientName;
            string Age = validatations.Agevalidation();
            Appointment.patientAge = Age;
            string MobileNumber = validatations.phoneNumber();
            Appointment.PatientMobileNumber = MobileNumber;
            return Appointment;

        }


    }
}
