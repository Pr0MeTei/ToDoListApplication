using ToDoListApplication.Domain.Enum;

namespace ToDoListApplication.Domain.Entity
{
    public class TaskEntity
    {
        public long ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Priority Prioriti { get; set; }
    }
}