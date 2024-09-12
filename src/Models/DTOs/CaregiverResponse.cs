using IfaceMainApi.Models.DTOs;
using IfaceMainApi.Models.Entities;

namespace IfaceMainApi.src.Models.DTOs
{
    public class CaregiverResponse
    {
        public Guid Id { get; set; }
        public PersonResponse Person { get; set; }


        public CaregiverResponse(Caregiver caregiver)
        {
            Id = caregiver.Id;
            Person = new PersonResponse(caregiver.Person);
        }
    }
}
