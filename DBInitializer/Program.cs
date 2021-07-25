using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBInitializer
{
   public class Program
    {
       private static void Main(string[] args)
        {
            using (CommentContext context = new CommentContext())
            {
                var commentCount = context.co.Count();
                Console.WriteLine($"Added {entityTypesCount} records to {nameof(context.EntityTypes)} table.");

                var groupRolesCount = context.GroupRoles.Count();
                Console.WriteLine($"Added {groupRolesCount} records to {nameof(context.GroupRoles)} table.");

                var userStatesCount = context.UserStates.Count();
                Console.WriteLine($"Added {userStatesCount} records to {nameof(context.UserStates)} table.");

                Console.WriteLine("Done.");
            }
        }
    }
}
