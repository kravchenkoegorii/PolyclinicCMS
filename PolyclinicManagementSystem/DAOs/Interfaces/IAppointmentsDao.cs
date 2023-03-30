using PolyclinicManagementSystem.Models;
using System.Collections.Generic;

namespace PolyclinicManagementSystem.DAOs.Interfaces
{
    public interface IAppointmentsDao
    {
        List<AppointmentModel> GetDoctorAppointments(string name, string surname);

        List<AppointmentModel> GetAllAppointments();

        void AddAppointment(AppointmentModel model);

        void ChangeAppointment(AppointmentModel model);

        int GetAppointmentsCount();

        bool CheckAppointment(string docSurname, string patSurname);

        AppointmentModel GetAppointment(string docSurname, string patSurname);
    }
}
