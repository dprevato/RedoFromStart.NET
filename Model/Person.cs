namespace Model;

public class Person
{
    public string Id { get; set; } // Matricola
    public string LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? FirstName { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime? QuitDate { get; set; }
    public string RoleId { get; set; }

    public string AreaId { get; set; }
    public DateTime? Ts { get; set; }

    public Area Area { get; set; }
    public Role Role { get; set; }

    public ICollection<Agent> Agents { get; set; }
    public ICollection<PersonPlant> PlantPeople { get; set; }
}