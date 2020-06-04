using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <inheritdoc />
    public interface ICustomerConnector : IEntityConnector<Sort.By.Customer?>
    {
        /// <remarks/>
        Filter.Customer? FilterBy { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string CustomerNumber { get; set; }

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
        string ZipCode { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string GLN { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string GLNDelivery { get; set; }

        /// <summary>
        /// Find a customer based on customernumber
        /// </summary>
        /// <param name="customerNumber">The customernumber to find</param>
        /// <returns>The found customer</returns>
        Customer Get(string customerNumber);

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customer">The customer to update</param>
        /// <returns>The updated customer</returns>
        Customer Update(Customer customer);

        /// <summary>
        /// Create a new customer
        /// </summary>
        /// <param name="customer">The customer to create</param>
        /// <returns>The created customer</returns>
        Customer Create(Customer customer);

        /// <summary>
        /// Deletes a customer
        /// </summary>
        /// <param name="customerNumber">The customernumber to delete</param>
        void Delete(string customerNumber);

        /// <summary>
        /// Gets a list of customers
        /// </summary>
        /// <returns>A list of customers</returns>
        EntityCollection<CustomerSubset> Find();
    }

    /// <remarks/>
    public class CustomerConnector : EntityConnector<Customer, EntityCollection<CustomerSubset>, Sort.By.Customer?>
	{
        /// <remarks/>
		[SearchParameter("filter")]
		public Filter.Customer? FilterBy { get; set; }


        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string City { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string CustomerNumber { get; set; }

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
		public string ZipCode { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[SearchParameter]
		public string GLN { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[SearchParameter]
		public string GLNDelivery { get; set; }

		/// <remarks/>
		public CustomerConnector()
		{
			Resource = "customers";
		}


		/// <summary>
		/// Find a customer based on customernumber
		/// </summary>
		/// <param name="customerNumber">The customernumber to find</param>
		/// <returns>The found customer</returns>
		public Customer Get(string customerNumber)
		{
			return BaseGet(customerNumber);
		}

		/// <summary>
		/// Updates a customer
		/// </summary>
		/// <param name="customer">The customer to update</param>
		/// <returns>The updated customer</returns>
		public Customer Update(Customer customer)
		{
			return BaseUpdate(customer, customer.CustomerNumber);
		}

		/// <summary>
		/// Create a new customer
		/// </summary>
		/// <param name="customer">The customer to create</param>
		/// <returns>The created customer</returns>
		public Customer Create(Customer customer)
		{
			return BaseCreate(customer);
		}

		/// <summary>
		/// Deletes a customer
		/// </summary>
		/// <param name="customerNumber">The customernumber to delete</param>
		public void Delete(string customerNumber)
		{
			BaseDelete(customerNumber);
		}

		/// <summary>
		/// Gets a list of customers
		/// </summary>
		/// <returns>A list of customers</returns>
		public EntityCollection<CustomerSubset> Find()
		{
			return BaseFind();
		}
	}
}
