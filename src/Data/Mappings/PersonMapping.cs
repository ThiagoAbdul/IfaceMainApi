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
        builder.HasOne(x => x.MainPhoneNumber).WithOne().HasForeignKey<Person>(x => x.MainPhoneId);
        
    }
}
