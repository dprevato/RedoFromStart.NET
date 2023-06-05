// ReSharper disable InconsistentNaming
namespace Model;

public class Reading
{
    public Guid PMId { get; set; }
    public Guid Id { get; set; }

    public DateTime ScanDate { get; set; }
    public string? Tag { get; set; }
    public double Value { get; set; }
    public DateTime AcquisitionDate { get; set; }
    public DateTime? ValidationDate { get; set; }
    public DateTime? Ts { get; set; }

    public PM PM { get; set; }
}
