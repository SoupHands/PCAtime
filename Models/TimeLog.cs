using System.ComponentModel.DataAnnotations;

namespace PCAtime.Models
{
    public class TimeLog
    {
        
        [Key] public TimeOnly TimeIn { get; set; }
        public TimeOnly TimeOut { get; set; }

        public required string UserID { get; set; }
    }
}
