using System.Linq;
using Core;
using Core.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Order_being_canceled
    {
        [Test]    
        public void Order_is_not_picked_Then_it_should_be_canceled()
        {
            var order = new Order(null);

            order.SetStatus(OrderStatus.Canceled);

            order.Status.Should().Be(OrderStatus.Canceled);
        }

        public void Order_is_ready_for_shipping_Then_it_should_be_canceled()
        {
            var order = new Order(null);
            order.SetStatus(OrderStatus.ReadyForShipping);

            order.SetStatus(OrderStatus.Canceled);

            order.Status.Should().Be(OrderStatus.Canceled);
        }


        public void Order_is_ready_for_shipping_Then_it_should_invoice_10percent_of_the_order_total()
        {
            var order = new Order(new Customer());
            order.AddOrderLine(new Product {Price = 100});
            order.SetStatus(OrderStatus.ReadyForShipping);

            order.SetStatus(OrderStatus.Canceled);

            order.Customer.Invoices.First().Total.Should().Be(10);
        }

        [Test]
        [ExpectedException(typeof(InvalidStatusChangeException))]
        public void Order_has_been_shipped_Then_it_should_not_be_canceled()
        {
            var order = new Order(null);
            order.SetStatus(OrderStatus.Shipped);

            order.SetStatus(OrderStatus.Canceled);
        }
    }
}