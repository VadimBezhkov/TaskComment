using Model;
using Repositories.Repositor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAllComment
{
    public class AllComments
    {
        private CommentRepository _comentRepository = new CommentRepository(new DataProvider.CommentContext());
        public IEnumerable<Comment> AllCom()
        {
            return _comentRepository.GetAll();
        }
    }
}
