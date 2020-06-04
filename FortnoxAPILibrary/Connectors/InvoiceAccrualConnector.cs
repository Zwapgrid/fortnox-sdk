using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface IInvoiceAccrualConnector : IEntityConnector<Sort.By.InvoiceAccrual?>
    {
        /// <summary>
        /// Get an invoice accrual	
        /// </summary>
        /// <param name="invoiceNumber">The invoice number of the invoice accrual to get</param>
        /// <returns>The found invoice accrual</returns>
        InvoiceAccrual Get(string invoiceNumber);

        /// <summary>
        /// Updates an invoice accrual
        /// </summary>
        /// <param name="invoiceAccrual">The invoice accrual to update</param>
        /// <returns>The updated invoice accrual</returns>
        InvoiceAccrual Update(InvoiceAccrual invoiceAccrual);

        /// <summary>
        /// Create a new invoice accrual
        /// </summary>
        /// <param name="invoiceAccrual">The invoice accrual to create</param>
        /// <returns>The created invoice accrual</returns>
        InvoiceAccrual Create(InvoiceAccrual invoiceAccrual);

        /// <summary>
        /// Deletes an invoice accrual
        /// </summary>
        /// <param name="invoiceNumber">The invoice number of the invoice accrual to delete</param>
        void Delete(string invoiceNumber);

        /// <summary>
        /// Gets a list of invoice accruals
        /// </summary>
        /// <returns>A list of invoice accruals</returns>
        EntityCollection<InvoiceAccrualSubset> Find();
    }

    /// <remarks/>
    public class InvoiceAccrualConnector : EntityConnector<InvoiceAccrual, EntityCollection<InvoiceAccrualSubset>, Sort.By.InvoiceAccrual?>, IInvoiceAccrualConnector
	{
		/// <remarks/>
		public InvoiceAccrualConnector()
		{
			Resource = "invoiceaccruals";
		}
        
		/// <summary>
		/// Get an invoice accrual	
		/// </summary>
		/// <param name="invoiceNumber">The invoice number of the invoice accrual to get</param>
		/// <returns>The found invoice accrual</returns>
		public InvoiceAccrual Get(string invoiceNumber)
		{
			return BaseGet(invoiceNumber);
		}

		/// <summary>
		/// Updates an invoice accrual
		/// </summary>
		/// <param name="invoiceAccrual">The invoice accrual to update</param>
		/// <returns>The updated invoice accrual</returns>
		public InvoiceAccrual Update(InvoiceAccrual invoiceAccrual)
		{
			return BaseUpdate(invoiceAccrual, invoiceAccrual.InvoiceNumber);
		}

		/// <summary>
		/// Create a new invoice accrual
		/// </summary>
		/// <param name="invoiceAccrual">The invoice accrual to create</param>
		/// <returns>The created invoice accrual</returns>
		public InvoiceAccrual Create(InvoiceAccrual invoiceAccrual)
		{
			return BaseCreate(invoiceAccrual);
		}

		/// <summary>
		/// Deletes an invoice accrual
		/// </summary>
		/// <param name="invoiceNumber">The invoice number of the invoice accrual to delete</param>
		public void Delete(string invoiceNumber)
		{
			BaseDelete(invoiceNumber);
		}

		/// <summary>
		/// Gets a list of invoice accruals
		/// </summary>
		/// <returns>A list of invoice accruals</returns>
		public EntityCollection<InvoiceAccrualSubset> Find()
		{
			return BaseFind();
		}
	}
}
