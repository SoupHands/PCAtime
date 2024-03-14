using PCAtime;
using PCAtime.Data;
using PCAtime.Models;

public partial class Program
{
    private static void Main(string[] args)
    {
        using (ApplicationDbContext context = new ApplicationDbContext())
        {
            context.Database.EnsureCreated();

        }
        void AddUser()
        {
            UserLogins user = new UserLogins { Username = "APuleo", Email = "tpuleo@yahoo.com" ,Password = "TestPass1!", Role = "Intern" };
        }

        void GetUser()
        {
            using var context = new ApplicationDbContext();
            var user = context.Users.ToList();
            foreach (var item in user)
            {
                Console.WriteLine(item.Username + " " + item.Password);
            }
        }

        AddUser();
        GetUser();

    }
}

