using System;

namespace Taskmaster_Services.Domain.DTOs;

public class TaskReadDTO
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public string? Status { get; set; } // completed, in-progress, etc.
    public string? Category { get; set; } // e.g., "YouTube", "Blog"
    public string? Description { get; set; }
    public required DateTime CreatedAt { get; set; }
    public DateTime? DueDate { get; set; }
}
