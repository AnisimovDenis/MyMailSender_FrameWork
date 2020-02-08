using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender_lib.Entities;
using MailSender_lib.Service.Interfaces;

namespace MailSender_lib.Service
{
    public class RecipientsManager : IRecipientsManager
    {
        private IRecipientsStore _Store;

        public void Add(Recipient newRecipient)
        {
            throw new NotImplementedException();
        }

        public void Edit(Recipient recipient)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
