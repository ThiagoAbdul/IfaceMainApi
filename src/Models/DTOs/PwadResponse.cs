using IfaceMainApi.Models.Entities;

namespace IfaceMainApi.Models.DTOs
{
    public class PwadResponse
    {
        public Guid Id { get; set; }
        public PersonResponse Person { get; set; }
        public string CarefulToken { get; set; }
        public PwadResponse() { }


    }
}
