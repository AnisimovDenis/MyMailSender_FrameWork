﻿using MailSender_lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Service.Interfaces
{
    public interface IRecipientsStore : IDataStore<Recipient> { }
}
