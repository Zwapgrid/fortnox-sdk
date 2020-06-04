using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface IInvoicePaymentConnector : IEntityConnector<Sort.By.InvoicePayment?>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets an invoice payment
        /// </summary>
        /// <param name="number">The number of the invoice payment to find</param>
        /// <returns>The found invoice payment</returns>
        InvoicePayment Get(string number);

        /// <summary>
        /// Updates an invoice payment
        /// </summary>
        /// <param name="invoicePayment">The invoice payment to update</param>
        /// <returns>The updated invoice payment</returns>
        InvoicePayment Update(InvoicePayment invoicePayment);

        /// <summary>
        /// Create a new invoice payment
        /// </summary>
        /// <param name="invoicePayment">The invoice payment to be created</param>
        /// <returns>The created invoice payment</returns>
        InvoicePayment Create(InvoicePayment invoicePayment);

        /// <summary>
        /// Deletes a payment
        /// </summary>
        /// <param name="number">The number of the payment to delete</param>
        void Delete(string number);

        /// <summary>
        /// Gets a list of payments
        /// </summary>
        /// <returns>A list of payments</returns>
        EntityCollection<InvoicePaymentSubset> Find();

        /// <summary>
        /// Bookkeep an invoice payment
        /// </summary>
        /// <param name="invoicePaymentNumber">The number of the invoice payment to bookkeep.</param>
        /// <returns>The bookkept invoice payment</returns>
        InvoicePayment Bookkeep(string invoicePaymentNumber);
    }

    /// <remarks/>
    public class InvoicePaymentConnector : FinancialYearBasedEntityConnector<InvoicePayment, EntityCollection<InvoicePaymentSubset>, Sort.By.InvoicePayment?>, IInvoicePaymentConnector
	{
		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string InvoiceNumber { get; set; }

		/// <remarks/>
		public InvoicePaymentConnector()
		{
			Resource = "invoicepayments";
		}

		/// <summary>
		/// Gets an invoice payment
		/// </summary>
		/// <param name="number">The number of the invoice payment to find</param>
		/// <returns>The found invoice payment</returns>
		public InvoicePayment Get(string number)
		{
			return BaseGet(number);
		}

		/// <summary>
		/// Updates an invoice payment
		/// </summary>
		/// <param name="invoicePayment">The invoice payment to update</param>
		/// <returns>The updated invoice payment</returns>
		public InvoicePayment Update(InvoicePayment invoicePayment)
		{
			return BaseUpdate(invoicePayment, invoicePayment.Number);
		}

		/// <summary>
		/// Create a new invoice payment
		/// </summary>
		/// <param name="invoicePayment">The invoice payment to be created</param>
		/// <returns>The created invoice payment</returns>
		public InvoicePayment Create(InvoicePayment invoicePayment)
		{
			return BaseCreate(invoicePayment);
		}

		/// <summary>
		/// Deletes a payment
		/// </summary>
		/// <param name="number">The number of the payment to delete</param>
		public void Delete(string number)
		{
			BaseDelete(number);
		}

		/// <summary>
		/// Gets a list of payments
		/// </summary>
		/// <returns>A list of payments</returns>
		public EntityCollection<InvoicePaymentSubset> Find()
		{
			return BaseFind();
		}

		/// <summary>
		/// Bookkeep an invoice payment
		/// </summary>
		/// <param name="invoicePaymentNumber">The number of the invoice payment to bookkeep.</param>
		/// <returns>The bookkept invoice payment</returns>
		public InvoicePayment Bookkeep(string invoicePaymentNumber)
		{
			return DoAction(invoicePaymentNumber, "bookkeep");
		}
	}
}
