

namespace IfaceMainApi.Models.Entities;

public class Phone : EntityBase
{
    public string Number { get; set; } = string.Empty;
    public bool IsLandline { get; set; }

}
