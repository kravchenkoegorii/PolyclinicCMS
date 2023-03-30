using System;

namespace PolyclinicManagementSystem.Models
{
    public class PatientModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string PassportCode { get; set; }

        public string PhoneNumber { get; set; }

        public string DoctorName { get; set; }

        public string DoctorSurname { get; set; }
    }
}