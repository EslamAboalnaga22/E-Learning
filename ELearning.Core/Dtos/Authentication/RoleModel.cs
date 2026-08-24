namespace ELearning.Core.Dtos.Authentication
{
    public class RoleModel
    {
        public string? Id { get; set; } = string.Empty;
        [Required(ErrorMessage = "Role Name Required")]
        public string Name { get; set; } = string.Empty;
    }
}
