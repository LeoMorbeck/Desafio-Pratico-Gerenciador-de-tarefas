using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.Register;
public class RegisterTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseRegisteredTaskJson
        {
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            DateLimite = request.DateLimite,
            Status = request.Status,
        };
    }
}
