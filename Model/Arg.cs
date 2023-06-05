namespace Model;

public class Arg
{
    public Guid Id { get; set; }
    public Guid PMId { get; set; }
    public uint ArgNum { get; set; }
    public double ArgValue { get; set; }
    public DateTime? Ts { get; set; }

    public PM PM { get; set; }
}
