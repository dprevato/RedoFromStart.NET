// ReSharper disable InconsistentNaming
namespace Model;

/// <summary>
/// La classe ReadingCache non è collegata con chiave esterna a PM, perché nei file di importazione non c'è alcun Guid. L'unico
/// discriminante è il codice PM, attraverso il quale si può recuperare l'Id del PM.
/// </summary>
public class ReadingCache
{
    public string PMId { get; set; }
    public DateTime ReadingDateTime { get; set; }
    public string? Tag { get; set; }
    public decimal? ReadingValue { get; set; }
    public DateTime AcquisitionDate { get; set; }
}
