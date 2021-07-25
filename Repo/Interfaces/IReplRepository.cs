using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
   public interface IReplRepository <Repl> where Repl : class
    {
        void AddRepl(Repl repl);
        Repl GetById(int id);
        IEnumerable<Repl> GetAll();
        void UpdateRepl(Repl repl);
        void DeleteRepl(int id);
    }
}
