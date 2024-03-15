using Microsoft.EntityFrameworkCore;
using Microsoft.Exchange.WebServices.Data;

namespace PCAtime.Models
{
    public class UserLogins
    {
        public UserLogins()
        {
            Time = new List<TimesheetEntry>();

        }
        public string Email { get; set; } = string.Empty;
        public string UserId { get; set; } 
        public string Username { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<TimesheetEntry> Time { get; set; }


    }



}


