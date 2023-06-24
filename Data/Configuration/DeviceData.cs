using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class DeviceDataMap : IEntityTypeConfiguration<DeviceData>
{
    public void Configure(EntityTypeBuilder<DeviceData> e) {
        e.Property(x => x.Id).ValueGeneratedOnAdd();
        e.HasKey(x => x.Id);

        e.Property(x => x.ItemName).IsRequired(false);
        e.Property(x => x.ItemUnit).IsRequired(false);
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.Device).WithMany(x => x.DeviceData).HasForeignKey(x => x.DeviceId);
    }
}