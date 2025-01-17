﻿using System;
using System.Collections.Generic;
using System.Text;
using TDKRSports.CoreBusiness.Models;

namespace TDKRSports.UseCases.PluginInterfaces.DataStore
{
    public interface IOrderRepository
    {
        Order GetOrder(int id);
        Order GetOrderByUniqueId(string uniqueId);
        int CreateOrder(Order order);
        void UpdateOrder(Order order);
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOutstandingOrders();
        IEnumerable<Order> GetProcessedOrders();

        IEnumerable<OrderLineItem> GetLineItemsByOrderId(int orderId);
    }
}
