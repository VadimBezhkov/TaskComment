using Models;
using Repositories.Interfaces;
using Repositories.Repositor;
using Services;
using ServisecRepl.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServisecRepl
{
   public class AnswerRepl:IAnswerHelper
    {
        private IGenericRepository<Repl> _replRepository = new ReplRepository(new DataProvider.CommentContext());
        public void Set(string text,int Id)
        {
            Repl repl = new Repl();
            repl.Text = text;
            repl.ParentId = Id;
            _replRepository.Add(repl);
        }

    }
}
