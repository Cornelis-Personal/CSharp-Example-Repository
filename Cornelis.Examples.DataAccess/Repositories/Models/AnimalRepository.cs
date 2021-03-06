using Cornelis.Examples.DataAccess.DataContexts.SQL;
using Cornelis.Examples.DataAccess.Repositories.Interfaces;
using Cornelis.Examples.Models.Data;

namespace Cornelis.Examples.DataAccess.Repositories.Models
{
    /// <summary>
    /// Animal Repositor.
    /// Used to access the Animal Table.
    /// </summary>
    public class AnimalRepository : GenericRepository<Animal, string>, IAnimalRepository
    {
        /// <summary>
        /// Set a database context that is explicitly an SQL Context.
        /// However, should we need to we can easily switch between different
        /// databases/contexts with this table.
        /// </summary>
        /// <param name="context"></param>
        public AnimalRepository(SQLContext context) : base(context)
        { }
    }
}