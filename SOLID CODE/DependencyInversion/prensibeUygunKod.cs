using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CODE.DependencyInversion
{
    public class prensibeUygunKod
    {
    }


    //Bu yapı, yüksek seviye modüllerin (Notification) düşük seviye modüllere (EmailService, SmsService) doğrudan bağımlı
    //olmasını önler ve bağımlılıkları soyutlamalar üzerinden sağlar. Bu, Dependency Inversion Prensibi'ne uygun bir yapıdır.
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    // E-posta hizmeti somut sınıfı
    public class EmailService3 : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }

    // SMS hizmeti somut sınıfı (örnek olarak)
    public class SmsService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    // Bildirim sınıfı
    public class Notification2
    {
        private readonly IMessageService _messageService;

        public Notification2(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }

}
