using Core;
using Core.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Adding_Products_to_an_order
    {
        [Test]
        public void AddOrderLine_updates_OrderLine_count()
        {
            var order = new Order(null);
            
            order.AddOrderLine(new OrderLine());

            order.OrderLineCount.Should().Be(1);
        }

        [Test]
        public void AddOrderLine_updates_the_Order_Total()
        {
            var order = new Order(null);

            order.AddOrderLine(new OrderLine { Price = 1.1m });
            order.AddOrderLine(new OrderLine { Price = 2.2m });

            order.Total.Should().Be(3.3m);
        }
    }
}