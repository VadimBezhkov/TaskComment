using Models;
using Repositories.Repositor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisecRepl
{
   public class GetRepl
    {
        private ReplRepository _replRepository = new ReplRepository(new DataProvider.CommentContext());
        public Repl Search(int id)
        {
            return _replRepository.GetById(id);
        }
    }
}
