using System;

namespace Taskmaster_Services.Domain.Interfaces;

public interface ITaskService
{
    // Define the methods that the TaskService should implement
    void CreateTask(string taskName, DateTime dueDate);
    void UpdateTask(int taskId, string taskName, DateTime dueDate);
    void DeleteTask(int taskId);
    void GetTask(int taskId);
    void GetAllTasks();
}
