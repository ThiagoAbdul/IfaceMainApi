namespace IfaceMainApi.src.Models.DTOs.In
{
    public class AddImageForm
    {
        public IFormFile? File { get; set; }
        public string Embedding { get; set; } = string.Empty;

        public AddImageForm()
        {

        }
    }
}
