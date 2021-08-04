using Model;
using Models;
using Ninject;
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
        private IGenericRepository<Repl> _replRepository;
        public IEnumerable<Repl> Allrep()
        {
            return _replRepository.GetAll();
        }
        public AllRepl()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IGenericRepository<Repl>>().To<ReplRepository>();
            _replRepository = ninjectKernel.Get<IGenericRepository<Repl>>();
        }
    }
}
