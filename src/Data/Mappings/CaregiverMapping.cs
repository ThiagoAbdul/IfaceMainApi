using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class CaregiverMapping : MappingBase<Caregiver>
{
    public override void Configure(EntityTypeBuilder<Caregiver> builder)
    {
        base.Configure(builder);
        builder.ToTable("caregivers");
        builder.HasIndex(x => x.AuthId);
        builder.HasOne(x => x.Person).WithOne().HasForeignKey<Caregiver>(x => x.PersonId);
        builder.HasMany(x => x.Carefuls).WithOne(x => x.Caregiver);
    }
}
