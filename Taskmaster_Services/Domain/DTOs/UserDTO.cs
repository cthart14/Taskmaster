using System;

namespace Taskmaster_Services.Domain.DTOs;

public class UserDTO
{
    public required string UserName { get; set; }
    public required string Passsword { get; set; }
}
