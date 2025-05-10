using Taskmaster_Services.Domain.Interfaces;

namespace Taskmaster_Services.Domain.Services;

public class TaskService : ITaskService
{
    public void CreateTask(string taskName, DateTime dueDate) { }

    public void DeleteTask(int taskId)
    {
        throw new NotImplementedException();
    }

    public void GetAllTasks()
    {
        throw new NotImplementedException();
    }

    public void GetTask(int taskId)
    {
        throw new NotImplementedException();
    }

    public void UpdateTask(int taskId, string taskName, DateTime dueDate)
    {
        throw new NotImplementedException();
    }
}
