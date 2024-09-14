using IfaceMainApi.Models.Entities;

namespace IfaceMainApi.src.Models.DTOs.Out;

public class KnownPersonResponse
{
    public Guid Id { get; set; }
    public PersonResponse Person { get; set; }
    public Guid PwadId { get; set; }
    public string Description { get; set; } = string.Empty;

    public KnownPersonResponse() { }

    public KnownPersonResponse(KnownPerson knownPerson)
    {
        Id = knownPerson.Id;
        Description = knownPerson.Description;

        Person = new PersonResponse(knownPerson.Person);

        PwadId = knownPerson.PersonWithAlzheimersDiseaseId;
    }

}