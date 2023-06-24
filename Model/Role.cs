using System.Collections.ObjectModel;

namespace Model;

public class Role
{
    public string Id { get; set; }
    public string Name { get; set; }
    public DateTime? Ts { get; set; }

    public ObservableCollection<PersonPlant> Roles { get; set; }
}