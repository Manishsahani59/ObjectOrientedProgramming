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

            char input;
            bool flag;
            do
            {
                int choice;
              
                string path = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\DoctorsInformation.json";
                string DoctorDetails = File.ReadAllText(path);
                var DoctorjsonData = JsonConvert.DeserializeObject<DoctoreList>(DoctorDetails);
                List<DoctorInfo> Doctors;
                DoctorInfo DoctorsInformation;
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("________________ You Selected Doctors___________________");
                    Console.WriteLine("1 . Enter the Doctors Infromation");
                    Console.WriteLine("2 . Doctors By Name ");
                    Console.WriteLine("3 . Doctors By Id ");
                    Console.WriteLine("4 . Doctors By Avaliablity ");
                    Console.WriteLine("5 . Doctors By Specialization ");
                    Console.WriteLine("6 . Doctors List of the Clinique ");
                    Console.WriteLine("________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("Enter The Your Choice ?");
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
                        case 3:
                            implmentationofSerachID _DoctorbyId = new implmentationofSerachID();
                            _DoctorbyId.serachById();
                            break;
                        case 4:
                            ImplemntaionofSearchByAvaliablity _DoctorbyAvaliablity = new ImplemntaionofSearchByAvaliablity();
                            _DoctorbyAvaliablity.serachByAvaliablity();
                            break;
                        case 5:
                            ImplemntaionofSearchBySpecilaization _DoctorBySpecialization = new ImplemntaionofSearchBySpecilaization();
                            _DoctorBySpecialization.serachBySepcilaization();
                            break;
                        case 6:
                            ImplemntaionofSearchByAvaliablity DoctorList = new ImplemntaionofSearchByAvaliablity();
                            DoctorList.DoctorList();

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
                Console.WriteLine("if you Want Continue Press Y and For go Back Press Any Key ....");
                do
                {
                    flag = char.TryParse(Console.ReadLine(), out input);
                    if (flag)
                        break;
                    Console.WriteLine("Enter the valid Character ....");
                } while (!flag);
            } while (input.Equals('y')||input.Equals('Y'));
        }
    }
}

