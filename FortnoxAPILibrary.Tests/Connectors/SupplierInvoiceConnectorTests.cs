﻿using System;
using System.Linq;
using FortnoxAPILibrary.Connectors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FortnoxAPILibrary.Tests.Connectors
{
    [TestClass]
    //Update AccessToken, ClientSecret before run tests and clear those values when you finished
    public class SupplierInvoiceConnectorTests : ConnectorTestsBase
    {
        readonly ISupplierInvoiceConnector _connector;

        public SupplierInvoiceConnectorTests()
        {
            _connector = new SupplierInvoiceConnector
            {
                AccessToken = AccessToken,
                ClientSecret = ClientSecret
            };
        }

        [TestMethod]
        public void GetSupplierInvoices()
        {
            _connector.SortBy = Sort.By.SupplierInvoice.InvoiceDate;
            _connector.SortOrder = Sort.Order.Descending;
            var supplierInvoices = _connector.Find().SupplierInvoiceSubset;

            var firstInvoiceDate = DateTime.Parse(supplierInvoices.First().InvoiceDate);
            var lastInvoiceDate = DateTime.Parse(supplierInvoices.Last().InvoiceDate);
            Assert.IsTrue(firstInvoiceDate > lastInvoiceDate);
            Assert.IsTrue(supplierInvoices.First().Credit == "true" || supplierInvoices.First().Credit == "false");

            _connector.SortOrder = Sort.Order.Ascending;
            supplierInvoices = _connector.Find().SupplierInvoiceSubset;

            firstInvoiceDate = DateTime.Parse(supplierInvoices.First().InvoiceDate);
            lastInvoiceDate = DateTime.Parse(supplierInvoices.Last().InvoiceDate);
            Assert.IsTrue(lastInvoiceDate > firstInvoiceDate);
        }
    }
}
