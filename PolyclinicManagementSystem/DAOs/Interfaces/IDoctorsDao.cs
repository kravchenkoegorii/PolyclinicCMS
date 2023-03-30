using PolyclinicManagementSystem.Models;
using System.Collections.Generic;

namespace PolyclinicManagementSystem.DAOs
{
    public interface IDoctorsDao
    {
        string GetName();

        string GetSurname();

        void AddDoctor(DoctorModel doctor);

        void ChangeDoctor(DoctorModel newDoctor);

        List<DoctorModel> GetAllDoctors();

        List<PatientModel> GetAllDoctorPatients(string name, string surname);

        bool LoginDoctor(string email, string password);

        DoctorModel GetDoctor(string name, string surname);

        bool CheckDoctor(string name, string surname);
    }
}