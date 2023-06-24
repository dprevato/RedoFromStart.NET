using System.Security.AccessControl;
using Model.Enums;

namespace Model;

public class StatusHistory
{
    public int Id { get; set; }
    // ReSharper disable once InconsistentNaming
    public string PMId { get; set; }
    public DateTime ChangeDate { get; set; }
    public Status NewStatus { get; set; }
    public string Details { get; set; }
    public DateTime? Ts { get; set; }
}
