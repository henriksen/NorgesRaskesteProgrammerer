using Core;
using Core.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Adding_items_to_an_Invoice
    {
        [Test]
        public void Adding_an_InvoiceItem_updates_Invoice_total()
        {
            var invoice = new Invoice();

            invoice.AddInvoiceItem(new InvoiceItem { Cost = 1.1m });
            invoice.AddInvoiceItem(new InvoiceItem { Cost = 2.2m });

            invoice.Total.Should().Be(3.3m);
        }
    }
}