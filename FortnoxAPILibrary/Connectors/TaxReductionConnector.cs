using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface ITaxReductionConnector : IEntityConnector<Sort.By.TaxReduction?>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string ReferenceNumber { get; set; }

        /// <remarks/>
        Filter.Invoice? FilterBy { get; set; }

        /// <summary>
        /// Find a tax reduction based on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TaxReduction Get(string id);

        /// <summary>
        /// Updates a tax reduction
        /// </summary>
        /// <param name="taxReduction">The tax reduction to update</param>
        /// <returns>The updated tax reduction</returns>
        TaxReduction Update(TaxReduction taxReduction);

        /// <summary>
        /// Create a new tax reduction
        /// </summary>
        /// <param name="taxReduction">The tax reduction to create</param>
        /// <returns>The created tax reduction</returns>
        TaxReduction Create(TaxReduction taxReduction);

        /// <summary>
        /// Deletes a tax reduction
        /// </summary>
        /// <param name="id">Id of the tax reduction to delete</param>
        void Delete(string id);

        /// <summary>
        /// Gets a list of tax reductions
        /// </summary>
        /// <returns>A list of tax reductions</returns>
        EntityCollection<TaxReductionSubset> Find();
    }

    /// <remarks/>
    public class TaxReductionConnector : EntityConnector<TaxReduction, EntityCollection<TaxReductionSubset>, Sort.By.TaxReduction?>, ITaxReductionConnector
	{
		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
		public string ReferenceNumber { get; set; }

        /// <remarks/>
        [SearchParameter("filter")]
		public Filter.Invoice? FilterBy { get; set; }
        
		/// <remarks/>
		public TaxReductionConnector()
		{
			Resource = "taxreductions";
		}

		/// <summary>
		/// Find a tax reduction based on id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public TaxReduction Get(string id)
		{
			return BaseGet(id);
		}

		/// <summary>
		/// Updates a tax reduction
		/// </summary>
		/// <param name="taxReduction">The tax reduction to update</param>
		/// <returns>The updated tax reduction</returns>
		public TaxReduction Update(TaxReduction taxReduction)
		{
			return BaseUpdate(taxReduction, taxReduction.Id);
		}

		/// <summary>
		/// Create a new tax reduction
		/// </summary>
		/// <param name="taxReduction">The tax reduction to create</param>
		/// <returns>The created tax reduction</returns>
		public TaxReduction Create(TaxReduction taxReduction)
		{
			return BaseCreate(taxReduction);
		}

		/// <summary>
		/// Deletes a tax reduction
		/// </summary>
		/// <param name="id">Id of the tax reduction to delete</param>
		public void Delete(string id)
		{
			BaseDelete(id);
		}

		/// <summary>
		/// Gets a list of tax reductions
		/// </summary>
		/// <returns>A list of tax reductions</returns>
		public EntityCollection<TaxReductionSubset> Find()
		{
			return BaseFind();
		}
	}
}
