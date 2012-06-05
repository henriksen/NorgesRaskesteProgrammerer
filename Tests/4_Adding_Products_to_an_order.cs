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
            
            order.AddOrderLine(new Product());

            order.OrderLineCount.Should().Be(1);
        }
    }
}