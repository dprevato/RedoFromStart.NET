using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data;
public class PersonPlantMap : IEntityTypeConfiguration<PersonPlant>
{
    public void Configure(EntityTypeBuilder<PersonPlant> e) {
        e.Property(x => x.PlantId).HasMaxLength(16);
        e.Property(x => x.PersonId).HasMaxLength(16);
        e.Property(x => x.RoleId).HasMaxLength(16);
        e.HasKey(x => new { x.PlantId, x.PersonId, x.RoleId, x.SettledOn });

        e.Property(x => x.SettledOn).HasColumnType("DATE");
        e.Property(x => x.RelievedOn).HasColumnType("DATE").IsRequired(false);
        e.Property(x => x.Ts).IsRowVersion();

        e.HasOne(x => x.Plant).WithMany(x => x.PersonPlants).HasForeignKey(x => x.PlantId);
        e.HasOne(x => x.Person).WithMany(x => x.PlantPeople).HasForeignKey(x => x.PersonId);
        e.HasOne(x => x.Role).WithMany(x => x.Roles).HasForeignKey(x => x.RoleId);
    }
}