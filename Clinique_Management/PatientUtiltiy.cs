using ObjectOrientedProgramming.Address_Book;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Clinique_Management
{
    class PatientUtiltiy
    {
      
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
        
        }

        public void SearchByMobileNumber()
        { 
        
        }

        public void SearchById()
        { 
            
        }

    }
}
