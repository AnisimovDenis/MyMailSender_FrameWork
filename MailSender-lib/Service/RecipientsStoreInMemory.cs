using MailSender_lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Service
{
    class RecipientsStoreInMemory
    {
        //public IEnumerable<Recipient> Get() => Data.User;

        public void Edit(int id, Recipient recipient)
        {
            // Так как это хранилище данных в памяти, то здесь ничего не делаем
        }

        public void SaveChanges()
        {
            // Так как это хранилище данных в памяти, то здесь ничего не делаем
        }
    }
}
