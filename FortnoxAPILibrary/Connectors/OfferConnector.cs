using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface IOfferConnector : IFinancialYearBasedEntityConnector<Offer, EntityCollection<OfferSubset>, Sort.By.Offer?>
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

        /// <remarks/>
        bool? Sent { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        bool? NotCompleted { get; set; }

        /// <remarks/>
        Filter.Offer? FilterBy { get; set; }

        /// <summary>
        /// Gets an offer
        /// </summary>
        /// <param name="documentNumber">The document number of the offer to find</param>
        /// <returns>An offer</returns>
        Offer Get(string documentNumber);

        /// <summary>
        /// Updates an offer
        /// </summary>
        /// <param name="offer">The offer to update</param>
        /// <returns>The updated offer</returns>
        Offer Update(Offer offer);

        /// <summary>
        /// Create a new offer
        /// </summary>
        /// <param name="offer">The offer to create</param>
        /// <returns>The created offer</returns>
        Offer Create(Offer offer);

        /// <summary>
        /// Gets a list of offers
        /// </summary>
        /// <returns>A list of offers</returns>
        EntityCollection<OfferSubset> Find();

        /// <summary>
        /// Cancel an offer
        /// </summary>
        /// <param name="documentNumber">The document number of the offer to cancel</param>
        /// <returns>The cancelled offer</returns>
        Offer Cancel(string documentNumber);

        /// <summary>
        /// Emails an offer
        /// </summary>
        /// <param name="documentNumber">The document number of the offer to be emailed</param>
        void Email(string documentNumber);

        /// <summary>
        /// Prints an offer
        /// </summary>
        /// <param name="documentNumber">The document number of the offer to print</param>
        /// <param name="localPath">Where to save the printed offer. If omitted the offer will be set to printed (i.e Sent = true) and no pdf is returned. </param>
        void Print(string documentNumber, string localPath = "");

        /// <summary>
        /// Marks the document as externally printed
        /// </summary>
        /// <param name="documentNumber"></param>
        void ExternalPrint(string documentNumber);

        /// <summary>
        /// Creates an order from the specified offer
        /// </summary>
        /// <param name="documentNumber">The document number of the offer to create order from</param>
        /// <returns></returns>
        Offer CreateOrder(string documentNumber);
    }

    /// <remarks/>
    public class OfferConnector : FinancialYearBasedEntityConnector<Offer, EntityCollection<OfferSubset>, Sort.By.Offer?>, IOfferConnector
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

		/// <remarks/>
		[SearchParameter]
		public bool? Sent { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		public bool? NotCompleted { get; set; }

		/// <remarks/>
		[SearchParameter("filter")]
		public Filter.Offer? FilterBy { get; set; }
        
		/// <remarks/>
		public OfferConnector()
		{
			Resource = "offers";
		}

		/// <summary>
		/// Gets an offer
		/// </summary>
		/// <param name="documentNumber">The document number of the offer to find</param>
		/// <returns>An offer</returns>
		public Offer Get(string documentNumber)
		{
			return BaseGet(documentNumber);
		}

		/// <summary>
		/// Updates an offer
		/// </summary>
		/// <param name="offer">The offer to update</param>
		/// <returns>The updated offer</returns>
		public Offer Update(Offer offer)
		{
			return BaseUpdate(offer, offer.DocumentNumber);
		}

		/// <summary>
		/// Create a new offer
		/// </summary>
		/// <param name="offer">The offer to create</param>
		/// <returns>The created offer</returns>
		public Offer Create(Offer offer)
		{
			return BaseCreate(offer);
		}

		/// <summary>
		/// Gets a list of offers
		/// </summary>
		/// <returns>A list of offers</returns>
		public EntityCollection<OfferSubset> Find()
		{
			return BaseFind();
		}

		/// <summary>
		/// Cancel an offer
		/// </summary>
		/// <param name="documentNumber">The document number of the offer to cancel</param>
		/// <returns>The cancelled offer</returns>
		public Offer Cancel(string documentNumber)
		{
			return DoAction(documentNumber, "cancel");
		}

		/// <summary>
		/// Emails an offer
		/// </summary>
		/// <param name="documentNumber">The document number of the offer to be emailed</param>
		public void Email(string documentNumber)
		{
			DoAction(documentNumber, "email");
		}

		/// <summary>
		/// Prints an offer
		/// </summary>
		/// <param name="documentNumber">The document number of the offer to print</param>
		/// <param name="localPath">Where to save the printed offer. If omitted the offer will be set to printed (i.e Sent = true) and no pdf is returned. </param>
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
        /// Marks the document as externally printed
        /// </summary>
        /// <param name="documentNumber"></param>
        public void ExternalPrint(string documentNumber)
        {
            DoAction(documentNumber, "externalprint");
        }

		/// <summary>
		/// Creates an order from the specified offer
		/// </summary>
		/// <param name="documentNumber">The document number of the offer to create order from</param>
		/// <returns></returns>
		public Offer CreateOrder(string documentNumber)
		{
			return DoAction(documentNumber, "createorder");
		}
	}
}
