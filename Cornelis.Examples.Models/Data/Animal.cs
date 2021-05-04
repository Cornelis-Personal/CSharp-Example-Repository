using System;
using System.ComponentModel.DataAnnotations;

namespace Cornelis.Examples.Models.Data
{
    /// <summary>
    /// An animal.
    /// </summary>
    public class Animal
    {
        [Key]
        public string Rfid { get; set; }

        public decimal BodyNumber { get; set; }
        public DateTime? KillDate { get; set; }
        public int Ossification { get; set; }
        public int HumpHeight { get; set; }
    }
}