using Models;
using Repositories.Repositor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServisecRepl
{
   public class AddAnswer
    {
        private ReplRepository _replRepository = new ReplRepository(new DataProvider.CommentContext());
        public void Set(string text)
        {
            Repl repl = new Repl();
            repl.Text = text;
            _replRepository.AddRepl(repl);
        }

    }
}
