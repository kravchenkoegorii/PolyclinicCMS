using PolyclinicManagementSystem.Models;
using System.Collections.Generic;

namespace PolyclinicManagementSystem.DAOs.Interfaces
{
    public interface ISpecializationDao
    {
        List<SpecializationModel> GetAllSpec();

        void AddSpec(SpecializationModel model);
    }
}
