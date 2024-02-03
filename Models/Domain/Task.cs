namespace Check_Mate_API.Models.Domain;

public class Task
{
    public Guid Id { get; set; }
    public string?  Title { get; set; }
    public string?  Description { get; set; }
    public DateTime  DueDate { get; set; }
    public List<Priority>?  Priority { get; set; }
    public List<Status>?  Status { get; set; }
}