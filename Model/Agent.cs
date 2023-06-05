namespace Model;
public class Agent
{
    public Guid Id { get; set; }
    public string PersonId { get; set; }            // Questo è un Guid
    public string LoginName { get; set; }
    public string RoleId { get; set; }
    public DateTime? FirstLogOn { get; set; }
    public DateTime? LastLogOn { get; set; }
    public DateTime? Ts { get; set; }

    public Person Person { get; set; }
    public Role Role { get; set; }

    public bool Active() => FirstLogOn != null && LastLogOn == null;
}
