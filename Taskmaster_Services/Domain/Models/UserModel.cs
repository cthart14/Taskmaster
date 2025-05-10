using System;
using System.ComponentModel.DataAnnotations;

namespace Taskmaster_Services.Domain.Models;

public class UserModel
{
    [Key]
    public required int User_Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public required DateTime CreatedDate { get; set; }
    public int? PhoneNumber { get; set; }
}
