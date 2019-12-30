using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedProgramming.Clinique_Management
{
    class Patinets
    {
        public void Patients()
        {  
            char input;
            bool flag;
            do
            {
                try
                {
                    string patientPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\Patients.json";
                    string patientlist = File.ReadAllText(patientPath);
                    var jsondata = JsonConvert.DeserializeObject<PatientList>(patientlist);
                    List<Patientinfo> Patients;
                    Patientinfo patient;
                    Console.WriteLine("Enter the Your Choice");
                    Console.WriteLine("1 Patient Information");
                    Console.WriteLine("2 Patient By Name");
                    Console.WriteLine("3 Patient By Id");
                    Console.WriteLine("4 Patient By Mobile Number");
                    Console.WriteLine("5 Patients List ");
                    int choice = Utility.switchinputvalidation();
                    switch (choice)
                    {
                        case 1:
                            if (patientlist == "")
                            {
                                Patients = new List<Patientinfo>();
                                patient = PatientUtiltiy.AddPatient();
                                Patients.Add(patient);
                            }
                            else
                            {
                                Patients = jsondata.Patinets;
                                patient = PatientUtiltiy.AddPatient();
                                Patients.Add(patient);
                            }
                            PatientList cleqniquepatients = new PatientList()
                            {
                                Patinets = Patients
                            };
                            string patinets = JsonConvert.SerializeObject(cleqniquepatients);
                            File.WriteAllText(patientPath, patinets);
                            break;
                        case 2:
                            PatientUtiltiy _ByName = new PatientUtiltiy();
                            _ByName.SerachByName();
                            break;
                        case 3:
                            PatientUtiltiy _ById = new PatientUtiltiy();
                            _ById.SearchById();
                            break;
                        case 4:
                            PatientUtiltiy _ByMobileNumber = new PatientUtiltiy();
                            _ByMobileNumber.SearchByMobileNo();
                            break;
                        case 5:
                            PatientUtiltiy _patientList = new PatientUtiltiy();
                            _patientList.PatientList();
                            break;
                           
                        default:
                            Console.WriteLine("You Entered the Wrong Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("if you Want Continue Press Y and For go Back Press Any Key ....");
                do
                {
                    flag = char.TryParse(Console.ReadLine(), out input);
                    if (flag)
                        break;
                    Console.WriteLine("Enter the valid Character ....");

                } while (!flag);
            } while (input.Equals('y') || input.Equals('Y'));
        }
    }
}
