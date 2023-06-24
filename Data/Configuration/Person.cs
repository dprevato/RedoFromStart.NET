using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class PersonMap : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> e) {
        e.Property(x => x.Id).HasMaxLength(16);
        e.HasKey(x => x.Id);
        e.HasIndex(x => new { x.LastName, x.MiddleName, x.FirstName }, "Person_idx").IsUnique(false);
        e.Property(x => x.HireDate).HasColumnType("DATE");
        e.Property(x => x.QuitDate).HasColumnType("DATE").IsRequired(false);
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.Area).WithMany(x => x.People).HasForeignKey(x => x.AreaId);

    }
}