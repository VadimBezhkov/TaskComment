using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
   public interface ICommentRepository <Comment> where Comment : class
    {
        void AddComment(Comment comment);
        Comment GetById(int id);
        IEnumerable<Comment> GetAll();
        void UpdateComment(Comment comment);
        void DeleteComment(int id);
    }
}
