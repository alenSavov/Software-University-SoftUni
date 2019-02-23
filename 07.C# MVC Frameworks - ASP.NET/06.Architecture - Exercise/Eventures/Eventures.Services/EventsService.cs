using AutoMapper;
using Eventures.Data;
using Eventures.Mapping;
using Eventures.Models;
using Eventures.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using Eventures.Services.Models.Events;
using Eventures.Web.Models.Events;
using System.Security.Principal;

namespace Eventures.Services
{
    public class EventsService : IEventsService
    {
        private readonly EventuresDbContext _dbContext;
        private readonly IMapper mapper;

        public EventsService(EventuresDbContext dbContext, IMapper autoMapper)
        {
            this._dbContext = dbContext;
            this.mapper = autoMapper;
        }

        public bool Create(string name, DateTime start, DateTime end, string place, int totalTickets, decimal pricePerTicket)
        {
            if (name == null ||
               start == null ||
               end == null ||
               totalTickets <= 0 ||
               pricePerTicket <= 0 ||
               place == null)
                return false;

            var model = new Event
            {
                Name = name,
                Start = start,
                End = end,
                TotalTickets = totalTickets,
                PricePerTicket = pricePerTicket,
                Place = place
            };

            var eventModelResult = this._dbContext.Eventd.Add(model);

            if (eventModelResult == null)
            {
                return false;
            }

            _dbContext.SaveChanges();

            return true;
        }

        public ICollection<AllEventsViewModel> All()
        {
            var events = this._dbContext.Eventd
                .To<AllEventsViewModel>()
                .ToList();

            return events;
        }

        public ICollection<EventWithTicketsCountViewModel> MyEvents(IIdentity identity)
        {
            var events = this._dbContext
                  .Orders
                  .Where(o => o.Customer.UserName == identity.Name)
                  .To<EventWithTicketsCountViewModel>()
                  .ToList();

            return events;
        }

        public Event GetById(string id)
        {
            var @event = this._dbContext.Eventd.Find(id);

            return @event;
        }
    }
}
