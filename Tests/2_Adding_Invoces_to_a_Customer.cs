using System.Linq;
using Core;
using Core.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Adding_Invoces_to_a_Customer
    {
        [Test]
        public void AddInvoice_updates_Invoices_count()
        {
            var customer = new Customer();

            customer.AddInvoice(new Invoice());
            customer.AddInvoice(new Invoice());

            customer.Invoices.Count().Should().Be(2);
        }
    }
}