namespace IfaceMainApi.Models.DTOs.In;

public class AddImageRequest
{
    public string Embedding { get; set; } = string.Empty;
    public string Base64Image { get; set; } = string.Empty;
    public AddImageRequest()
    {
        
    }
}
