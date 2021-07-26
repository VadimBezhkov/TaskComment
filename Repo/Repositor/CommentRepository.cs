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
    public class CommentRepository :IDisposable, IGenericRepository<Comment>
    {
        private CommentContext _dbContext;
        private DbSet<Comment> comment;
        public CommentRepository(CommentContext dbContext)
        {
            _dbContext = dbContext;
            comment = _dbContext.Coments;
        }

        public void Add(Comment com)
        {
            comment.Add(com);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var commentRemove = comment.Find(id);
            comment.Remove(commentRemove);
            _dbContext.SaveChanges();
        }

        public Comment GetById(int id)
        {
            return comment.Find(id);
        }

        public void Update(Comment comment)
        {
            _dbContext.Entry(comment).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        public IEnumerable<Comment> GetAll()
        {
            return comment;
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}