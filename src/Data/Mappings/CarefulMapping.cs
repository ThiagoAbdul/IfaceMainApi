using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings
{
    public class CarefulMapping : MappingBase<Careful>
    {
        public override void Configure(EntityTypeBuilder<Careful> builder)
        {
            base.Configure(builder);

            builder.HasIndex(e => new { e.PwadId, e.CaregiverId }).IsUnique();

            builder.HasOne(e => e.Caregiver)
                .WithMany(x => x.Carefuls)
                .HasForeignKey(e => e.CaregiverId);

            builder.HasOne(e => e.Pwad)
            .WithMany(x => x.Carefuls)
            .HasForeignKey(e => e.PwadId);
        }
    }
}
