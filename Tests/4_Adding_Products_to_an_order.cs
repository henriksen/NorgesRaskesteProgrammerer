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

        [Test]
        public void Discount_should_be_10_percent_when_Order_Total_is_over_10k()
        {
            var order = new Order(null);

            order.AddOrderLine(new OrderLine { Price = 9000m });
            order.AddOrderLine(new OrderLine { Price = 2000m });

            order.Discount.Should().Be(1100m);
        }

        [Test]
        public void Order_Total_abouve_10k_should_reflect_discount()
        {
            var order = new Order(null);

            order.AddOrderLine(new OrderLine { Price = 9000m });
            order.AddOrderLine(new OrderLine { Price = 2000m });

            order.Total.Should().Be(9900m);
        }

        [Test]
        public void Order_Total_at_10k_or_less_should_not_have_a_discount()
        {
            var order = new Order(null);

            order.AddOrderLine(new OrderLine { Price = 9000m });
            order.AddOrderLine(new OrderLine { Price = 1000m });

            order.Total.Should().Be(10000m);
        }

        [Test]
        public void Order_Total_being_at_10k_should_not_add_10percent_discount()
        {
            var order = new Order(null);

            order.AddOrderLine(new OrderLine { Price = 9000m });
            order.AddOrderLine(new OrderLine { Price = 1000m });

            order.Total.Should().Be(10000m);
        }

        [Test]
        public void Order_Total_at_more_than_500_should_not_add_shipping_costs()
        {
            var order = new Order(null);

            order.AddOrderLine(new OrderLine { Price = 501m });

            order.Shipping.Should().Be(0m);
        }

        [Test]
        public void Order_Total_at_500_or_below_should_add_125_in_shipping_costs()
        {
            var order = new Order(null);

            order.AddOrderLine(new OrderLine { Price = 500m });

            order.Shipping.Should().Be(125m);
        }
    }
}