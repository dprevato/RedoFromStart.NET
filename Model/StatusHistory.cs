using System.Security.AccessControl;
using Model.Enums;

namespace Model;

public class StatusHistory
{
    public Guid Id { get; set; }
    // ReSharper disable once InconsistentNaming
    public Guid PMId { get; set; }
    public DateTime ChangeDate { get; set; }
    public Status NewStatus { get; set; }
    public string Details { get; set; }
    public DateTime? Ts { get; set; }
}
