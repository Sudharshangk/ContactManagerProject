using System.ComponentModel.DataAnnotations;

namespace AngularAuthPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
