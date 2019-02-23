using Eventures.Models;
using System.Collections.Generic;

namespace Eventures.Web.Models.Events
{
    public class AllEventsCollectionViewModel
    {
        public ICollection<Event> Events { get; set; }
    }
}
