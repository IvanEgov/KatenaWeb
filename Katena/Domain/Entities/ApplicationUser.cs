using Microsoft.AspNetCore.Identity;
using System;

namespace Katena.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirmId { get; set; }
        public virtual Firm? Firm { get; set; }

        public string UserRole { get; set; } = "Employee";

        // Добавляем дату создания
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}