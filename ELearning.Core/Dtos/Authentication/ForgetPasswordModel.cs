namespace ELearning.Core.Dtos.Authentication
{
    public class ForgetPasswordModel
    {
        [Required(ErrorMessage = "مـطـلـوب")]  
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        public string? WebLink { get; set; } = string.Empty;
    }
}
