using System.Collections.Generic;

namespace Core.Domain
{
    public class Customer {
        public IEnumerable<Invoice> Invoices
        {
            get { throw new System.NotImplementedException(); }
            private set { throw new System.NotImplementedException(); }
        }

        public string Name { get; set; }

        public void AddInvoice(Invoice invoice)
        {
        }
    }
}