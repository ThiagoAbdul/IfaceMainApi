using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings
{
    public class ChangeMapping : MappingBase<Change>
    {
        public override void Configure(EntityTypeBuilder<Change> builder)
        {
            base.Configure(builder);

            builder.ToTable("changes");

        }
    }
}
