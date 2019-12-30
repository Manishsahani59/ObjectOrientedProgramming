using ObjectOrientedProgramming.Address_Book;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Web.Helpers;
using ObjectOrientedProgramming.Clinique_Management.JsonFileofDoctors;

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
                        Console.WriteLine("Seq.\tId\t\tName\t\tSpecialization\t\tAvalialblity\tMobileNo\t\tAge");
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
                        Console.WriteLine("Seq.\tId\t\tName\t\tSpecialization\t\tAvalialblity\tMobileNo\t\tAge");
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
        PatientUtiltiy patientUtiltiy = new PatientUtiltiy();
        public void serachByAvaliablity()
        {
            try
            {
                string DoctorDetails = File.ReadAllText(path);
                var DoctorjsonData = JsonConvert.DeserializeObject<DoctoreList>(DoctorDetails);
                AddressBookUtility validations = new AddressBookUtility();
                string Avaliable = validations.ValidationAvaliablity();

                for (int i = 0; i < DoctorjsonData.Doctors.Count; i++)
                {
                    if (DoctorjsonData.Doctors[i].Availability == Avaliable)
                    {
                        Console.WriteLine("Seq.\tId\t\tName\t\tSpecialization\t\tAvalialblity\tMobileNo\t\tAge");
                        Console.WriteLine(serail + "\t\t" + DoctorjsonData.Doctors[i].Id + "\t\t" + DoctorjsonData.Doctors[i].Name + "\t\t" + DoctorjsonData.Doctors[i].Specialization + "\t\t" + DoctorjsonData.Doctors[i].Availability + "\t\t" + DoctorjsonData.Doctors[i].MobileNo + "\t\t" + DoctorjsonData.Doctors[i].Age + "\t\t");
                        ImplemntaionofSearchByAvaliablity Appitment = new ImplemntaionofSearchByAvaliablity();
                        Console.WriteLine("Today Doctor  " + DoctorjsonData.Doctors[i].Name + " Can See Only the Patients .........");
                        Appitment.AppointmentwithDoctor();


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

        public void AppointmentwithDoctor()
        {  
            char input;
            int serail = 1;
            try
            {
                string patientPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\Patients.json";
                string patientlist = File.ReadAllText(patientPath);
                var jsondata = JsonConvert.DeserializeObject<PatientList>(patientlist);
                Console.WriteLine("Seq.\t\tId\t\tName\t\tMobile Number\t\tAge");
                foreach (var patients in jsondata.Patinets)
                {
                   
                    Console.WriteLine(serail + "\t\t" + patients.Id + "\t\t" + patients.Name + "\t\t" + patients.MobileNo + "\t\t" + patients.Age + "\t\t");
                    serail++;
                    if (serail == 6)
                        break;
                }
                if (serail == 6)
                {
                    do {
                        Console.WriteLine("Do you want To Take Appointment with Doctor Y/N ?");
                        do
                        {
                            flag = char.TryParse(Console.ReadLine(), out input);
                            if (flag)
                                break;
                            Console.WriteLine("Enter the  proper value ");
                        }while(!flag);
                        string FullPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\NewAppoitmentWithDoctors.json";
                        string patientAppointment = File.ReadAllText(FullPath);
                        var appointmnetList = JsonConvert.DeserializeObject<PatientAppointmentList>(patientAppointment);
                        List<PatientAppointment> patientAppointments;
                        PatientAppointment Appointment;
                        if (patientAppointment == "")
                        {
                            patientAppointments = new List<PatientAppointment>();
                            Appointment = PatientUtiltiy.AddPatientAppointment();
                            patientAppointments.Add(Appointment);
                        }
                        else
                        {
                            patientAppointments = appointmnetList.Appointment;
                            Appointment = PatientUtiltiy.AddPatientAppointment();
                            patientAppointments.Add(Appointment);
                        }
                        PatientAppointmentList AppointmentwithDocotrs = new PatientAppointmentList()
                        {
                            Appointment= patientAppointments
                        };
                        string AppointMentdata=JsonConvert.SerializeObject(AppointmentwithDocotrs);
                        File.WriteAllText(FullPath, AppointMentdata);
                    } while (input.Equals('y') || input.Equals('Y'));



                  
                }
               
                   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DoctorList()
        {
            try
            {
                string path = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\DoctorsInformation.json";
                string DoctorDetails = File.ReadAllText(path);
                var DoctorjsonData = JsonConvert.DeserializeObject<DoctoreList>(DoctorDetails);
                Console.WriteLine("Serial No\tId\t\tName\t\tSpecialization\t\tAvalialblity\tMobileNo\t\tAge");
                foreach (var doctor in DoctorjsonData.Doctors)
                {
                  
                    Console.WriteLine(serail + "\t\t" + doctor.Id + "\t\t" + doctor.Name + "\t\t" + doctor.Specialization + "\t\t" + doctor.Availability + "\t\t" + doctor.MobileNo + "\t\t" + doctor.Age + "\t\t");
                    serail++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }


}
