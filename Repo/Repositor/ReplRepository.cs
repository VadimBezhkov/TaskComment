using DataProvider;
using Model;
using Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositor
{
    public class ReplRepository : IDisposable, IReplRepository<Repl>
    {
        private CommentContext _dbContext;
        private DbSet<Repl> repl;
        public ReplRepository(CommentContext dbContext)
        {
            _dbContext = dbContext;
            repl = _dbContext.Answers;
        }

        public void AddRepl(Repl rep)
        {
            repl.Add(rep);
            _dbContext.SaveChanges();
        }

        public void DeleteRepl(int id)
        {
            var replRemove = repl.Find(id);
            repl.Remove(replRemove);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Repl> GetAll()
        {
            return repl.ToList();
        }

        public Repl GetById(int id)
        {
            return repl.Find(id);
        }

        public void UpdateRepl(Repl repl)
        {
            _dbContext.Entry(repl).State = EntityState.Modified;
            _dbContext.SaveChanges();
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