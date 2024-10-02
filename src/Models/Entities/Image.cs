namespace IfaceMainApi.Models.Entities
{
    public class Image : EntityBase
    {
        public Guid KnownPersonId { get; set; }
        public KnownPerson? KnownPerson { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Embedding { get; set; } = string.Empty;

        public Image()
        {
            
        }
    }
}
