using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class PlantMap : IEntityTypeConfiguration<Plant>
{
    public void Configure(EntityTypeBuilder<Plant> e) {
        e.Property(x => x.Id).HasMaxLength(16);
        e.HasKey(x => x.Id);
        e.Property(x => x.Name).HasMaxLength(64);
        e.Property(x => x.BuiltDate).HasColumnType("DATE");
        e.Property(x => x.DismissedDate).HasColumnType("DATE").IsRequired(false);
        e.Property(x => x.MaxHeight).HasColumnType("DECIMAL(10,4)").IsRequired(false);
        e.Property(x => x.MinHeight).HasColumnType("DECIMAL(10,4)").IsRequired(false);

        e.HasOne(x => x.Area).WithMany(x => x.Plants).HasForeignKey(x => x.AreaId);
    }
}