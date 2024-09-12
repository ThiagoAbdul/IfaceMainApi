using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class KnownPersonMapping : MappingBase<KnownPerson>
{
    public override void Configure(EntityTypeBuilder<KnownPerson> builder)
    {
        base.Configure(builder);

        builder.ToTable("known_persons");

        builder.HasOne(x => x.Person)
                .WithOne()
                .HasForeignKey<KnownPerson>(x => x.PersonId);

        builder.HasOne(x => x.PersonWithAlzheimersDisease)
                .WithMany(x => x.KnownPersons)
                .HasForeignKey(x => x.PersonWithAlzheimersDiseaseId);

        builder.HasMany(x => x.Photos)
                .WithOne(x => x.KnownPerson)
                .HasForeignKey(x => x.KnownPersonId);
    }
}
