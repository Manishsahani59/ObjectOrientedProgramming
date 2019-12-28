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
            try
            {
                string patientPath = @"C:\Users\User\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\Clinique_Management\JsonFileofDoctors\Patients.json";
                string patientlist = File.ReadAllText(patientPath);
                var jsondata=JsonConvert.DeserializeObject<PatientList>(patientlist);
                List<Patientinfo> Patients;
                Patientinfo patient;

                if (patientlist == null)
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
                    Patinets= Patients
                };

                string patinets=JsonConvert.SerializeObject(cleqniquepatients);
                Console.WriteLine(patinets);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          

        }
    }
}
