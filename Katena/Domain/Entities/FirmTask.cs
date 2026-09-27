using System;
using System.Collections.Generic;

namespace Katena.Domain.Entities
{
    public class FirmTask
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;       // Название задачи
        public string Description { get; set; } = string.Empty; // Описание
        public DateTime Deadline { get; set; }                  // Срок выполнения (для таймера)
        public string Status { get; set; } = "Новая";           // Новая, В работе, Выполнена

        public string FirmId { get; set; } = string.Empty;
        public virtual Firm? Firm { get; set; }

        public string CreatorId { get; set; } = string.Empty;   // ID директора, создавшего задачу
        public virtual ApplicationUser? Creator { get; set; }

        // Список сотрудников, назначенных на эту задачу
        public virtual ICollection<TaskAssignee> Assignees { get; set; } = new List<TaskAssignee>();
    }
}