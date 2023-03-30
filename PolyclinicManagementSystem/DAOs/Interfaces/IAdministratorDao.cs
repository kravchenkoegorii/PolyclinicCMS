namespace PolyclinicManagementSystem.DAOs.Interfaces
{
    public interface IAdministratorDao
    {
        bool LoginAdmin(string email, string password);
    }
}
