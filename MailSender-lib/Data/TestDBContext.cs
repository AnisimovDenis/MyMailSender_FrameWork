using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Data
{
    class TestDBContext : DbContext
    {
        static TestDBContext() => Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestDBContext, Configuration>());

        public DbSet<Recipient> Recipient { get; set;}

        public TestDBContext() : this("name=DefaultConnection") { }

        public TestDBContext(string ConnectionString) : base(ConnectionString) { }
    }
}
