using Eventures.Services.Contracts;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace Eventures.Web.Filters
{
    public class LogUserActivityActionFilter : ActionFilterAttribute
    {
        private readonly IEventsService eventsService;
        private readonly ILogger<LogUserActivityActionFilter> logger;

        public LogUserActivityActionFilter(IEventsService eventsService, ILogger<LogUserActivityActionFilter> logger)
        {
            this.eventsService = eventsService;
            this.logger = logger;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var userName = context.HttpContext.User.Identity.Name;
            var eventureEvent = this.eventsService.All().FirstOrDefault();
            var eventName = eventureEvent.Name;
            var eventStart = eventureEvent.Start;
            var eventureEnd = eventureEvent.End;
            var logMessage = $"[{DateTime.Now}] User {userName} viewed event {eventName} ( {eventStart} / {eventureEnd} )";
            logger.LogInformation(logMessage);
      
            base.OnActionExecuted(context);
        }
    }
}
