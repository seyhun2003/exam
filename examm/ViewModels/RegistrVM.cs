
using System.ComponentModel.DataAnnotations;


namespace examm.ViewModels
{
    public class RegistrVM
    {
        [Required,MaxLength(100)]
        public string FullName { get; set; }
        [Required, MaxLength(100)]
        public string UserName { get; set; }
        [Required, MaxLength(100),EmailAddress()]
        public string Email { get; set; }
        [Required, MaxLength(100),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, MaxLength(100), DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
