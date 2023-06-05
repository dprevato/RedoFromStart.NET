using System.Collections.ObjectModel;

namespace Model;
public class Formula
{
    public int Id { get; set; }
    public string FormulaText { get; set; }
    public int? ArgCount { get; set; }
    public DateTime? Ts { get; set; }

    public ObservableCollection<PM> PMs { get; set; }
}
