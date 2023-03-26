using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyclinicManagementSystem.DAOs.Interfaces
{
    public interface IAdministratorDao
    {
        bool LoginAdmin(string email, string password);
    }
}
