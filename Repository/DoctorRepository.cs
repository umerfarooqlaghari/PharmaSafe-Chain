using ProjectLearn.Data;
using ProjectLearn.Interfaces;
using ProjectLearn.Models.UserManagementModels.DoctorManagement;


namespace ProjectLearn.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDBContext _context;
        public DoctorRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public ICollection<DoctorDirectoryTable> GetDoctors()
        {
            return _context.DoctorsDirectory.OrderBy(p => p.DoctorId).ToList();
        }

    }
}
