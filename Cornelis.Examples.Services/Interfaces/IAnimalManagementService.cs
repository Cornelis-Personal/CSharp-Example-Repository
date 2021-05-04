using Cornelis.Examples.Models.Data;
using System.Threading.Tasks;

namespace Cornelis.Examples.Services.Interfaces
{
    public interface IAnimalManagementService
    {
        /// <summary>
        /// Update or insert an animal.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Task<bool> UpdateOrInsertAsync(Animal animal);

        /// <summary>
        /// Search an animal.
        /// </summary>
        /// <param name="rfid"></param>
        /// <returns></returns>
        public Task<Animal> SearchAnimalAsync(string rfid);
    }
}