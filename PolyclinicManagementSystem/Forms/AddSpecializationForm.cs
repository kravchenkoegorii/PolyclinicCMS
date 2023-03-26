using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
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
    public partial class AddSpecializationForm : Form
    {
        private ISpecializationDao _specDao;

        public AddSpecializationForm()
        {
            InitializeComponent();
            _specDao = new SpecializationDao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpecializationModel model = new SpecializationModel
            {
                Name = textBox1.Text
            };

            _specDao.AddSpec(model);
        }
    }
}
