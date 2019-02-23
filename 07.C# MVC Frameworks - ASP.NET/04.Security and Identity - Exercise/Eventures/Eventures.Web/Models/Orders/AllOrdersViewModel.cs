using System;
using System.Globalization;

namespace Eventures.Web.Models.Orders
{
    public class AllOrdersViewModel
    {
        public string EventName { get; set; }

        public string CustomerName { get; set; }

        public DateTime OrderedOn { get; set; }

        public string OrderedOnStr => this.OrderedOn.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture);
    }
}
