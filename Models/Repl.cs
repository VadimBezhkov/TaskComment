using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual List<Repl> Childrens
        {
            get
            {
                if (childrens == null)
                {
                    childrens = new List<Repl>();
                }
                return childrens;
            }
            set
            {
                childrens = value;
            }
        }
        private List<Repl> childrens;
    }
}
