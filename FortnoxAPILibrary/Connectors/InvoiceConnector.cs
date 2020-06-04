using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface IInvoiceConnector : IFinancialYearBasedEntityConnector<Invoice, EntityCollection<InvoiceSubset>, Sort.By.Invoice>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string FromDate { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string ToDate { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string CostCenter { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string CustomerName { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string CustomerNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string DocumentNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string ExternalInvoiceReference1 { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string ExternalInvoiceReference2 { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string OCR { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string OurReference { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string InvoiceDate { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Project { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string YourReference { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Label { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        bool? Sent { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        bool? NotCompleted { get; set; }
        
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        bool? IsCredit { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string YourOrderNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        InvoiceType? InvoiceTypeFilter { get; set; }

        /// <remarks/>
        Filter.Invoice? FilterBy { get; set; }

        /// <summary>
        /// Find an invoice
        /// </summary>
        /// <param name="documentNumber">The document number of the invoice to find</param>
        /// <returns>The found invoice</returns>
        Invoice Get(string documentNumber);

        /// <summary>
        /// Updates an Invoice
        /// </summary>
        /// <param name="invoice">The invoice to update</param>
        /// <returns>The updated invoice</returns>
        Invoice Update(Invoice invoice);

        /// <summary>
        /// Create a new invoice
        /// </summary>
        /// <param name="invoice">The invoice to create</param>
        /// <returns>The created invoice</returns>
        Invoice Create(Invoice invoice);

        /// <summary>
        /// Gets at list of Invoices
        /// </summary>
        /// <returns>A list of invoices</returns>
        EntityCollection<InvoiceSubset> Find();

        /// <summary>
        /// Bookkeep an invoice
        /// </summary>
        /// <param name="documentNumber">The document number of the invoice to bookkeep.</param>
        /// <returns>The bookkept invoice</returns>
        Invoice Bookkeep(string documentNumber);

        /// <summary>
        /// Cancel an invoice
        /// </summary>
        /// <param name="documentNumber">The document number of the invoice to cancel</param>
        /// <returns>The cancelled invoice</returns>
        Invoice Cancel(string documentNumber);

        /// <summary>
        /// Credit an invoice
        /// </summary>
        /// <param name="documentNumber">The document number of the invoice to credit</param>
        /// <returns>The credited invoice</returns>
        Invoice Credit(string documentNumber);

        /// <summary>
        /// Emails an invoice
        /// </summary>
        /// <param name="documentNumber">The document number of the invoice to be emailed</param>
        void Email(string documentNumber);

        /// <summary>
        /// Print an invoice to pdf
        /// </summary>
        /// <param name="documentNumber">The document number of the invoice to print</param>
        /// <param name="localPath">The path where to save the generated pdf. If omitted the invoice will be set to printed (i.e Sent = true) and no pdf is returned. </param>
        void Print(string documentNumber, string localPath = "");

        /// <param name="documentNumber">The document number of the invoice to print</param>
        void EPrint(string documentNumber);

        /// <summary>
        /// Prints a reminder to pdf and increments <Reminders></Reminders> on the invoice
        /// </summary>
        /// <param name="documentNumber"></param>
        /// <param name="localPath">The path where to save the reminder </param>
        void PrintReminder(string documentNumber, string localPath);

        /// <summary>
        /// Prints a preview as pdf
        /// </summary>
        /// <param name="documentNumber"></param>
        /// <param name="localPath">The path where to save the preview</param>
        void Preview(string documentNumber, string localPath);

        /// <summary>
        /// Marks the document as externally printed
        /// </summary>
        /// <param name="documentNumber"></param>
        void ExternalPrint(string documentNumber);
    }

    /// <remarks/>
    public class InvoiceConnector : FinancialYearBasedEntityConnector<Invoice, EntityCollection<InvoiceSubset>, Sort.By.Invoice>, IInvoiceConnector
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string FromDate { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string ToDate { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string CostCenter { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [SearchParameter]
		public string CustomerName { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string CustomerNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string DocumentNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string ExternalInvoiceReference1 { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string ExternalInvoiceReference2 { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string OCR { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string OurReference { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string InvoiceDate { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string Project { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string YourReference { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string Label { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public bool? Sent { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public bool? NotCompleted { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter("credit")]
		public bool? IsCredit { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string YourOrderNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter("invoicetype")]
		public InvoiceType? InvoiceTypeFilter { get; set; }

        /// <remarks/>
        [SearchParameter("filter")]
		public Filter.Invoice? FilterBy { get; set; }

        /// <remarks/>
		public InvoiceConnector()
		{
			Resource = "invoices";
		}

		/// <summary>
		/// Find an invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to find</param>
		/// <returns>The found invoice</returns>
		public Invoice Get(string documentNumber)
		{
			return BaseGet(documentNumber);
		}

		/// <summary>
		/// Updates an Invoice
		/// </summary>
		/// <param name="invoice">The invoice to update</param>
		/// <returns>The updated invoice</returns>
		public Invoice Update(Invoice invoice)
		{
			return BaseUpdate(invoice, invoice.DocumentNumber);
		}

		/// <summary>
		/// Create a new invoice
		/// </summary>
		/// <param name="invoice">The invoice to create</param>
		/// <returns>The created invoice</returns>
		public Invoice Create(Invoice invoice)
		{
			return BaseCreate(invoice);
		}

        /// <summary>
        /// Gets at list of Invoices
        /// </summary>
        /// <returns>A list of invoices</returns>
        public EntityCollection<InvoiceSubset> Find()
		{
			return BaseFind();
		}

		/// <summary>
		/// Bookkeep an invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to bookkeep.</param>
		/// <returns>The bookkept invoice</returns>
		public Invoice Bookkeep(string documentNumber)
		{
			return DoAction(documentNumber, "bookkeep");
		}

		/// <summary>
		/// Cancel an invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to cancel</param>
		/// <returns>The cancelled invoice</returns>
		public Invoice Cancel(string documentNumber)
		{
			return DoAction(documentNumber, "cancel");
		}

		/// <summary>
		/// Credit an invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to credit</param>
		/// <returns>The credited invoice</returns>
		public Invoice Credit(string documentNumber)
		{
			return DoAction(documentNumber, "credit");
		}

		/// <summary>
		/// Emails an invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to be emailed</param>
		public void Email(string documentNumber)
		{
			DoAction(documentNumber, "email");
		}

		/// <summary>
		/// Print an invoice to pdf
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to print</param>
		/// <param name="localPath">The path where to save the generated pdf. If omitted the invoice will be set to printed (i.e Sent = true) and no pdf is returned. </param>
		public void Print(string documentNumber, string localPath = "")
		{
			if (string.IsNullOrEmpty(localPath))
			{
				DoAction(documentNumber, "externalprint");
			}
			else
			{
				LocalPath = localPath;
				DoAction(documentNumber, "print");
			}
		}
        
        /// <param name="documentNumber">The document number of the invoice to print</param>
        public void EPrint(string documentNumber)
        {
            DoAction(documentNumber, "eprint");
        }

		/// <summary>
		/// Prints a reminder to pdf and increments <Reminders></Reminders> on the invoice
		/// </summary>
		/// <param name="documentNumber"></param>
		/// <param name="localPath">The path where to save the reminder </param>
		public void PrintReminder(string documentNumber, string localPath)
		{
			LocalPath = localPath;
			DoAction(documentNumber, "printreminder");
		}

        /// <summary>
        /// Prints a preview as pdf
        /// </summary>
        /// <param name="documentNumber"></param>
        /// <param name="localPath">The path where to save the preview</param>
        public void Preview(string documentNumber, string localPath)
        {
            LocalPath = localPath;
            DoAction(documentNumber, "preview");
        }

        /// <summary>
        /// Marks the document as externally printed
        /// </summary>
        /// <param name="documentNumber"></param>
        public void ExternalPrint(string documentNumber)
        {
            DoAction(documentNumber, "externalprint");
        }
	}
}
