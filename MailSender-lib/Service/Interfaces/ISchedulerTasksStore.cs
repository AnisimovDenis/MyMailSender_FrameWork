using MailSender_lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Service.Interfaces
{
    public class ISchedulerTasksStore : IDataStore<SchedulerTask>
    {
        public int Create(SchedulerTask item)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, SchedulerTask itme)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SchedulerTask> GetAll()
        {
            throw new NotImplementedException();
        }

        public SchedulerTask GetById(int id)
        {
            throw new NotImplementedException();
        }

        public SchedulerTask Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
