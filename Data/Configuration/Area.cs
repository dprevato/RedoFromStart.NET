using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class AreaMap : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> e) {
        e.Property(x => x.Id).HasMaxLength(2);
        e.HasKey(x => x.Id);
        e.Property(x => x.Ts).IsRowVersion();

        e.HasMany(x => x.Plants).WithOne(x => x.Area).HasForeignKey(x => x.AreaId);
    }
}