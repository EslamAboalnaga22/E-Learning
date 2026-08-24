namespace ELearning.Core.Dtos.Authentication
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage = "مـطـلـوب")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "مـطـلـوب")]
        [DataType(DataType.Password, ErrorMessage = "غير متطابقان")]
        [Compare("Password")]
        public string ConfirmNewPassword { get; set; } = string.Empty;


        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        public string Token { get; set; } = string.Empty;
    }
}
