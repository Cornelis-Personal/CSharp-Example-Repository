using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cornelis.Examples.Models.Data
{
    public class User
    {
        [Key]
        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}