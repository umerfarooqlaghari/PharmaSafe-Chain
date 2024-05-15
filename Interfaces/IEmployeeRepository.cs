using ProjectLearn.Models.UserManagementModels.EmployeeManagement;

namespace ProjectLearn.Interfaces
{
    public interface IEmployeeRepository
    {
        ICollection<EmployeeDirectoryTable> GetEmployees();
    }
}
