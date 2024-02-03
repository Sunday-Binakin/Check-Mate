namespace Check_Mate_API.Models.Domain;

public class Project
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<Task>? Tasks { get; set; }// list of associated task
}