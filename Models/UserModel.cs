using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        [StringLength(30, ErrorMessage = "30 karakterden fazla olamaz")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Zorunlu Alan")]
        [StringLength(30, ErrorMessage = "30 karakterden fazla olamaz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }

        [Url]
        public string Url { get; set; }

        [Range(1800, 2021)]
        public string BirthYear { get; set; }
    }
}