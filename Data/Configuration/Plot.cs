using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data.Configuration;
public class PlotMap : IEntityTypeConfiguration<Plot>
{
    public void Configure(EntityTypeBuilder<Plot> e) {
        e.Property(x => x.Id).ValueGeneratedOnAdd();
        e.HasKey(x => x.Id);
        e.Property(x => x.ShowDataPoints).HasColumnType("BOOLEAN").HasDefaultValue(false);
        e.Property(x => x.DataSrc).IsRequired(false);
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.Chart).WithMany(x => x.Plots).HasForeignKey(x => x.ChartId);
    }
}