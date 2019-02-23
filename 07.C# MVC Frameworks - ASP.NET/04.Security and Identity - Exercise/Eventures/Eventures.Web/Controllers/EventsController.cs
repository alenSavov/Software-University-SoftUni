using Eventures.Data;
using Eventures.Services.Contracts;
using Eventures.Web.Filters;
using Eventures.Web.Models.Events;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Eventures.Web.Controllers
{
    [Authorize]
    public class EventsController : Controller
    {
        private readonly IEventsService _eventsService;
        private readonly IOrdersService _ordersService;
        private readonly ILogger<EventsController> _logger;
        private readonly EventuresDbContext _dbContext;

        public EventsController(IEventsService eventsService, IOrdersService ordersService, ILogger<EventsController> logger, EventuresDbContext dbContext)
        {
            this._eventsService = eventsService;
            this._ordersService = ordersService;
            this._logger = logger;
            this._dbContext = dbContext;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return this.View();
        }

        [ServiceFilter(typeof(EventsCreateLogActionFilter))]
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(CreateEventsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            var result = this._eventsService.Create(model.Name, model.Start, model.End, model.Place, model.TotalTickets, model.PricePerTicket);

            if (!result)
            {
                return this.View(model);
            }

            this._logger.LogInformation($"Event created: {model.Name}", model);

            return this.RedirectToAction(nameof(All));            
        }
        
        public IActionResult All()
        {
            var events = this._dbContext.Eventd
                .Select(e => new AllEventsViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start,
                    End = e.End,
                    Place = e.Place
                }).ToList();


            //var events = this._eventsService
            //   .All<CreateEventsViewModel>()
            //   .OrderBy(e => e.Start)
            //   .ToList();                       

            return this.View(events);
        }
        
        public IActionResult MyEvents()
        {
            var events = this._dbContext
                        .Orders.Where(o => o.Customer.UserName == this.User.Identity.Name)
                        .Select(o => new EventWithTicketsCountViewModel
                                {
                                    Name = o.EventureEvent.Name,
                                    TicketsCount = o.TicketCount,
                                    Start = o.EventureEvent.Start,
                                    End = o.EventureEvent.End
                                }).ToList();

            return this.View(events);

            //var username = this.User.Identity.Name;
            //var orders = this._ordersService.AllByUser<AllEventsViewModel>(username);

            //return this.View(orders);
        }
    }
}
