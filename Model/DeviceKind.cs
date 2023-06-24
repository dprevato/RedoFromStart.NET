using System.Collections.ObjectModel;

namespace Model;

public class DeviceKind
{
    public string Id { get; set; }
    public string KindName { get; set; }

    public DateTime? Ts { get; set; }

    public ObservableCollection<ChartDefinition> ChartDefinitions { get; set; } = new();
    public ObservableCollection<Device> Devices { get; set; } = new();

}