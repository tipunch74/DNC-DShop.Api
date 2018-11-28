using System.Threading.Tasks;
using DShop.Api.Messages.Commands.Sales;
using DShop.Common.Mvc;
using DShop.Common.RabbitMq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DShop.Api.Controllers
{
    [AllowAnonymous]
    public class SalesController : BaseController
    {
        public SalesController(IBusPublisher busPublisher) : base(busPublisher)
        {
        }

        [HttpPost("reports/products")]
        public async Task<IActionResult> Post(CreateProductsReport command)
            => await SendAsync(command.BindId(c => c.Id));
    }
}