using System.Collections.Generic;
using System.Linq;

namespace Core.Domain
{
    public class Customer {
        private List<Invoice> _invoices;

        public Customer()
        {
            _invoices = new List<Invoice>();
        }

        public IEnumerable<Invoice> Invoices
        {
            get { return _invoices.AsEnumerable(); }
        }

        public string Name { get; set; }

        public void AddInvoice(Invoice invoice)
        {
            _invoices.Add(invoice);
        }
    }
}