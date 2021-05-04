using Cornelis.Examples.DataAccess.Repositories.Interfaces;
using Cornelis.Examples.Models.Data;
using Cornelis.Examples.Services.Interfaces;
using System.Threading.Tasks;

namespace Cornelis.Examples.Services.Model
{
    /// <summary>
    /// A Service that deals with animal data
    /// </summary>
    public class AnimalManagementService : IAnimalManagementService
    {
        private IAnimalRepository AnimalRepository { get; }
        private IPlantRepository PlantRepository { get; }
        private IAnimalPlantHistoryRepository AnimalPlantHistoryRepository { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="animalRepository"></param>
        /// <param name="plantRepository"></param>
        /// <param name="animalPlantHistoryRepository"></param>
        public AnimalManagementService(
            IAnimalRepository animalRepository,
            IPlantRepository plantRepository,
            IAnimalPlantHistoryRepository animalPlantHistoryRepository)
        {
            AnimalRepository = animalRepository;
            PlantRepository = plantRepository;
            AnimalPlantHistoryRepository = animalPlantHistoryRepository;
        }

        /// <summary>
        /// Update or insert an animal
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public async Task<bool> UpdateOrInsertAsync(Animal animal)
        {
            // First check if the animal exists
            var existingAnimal = await AnimalRepository.GetByKeyAsync(animal.Rfid);

            if (existingAnimal != null)
            {
                return await AnimalRepository.UpdateEntityAsync(animal) == 1;
            }
            else
            {
                return await AnimalRepository.InsertEntityAsync(animal) == 1;
            }
        }

        /// <summary>
        /// Serch for an specific animal
        /// </summary>
        /// <param name="rfid"></param>
        /// <returns></returns>
        public Task<Animal> SearchAnimalAsync(string rfid) => AnimalRepository.GetByKeyAsync(rfid);
    }
}