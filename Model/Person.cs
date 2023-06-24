using System.Collections.ObjectModel;

namespace Model;

public class Person
{
    public string Id { get; set; }                  // Matricola
    public string Title { get; set; }   
    public string LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? FirstName { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime? QuitDate { get; set; }

    public string AreaId { get; set; }
    public DateTime? Ts { get; set; }

    public Area Area { get; set; }

    public ObservableCollection<Agent> Agents { get; set; } = new();
    public ObservableCollection<PersonPlant> PlantPeople { get; set; } = new();
}