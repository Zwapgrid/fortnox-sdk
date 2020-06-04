using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface IOrderConnector : IFinancialYearBasedEntityConnector<Order, EntityCollection<OrderSubset>, Sort.By.Order?>
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
        string OurReference { get; set; }

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

        /// <remarks/>
        Filter.Order? FilterBy { get; set; }

        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="documentNumber">The document number of the order to find</param>
        /// <returns>An order</returns>
        Order Get(string documentNumber);

        /// <summary>
        /// Updates an order
        /// </summary>
        /// <param name="order">The order to update</param>
        /// <returns>The updated order</returns>
        Order Update(Order order);

        /// <summary>
        /// Creates a new order
        /// </summary>
        /// <param name="order">The order to create</param>
        /// <returns>The created order</returns>
        Order Create(Order order);

        /// <summary>
        /// Gets a list of orders
        /// </summary>
        /// <returns>A list of orders</returns>
        EntityCollection<OrderSubset> Find();

        /// <summary>
        /// Cancel an order
        /// </summary>
        /// <param name="documentNumber">The document number of the order to canceld</param>
        /// <returns>The cancelled order</returns>
        Order Cancel(string documentNumber);

        /// <summary>
        /// Emails an order
        /// </summary>
        /// <param name="documentNumber">The document number of the order to be emailed</param>
        void Email(string documentNumber);

        /// <summary>
        /// Print an order
        /// </summary>
        /// <param name="documentNumber">The document number of the order to print</param>
        /// <param name="localPath">Where to save the printed order. If omitted the order will be set to printed (i.e Sent = true) and no pdf is returned. </param>
        void Print(string documentNumber, string localPath = "");

        /// <summary>
        /// Creates an invoice from the specified order
        /// </summary>
        /// <param name="documentNumber">The document number of the order to create invoice from</param>
        /// <returns></returns>
        Order CreateInvoice(string documentNumber);

        /// <summary>
        /// Marks the document as externally printed
        /// </summary>
        /// <param name="documentNumber"></param>
        void ExternalPrint(string documentNumber);
    }

    /// <remarks/>
    public class OrderConnector : FinancialYearBasedEntityConnector<Order, EntityCollection<OrderSubset>, Sort.By.Order?>, IOrderConnector
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
		public string OurReference { get; set; }

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

		/// <remarks/>
		[SearchParameter("filter")]
		public Filter.Order? FilterBy { get; set; }

		/// <remarks/>
		public enum DiscountType
		{
			/// <remarks/>
			AMOUNT,
			/// <remarks/>
			PERCENT
		}

		/// <remarks/>
		public OrderConnector()
		{
			Resource = "orders";
		}


		/// <summary>
		/// Gets an order
		/// </summary>
		/// <param name="documentNumber">The document number of the order to find</param>
		/// <returns>An order</returns>
		public Order Get(string documentNumber)
		{
			return BaseGet(documentNumber);
		}

		/// <summary>
		/// Updates an order
		/// </summary>
		/// <param name="order">The order to update</param>
		/// <returns>The updated order</returns>
		public Order Update(Order order)
		{
			return BaseUpdate(order, order.DocumentNumber);
		}

		/// <summary>
		/// Creates a new order
		/// </summary>
		/// <param name="order">The order to create</param>
		/// <returns>The created order</returns>
		public Order Create(Order order)
		{
			return BaseCreate(order);
		}

		/// <summary>
		/// Gets a list of orders
		/// </summary>
		/// <returns>A list of orders</returns>
		public EntityCollection<OrderSubset> Find()
		{
			return BaseFind();
		}

		/// <summary>
		/// Cancel an order
		/// </summary>
		/// <param name="documentNumber">The document number of the order to canceld</param>
		/// <returns>The cancelled order</returns>
		public Order Cancel(string documentNumber)
		{
			return DoAction(documentNumber, "cancel");
		}

		/// <summary>
		/// Emails an order
		/// </summary>
		/// <param name="documentNumber">The document number of the order to be emailed</param>
		public void Email(string documentNumber)
		{
			DoAction(documentNumber, "email");
		}


		/// <summary>
		/// Print an order
		/// </summary>
		/// <param name="documentNumber">The document number of the order to print</param>
		/// <param name="localPath">Where to save the printed order. If omitted the order will be set to printed (i.e Sent = true) and no pdf is returned. </param>
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

		/// <summary>
		/// Creates an invoice from the specified order
		/// </summary>
		/// <param name="documentNumber">The document number of the order to create invoice from</param>
		/// <returns></returns>
		public Order CreateInvoice(string documentNumber)
		{
			return DoAction(documentNumber, "createinvoice");
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
