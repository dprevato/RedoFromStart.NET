using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class PlantInfoMap : IEntityTypeConfiguration<PlantInfo>
{
    public void Configure(EntityTypeBuilder<PlantInfo> e) {
        e.Property(x => x.Id).ValueGeneratedOnAdd();
        e.HasKey(x => x.Id);
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.Plant).WithMany(x => x.PlantInfos).HasForeignKey(x => x.PlantId);
    }
}