using PolyclinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyclinicManagementSystem.DAOs.Interfaces
{
    public interface ISpecializationDao
    {
        List<SpecializationModel> GetAllSpec();

        void AddSpec(SpecializationModel model);
    }
}
