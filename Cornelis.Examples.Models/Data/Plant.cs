using System.ComponentModel.DataAnnotations;

namespace Cornelis.Examples.Models.Data
{
    /// <summary>
    /// The processing plant.
    /// </summary>
    public class Plant
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
    }
}