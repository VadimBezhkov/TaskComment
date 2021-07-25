using Models;
using Repositories.Repositor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisecRepl
{
   public class UpdateRepl
    {
        private ReplRepository _replRepository = new ReplRepository(new DataProvider.CommentContext());
        public void Update(Repl rep)
        {
            _replRepository.UpdateRepl(rep);
        }
    }
}
