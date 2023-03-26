using System.Collections.Generic;
using PolyclinicManagementSystem.Models;

namespace PolyclinicManagementSystem.DAOs
{
    public interface IDoctorsDao
    {
        int GetSessionId();

        void AddDoctor(DoctorModel doctor);

        void ChangeDoctor(DoctorModel newDoctor);

        List<DoctorModel> GetAllDoctors();
        
        List<PatientModel> GetAllDoctorPatients(string id);

        bool LoginDoctor(string email, string password);

        DoctorModel GetDoctor(int id);
    }
}