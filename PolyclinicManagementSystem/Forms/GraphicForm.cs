using PolyclinicManagementSystem.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyclinicManagementSystem.Forms
{
    public partial class GraphicForm : Form
    {
        private IDoctorsDao _doctorsDao;

        private IPatientsDao _patientsDao;

        private BindingSource _bindingSource;

        public GraphicForm()
        {
            InitializeComponent();
            _doctorsDao = new DoctorsDao();
            _patientsDao = new PatientsDao();
            _bindingSource = new BindingSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var allDocs = _doctorsDao.GetAllDoctors();

            var docPatients = new List<int>();
            foreach(var item in allDocs)
            {
                //docPatients.Add(_doctorsDao.GetAllDoctorPatients(item.Id.ToString()).Count());
            }

            double[] doctors = new double[allDocs.Count];
            double[] patients = new double[docPatients.Count];

            for (int i = 0; i < allDocs.Count; i++)
            {
                doctors[i] = allDocs[i].Id;
            }

            for (int i = 0; i < docPatients.Count; i++)
            {
                patients[i] = docPatients[i];
            }

            formsPlot1.Plot.XLabel("Doctor");
            formsPlot1.Plot.YLabel("Patients count");

            formsPlot1.Plot.AddScatter(doctors, patients);
            formsPlot1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _doctorsDao.GetAllDoctors();
            dataGridView1.DataSource = _bindingSource;
        }
    }
}
