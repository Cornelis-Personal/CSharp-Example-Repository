using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cornelis.Examples.Models.Data
{
    /// <summary>
    /// Animal transfer history.
    /// </summary>
    public class AnimalPlantHistory
    {
        [ForeignKey("Rfid")]
        public string Rfid { get; set; }

        [ForeignKey("Id")]
        public int Id { get; set; }

        public DateTime? TransferDate { get; set; }

        public virtual List<Animal> Animals { get; set; }
        public virtual List<Plant> Plants { get; set; }
    }
}