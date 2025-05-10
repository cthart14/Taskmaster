using System;

namespace Taskmaster_Services.Domain.DTOs;

public class TaskCreateDTO
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; } // completed, in-progress, etc.
    public string? Tag { get; set; } // e.g., "YouTube"
    public DateTime? DueDate { get; set; }
    public required string Type { get; set; } // e.g., "Idea", "To-Do"
}
