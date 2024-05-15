using ProjectLearn.Data;
using ProjectLearn.Interfaces;
using ProjectLearn.Models.UserManagementModels.EmployeeManagement;

namespace ProjectLearn.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDBContext _context;

        public EmployeeRepository(ApplicationDBContext context) 
        {
            _context = context;
        }
        public ICollection<EmployeeDirectoryTable> GetEmployees() 
        {
        return _context.EmployeeDirectory.OrderBy(p => p.EmployeeId).ToList();
        }
    }
}
