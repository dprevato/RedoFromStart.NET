using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class StatusHistoryMap : IEntityTypeConfiguration<StatusHistory>
{
    public void Configure(EntityTypeBuilder<StatusHistory> e) {
        e.Property(x => x.Id).ValueGeneratedOnAdd();
        e.HasKey(x => x.Id);
        e.Property(x => x.ChangeDate).HasColumnType("DATE");
        e.Property(x => x.Details).HasColumnType("TEXT");
        e.Property(x => x.Ts).IsRowVersion();
    }
}