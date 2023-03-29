using PolyclinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
