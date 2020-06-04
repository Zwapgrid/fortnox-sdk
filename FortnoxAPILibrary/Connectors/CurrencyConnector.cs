
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface ICurrencyConnector : IEntityConnector<Sort.By.Currency?>
    {
        /// <summary>
        /// Gets a currency based on currency code
        /// </summary>
        /// <param name="currencyCode"></param>
        /// <returns></returns>
        Currency Get(string currencyCode);

        /// <summary>
        /// Updates a currency
        /// </summary>
        /// <param name="currency">The currency entity to update</param>
        /// <returns>The updated currency entity</returns>
        Currency Update(Currency currency);

        /// <summary>
        /// Create a new currency
        /// </summary>
        /// <param name="currency">The currency entity to create</param>
        /// <returns>The created currency entity</returns>
        Currency Create(Currency currency);

        /// <summary>
        /// Deletes a currency
        /// </summary>
        /// <param name="currencyCode">The currency code to delete</param>
        /// <returns>If the currency was deleted or not</returns>
        void Delete(string currencyCode);

        /// <summary>
        /// Gets at list of currencies
        /// </summary>
        /// <returns>A list of currencies</returns>
        EntityCollection<CurrencySubset> Find();
    }

    /// <remarks/>
	public class CurrencyConnector : EntityConnector<Currency, EntityCollection<CurrencySubset>, Sort.By.Currency?>, ICurrencyConnector
    {
		/// <remarks/>
		public CurrencyConnector()
		{
			Resource = "currencies";
		}

		/// <summary>
		/// Gets a currency based on currency code
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <returns></returns>
		public Currency Get(string currencyCode)
		{
			return BaseGet(currencyCode);
		}

		/// <summary>
		/// Updates a currency
		/// </summary>
		/// <param name="currency">The currency entity to update</param>
		/// <returns>The updated currency entity</returns>
		public Currency Update(Currency currency)
		{
			return BaseUpdate(currency, currency.Code);
		}

		/// <summary>
		/// Create a new currency
		/// </summary>
		/// <param name="currency">The currency entity to create</param>
		/// <returns>The created currency entity</returns>
		public Currency Create(Currency currency)
		{
			return BaseCreate(currency);
		}

		/// <summary>
		/// Deletes a currency
		/// </summary>
		/// <param name="currencyCode">The currency code to delete</param>
		/// <returns>If the currency was deleted or not</returns>
		public void Delete(string currencyCode)
		{
			BaseDelete(currencyCode);
		}

		/// <summary>
		/// Gets at list of currencies
		/// </summary>
		/// <returns>A list of currencies</returns>
		public EntityCollection<CurrencySubset> Find()
		{
			return BaseFind();
		}
	}
}
