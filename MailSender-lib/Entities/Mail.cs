﻿using MailSender_lib.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Entities
{
    public class Mail : BaseEntity
    {
        public string Subject { get; set; }

        public string Body { get; set; }
    }
}
