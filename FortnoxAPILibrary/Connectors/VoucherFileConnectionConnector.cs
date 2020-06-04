using System.Collections.Generic;
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <inheritdoc />
    public interface IVoucherFileConnectionConnector : IEntityConnector<Sort.By.VoucherFileConnection?>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string VoucherDescription { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string VoucherNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string VoucherSeries { get; set; }

        /// <summary>
        /// Get a voucher file connection based on fileId
        /// </summary>
        /// <param name="fileId">The id of the file to find.</param>
        /// <returns>The found voucher file connection</returns>
        VoucherFileConnection Get(string fileId);

        /// <summary>
        /// Creates a new connection between a file and a voucher.
        /// </summary>
        /// <param name="voucherFileConnection">The voucher file connection to create</param>
        /// <returns>The created voucher file connection</returns>
        VoucherFileConnection Create(VoucherFileConnection voucherFileConnection);

        /// <summary>
        /// Deletes a connected file from a voucher
        /// </summary>
        /// <param name="fileId"></param>
        void Delete(string fileId);

        /// <summary>
        /// Gets a list of VoucherFile Connections
        /// </summary>
        /// <returns></returns>
        EntityCollection<VoucherFileConnectionSubset> Find();
    }

    public class VoucherFileConnectionConnector : EntityConnector<VoucherFileConnection, EntityCollection<VoucherFileConnectionSubset>, Sort.By.VoucherFileConnection?>, IVoucherFileConnectionConnector
    {
		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [SearchParameter]
		public string VoucherDescription { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [SearchParameter]
		public string VoucherNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [SearchParameter]
		public string VoucherSeries { get; set; }

		/// <remarks/>
		public VoucherFileConnectionConnector()
		{
			Resource = "voucherfileconnections";
		}

		/// <summary>
		/// Get a voucher file connection based on fileId
		/// </summary>
		/// <param name="fileId">The id of the file to find.</param>
		/// <returns>The found voucher file connection</returns>
		public VoucherFileConnection Get(string fileId)
		{
			return BaseGet(fileId);
		}

		/// <summary>
		/// Creates a new connection between a file and a voucher.
		/// </summary>
		/// <param name="voucherFileConnection">The voucher file connection to create</param>
		/// <returns>The created voucher file connection</returns>
		public VoucherFileConnection Create(VoucherFileConnection voucherFileConnection)
		{
		    var financialYear = voucherFileConnection.VoucherYear;

			return BaseCreate(voucherFileConnection, new Dictionary<string, string>
			{
			    { "financialyear", financialYear }, //backwards compatibility
			    { "financialyeardate", financialYear }
			});
		}

		/// <summary>
		/// Deletes a connected file from a voucher
		/// </summary>
		/// <param name="fileId"></param>
		public void Delete(string fileId)
		{
			BaseDelete(fileId);
		}

		/// <summary>
		/// Gets a list of VoucherFile Connections
		/// </summary>
		/// <returns></returns>
		public EntityCollection<VoucherFileConnectionSubset> Find()
		{
			return BaseFind();
		}
	}
}
