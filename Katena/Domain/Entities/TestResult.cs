using System;

namespace Katena.Domain.Entities
{
    public class TestResult
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string UserId { get; set; } = string.Empty;
        public virtual ApplicationUser? User { get; set; }

        public string FirmId { get; set; } = string.Empty;
        public virtual Firm? Firm { get; set; }

        public DateTime TestDate { get; set; } = DateTime.UtcNow;

        // Результаты вашего теста PAEI
        public string? StyleResult { get; set; } // Например: "Производитель"
        public string? TypeResult { get; set; }  // Например: "Наставник"

        // Можно хранить детальные баллы в виде JSON-строки для будущего анализа
        public string? DetailedScoresJson { get; set; }
    }
}