namespace IfaceMainApi.Models.Entities;
public class EntityBase
{
    public Guid Id { get; set; }
    public bool Deleted { get; set; }
    public Guid CreatedById { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid UpdatedById { get; set; }
    public DateTime LastUpdatedAt { get; set; }

    public EntityBase()
    {
        
    }

}
