
using System.ComponentModel.DataAnnotations;

namespace BilAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        //[MaxLength(15), MinLength(6)]
        public string UserName { get; set; } = "";
        //[MaxLength(20), MinLength(8)]
        public string Password { get; set; } = "";
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Felaktig E-postadress!"), EmailAddress]
        public string Email { get; set; } = "";
        public bool Admin { get; set; } = false;
    }
}
