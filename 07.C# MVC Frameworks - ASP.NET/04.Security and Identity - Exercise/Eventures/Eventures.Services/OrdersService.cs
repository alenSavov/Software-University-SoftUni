﻿using AutoMapper;
using Eventures.Data;
using Eventures.Models;
using Eventures.Services.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Eventures.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly EventuresDbContext _dbContext;
        private readonly IMapper _mapper;

        public OrdersService(EventuresDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public bool CreateOrder(Event eventureEvent, User user, int ticketCount)
        {
            if (eventureEvent == null || user == null || ticketCount <= 0)
            {
                return false;
            }

            var model = new Order
            {
                Customer = user,
                EventureEvent = eventureEvent,
                TicketCount = ticketCount,
                OrderedOn = DateTime.UtcNow
            };

            eventureEvent.TotalTickets -= ticketCount;

            var eventOrderModel = this._dbContext.Orders.Add(model);

            if (eventOrderModel == null)
            {
                return false;
            }

            _dbContext.SaveChanges();

            return true;
        }

        public ICollection All()
        {
            //var orders = this._dbContext.Orders
            //    .Select(o => this._mapper.Map<Order>(o))
            //    .ToList();

            return null;
        }

        public ICollection AllByUser(string username)
        {
            var orders = this._dbContext.Orders
                .Where(o => o.Customer.UserName == username)
                .ToList();

            return orders;
        }

    }
}
