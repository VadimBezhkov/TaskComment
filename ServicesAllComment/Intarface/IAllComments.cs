using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAllComment.Intarface
{
    public interface IAllComments
    {
        IEnumerable<Comment> AllCom();
    }
}
