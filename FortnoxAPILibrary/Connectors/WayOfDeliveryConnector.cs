using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface IWayOfDeliveryConnector : IEntityConnector<Sort.By.WayOfDelivery?>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Code { get; set; }

        /// <summary>
        /// Find a way of delivery based on way of delivery code
        /// </summary>
        /// <param name="wayOfDeliveryCode">The way of deliverycode to find</param>
        /// <returns>The resulting way of deliverycode</returns>
        WayOfDelivery Get(string wayOfDeliveryCode);

        /// <summary>
        /// Updates a way of delivery
        /// </summary>
        /// <param name="wayOfDelivery">The way of delivery to update</param>
        /// <returns>The updated way of delivery</returns>
        WayOfDelivery Update(WayOfDelivery wayOfDelivery);

        /// <summary>
        /// Create a new way of delivery
        /// </summary>
        /// <param name="wayOfDelivery">The way of delivery to create</param>
        /// <returns>The created way of delivery</returns>
        WayOfDelivery Create(WayOfDelivery wayOfDelivery);

        /// <summary>
        /// Deletes a way of Delivery
        /// </summary>
        /// <param name="wayOfDeliveryCode">The way of delivery code to delete</param>
        /// <returns>If the way of delivery was deleted or not</returns>
        void Delete(string wayOfDeliveryCode);

        /// <summary>
        /// Gets a list of way of deliveries
        /// </summary>
        /// <returns>A list of way of deliveries</returns>
        EntityCollection<WayOfDeliverySubset> Find();
    }

    /// <remarks/>
    public class WayOfDeliveryConnector : EntityConnector<WayOfDelivery, EntityCollection<WayOfDeliverySubset>, Sort.By.WayOfDelivery?>, IWayOfDeliveryConnector
	{
		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [SearchParameter]
		public string Code { get; set; }

		/// <remarks/>
		public WayOfDeliveryConnector()
		{
			Resource = "wayofdeliveries";
		}

		/// <summary>
		/// Find a way of delivery based on way of delivery code
		/// </summary>
		/// <param name="wayOfDeliveryCode">The way of deliverycode to find</param>
		/// <returns>The resulting way of deliverycode</returns>
		public WayOfDelivery Get(string wayOfDeliveryCode)
		{
			return BaseGet(wayOfDeliveryCode);
		}

		/// <summary>
		/// Updates a way of delivery
		/// </summary>
		/// <param name="wayOfDelivery">The way of delivery to update</param>
		/// <returns>The updated way of delivery</returns>
		public WayOfDelivery Update(WayOfDelivery wayOfDelivery)
		{
			return BaseUpdate(wayOfDelivery, wayOfDelivery.Code);
		}

		/// <summary>
		/// Create a new way of delivery
		/// </summary>
		/// <param name="wayOfDelivery">The way of delivery to create</param>
		/// <returns>The created way of delivery</returns>
		public WayOfDelivery Create(WayOfDelivery wayOfDelivery)
		{
			return BaseCreate(wayOfDelivery);
		}

		/// <summary>
		/// Deletes a way of Delivery
		/// </summary>
		/// <param name="wayOfDeliveryCode">The way of delivery code to delete</param>
		/// <returns>If the way of delivery was deleted or not</returns>
		public void Delete(string wayOfDeliveryCode)
		{
			BaseDelete(wayOfDeliveryCode);
		}

        /// <summary>
        /// Gets a list of way of deliveries
        /// </summary>
        /// <returns>A list of way of deliveries</returns>
        public EntityCollection<WayOfDeliverySubset> Find()
		{
			return BaseFind();
		}
	}
}
