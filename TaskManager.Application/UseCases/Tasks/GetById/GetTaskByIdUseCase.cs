using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int Id)
    {
        return new ResponseTaskJson 
        { 
            Id = Id, 
            Name = "Limpar", 
            Description = "Limpar a casa", 
            Priority = Communication.Enums.TaskPriority.Alta, 
            DateLimite = DateTime.UtcNow, 
            Status = Communication.Enums.StatusProgress.Concluída 
        };

    }
}
