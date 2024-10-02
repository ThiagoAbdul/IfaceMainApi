using System.Text.Json;

namespace IfaceMainApi.Configurations;

public class CamelCaseFirstLetterLowerNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name)
    {
        if (string.IsNullOrEmpty(name) || !char.IsUpper(name[0]))
            return name;
        char lower = char.ToLower(name[0]);
        return lower + CamelCase.ConvertName(name)[1..];
    }
}
