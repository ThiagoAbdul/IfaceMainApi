using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings
{
    public class PhotoMapping : MappingBase<Photo>
    {
        public override void Configure(EntityTypeBuilder<Photo> builder)
        {
            base.Configure(builder);

            builder.ToTable("photos");

            builder.HasOne(x => x.KnownPerson)
                .WithMany(x => x.Photos)
                .HasForeignKey(x => x.KnownPersonId);
        }
    }
}
