using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;

namespace FortnoxAPILibrary.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(ElementName = "SalaryTransactionSubset")]
    [Entity(SingularName = "SalaryTransaction", PluralName = "SalaryTransactions")]
    public class SalaryTransactionSubset
    {
        /// <summary>
        /// Unique employee-id, max-length 15
        /// </summary>
        [XmlElement(ElementName = "EmployeeId")]
        [JsonProperty]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Salary code, max-length 6
        /// </summary>
        [XmlElement(ElementName = "SalaryCode")]
        [JsonProperty]
        public string SalaryCode { get; set; }

        /// <summary>
        /// Unique row ID, Read-only
        /// </summary>
        [XmlElement(ElementName = "SalaryRow")]
        [JsonProperty]
        public int SalaryRow { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        [XmlElement(ElementName = "Date")]
        [JsonProperty]
        public string Date { get; set; }

        /// <summary>
        /// Number of #
        /// </summary>
        [XmlElement(ElementName = "Number")]
        [JsonProperty]
        public double Number { get; set; }

        /// <summary>
        /// Cost per # in SEK
        /// </summary>
        [XmlElement(ElementName = "Amount")]
        [JsonProperty]
        public double Amount { get; set; }

        /// <summary>
        /// Sum in SEK
        /// </summary>
        [XmlElement(ElementName = "Total")]
        [JsonProperty]
        public double Total { get; set; }

        /// <summary>
        /// Expense code from the expense registry, max-length 6
        /// </summary>
        [XmlElement(ElementName = "Expense")]
        [JsonProperty]
        public string Expense { get; set; }

        /// <summary>
        /// Sum VAT
        /// </summary>
        [XmlElement(ElementName = "VAT")]
        [JsonProperty("VAT")]
        public double Vat { get; set; }

        /// <summary>
        /// Optional additional text relating to the salary transaction, max-length 40
        /// </summary>
        [XmlElement(ElementName = "TextRow")]
        [JsonProperty]
        public string TextRow { get; set; }

        /// <summary>
        /// Url of the full salary transaction
        /// </summary>
        [XmlAttribute(AttributeName = "url")]
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; set; }
    }
}
