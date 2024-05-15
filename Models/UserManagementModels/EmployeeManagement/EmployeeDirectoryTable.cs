using ProjectLearn.Models.UserManagementModels;
using ProjectLearn.Models.UserManagementModels.DoctorManagement;
using System.ComponentModel.DataAnnotations;

namespace ProjectLearn.Models.UserManagementModels.EmployeeManagement
{ 
    public enum BankName
{
    Meezan,
    Standard_Chartered,
    Habib_Bank,
    Bank_Al_Falah
}


    public class EmployeeDirectoryTable
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? Designation { get; set; }

        public EmployeeDirectoryTable Supervisor { get; set; }

        public DateOnly? Hiring_date { get; set; }

        public int? Base_Salary { get; set; }

        [EnumDataType(typeof(BankName), ErrorMessage = "We Do not have this bank yet")]
        public BankName Bank { get; set; }
        public string? Account_Number { get; set; }  
        public int? SupervisorId { get; set; }

        public UserTable User { get; set; }

        public ICollection<EmployeeDirectoryTable> Follower { get; set; }
    }
}
