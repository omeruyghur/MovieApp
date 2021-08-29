using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Zorunlu Alan")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}