using PolyclinicManagementSystem.Models;
using System.Collections.Generic;

namespace PolyclinicManagementSystem.DAOs
{
    public interface IPatientsDao
    {
        void AddPattient(PatientModel patient);

        void ChangePatient(PatientModel newPatient);

        List<PatientModel> GetAllPatients();

        bool CheckPatient(string name, string surname);

        int GetPatientsCount();

        PatientModel GetPatient(string name, string surname);
    }
}