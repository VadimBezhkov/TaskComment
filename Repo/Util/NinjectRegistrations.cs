using Model;
using Models;
using Ninject.Modules;
using Repositories.Interfaces;
using Repositories.Repositor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenericRepository<Comment>>().To<CommentRepository>();
            Bind<IGenericRepository<Repl>>().To<ReplRepository>();
        }
    }
}
