using Models;
using Ninject;
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
   public class AnswerHelper:IAnswerHelper
    {
        private IGenericRepository<Repl> _replRepository;
        public void Set(string text,int Id)
        {
            Repl repl = new Repl();
            repl.Text = text;
            repl.CommentId = Id;
            _replRepository.Add(repl);
        }
        public AnswerHelper()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IGenericRepository<Repl>>().To<ReplRepository>();
            _replRepository = ninjectKernel.Get<IGenericRepository<Repl>>();
        }
    }
}
