using AutoMapper;
using Eventures.Data;
using Eventures.Models;
using Eventures.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;


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

        public ICollection<T> All<T>()
        {
            //var events = this._dbContext.Eventd
            //    .Select(e => this.mapper.Map<T>(e))
            //    .ToList();

           

            return null;
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


        public Event GetById(string id)
        {
            var @event = this._dbContext.Eventd.Find(id);

            return @event;
        }
    }
}
