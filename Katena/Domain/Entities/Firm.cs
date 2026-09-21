using System.Collections.Generic;

namespace Katena.Domain.Entities
{
    public class Firm
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty; // Название юридической фирмы

        // Связь: у одной фирмы много пользователей
        public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();

        // Связь: у одной фирмы много результатов тестов
        public virtual ICollection<TestResult> TestResults { get; set; } = new List<TestResult>();
    }
}