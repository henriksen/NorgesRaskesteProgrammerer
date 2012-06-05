using System.Collections.Generic;
using System.Linq;

namespace Core.Domain
{
    public class Invoice {
        private List<InvoiceItem> _invoiceItems;

        public Invoice()
        {
            _invoiceItems = new List<InvoiceItem>();
        }

        public decimal Total
        {
            get { return _invoiceItems.Sum(it => it.Cost); }
        }

        public void AddInvoiceItem(InvoiceItem invoiceItem)
        {
            _invoiceItems.Add(invoiceItem);
        }
    }
}