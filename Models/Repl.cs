using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Repl
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
