using Model;
using Models;
using Repositories.Interfaces;
using Repositories.Repositor;
using ServisecRepl.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAllComment
{
    public class AllRepl:IAllRepl
    {
        private IGenericRepository<Repl> _replRepository = new ReplRepository(new DataProvider.CommentContext());
        public IEnumerable<Repl> Allrep()
        {
            return _replRepository.GetAll();
        }
    }
}
