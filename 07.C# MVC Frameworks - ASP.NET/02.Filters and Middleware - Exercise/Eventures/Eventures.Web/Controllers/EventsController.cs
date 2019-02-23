using Eventures.Services.Contracts;
using Eventures.Web.Filters;
using Eventures.Web.Models.Events;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Eventures.Web.Controllers
{
    [Authorize]    
    public class EventsController : Controller
    {
        private readonly IEventsService eventsService;

        public EventsController(IEventsService eventsService)
        {
            this.eventsService = eventsService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(CreateEventsViewModel model)
        {
            var evenetModel = this.eventsService.Create(
                 model.Name,
                 model.Start,
                 model.End,
                 model.Place,
                 model.TotalTickets,
                 model.PricePerTicket);

            return this.RedirectToAction(nameof(All), "Events");
        }

        [ServiceFilter(typeof(LogUserActivityActionFilter))]
        public IActionResult All()
        {
            var events = this.eventsService
               .All()
               .OrderBy(e => e.Start)
               .ToList();

            var eventsModelCollection = new AllEventsCollectionViewModel
            {
                Events = events
            };

            return this.View(eventsModelCollection);
        }
    }
}
