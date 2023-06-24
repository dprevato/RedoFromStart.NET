namespace Model;

public class Journal
{
    public int Id { get; set; }
    public string PlantId { get; set; }
    public DateTime EntryDate { get; set; }
    public string EntryText { get; set; }
    public DateTime? Ts { get; set; }

    public Plant Plant { get; set; }
}