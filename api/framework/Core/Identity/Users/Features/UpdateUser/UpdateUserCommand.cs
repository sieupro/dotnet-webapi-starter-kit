﻿namespace FSH.Framework.Core.Identity.Users.Features.UpdateUser;
public class UpdateUserCommand
{
    public string Id { get; set; } = default!;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
}
