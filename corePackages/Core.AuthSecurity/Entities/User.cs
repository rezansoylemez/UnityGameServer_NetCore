﻿using Core.Persistence.Models;

namespace Core.AuthSecurity.Entities;
public class User:Entity
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte[]? PasswordSalt { get; set; }
    public byte[]? PasswordHash { get; set; }
    
}
