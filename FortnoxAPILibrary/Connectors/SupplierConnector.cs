using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface ISupplierConnector : IEntityConnector<Sort.By.Supplier?>
    {
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
        string Name { get; set; }

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
        string SupplierNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string ZipCode { get; set; }

        /// <summary>
        /// Get a supplier based on suppliernumber
        /// </summary>
        /// <param name="supplierNumber">The suppliernumber to find</param>
        /// <returns>The resulting supplier</returns>
        Supplier Get(string supplierNumber);

        /// <summary>
        /// Updates a supplier
        /// </summary>
        /// <param name="supplier">The supplier entity to update</param>
        /// <returns>The updated supplier</returns>
        Supplier Update(Supplier supplier);

        /// <summary>
        /// Create a new supplier
        /// </summary>
        /// <param name="supplier">The supplier entity to create</param>
        /// <returns>The created supplier</returns>
        Supplier Create(Supplier supplier);

        /// <summary>
        /// Deletes at supplier
        /// </summary>
        /// <param name="supplierNumber">The suppliernumber to delete</param>
        /// <returns></returns>
        void Delete(string supplierNumber);

        /// <summary>
        /// Gets a list of suppliers
        /// </summary>
        /// <returns>A list of suppliers</returns>
        EntityCollection<SupplierSubset> Find();
    }

    /// <remarks/>
    public class SupplierConnector : EntityConnector<Supplier, EntityCollection<SupplierSubset>, Sort.By.Supplier?>, ISupplierConnector
	{

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
		public string Name { get; set; }

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
		public string SupplierNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [SearchParameter]
		public string ZipCode { get; set; }

		/// <remarks/>
		public SupplierConnector()
		{
			Resource = "suppliers";
		}

		/// <summary>
		/// Get a supplier based on suppliernumber
		/// </summary>
		/// <param name="supplierNumber">The suppliernumber to find</param>
		/// <returns>The resulting supplier</returns>
		public Supplier Get(string supplierNumber)
		{
			return BaseGet(supplierNumber);
		}

		/// <summary>
		/// Updates a supplier
		/// </summary>
		/// <param name="supplier">The supplier entity to update</param>
		/// <returns>The updated supplier</returns>
		public Supplier Update(Supplier supplier)
		{
			return BaseUpdate(supplier, supplier.SupplierNumber);
		}

		/// <summary>
		/// Create a new supplier
		/// </summary>
		/// <param name="supplier">The supplier entity to create</param>
		/// <returns>The created supplier</returns>
		public Supplier Create(Supplier supplier)
		{
			return BaseCreate(supplier);
		}

		/// <summary>
		/// Deletes at supplier
		/// </summary>
		/// <param name="supplierNumber">The suppliernumber to delete</param>
		/// <returns></returns>
		public void Delete(string supplierNumber)
		{
			BaseDelete(supplierNumber);
		}

		/// <summary>
		/// Gets a list of suppliers
		/// </summary>
		/// <returns>A list of suppliers</returns>
		public EntityCollection<SupplierSubset> Find()
		{
			return BaseFind();
		}
	}
}
