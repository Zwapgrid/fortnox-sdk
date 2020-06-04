using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Entities
{
    /// <remarks/>

	[Entity(SingularName = "FinancialYear", PluralName = "FinancialYears")]
	public class FinancialYear 
	{
		/// <remarks/>
		[JsonProperty]
		public string AccountChartType { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly]
		[JsonProperty]
		public string Id { get; private set; }

        /// <remarks/>
        [JsonProperty]
        public AccountingMethod? AccountingMethod { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string FromDate { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string ToDate { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly]
		[JsonProperty(PropertyName = "@url")]
		public string Url { get; private set; }
    }

    /// <remarks/>
    [Entity(SingularName = "FinancialYear", PluralName = "FinancialYears")]
    public class FinancialYearSubset
    {
        /// <remarks/>
        [JsonProperty]
        public string Id { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string FromDate { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string ToDate { get; set; }

        /// <remarks/>
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; set; }
    }

    /// <remarks/>
    public enum AccountingMethod
    {
        /// <remarks/>
        ACCRUAL,
        /// <remarks/>
        CASH
    }
}
