using Microsoft.AspNetCore.Mvc;

namespace VelzonModerna.Controllers
{
    public class HistoricoDePedidoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return await Task.FromResult(View());
        }
    }
}
