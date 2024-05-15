using System.ComponentModel.DataAnnotations;

namespace ProjectLearn.Models.UserManagementModels.DoctorManagement
{
    public class DoctorDirectoryTable
    {
        [Key]
        public int DoctorId { get; set; }
        public string? DoctorName { get; set;}
        public string? DoctorType { get; set;}

        public UserTable User { get; set; }

        public ICollection<DoctorTimingsTable> DoctorTimings { get; set; }
    }
}
