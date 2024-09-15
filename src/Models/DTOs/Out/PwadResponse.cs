using IfaceMainApi.src.Models.DTOs.Out;

namespace IfaceMainApi.Models.DTOs.Out;

public class PwadResponse
{
    public Guid Id { get; set; }
    public PersonResponse Person { get; set; }
    public string CarefulToken { get; set; }
    public PwadResponse() { }
}
