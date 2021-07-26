using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
   public interface IGenericRepository <T> where T : class
    {
        void Add(T comment);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T comment);
        void Delete(int id);
    }
}
