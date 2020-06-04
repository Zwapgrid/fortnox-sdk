using System.Collections.Generic;
using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Entities
{
    /// <remarks/>
    [Entity(SingularName = "SupplierInvoice", PluralName = "SupplierInvoices")]
    public class SupplierInvoice 
    {
		/// <remarks/>
		public SupplierInvoice()
        {
            SupplierInvoiceRows = new List<SupplierInvoiceRow>();
        }

		/// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly]
		[JsonProperty]
		public string AccountingMethod { get; private set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? AdministrationFee { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly]
        [JsonProperty]
        public string Balance { get; private set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly]
        [JsonProperty]
        public bool? Booked { get; private set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly]
        [JsonProperty]
        public bool? Cancelled { get; private set; }

        /// <remarks/>
        [JsonProperty]
        public string Comments { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string CostCenter { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly]
        [JsonProperty]
        public bool? Credit { get; private set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly]
        [JsonProperty]
        public string CreditReference { get; private set; }

        /// <remarks/>
        [JsonProperty]
        public string Currency { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? CurrencyRate { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? CurrencyUnit { get; set; }

        /// <remarks/>
        [JsonProperty]
        public bool? DisablePaymentFile { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string DueDate { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string ExternalInvoiceNumber { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string ExternalInvoiceSeries { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? Freight { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string VoucherSeries { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string VoucherNumber { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string VoucherYear { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string GivenNumber { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string InvoiceDate { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string InvoiceNumber { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string OCR { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string OurReference { get; set; }

        /// <remarks/>
        [JsonProperty]
        public bool? PaymentPending { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Project { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? RoundOffValue { get; set; }

        /// <remarks/>
        [JsonProperty]
        public SalesType? SalesType { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string SupplierNumber { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly]
        [JsonProperty]
        public string SupplierName { get; private set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? Total { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? VAT { get; set; }

        /// <remarks/>
        [JsonProperty]
        public InvoiceVATType? VATType { get; set; }

        /// <remarks/>
        [JsonProperty]
        public List<SupplierInvoiceRow> SupplierInvoiceRows { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly]
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; private set; }

        /// <remarks/>
        [JsonProperty]
        public string YourReference { get; set; }
    }

    /// <remarks/>
    public class SupplierInvoiceRow
    {
        /// <remarks/>
        [JsonProperty]
        public int? Account { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string ArticleNumber { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Code { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string CostCenter { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Project { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string TransactionInformation { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string ItemDescription { get; set; }

        /// <remarks />
        [JsonProperty]
        public string AccountDescription { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? Price { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? Quantity { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? Total { get; set; }

        /// <remarks/>
        [JsonProperty]
        public bool? Credit { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? Debit { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? CreditCurrency { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? DebitCurrency { get; set; }
        /// <remarks/>
        [JsonProperty]
        public string Unit { get; set; }
    }

    /// <remarks/>
    [Entity(SingularName = "SupplierInvoice", PluralName = "SupplierInvoices")]
    public class SupplierInvoiceSubset
    {
        /// <remarks/>
        [JsonProperty]
        public string Balance { get; set; }

        /// <remarks/>
        [JsonProperty]
        public bool? Booked { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Cancel { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string DueDate { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string GivenNumber { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string InvoiceDate { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string InvoiceNumber { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string SupplierNumber { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string SupplierName { get; set; }

        /// <remarks/>
        [JsonProperty]
        public decimal? Total { get; set; }

        /// <remarks/>
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; set; }
    }

    /// <remarks/>
    public enum SalesType
    {
        /// <remarks/>
        STOCK,
        /// <remarks/>
        SERVICE
    }

    /// <remarks/>
    public enum InvoiceVATType
    {
        /// <remarks/>
        NORMAL,
        /// <remarks/>
        REVERSE,
        /// <remarks/>
        EUINTERNAL
    }
}
