namespace Model;

public class Role
{
    public Role() {
        People = new HashSet<Person>();
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public DateTime? Ts { get; set; }

    public ICollection<Person> People { get; set; }
}