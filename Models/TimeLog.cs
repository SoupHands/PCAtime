namespace PCAtime.Models
{
    public class TimeLog
    {
        public TimeOnly TimeIn { get; set; }
        public TimeOnly TimeOut { get; set; }

        public string UserID { get; set; }
    }
}
