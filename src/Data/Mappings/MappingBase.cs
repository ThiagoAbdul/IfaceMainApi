using IfaceMainApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IfaceMainApi.Data.Mappings
{
    public class MappingBase<T> : IEntityTypeConfiguration<T> where T : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasQueryFilter(x => !x.Deleted);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.UtcNow);
        }
    }
}
