
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class ChartMap : IEntityTypeConfiguration<Chart>
{
    public void Configure(EntityTypeBuilder<Chart> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.YAxisTitle).IsRequired(false);
        e.Property(x => x.YMin).IsRequired(false).HasColumnType("NUMERIC(10,4)");
        e.Property(x => x.YMax).IsRequired(false).HasColumnType("NUMERIC(10,4)");
        e.Property(x => x.ShowLegend).HasColumnType("BOOLEAN").HasDefaultValue(false);
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.Definition).WithMany(x => x.Charts).HasForeignKey(x => x.DefId);
    }
}