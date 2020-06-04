using System.Linq;
using FortnoxAPILibrary.Connectors;
using FortnoxAPILibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FortnoxAPILibrary.Tests
{
    [TestClass]
    //Update AccessToken, ClientSecret before run tests and clear those values when you finished
    public class SupplierInvoicePaymentTests : ConnectorTestsBase
    {
        readonly SupplierInvoicePaymentConnector _connector;

        public SupplierInvoicePaymentTests()
        {
            _connector = new SupplierInvoicePaymentConnector
            {
                AccessToken = AccessToken,
                ClientSecret = ClientSecret
            };
        }

        [TestMethod]
        public void GetSupplierInvoices()
        {
            var supplierInvoicePaymentsResponse = _connector.Find();
            Assert.AreNotEqual(supplierInvoicePaymentsResponse.Entities, null);
            Assert.IsTrue(supplierInvoicePaymentsResponse.Entities.Any());
        }

        [TestMethod]
        public void UpdateSupplierInvoicePayment()
        {
            var supplierInvoiceNr = GetOrCreateSupplierInvoice();
            
            var createdSuppInvPayment = _connector.Create(new SupplierInvoicePayment
            {
                InvoiceNumber = supplierInvoiceNr,
                Amount = 100
            });
            
            MyAssert.HasNoError(_connector);
            
            Assert.AreEqual(createdSuppInvPayment.InvoiceNumber, supplierInvoiceNr);

            createdSuppInvPayment.Information = "SomeInformation";

            var updatedSuppInvPayment = _connector.Update(createdSuppInvPayment);

            MyAssert.HasNoError(_connector);
            
            Assert.AreEqual("SomeInformation", updatedSuppInvPayment.Information);
        }

        private string GetOrCreateSupplierInvoice()
        {
            var supplierInvoiceClient = new SupplierInvoiceConnector
            {
                AccessToken = AccessToken,
                ClientSecret = ClientSecret
            };

            var supplierInvoice = supplierInvoiceClient.Find().Entities.FirstOrDefault();

            if (null != supplierInvoice)
                return supplierInvoice.InvoiceNumber;

            var supplierNumber = GetOrCreateSupplier();

            return supplierInvoiceClient.Create(new SupplierInvoice
            {
                SupplierNumber = supplierNumber
            }).InvoiceNumber;
        }

        private string GetOrCreateSupplier()
        {
            var supplierClient = new SupplierConnector
            {
                AccessToken = AccessToken,
                ClientSecret = ClientSecret
            };
            
            var supplier = supplierClient.Find().Entities.FirstOrDefault();
            
            if (null != supplier)
                return supplier.SupplierNumber;

            return supplierClient.Create(new Supplier
            {
                Name = "TmpSupplier", 
                CountryCode = "SE", 
                City = "Testopolis"
            }).SupplierNumber;
        }
    }
}
