using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Comment
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Text")]
        public string TextComment { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Repl> Repls { get; set; }
        public Comment()
        {
            Repls = new List<Repl>();
        }
    }
}
