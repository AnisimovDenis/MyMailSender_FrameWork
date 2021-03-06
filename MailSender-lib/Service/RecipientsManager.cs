﻿using System;
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

        public RecipientsManager(IRecipientsStore Store) { _Store = Store; }


        public IEnumerable<Recipient> GetAll()
        {
            return _Store.GetAll();
        }

        public void Add(Recipient NewRecipient)
        {

        }

        public void Edit(Recipient Recipient)
        {
            _Store.Edit(Recipient.Id, Recipient);
        }

        public void SaveChanges()
        {
            _Store.SaveChanges();
        }
    }
}
