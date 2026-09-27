namespace Katena.Domain.Entities
{
    public class TaskAssignee
    {
        public Guid TaskId { get; set; }
        public virtual FirmTask? Task { get; set; }

        public string UserId { get; set; } = string.Empty;
        public virtual ApplicationUser? User { get; set; }

        public string Status { get; set; } = "Ожидает"; // Ожидает, В работе, Выполнено
    }
}