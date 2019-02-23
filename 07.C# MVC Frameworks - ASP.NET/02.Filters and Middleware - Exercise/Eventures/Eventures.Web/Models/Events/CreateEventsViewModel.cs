using System;

namespace Eventures.Web.Models.Events
{
    public class CreateEventsViewModel
    {
        public string Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int TotalTickets { get; set; }

        public decimal PricePerTicket { get; set; }

        public string Place { get; set; }
    }
}
