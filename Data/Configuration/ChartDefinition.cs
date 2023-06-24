using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class ChartDefinitionMap : IEntityTypeConfiguration<ChartDefinition>
{
    public void Configure(EntityTypeBuilder<ChartDefinition> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.Tag).HasComputedColumnSql("CONCAT(`PlantId`, `KindId`)", true).ValueGeneratedOnAdd();
        e.Property(x => x.Owner).HasColumnName("DefOwner");
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.Plant).WithMany(x => x.ChartDefinitions).HasForeignKey(x => x.PlantId);
        e.HasOne(x => x.Kind).WithMany(x => x.ChartDefinitions).HasForeignKey(x => x.KindId);
    }
}