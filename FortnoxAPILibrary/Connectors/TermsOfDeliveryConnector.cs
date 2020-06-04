using FortnoxAPILibrary.Entities;

namespace FortnoxAPILibrary.Connectors
{
    public interface ITermsOfDeliveryConnector : IEntityConnector<Sort.By.TermsOfDelivery?>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Code { get; set; }

        /// <summary>
        /// Find a terms of delivery based on terms of delivery code
        /// </summary>
        /// <param name="termsOfDeliveryCode">The terms of deliverycode to find</param>
        /// <returns>The resulting terms of delivery</returns>
        TermsOfDelivery Get(string termsOfDeliveryCode);

        /// <summary>
        /// Updates a terms of delivery
        /// </summary>
        /// <param name="termsOfDelivery">The terms of delivery entity to update</param>
        /// <returns>The updated terms of delivery</returns>
        TermsOfDelivery Update(TermsOfDelivery termsOfDelivery);

        /// <summary>
        /// Create a new terms of delivery
        /// </summary>
        /// <param name="termsOfDelivery">The terms of delivery entity to create</param>
        /// <returns>The created terms of delivery</returns>
        TermsOfDelivery Create(TermsOfDelivery termsOfDelivery);

        /// <summary>
        /// Deletes a terms of delivery
        /// </summary>
        /// <param name="termsOfDeliveryCode">The terms of delivery code to delete</param>
        /// <returns>If the terms of delivery was deleted or not</returns>
        void Delete(string termsOfDeliveryCode);

        /// <summary>
        /// Gets a list of terms of deliveries
        /// </summary>
        /// <returns>A list of terms of deliveries</returns>
        EntityCollection<TermsOfDeliverySubset> Find();
    }

    /// <remarks/>
    public class TermsOfDeliveryConnector : EntityConnector<TermsOfDelivery, EntityCollection<TermsOfDeliverySubset>, Sort.By.TermsOfDelivery?>, ITermsOfDeliveryConnector
	{
		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [SearchParameter]
		public string Code { get; set; }

		/// <remarks/>
		public TermsOfDeliveryConnector()
		{
			Resource = "termsofdeliveries";
		}

		/// <summary>
		/// Find a terms of delivery based on terms of delivery code
		/// </summary>
		/// <param name="termsOfDeliveryCode">The terms of deliverycode to find</param>
		/// <returns>The resulting terms of delivery</returns>
		public TermsOfDelivery Get(string termsOfDeliveryCode)
		{
			return BaseGet(termsOfDeliveryCode);
		}

		/// <summary>
		/// Updates a terms of delivery
		/// </summary>
		/// <param name="termsOfDelivery">The terms of delivery entity to update</param>
		/// <returns>The updated terms of delivery</returns>
		public TermsOfDelivery Update(TermsOfDelivery termsOfDelivery)
		{
			return BaseUpdate(termsOfDelivery, termsOfDelivery.Code);
		}

		/// <summary>
		/// Create a new terms of delivery
		/// </summary>
		/// <param name="termsOfDelivery">The terms of delivery entity to create</param>
		/// <returns>The created terms of delivery</returns>
		public TermsOfDelivery Create(TermsOfDelivery termsOfDelivery)
		{
			return BaseCreate(termsOfDelivery);
		}


		/// <summary>
		/// Deletes a terms of delivery
		/// </summary>
		/// <param name="termsOfDeliveryCode">The terms of delivery code to delete</param>
		/// <returns>If the terms of delivery was deleted or not</returns>
		public void Delete(string termsOfDeliveryCode)
		{
			BaseDelete(termsOfDeliveryCode);
		}

		/// <summary>
		/// Gets a list of terms of deliveries
		/// </summary>
		/// <returns>A list of terms of deliveries</returns>
		public EntityCollection<TermsOfDeliverySubset> Find()
		{
			return BaseFind();
		}
	}
}
