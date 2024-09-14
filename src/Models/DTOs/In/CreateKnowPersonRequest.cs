namespace IfaceMainApi.src.Models.DTOs.In;

public class CreateKnowPersonRequest
{

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public CreateKnowPersonRequest()
    {

    }
}
