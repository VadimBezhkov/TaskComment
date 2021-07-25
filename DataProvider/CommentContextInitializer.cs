using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class CommentContextInitializer : DropCreateDatabaseAlways<CommentContext>
    {
        protected override void Seed(CommentContext context)
        {
            Comment com = new Comment() {UserName= "Vadim",TextComment = "Good Post", Date = DateTime.Now };
            context.Coments.Add(com);
            context.SaveChanges();
        }
    }
}
