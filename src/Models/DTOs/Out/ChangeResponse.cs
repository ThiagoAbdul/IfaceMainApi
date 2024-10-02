using IfaceMainApi.Configurations;
using IfaceMainApi.Models.Entities;
using IfaceMainApi.Models.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IfaceMainApi.Models.DTOs.Out;

public class ChangeResponse
{
    public Guid Id { get; set; }
    public AppEntity Entity { get; set; }
    public Guid? RegisterId { get; set; }
    public ChangeOperation Operation { get; set; }
    public Guid PwadId { get; set; }

    public string? NewValue { get; set; }

    [JsonIgnore]
    private static readonly JsonSerializerOptions options = new() {
        WriteIndented = false,
        PropertyNamingPolicy = new CamelCaseFirstLetterLowerNamingPolicy()
    };
    public ChangeResponse() { }

    public ChangeResponse(Change change, object? newValue = null)
    {
        Id = change.Id;
        Entity = change.Entity;
        Operation = change.Operation;
        RegisterId = change.RegisterId;
        PwadId = change.PwadId;
        if(newValue != null)
            NewValue =  JsonSerializer.Serialize(newValue, options);
    }
}
