namespace Model;

public class AppLog
{
    public Guid Id { get; set; }
    public DateTime LogDate { get; set; }
    public string UserName { get; set; }
    public string Class { get; set; }
    public string Method { get; set; }
    public string LogText { get; set; }
}
