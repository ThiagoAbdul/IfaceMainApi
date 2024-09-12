using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class PersonWithAlzheimersDiseaseMapping : MappingBase<PersonWithAlzheimerDisease>
{
    public override void Configure(EntityTypeBuilder<PersonWithAlzheimerDisease> builder)
    {
        base.Configure(builder);

        builder.ToTable("persons_with_alzheimer_disease");

        builder.HasOne(x => x.Person)
                .WithOne().HasForeignKey<PersonWithAlzheimerDisease>(x => x.PersonId);

        builder.HasOne(x => x.MainCaregiver)
            .WithMany()
            .HasForeignKey(x => x.MainCaregiverId);

        builder.HasMany(x => x.Carefuls).WithOne(x => x.Pwad);

    }
}
