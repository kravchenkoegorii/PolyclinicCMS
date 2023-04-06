using LiveCharts;
using LiveCharts.Wpf;
using PolyclinicManagementSystem.DAOs;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PolyclinicManagementSystem.Forms
{
    public partial class GraphicForm : Form
    {
        private IDoctorsDao _doctorsDao;

        private IPatientsDao _patientsDao;

        public GraphicForm()
        {
            InitializeComponent();
            _doctorsDao = new DoctorsDao();
            _patientsDao = new PatientsDao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var doctors = _doctorsDao.GetAllDoctors();
            var patients = _patientsDao.GetAllPatients();
            ChartValues<int> count = new ChartValues<int>();
            for (int i = 0; i < doctors.Count; i++)
            {
                int tmp = patients.
                    Where(x => x.DoctorName == doctors[i].Name && x.DoctorSurname == doctors[i].Surname)
                    .Count();
                count.Add(tmp);
            }

            pieChart1.Series = new SeriesCollection();
            for (int i = 0; i < doctors.Count; i++)
            {
                var pie = new PieSeries
                {
                    Title = $"{doctors[i].Name} {doctors[i].Surname}",
                    Values = new ChartValues<int> { count[i] },
                    DataLabels = true,
                    LabelPoint = point => $"{point.Y} пацієнтів"
                };
                pieChart1.Series.Add(pie);
            }

            pieChart1.Refresh();
        }
    }
}
