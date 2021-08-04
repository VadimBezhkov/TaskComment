using Model;
using Ninject;
using Repositories.Interfaces;
using Repositories.Repositor;
using ServicesAllComment.Intarface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAllComment
{
    public class AllComments: IAllComments
    {
        private IGenericRepository<Comment> _comentRepository;
        public IEnumerable<Comment> AllCom()
        {
            return _comentRepository.GetAll();
        }
        public AllComments()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IGenericRepository<Comment>>().To<CommentRepository>();
            _comentRepository = ninjectKernel.Get<IGenericRepository<Comment>>();
        }
    }
}
