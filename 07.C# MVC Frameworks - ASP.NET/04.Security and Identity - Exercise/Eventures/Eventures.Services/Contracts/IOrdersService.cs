using Eventures.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Eventures.Services.Contracts
{
    public interface IOrdersService
    {
        bool CreateOrder(Event eventureEvent, User customer, int ticketCount);

        ICollection All();

        ICollection AllByUser(string username);
    }
}
