using System.Collections.ObjectModel;

namespace Model;

public class Area
{
    public Guid Id { get; set; }
    public string Tag { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime? Ts { get; set; }
    public ObservableCollection<Plant> Plants { get; set; } = new();
}
