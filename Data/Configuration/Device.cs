using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class DeviceMap : IEntityTypeConfiguration<Device>
{
    public void Configure(EntityTypeBuilder<Device> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.Id).HasComputedColumnSql("CONCAT(`AreaId`, `PlantId`, `KindId`, `Item`)", true).ValueGeneratedOnAdd();
        e.Property(x => x.PlacedOn).HasColumnType("DATE");
        e.Property(x => x.RemovedOn).HasColumnType("DATE").IsRequired(false);
        e.Property(x => x.VirtualDevice).HasColumnType("BOOLEAN").HasDefaultValue(false);
        e.Property(x => x.ShouldReport).HasColumnType("BOOLEAN").HasDefaultValue(true);
        e.Property(x => x.Validation).HasColumnType("BOOLEAN").HasDefaultValue(true);
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.Kind).WithMany(x => x.Devices).HasForeignKey(x => x.KindId);
        e.HasOne(x => x.Area).WithMany(x => x.Devices).HasForeignKey(x => x.AreaId);
        e.HasOne(x => x.Plant).WithMany(x => x.Devices).HasForeignKey(x => x.PlantId);
    }
}