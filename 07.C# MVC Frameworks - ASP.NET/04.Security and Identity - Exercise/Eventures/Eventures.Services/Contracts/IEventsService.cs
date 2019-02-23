using Eventures.Models;
using System;
using System.Collections.Generic;

namespace Eventures.Services.Contracts
{
    public interface IEventsService
    {
        ICollection<T> All<T>();

        bool Create(string name, DateTime start, DateTime end, string place, int totalTickets, decimal pricePerTicket);

        Event GetById(string id);
    }
}
