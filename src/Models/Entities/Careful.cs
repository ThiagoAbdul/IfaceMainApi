namespace IfaceMainApi.Models.Entities
{
    public class Careful : EntityBase
    {
        public Guid CaregiverId { get; set; }
        public Caregiver? Caregiver { get; set; }
        public Guid PwadId { get; set; }
        public PersonWithAlzheimerDisease? Pwad { get; set; }
        public string CarefulToken { get; set; } = string.Empty;

        public Careful()
        {
            
        }

    }
}

