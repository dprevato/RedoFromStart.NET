using System.Collections.ObjectModel;

namespace Model;
public class Chart
{
    public Guid Id { get; set; }
    public Guid DefId { get; set; }
    public string ChartTitle { get; set; }
    public string? YAxisTitle { get; set; }
    public double? YMin { get; set; }
    public double? YMax { get; set; }
    public bool ShowLegend { get; set; }    // Prima era ulong; ma che significato aveva? Boh...
    public string Owner { get; set; }       // Può essere diverso da quello della definizione
    public DateTime? Ts { get; set; }

    public ChartDefinition Definition { get; set; }
    public ObservableCollection<ChartNote> Notes { get; set; }
    public ObservableCollection<Plot> Plots { get; set; }
}
