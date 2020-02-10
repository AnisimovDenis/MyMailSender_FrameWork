using MailSender_lib.Entities;
using MailSender_lib.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Service
{
    public class RecipientsStoreInMemory : DataStoreInMemory<Recipient>, IRecipientsStore
    {
        //public IEnumerable<Recipient> Get() => Data.User;

        public RecipientsStoreInMemory() : base() { }

        public override void Edit(int id, Recipient recipient)
        {
            var db_recipient = GetById(id);
            if (db_recipient is null) return;

            db_recipient.Name = recipient.Name;       // Притворяемся, что мы работаем не с объектами в памяти, а с объектам в БД
            db_recipient.Address = recipient.Address;
        }
    }
}
