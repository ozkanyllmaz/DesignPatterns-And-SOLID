using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.GoodCode
{
    public class OrderProcessor
    {
        private readonly Order _order;
        private readonly OrderValidate _orderValidate;
        private readonly OrderSave _orderSave;
        private readonly OrderNotification _orderNotification;

        public OrderProcessor(OrderValidate orderValidate, OrderSave orderSave, OrderNotification orderNotification, Order order)
        {
            _orderValidate = orderValidate;
            _orderSave = orderSave;
            _orderNotification = orderNotification;
            _order = order;
        }

        public void Process()
        {
            _orderValidate.ValidateOrder(_order);
            _orderSave.OrderSaveToDatabase(_order);
            _orderNotification.SendNotification(_order);
        }
    }
}
