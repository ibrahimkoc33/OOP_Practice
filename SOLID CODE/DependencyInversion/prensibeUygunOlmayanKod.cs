using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE.DependencyInversion
{
    public class prensibeUygunOlmayanKod
    {
    }

    //Bu örnekte Notification sınıfı doğrudan EmailService sınıfına bağımlıdır. Eğer e-posta gönderme yöntemi değişirse veya
    //yeni bir bildirim yöntemi eklemek istersek Notification sınıfını değiştirmek zorunda kalırız. Bu, DIP'yi ihlal eder.
    public class EmailService2
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }

    public class Notification
    {
        private EmailService2 _emailService;

        public Notification()
        {
            _emailService = new EmailService2();
        }

        public void Notify(string message)
        {
            _emailService.SendEmail(message);
        }
    }
}
