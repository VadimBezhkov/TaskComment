using DataProvider;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class CommentContext:DbContext
    {
        static CommentContext()
        {
            Database.SetInitializer(new CommentContextInitializer());
        }
        public DbSet<Comment> Coments { get; set; }
    }
}
