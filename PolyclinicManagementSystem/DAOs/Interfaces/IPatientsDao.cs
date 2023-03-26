using System.Collections.Generic;
using PolyclinicManagementSystem.Models;

namespace PolyclinicManagementSystem.DAOs
{
    public interface IPatientsDao
    {
        void AddPattient(PatientModel patient);

        void ChangePatient(PatientModel newPatient);
        
        List<PatientModel> GetAllPatients();

        bool CheckPatient(int patId);

        int GetPatientsCount();

        PatientModel GetPatient(int id);
    }
}