namespace ELearning.Core.Dtos.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "مـطـلـوب")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "مـطـلـوب")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; } = false;
    }
}
