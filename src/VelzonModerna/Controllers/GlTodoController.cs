using Microsoft.AspNetCore.Mvc;

namespace VelzonModerna.Controllers
{
    public class GlTodoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return await Task.FromResult(View());
        }
    }
}
