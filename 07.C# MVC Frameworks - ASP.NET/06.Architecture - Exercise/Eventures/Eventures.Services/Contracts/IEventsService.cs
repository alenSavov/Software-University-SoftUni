using Eventures.Models;
using Eventures.Services.Models.Events;
using Eventures.Web.Models.Events;
using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace Eventures.Services.Contracts
{
    public interface IEventsService
    {
        ICollection<AllEventsViewModel> All();

        bool Create(string name, DateTime start, DateTime end, string place, int totalTickets, decimal pricePerTicket);

        Event GetById(string id);

        ICollection<EventWithTicketsCountViewModel> MyEvents(IIdentity identity);
    }
}
