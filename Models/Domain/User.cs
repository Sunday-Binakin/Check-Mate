namespace Check_Mate_API.Models.Domain;

public class User
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public List<Task>?  Tasks { get; set; } //list of Tasks done
}