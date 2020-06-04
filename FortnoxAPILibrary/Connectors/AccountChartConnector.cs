using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <inheritdoc />
    public interface IAccountChartConnector : IEntityConnector<Sort.By.AccountChart?>
    {
        /// <summary>
        /// Gets a list of account charts 
        /// </summary>
        /// <returns>A list of account charts</returns>
        EntityCollection<AccountChartSubset> Find();
    }

    /// <remarks/>
    public class AccountChartConnector : EntityConnector<AccountChart, EntityCollection<AccountChartSubset>, Sort.By.AccountChart?>, IAccountChartConnector
	{
        /// <remarks/>
        public AccountChartConnector()
        {
            Resource = "accountcharts";
        }

		/// <summary>
		/// Gets a list of account charts 
		/// </summary>
		/// <returns>A list of account charts</returns>
		public EntityCollection<AccountChartSubset> Find()
		{
			return BaseFind();
		}
	}
}
