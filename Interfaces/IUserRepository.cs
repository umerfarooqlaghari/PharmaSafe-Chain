using ProjectLearn.Models.UserManagementModels;

namespace ProjectLearn.Interfaces
{
    public interface IUserRepository
    {
        ICollection<UserTable> GetUsers();
    }
}
