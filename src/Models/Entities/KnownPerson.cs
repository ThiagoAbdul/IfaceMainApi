namespace IfaceMainApi.Models.Entities;
public class KnownPerson : EntityBase
{
    public Guid PersonId { get; set; }
    public Person? Person { get; set; }
    public Guid PersonWithAlzheimersDiseaseId { get; set; }
    public PersonWithAlzheimerDisease? PersonWithAlzheimersDisease { get; set; }
    public virtual List<Photo> Photos { get; set; } = [];

    public string Description { get; set; } = string.Empty;

}
