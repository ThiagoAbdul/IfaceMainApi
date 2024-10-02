using IfaceMainApi.Models.Entities;

namespace IfaceMainApi.src.Models.DTOs.Out
{
    public class ImageResponse
    {
        public Guid Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Embedding { get; set; } = string.Empty;
        public Guid KnownPersonId { get; set; }

        public ImageResponse() { }

        public ImageResponse(Image image) 
        {
            Id = image.Id;
            Url = image.Url;
            Embedding = image.Embedding;
            KnownPersonId = image.KnownPersonId;
        }

    }
}
