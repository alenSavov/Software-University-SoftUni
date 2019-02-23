using Eventures.Data;
using Eventures.Models;
using Eventures.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Services
{
    public class EventsService : IEventsService
    {
        private readonly EventuresDbContext _dbContext;


        public EventsService(EventuresDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public ICollection<Event> All()
        {
            var events = this._dbContext.Eventd
                .ToList();

            return events;
        }

        public bool Create(string name, DateTime start, DateTime end, string place ,int totalTickets, decimal pricePerTicket)
        {
            if (name == null ||
               start == null ||
               end == null ||
               totalTickets == 0 ||
               pricePerTicket == 0 ||
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
    }
}
