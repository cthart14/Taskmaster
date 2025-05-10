using System;

namespace Taskmaster_Services.Domain.DTOs;

public class TaskSearchDTO
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; } // completed, in-progress, etc.
    public string? Category { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? CreatedDate { get; set; }
}
