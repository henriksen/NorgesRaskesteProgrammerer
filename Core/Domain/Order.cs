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
            _orderLines = new List<OrderLine>();
        }

        public Order()
        {
            _orderLines = new List<OrderLine>();
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

        public void SetStatus(OrderStatus canceled)
        {
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            _orderLines.Add(orderLine);
        }
    }
}