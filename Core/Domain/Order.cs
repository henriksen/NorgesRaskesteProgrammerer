using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Domain
{
    public class Order {
        private readonly Customer _customer;
        private List<OrderLine> _orderLines;

        public Order(Customer customer)
        {
            _customer = customer;
        }

        public OrderStatus Status { get; private set; }

        public Customer Customer
        {
            get { return _customer; }
        }

        public IEnumerable<OrderLine> OrderLines
        {
            get { return _orderLines.AsEnumerable(); }
        }

        public int OrderLineCount
        {
            get { return _orderLines.Count; }
        }

        public decimal Total        
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Shipping { get { throw new NotImplementedException(); } }

        public decimal Discount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetStatus(OrderStatus newOrderStatus)
        {
            throw new NotImplementedException();
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            throw new NotImplementedException();
        }
    }
}