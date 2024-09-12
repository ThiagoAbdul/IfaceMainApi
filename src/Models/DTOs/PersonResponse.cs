using IfaceMainApi.Models.Entities;

namespace IfaceMainApi.Models.DTOs
{
    public class PersonResponse
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public PersonResponse()
        {
            
        }
        public PersonResponse(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
        }
    }
}
