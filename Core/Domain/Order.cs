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

        public decimal Total        
        {
            get
            {
                var sum = _orderLines.Sum(ol => ol.Price);
                return sum - Discount;
            }
        }

        public decimal Shipping { get { return Total > 500 ? 0 : 125; } }

        public decimal Discount
        {
            get
            {
                var sum = _orderLines.Sum(ol => ol.Price);
                if (sum > 10000m) return sum * 0.1m;
                return 0;
            }
        }

        public void SetStatus(OrderStatus newOrderStatus)
        {
            if (Status == OrderStatus.Shipped && newOrderStatus == OrderStatus.Canceled)
            {
                throw new InvalidStatusChangeException();
            }
            
            if (Status == OrderStatus.ReadyForShipping && newOrderStatus == OrderStatus.Canceled)
            {
                var invoice = new Invoice();
                invoice.AddInvoiceItem(new InvoiceItem { Cost = this.Total * 0.1m});
                Customer.AddInvoice(invoice);
            }
            Status = newOrderStatus;
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            _orderLines.Add(orderLine);
        }
    }
}