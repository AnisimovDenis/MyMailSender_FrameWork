﻿using MailSender_lib.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Entities
{
    public class Sender : PersonEntity
    {
        public override string ToString() => $"{Name}:{Address}";
    }

}
