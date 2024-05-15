using Microsoft.EntityFrameworkCore;
using ProjectLearn.Models.UserManagementModels;
using ProjectLearn.Models.UserManagementModels.DoctorManagement;
using ProjectLearn.Models.UserManagementModels.EmployeeManagement;

namespace ProjectLearn.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }



        public DbSet<UserTable> UserInformtionTable { get; set; }
        //DbSet<EmployeeAttendanceTable> EmployeesAttendance { get; set;}
        public DbSet<EmployeeDirectoryTable> EmployeeDirectory { get; set;}

        //public DbSet<DoctorBusinessTable> DoctorsBusiness{ get; set;}
        public DbSet<DoctorDirectoryTable> DoctorsDirectory{ get; set;}
        public DbSet<DoctorTimingsTable> DoctorsTimings{ get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
