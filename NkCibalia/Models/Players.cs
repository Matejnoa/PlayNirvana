using System.ComponentModel.DataAnnotations;

namespace NkCibalia.Models
{
    public class Players
    {

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
        public string Position { get; set; } = null!;
        public int Age { get; set; } 
    }
}
