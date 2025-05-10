using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Taskmaster_Services.Domain.Models;

public class TaskModel
{
    [Key]
    public int Task_Id { get; set; }

    [ForeignKey("UserModel")]
    public int User_Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DueDate { get; set; }
    public string? Status { get; set; } // in-progress, completed, etc.
    public string? Category { get; set; } // e.g., "YouTube", "Blog"
    public required string Type { get; set; } // idea, todo
}
