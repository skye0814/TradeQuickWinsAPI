﻿using System.ComponentModel.DataAnnotations;

namespace TradeQuickWinsAPI.WebModel.Request
{
    public class RegisterUserRequest
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Role { get; set; } 
    }
}
