using GeneralLabSolutions.Domain.Notigfications;
using Microsoft.AspNetCore.Mvc;
using velzon.Models;

namespace VelzonModerna.Controllers.Base
{
    public abstract class MainController : Controller
    {
        private readonly INotificador _notificador;

        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }

    }
}
