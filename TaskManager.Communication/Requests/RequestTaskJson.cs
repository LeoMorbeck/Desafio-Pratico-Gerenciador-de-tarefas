using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;
public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public DateTime DateLimite { get; set; }
    public StatusProgress Status { get; set; }
}
