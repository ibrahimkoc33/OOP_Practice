using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE.SingleResponsibility
{
    public class prensibeUygunKod
    {
    }

    //Bu yazılan kod SRP'ye uygun şekilde yazılmıştır. Her sınıfta belli bir sorumluluk vardır.
    public class Userr
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Userr(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    public class UserRepository
    {
        public void SaveToDatabase(User user)
        {
            Console.WriteLine($"Saving {user.Name} to the database");
        }
    }

    public class EmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending email to {email}: {message}");
        }
    }

    public class UserDisplayService
    {
        public void DisplayUserInfo(User user)
        {
            Console.WriteLine($"User: {user.Name}, Email: {user.Email}");
        }
    }
}
