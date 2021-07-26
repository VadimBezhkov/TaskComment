using Model;
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
        private IGenericRepository<Comment> _comentRepository = new CommentRepository(new DataProvider.CommentContext());
        public IEnumerable<Comment> AllCom()
        {
            return _comentRepository.GetAll();
        }
    }
}
