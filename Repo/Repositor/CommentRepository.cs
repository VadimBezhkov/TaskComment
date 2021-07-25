using DataProvider;
using Model;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositor
{
    public class CommentRepository : ICommentRepository<Comment>
    {
        private CommentContext _dbContext;
        private DbSet<Comment> comment;
        public CommentRepository(CommentContext dbContext)
        {
            _dbContext = dbContext;
            comment = _dbContext.Coments;
        }

        public void AddComment(Comment com)
        {
            comment.Add(com);
            _dbContext.SaveChanges();
        }

        public void DeleteComment(int id)
        {
            var commentRemove = comment.Find(id);
            comment.Remove(commentRemove);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Comment> GetAll()
        {
            return comment.ToList();
        }

        public Comment GetById(int id)
        {
            return comment.Find(id);
        }

        public void UpdateComment(Comment comment)
        {
            _dbContext.Entry(comment).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}