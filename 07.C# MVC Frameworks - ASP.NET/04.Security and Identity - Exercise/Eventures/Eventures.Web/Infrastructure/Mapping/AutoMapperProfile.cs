using System;
using System.Linq;
using AutoMapper;
using Eventures.Models;
using Eventures.Web.Models.Events;
using Eventures.Web.Models.Orders;

namespace Eventures.Web.Infrastructure.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Event, CreateEventsViewModel>();
            CreateMap<Order, AllOrdersViewModel>();
        }
    }
}
