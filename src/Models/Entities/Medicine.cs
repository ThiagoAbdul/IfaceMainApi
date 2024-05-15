namespace IfaceMainApi.Models.Entities;

public class Medicine : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string? DrugLabel { get; set; }
}
