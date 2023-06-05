namespace Model;

public class Journal
{
    public Guid PlantId { get; set; }
    public uint Id { get; set; }
    public DateTime EntryDate { get; set; }
    public string EntryText { get; set; }
    public DateTime? Ts { get; set; }

    public Plant Plant { get; set; }
}