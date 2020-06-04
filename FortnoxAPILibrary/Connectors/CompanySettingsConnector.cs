using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface ICompanySettingsConnector : IEntityConnector<Sort.By.CompanySettings?>
    {
        /// <summary>
        /// Gets the company settings
        /// </summary>
        /// <returns>The company settings</returns>
        CompanySettings Get();
    }

    /// <remarks />
    public class CompanySettingsConnector : EntityConnector<CompanySettings, EntityWrapper<CompanySettings>, Sort.By.CompanySettings?>, ICompanySettingsConnector
    {
        /// <remarks />
        public CompanySettingsConnector()
        {
            Resource = "settings/company";
        }

        /// <summary>
        /// Gets the company settings
        /// </summary>
        /// <returns>The company settings</returns>
        public CompanySettings Get()
        {
            return BaseFind()?.Entity;
        }
    }
}
