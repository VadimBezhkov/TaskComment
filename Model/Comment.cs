using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string TextComment { get; set; }
        public DateTime Date { get; set; }
    }
}
