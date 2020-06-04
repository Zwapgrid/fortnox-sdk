using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface ISupplierInvoiceConnector : IFinancialYearBasedEntityConnector<SupplierInvoice, EntityCollection<SupplierInvoiceSubset>, Sort.By.SupplierInvoice?>
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
        string SupplierNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string SupplierName { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string OrganisationNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Phone { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string ZipCode { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string OCR { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string InvoiceNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string SerialNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string CostCenter { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Project { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string OurReference { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string YourReference { get; set; }

        /// <remarks/>
        Filter.SupplierInvoice? FilterBy { get; set; }

        /// <summary>
        /// Get a supplier invoice based on document number
        /// </summary>
        /// <param name="documentNumber">The document number to find</param>
        /// <returns></returns>
        SupplierInvoice Get(string documentNumber);

        /// <summary>
        /// Updates a supplier invoice
        /// </summary>
        /// <param name="supplierInvoice">the supplier invoice to update</param>
        /// <returns></returns>
        SupplierInvoice Update(SupplierInvoice supplierInvoice);

        /// <summary>
        /// Create a new supplier invoice
        /// </summary>
        /// <param name="supplierInvoice">The supplier invoice to create</param>
        /// <returns>The created supplier invoice</returns>
        SupplierInvoice Create(SupplierInvoice supplierInvoice);

        /// <summary>
        /// Gets at list of supplier invoices
        /// </summary>
        /// <returns>A list of supplier invoices</returns>
        EntityCollection<SupplierInvoiceSubset> Find();

        /// <summary>
        /// Bookkeeps a supplier invoice
        /// </summary>
        /// <param name="documentNumber">The document number of the invoice to bookkeep.</param>
        /// <returns>The bookkept invoice</returns>
        SupplierInvoice Bookkeep(string documentNumber);

        /// <summary>
        /// Cancels a supplier invoice
        /// </summary>
        /// <param name="documentNumber">The document number of the invoice to be cancelled</param>
        /// <returns>The cancelled invoice</returns>
        SupplierInvoice Cancel(string documentNumber);

        /// <summary>
        /// Credits a supplier invoice
        /// </summary>
        /// <param name="documentNumber">The document number of the supplier invoice to credit</param>
        /// <returns>The credited supplier invoice</returns>
        SupplierInvoice Credit(string documentNumber);

        /// <summary>
        /// Approves a payment
        /// </summary>
        /// <param name="documentNumber">The doucment number of the supplier invoice to approve</param>
        /// <returns></returns>
        SupplierInvoice ApprovalPayment(string documentNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentNumber"></param>
        /// <returns></returns>
        SupplierInvoice ApprovalBookkeep(string documentNumber);
    }

    /// <remarks/>
    public class SupplierInvoiceConnector : FinancialYearBasedEntityConnector<SupplierInvoice, EntityCollection<SupplierInvoiceSubset>, Sort.By.SupplierInvoice?>, ISupplierInvoiceConnector
	{
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string ToDate { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string SupplierNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [SearchParameter]
		public string SupplierName { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string OrganisationNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string Phone { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [SearchParameter]
		public string ZipCode { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string City { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string Email { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string OCR { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string CostCenter { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string Project { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string OurReference { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string YourReference { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string FromDate { get; set; }

        /// <remarks/>
        [SearchParameter("filter")]
        public Filter.SupplierInvoice? FilterBy { get; set; }

		/// <remarks/>
		public SupplierInvoiceConnector()
		{
			Resource = "supplierinvoices";
		}


		/// <summary>
		/// Get a supplier invoice based on document number
		/// </summary>
		/// <param name="documentNumber">The document number to find</param>
		/// <returns></returns>
		public SupplierInvoice Get(string documentNumber)
		{
			return BaseGet(documentNumber);
		}

		/// <summary>
		/// Updates a supplier invoice
		/// </summary>
		/// <param name="supplierInvoice">the supplier invoice to update</param>
		/// <returns></returns>
		public SupplierInvoice Update(SupplierInvoice supplierInvoice)
		{
			return BaseUpdate(supplierInvoice, supplierInvoice.GivenNumber);
		}

		/// <summary>
		/// Create a new supplier invoice
		/// </summary>
		/// <param name="supplierInvoice">The supplier invoice to create</param>
		/// <returns>The created supplier invoice</returns>
		public SupplierInvoice Create(SupplierInvoice supplierInvoice)
		{
			return BaseCreate(supplierInvoice);
		}

		/// <summary>
		/// Gets at list of supplier invoices
		/// </summary>
		/// <returns>A list of supplier invoices</returns>
		public EntityCollection<SupplierInvoiceSubset> Find()
		{
			return BaseFind();
		}

		/// <summary>
		/// Bookkeeps a supplier invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to bookkeep.</param>
		/// <returns>The bookkept invoice</returns>
		public SupplierInvoice Bookkeep(string documentNumber)
		{
			return DoAction(documentNumber, "bookkeep");
		}

		/// <summary>
		/// Cancels a supplier invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to be cancelled</param>
		/// <returns>The cancelled invoice</returns>
		public SupplierInvoice Cancel(string documentNumber)
		{
			return DoAction(documentNumber, "cancel");
		}

		/// <summary>
		/// Credits a supplier invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the supplier invoice to credit</param>
		/// <returns>The credited supplier invoice</returns>
		public SupplierInvoice Credit(string documentNumber)
		{
			return DoAction(documentNumber, "credit");
		}

		/// <summary>
		/// Approves a payment
		/// </summary>
		/// <param name="documentNumber">The doucment number of the supplier invoice to approve</param>
		/// <returns></returns>
		public SupplierInvoice ApprovalPayment(string documentNumber)
		{
			return DoAction(documentNumber, "approvalpayment");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentNumber"></param>
		/// <returns></returns>
		public SupplierInvoice ApprovalBookkeep(string documentNumber)
		{
			return DoAction(documentNumber, "approvalbookkeep");
		}
	}
}
