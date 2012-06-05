using Core;
using Core.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Order_being_created
    {
        [Test]
        public void Default_status_is_ReadyToBePicked()
        {
            var order = new Order(null);

            order.Status.Should().Be(OrderStatus.ReadyToBePicked);
        }

        [Test]
        public void Customer_is_assigned_in_the_constructor()
        {
            var order = new Order(new Customer() {Name = "Test"});

            order.Customer.Name.Should().Be("Test");
        }
    }
}