using System;
using System.Xml.Serialization;
using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;

namespace FortnoxAPILibrary.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(ElementName = "SalaryTransaction", IsNullable = false)]
    [Entity(SingularName = "SalaryTransaction", PluralName = "SalaryTransactions")]
    public class SalaryTransaction
    {
        /// <summary>
        /// Unique employee-id, max-length 15. Required.
        /// </summary>
        [XmlElement(ElementName = "EmployeeId")]
        [JsonProperty]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Salary code, max-length 6. Required.
        /// 
        /// You can get a list of usable salary codes from Register, Lönearter och koder, Lönearter by choosing
        /// one of two tables and printing (Utskrift in the toolbar). Depending on which salary code
        /// table(löneartstabell) that is set in the settings(Inställningar, Lön, Avtal för arbetare/tjänsteman – Allmänt)
        /// you can choose the salary code to use from either salary code table.Make sure to use the correct
        /// table that is used for the employee(Register, Personal, Anställning, Personaltyp) you want to sent
        /// the salary transaction for. Some salary codes do not exist in every table.
        /// </summary>
        [XmlElement(ElementName = "SalaryCode")]
        [JsonProperty]
        public string SalaryCode { get; set; }

        /// <summary>
        /// Unique row ID, Read-only
        /// </summary>
        [XmlElement(ElementName = "SalaryRow")]
        [JsonProperty]
        public int? SalaryRow { get; set; }

        /// <summary>
        /// Date, format YYYY-MM-DD. Required
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
    }
}
