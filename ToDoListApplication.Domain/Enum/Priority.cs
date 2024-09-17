using System.ComponentModel.DataAnnotations;

namespace ToDoListApplication.Domain.Enum
{
    public enum Priority
    {
        [Display(Name = "Простая")]
        Easy = 1,
        [Display(Name = "Важная")]
        Medium = 2,
        [Display(Name = "Срочная")]
        Hard = 3
    }
}