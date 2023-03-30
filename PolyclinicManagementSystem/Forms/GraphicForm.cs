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

        public GraphicForm()
        {
            InitializeComponent();
            _doctorsDao = new DoctorsDao();
            _patientsDao = new PatientsDao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
