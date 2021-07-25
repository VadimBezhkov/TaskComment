using Model;
using Models;
using Repositories.Repositor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAllComment
{
    public class AllRepl
    {
        private ReplRepository _replRepository = new ReplRepository(new DataProvider.CommentContext());
        public IEnumerable<Repl> Allrep()
        {
            return _replRepository.GetAll();
        }
    }
}
