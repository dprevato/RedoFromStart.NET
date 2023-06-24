using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class JournalMap : IEntityTypeConfiguration<Journal>
{
    public void Configure(EntityTypeBuilder<Journal> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.EntryDate).HasColumnType("TIMESTAMP");
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.Plant).WithMany(x => x.Journal).HasForeignKey(x => x.PlantId);
    }
}