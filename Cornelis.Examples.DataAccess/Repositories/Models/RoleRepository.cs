using Cornelis.Examples.DataAccess.DataContexts.SQL;
using Cornelis.Examples.DataAccess.Repositories.Interfaces;
using Cornelis.Examples.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace Cornelis.Examples.DataAccess.Repositories.Models
{
    /// <summary>
    /// Role Repositor.
    /// Used to access the Role Table.
    /// </summary>
    public class RoleRepository : GenericRepository<Role, int>, IRoleRepository
    {
        /// <summary>
        /// Set a database context that is explicitly an SQL Context.
        /// However, should we need to we can easily switch between different
        /// databases/contexts with this table.
        /// </summary>
        /// <param name="context"></param>
        public RoleRepository(SQLContext context) : base(context)
        {
        }
    }
}