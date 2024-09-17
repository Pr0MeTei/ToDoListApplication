using ToDoListApplication.Domain.Enum;

namespace ToDoListApplication.Domain.ViewModels.Task
{
    public class CreateTaskViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Priority Prioriti { get; set; }
    }
}