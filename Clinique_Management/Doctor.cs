﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedProgramming.Clinique_Management
{
    class Doctor
    {
        public void Doctors()
        {
            int choice;
            bool flag;
            string path = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\DoctorsInformation.json";
            string DoctorDetails = File.ReadAllText(path);
            var DoctorjsonData = JsonConvert.DeserializeObject<DoctoreList>(DoctorDetails);
            List<DoctorInfo> Doctors;
            DoctorInfo DoctorsInformation;
            try
            {
               
                Console.WriteLine("Enter The Your Choice");
                Console.WriteLine("1 . Enter the Doctors Infromation");
                Console.WriteLine("2 . Doctors By Name ");
                do
                {
                   flag = int.TryParse(Console.ReadLine(), out choice);
                    if (flag)
                        break;
                    Console.WriteLine("Choice Must a Digit No");
                } while (!flag);
                switch (choice)
                {
                    case 1:
                        if (DoctorDetails == "")
                        {
                            Doctors = new List<DoctorInfo>();
                            DoctorsInformation = DoctorUtility.AddDoctors();
                            Doctors.Add(DoctorsInformation);
                        }
                        else
                        {
                            Doctors = DoctorjsonData.Doctors;
                            DoctorsInformation = DoctorUtility.AddDoctors();
                            Doctors.Add(DoctorsInformation);
                        }
                        DoctoreList CliniqueManagement = new DoctoreList()
                        {
                            Doctors = Doctors
                        };
                        string CliniqueDoctors = JsonConvert.SerializeObject(CliniqueManagement);
                        File.WriteAllText(path, CliniqueDoctors);
                        break;
                    case 2:
                        DoctorsByName _DoctorbyName = new DoctorsByName();
                        _DoctorbyName.DoctorbyName();
                        break;

                    default:
                        Console.WriteLine("Your option is Wrong");
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

