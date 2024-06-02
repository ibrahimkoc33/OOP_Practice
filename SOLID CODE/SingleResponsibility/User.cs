using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE.SingleResponsibility
{
    //Bu yazılan kod Single Responsibility yi ihlal ediyor. Bir sınıf içerisinde birden çok sorumluluk tanımlanmıştır.
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void SaveToDatabase()
        {
            Console.WriteLine($"Saving {Name} to the database");
        }

        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending email to {Email}: {message}");
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"User: {Name}, Email: {Email}");
        }
    }
}
