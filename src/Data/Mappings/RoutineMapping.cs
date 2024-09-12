using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings
{
    public class RoutineMapping : MappingBase<Routine>
    {
        public override void Configure(EntityTypeBuilder<Routine> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.PersonWithAlzheimersDisease)
                .WithMany(x => x.Routines)
                .HasForeignKey(x => x.PersonWithAlzheimersDiseaseId);
        }
    }
}
