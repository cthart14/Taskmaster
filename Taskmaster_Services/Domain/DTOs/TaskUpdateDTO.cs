using System;

namespace Taskmaster_Services.Domain.DTOs;

public class TaskUpdateDTO
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public DateTime? DueDate { get; set; }
    public string? Type { get; set; } // e.g., "Idea", "To-Do"
    public string? Category { get; set; } // e.g., "YouTube", "Blog"
    public required DateTime UpdatedDate { get; set; } // Optional, for tracking when the task was updated
}
