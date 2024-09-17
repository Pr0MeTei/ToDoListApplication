using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoListApplication.Domain.ViewModels.Task;

namespace ToDoListApplication.Controllers
{
    public class TaskController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTaskViewModel model)
        {
            return Ok();
        }
    }
}

