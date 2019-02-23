using Eventures.Data;
using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.Services.Models.Events;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eventures.Web.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IOrdersService _ordersService;
        private readonly EventuresDbContext _dbCotext;
        private readonly UserManager<User> _userManager;
        private readonly IEventsService _eventsService;

        public OrdersController(IOrdersService ordersService, EventuresDbContext dbCotext, UserManager<User> userManager, IEventsService eventsService)
        {
            this._ordersService = ordersService;
            this._dbCotext = dbCotext;
            this._userManager = userManager;
            this._eventsService = eventsService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderViewModel model)
        {
           
            if (!ModelState.IsValid)
            {
                return this.RedirectToAction(actionName: "All", controllerName: "Events");
            }

            var user = await this._userManager.FindByNameAsync(this.User.Identity.Name);
            var @event = this._eventsService.GetById(model.EventId);

            if (@event.TotalTickets < model.TicketsCount)
            {
                return this.RedirectToAction(actionName: "All", controllerName: "Events");
            }

            var result = this._ordersService.CreateOrder(@event, user, model.TicketsCount);

            if (!result)
            {
                return this.RedirectToAction(actionName: "All", controllerName: "Events");
            }

            return this.RedirectToAction(actionName: "MyEvents", controllerName: "Events");
        }

        public IActionResult All()
        {
            var orders = this._ordersService.All();

            return this.View(orders);
        }
    }
}
