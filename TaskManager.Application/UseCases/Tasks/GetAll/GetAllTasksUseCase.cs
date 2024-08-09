using TaskManager.Communication.Enums;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskjson> 
            { 
                new ResponseShortTaskjson 
                {
                    Name = "Louça",
                    Description = "Lavar a louça",
                    Priority = TaskPriority.Média,
                    DateLimite = DateTime.UtcNow,
                    Status = StatusProgress.Concluída,
                }
            }
        };
    }

}
