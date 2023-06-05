namespace Model;
public class Plot
{
    public Guid Id { get; set; }
    public Guid ChartId { get; set; }
    public int PlotType { get; set; }   // tipo di curva - 0 = Istogramma, 1 = curva
    public string? PlotColor { get; set; }
    public string? PlotLabel { get; set; }
    public bool? ShowDataPoints { get; set; }
    public string DataSrc { get; set; }
    public DateTime? Ts { get; set; }

    public Chart Chart { get; set; }
}
