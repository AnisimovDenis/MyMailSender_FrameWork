using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_lib.Service.Interfaces
{
    public interface IDataStore<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        int Create(T item);

        void Edit(int id, T itme);

        T Remove(int id);

        void SaveChanges();
    }
}
