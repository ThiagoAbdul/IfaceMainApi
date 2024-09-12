namespace IfaceMainApi.Models.Entities
{
    public class Photo : EntityBase
    {
        public Guid KnownPersonId { get; set; }
        public KnownPerson? KnownPerson { get; set; }
        public string Url { get; set; } = string.Empty;
        public string? Embedding { get; set; }

        public Photo()
        {
            
        }
    }
}
