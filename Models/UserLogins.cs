namespace PCAtime.Models
{
    public class UserLogins
    {
        public UserLogins()
        {
            Time = new List<TimeLog>();
        }
        public string UserID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Role { get; set; }
        public string Password { get; set; }
        public List<TimeLog> Time { get; set; }


    }



}


