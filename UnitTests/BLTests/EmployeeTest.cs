using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankBLL;
using UnitTests.BLTestDatas;

namespace UnitTests.BLTests
{
    [TestClass]
    public class EmployeeTest
    {
        private EmployeeBL employeeBL = new EmployeeBL();
        private EmployeeTestData testData = new EmployeeTestData();

        [TestMethod]
        public void InsertClient_WrongMobileFormat_ExpectedFalseResult()
        {
            //Arrange
            var client = testData.wrongMobileFormat;
            bool expectedResponse = false;

            //Act
            bool respones = employeeBL.InserClient(client);

            //Assert
            Assert.AreEqual(expectedResponse,respones);
        }

        [TestMethod]
        public void UpdateClient_WrongMobileFormat_ExpectedFalseResult()
        {
            //Arrange
            var client = testData.wrongMobileFormat;
            bool expectedResponse = false;

            //Act
            bool respones = employeeBL.UpdateClient(client);

            //Assert
            Assert.AreEqual(expectedResponse, respones);
        }
    }
}
