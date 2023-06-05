namespace Model;

public class DeviceKind
{
    public string Id { get; set; }
    public string KindName { get; set; }

    public DateTime? Ts { get; set; }

    public ICollection<ChartDefinition> ChartDefinitions { get; set; }
    public ICollection<Device> Devices { get; set; }

    public DeviceKind() {
        ChartDefinitions = new HashSet<ChartDefinition>();
        Devices = new HashSet<Device>();
    }
}