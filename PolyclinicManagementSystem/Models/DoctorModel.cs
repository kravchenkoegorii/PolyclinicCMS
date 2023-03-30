using System;
using System.Collections.Generic;

namespace PolyclinicManagementSystem.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string PassportCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Specialization { get; set; }

        public string Password { get; set; }

        public List<PatientModel> Patients { get; set; }
    }
}