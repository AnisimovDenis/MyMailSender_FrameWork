using MailSender_lib.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Entities
{
    public class MailingList : NamedEntity
    {
        public ICollection<Recipient> Recipients { get; set; } = new List<Recipient>();
    }
}
