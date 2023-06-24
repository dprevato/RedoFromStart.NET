using System.Collections.ObjectModel;

namespace Model;

public class Area
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime? Ts { get; set; }

    public ObservableCollection<Person> People { get; set; } = new();
    public ObservableCollection<Plant> Plants { get; set; } = new();
    public ObservableCollection<Device> Devices { get; set; } = new();
}
