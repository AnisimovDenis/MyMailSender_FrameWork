using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Data
{
    class Configuration : DbMigrationsConfiguration<TestDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.TestDBContext context)
        {
            if (!context.Recipient.Any())
            {
                context.Recipient.AddOrUpdate(
                    new Recipient
                    {
                        Name = "Отправитель 1",
                    },
                    new Recipient
                    {
                        Name = "Отправитель 2",
                    },
                    new Recipient
                    {
                        Name = "Отправитель 3",
                    },
                    new Recipient
                    {
                        Name = "Отправитель 4",
                    });
                context.SaveChanges();
            }

        }
    }
}