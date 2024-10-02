using IfaceMainApi.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace IfaceMainApi.Models.Entities
{
    public class Change : EntityBase
    {
        public AppEntity Entity { get; set; }
        public Guid? RegisterId { get; set; }
        public ChangeOperation Operation { get; set; }
        public bool Sync { get; set; } = false;
        public Guid PwadId { get; set; }
        public PersonWithAlzheimerDisease? Pwad { get; set; }

        public Change()
        {
            
        }

    }
}
