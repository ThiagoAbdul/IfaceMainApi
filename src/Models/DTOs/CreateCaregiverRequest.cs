namespace IfaceMainApi.Models.DTOs
{
    public class CreateCaregiverRequest
    {
        public Guid AuthId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
    }
}
