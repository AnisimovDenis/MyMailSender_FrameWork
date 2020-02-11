using MailSender_lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Data
{
    class TestData
    {
        public static List<MailSender_lib.Entities.Server> Servers { get; } = new List<MailSender_lib.Entities.Server>
        {
            new MailSender_lib.Entities.Server { Id = 1, Name = "Яндекс", Address = "smtp.yandex.ru", Port = 587, Login = "UserLogin", Password = "Password" },
            new MailSender_lib.Entities.Server { Id = 2, Name = "Mail.ru", Address = "smtp.mail.ru", Port = 587, Login = "UserLogin", Password = "Password" },
            new MailSender_lib.Entities.Server { Id = 3, Name = "GMail", Address = "smtp.gmail.com", Port = 587, Login = "UserLogin", Password = "Password" },
        };

        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender { Id = 1, Name = "Иванов", Address = "ivanov@server.ru" },
            new Sender { Id = 2, Name = "Петров", Address = "petrov@server.ru" },
            new Sender { Id = 3, Name = "Сидоров", Address = "sidorov@server.ru" },
        };

        public static List<MailSender_lib.Entities.Recipient> Recipients { get; } = new List<MailSender_lib.Entities.Recipient>
        {
            new MailSender_lib.Entities.Recipient { Id = 1, Name = "Иванов", Address = "ivanov@server.ru" },
            new MailSender_lib.Entities.Recipient { Id = 2, Name = "Петров", Address = "petrov@server.ru" },
            new MailSender_lib.Entities.Recipient { Id = 3, Name = "Сидоров", Address = "sidorov@server.ru" },
        };
    }
}
