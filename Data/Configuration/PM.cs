using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class PMMap : IEntityTypeConfiguration<PM>
{
    public void Configure(EntityTypeBuilder<PM> e) {
        e.Property(x => x.Id).HasComputedColumnSql("CONCAT(`DeviceId`, `PmId`", true).HasMaxLength(16).ValueGeneratedOnAdd();
        e.HasKey(x => x.Id);

        e.Property(x => x.SettledOn).HasColumnType("DATE").IsRequired(false);
        e.Property(x => x.RemovedOn).HasColumnType("DATE").IsRequired(false);

        e.Property(x => x.SpecialOffset).HasColumnType("DECIMAL(10,4)");
        e.Property(x => x.ShouldReport).HasColumnType("BOOLEAN").HasDefaultValue(true);
        e.Property(x => x.VirtualPm).HasColumnType("BOOLEAN");
        e.Property(x => x.DontValidate).HasColumnType("BOOLEAN");
        //
        e.Property(x => x.AutoImport).HasColumnType("BOOLEAN");
        e.Property(x => x.Selected).HasColumnType("BOOLEAN");
        e.Property(X => X.LastImport).HasColumnType("DATE");
        //
        e.Property(x => x.Ts).IsRowVersion();
        //
        e.HasOne(x => x.Device).WithMany(x => x.Pms).HasForeignKey(x => x.DeviceId).OnDelete(DeleteBehavior.Restrict);
        e.HasOne(x => x.Formula).WithMany(x => x.PMs).HasForeignKey(x => x.FormulaId);
        e.HasOne("Threshold").WithOne("PM").HasForeignKey("Threshold", "PMId").OnDelete(DeleteBehavior.Cascade);
    }
}