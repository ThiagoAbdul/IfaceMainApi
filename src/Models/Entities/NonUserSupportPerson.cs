using IfaceMainApi.Models.Enums;

namespace IfaceMainApi.Models.Entities;
public class NonUserSupportPerson : EntityBase
{
    public Guid PersonId { get; set; }
    public Person? Person { get; set; }
    public Guid PersonWithAlzheimersDiseaseId { get; set; }
    public PersonWithAlzheimersDisease? PersonWithAlzheimersDisease { get; set; }
    public PersonWithAlzheimersDiseaseRelationship Relationship { get; set; }
    public string? Email { get; set; }

}
