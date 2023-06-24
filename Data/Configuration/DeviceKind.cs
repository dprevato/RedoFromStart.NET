using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class DeviceKindMap : IEntityTypeConfiguration<DeviceKind>
{
    public void Configure(EntityTypeBuilder<DeviceKind> e) {
        e.Property(x => x.Id).HasMaxLength(16);
        e.HasKey(x => x.Id);
        e.Property(x => x.Ts).IsRowVersion();

    }
}