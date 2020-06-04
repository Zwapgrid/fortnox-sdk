﻿using System;
using System.Linq;
using FortnoxAPILibrary.Connectors;
using FortnoxAPILibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FortnoxAPILibrary.Tests
{
    [TestClass]
    public class EmployeeTests : ConnectorTestsBase
    {
        readonly IEmployeeConnector _connector;
        
        static string NewEmployeeId => Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6);

        public EmployeeTests()
        {
            _connector = new EmployeeConnector
            {
                AccessToken = AccessToken,
                ClientSecret = ClientSecret
            };
        }

        [TestMethod]
        public void TestConnection()
        {
            _connector.Find();

            CheckForError(_connector);
        }

        [TestMethod]
        public void CreateShouldCreateAnEmployee()
        {
            var employee = new Employee
            {
                EmployeeId = NewEmployeeId
            };

            var result = _connector.Create(employee);
            
            CheckForError(_connector);

            Assert.IsNotNull(result.EmployeeId);

            //Cleanup
            _connector.Update(new Employee { EmployeeId = result.EmployeeId, Inactive = true });
        }

        [TestMethod]
        public void UpdateShouldUpdateAnEmployee()
        {
            //Arrange
            var create = new Employee
            {
                EmployeeId = NewEmployeeId
            };

            var createResult = _connector.Create(create);
            CheckForError(_connector);

            //Act
            var update = new Employee
            {
                EmployeeId = createResult.EmployeeId,
                FirstName = "Test",
                LastName = "Case"
            };

            var updateResult = _connector.Update(update);
            CheckForError(_connector);

            //Assert
            Assert.AreEqual(update.FirstName, updateResult.FirstName);
            Assert.AreEqual(update.LastName, updateResult.LastName);
            Assert.AreEqual("Test Case", updateResult.FullName);

            //Cleanup
            _connector.Update(new Employee {EmployeeId = createResult.EmployeeId, Inactive = true});
        }

        [TestMethod]
        public void GetShouldReturnResult()
        {
            var employeeId = GetNewOrExistingEmployeeId();

            var result = _connector.Get(employeeId);

            CheckForError(_connector);

            Assert.AreEqual(employeeId, result.EmployeeId);
        }

        [TestMethod]
        public void FindShouldReturnResults()
        {
            EnsureSomeEmployeeExists();

            var result = _connector.Find();

            CheckForError(_connector);

            Assert.IsTrue(result.Entities.Any());
        }

        void EnsureSomeEmployeeExists()
        {
            GetNewOrExistingEmployeeId();
        }

        string GetNewOrExistingEmployeeId()
        {
            var result = _connector.Find();

            CheckForError(_connector);

            if (result.Entities.Any())
                return result.Entities.First().EmployeeId;

            var employee = _connector.Create(new Employee());

            CheckForError(_connector);

            return employee.EmployeeId;
        }
    }
}