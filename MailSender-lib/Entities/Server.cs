using MailSender_lib.Entities.Base;

namespace MailSender_lib.Entities
{
    public class Server : NamedEntity
    {
        public string Address { get; set; }

        public int Port { get; set; }

        public bool UseSSL { get; set; } = true;

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
