using DataProvider;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
   public class CommentContext:DbContext
    {
        public DbSet<Comment> Coments { get; set; }
    }
}
