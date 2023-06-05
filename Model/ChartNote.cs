namespace Model;
public class ChartNote
{
    public Guid Id { get; set; }
    public Guid ChartId { get; set; }
    public DateTime? Xpos { get; set; }
    public double? Ypos { get; set; }
    public string NoteColor { get; set; }
    public string? NoteText { get; set; }
    public byte TextAlignment { get; set; }

    public Chart Chart { get; set; }
}
