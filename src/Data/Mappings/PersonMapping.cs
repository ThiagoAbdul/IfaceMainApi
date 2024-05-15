using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings;
public class PersonMapping : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("persons");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.MainPhone).WithOne().HasForeignKey<Person>(x => x.MainPhoneId);
        builder.HasOne(x => x.SecondaryPhone).WithOne().HasForeignKey<Person>(x => x.SecondaryPhoneId);
        builder.HasOne(x => x.MainAddress).WithOne().HasForeignKey<Person>(x => x.MainAddressId);
        builder.HasOne(x => x.SecondaryAddress).WithOne().HasForeignKey<Person>(x => x.SecondaryAddressId);
        
    }
}
