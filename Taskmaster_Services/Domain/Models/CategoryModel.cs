using System;
using System.ComponentModel.DataAnnotations;

namespace Taskmaster_Services.Domain.Models;

public class CategoryModel
{
    [Key]
    public required int Category_Id { get; set; }
    public required string CategoryName { get; set; } // e.g., "YouTube", "Blog"
}
