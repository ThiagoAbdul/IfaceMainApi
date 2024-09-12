using IfaceMainApi.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace IfaceMainApi.Models.Entities
{
    public class Change : EntityBase
    {
        public string EntityName { get; set; } = string.Empty;
        public Guid? RegisterId { get; set; }
        public ChangeOperation Operation { get; set; }
        public bool Sync { get; set; } = false;

        public Change()
        {
            
        }

    }
}
