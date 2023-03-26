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
        List<AppointmentModel> GetDoctorAppointments(int docId);

        void AddAppointment(AppointmentModel model);

        void ChangeAppointment(AppointmentModel model);

        int GetAppointmentsCount();

        bool CheckAppointment(int id);

        AppointmentModel GetAppointment(int id);
    }
}
