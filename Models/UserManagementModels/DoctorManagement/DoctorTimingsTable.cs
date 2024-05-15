using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectLearn.Models.UserManagementModels.DoctorManagement
{
    public enum DayOfWeekEnum
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class DoctorTimingsTable
    {
        [Key]
        public int DoctorTimingsId { get; set; }


        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public DoctorDirectoryTable Doctor { get; set; }

        // Timing information
        [EnumDataType(typeof(DayOfWeekEnum), ErrorMessage = "Invalid Day")]
        public DayOfWeekEnum DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        // Location information
        public string? Location { get; set; }

        [Url(ErrorMessage = "Invalid Google Maps URL")]
        public string? GoogleMapUrl { get; set; } 

        [RegularExpression(@"^(coordinates|address|other)$", ErrorMessage = "Invalid Pinpoint Type")]
        public string PinpointType { get; set; } 
    }
}
