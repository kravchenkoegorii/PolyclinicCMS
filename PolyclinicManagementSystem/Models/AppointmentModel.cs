using System;

namespace PolyclinicManagementSystem.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public string DoctorName { get; set; }

        public string DoctorSurname { get; set; }
        
        public string PatientName { get; set; }

        public string PatientSurname { get; set; }
    }
}