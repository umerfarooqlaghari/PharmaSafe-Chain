using ProjectLearn.Models.UserManagementModels.DoctorManagement;

namespace ProjectLearn.Interfaces
{
    public interface IDoctorRepository
    {
        ICollection<DoctorDirectoryTable> GetDoctors();
    }
}
