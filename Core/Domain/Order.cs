namespace Core.Domain
{
    public class Order {
        private readonly Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
        }

        public OrderStatus Status { get; private set; }

        public Customer Customer
        {
            get { return _customer; }
        }

        public int OrderLineCount
        {
            get { throw new System.NotImplementedException(); }
        }

        public void SetStatus(OrderStatus canceled)
        {
        }

        public void AddOrderLine(Product product)
        {
        }
    }
}