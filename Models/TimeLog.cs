using System.ComponentModel.DataAnnotations;

namespace PCAtime.Models
{
    public class TimesheetEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? TaskDescription { get; set; }
        public int HoursWorked { get; set; }
    }

}
