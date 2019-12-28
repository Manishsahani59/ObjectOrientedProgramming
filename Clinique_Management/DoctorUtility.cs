using ObjectOrientedProgramming.Address_Book;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Clinique_Management
{
    class DoctorUtility
    {
       
        public static DoctorInfo AddDoctors()
        {
            DoctorInfo DoctorsInformation = new DoctorInfo();
            Random _ID = new Random();
            DoctorsInformation.Id = _ID.Next(000000, 999999);
            AddressBookUtility validation = new AddressBookUtility();

            string Name=validation.FullName();
            DoctorsInformation.Name = Name;
            string specialization = validation.Specialization();
            DoctorsInformation.Specialization = specialization;
            string phoneNo = validation.phoneNumber();
            DoctorsInformation.MobileNo = phoneNo;
            string Age = validation.Agevalidation();
            DoctorsInformation.Age = Age;
            string Avaliable = validation.ValidationAvaliablity();
            DoctorsInformation.Availability = Avaliable;
            return DoctorsInformation;


        }

    }
}
