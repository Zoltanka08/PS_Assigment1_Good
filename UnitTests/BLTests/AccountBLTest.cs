using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankBLL;
using UnitTests.BLTestDatas;

namespace UnitTests.BLTests
{
    [TestClass]
    public class AccountBLTest
    {
        private AccountBL accountBL = new AccountBL();
        private AccountBLTestData testData = new AccountBLTestData();

        [TestMethod]
        public void InsertAccount_NegativeBalance_ExpectedFalseResult()
        {
            //Arrange
            var account = testData.balanceLessThanZero;
            bool expectedResponse = false;

            //Act
            var response = accountBL.InsertAccount(account);

            //Assert
            Assert.AreEqual(expectedResponse,response);
        }

        [TestMethod]
        public void InsertAccount_IBANLengthLessThan10_ExpectedFalseResult()
        {
            //Arrange
            var account = testData.IBANLengthLessThan10;
            bool expectedResponse = false;

            //Act
            var response = accountBL.InsertAccount(account);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void InsertAccount_NullIBAN_ExpectedFalseResult()
        {
            //Arrange
            var account = testData.nullIBAN;
            bool expectedResponse = false;

            //Act
            var response = accountBL.InsertAccount(account);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        //////////////////////////
        ////      Update     /////
        //////////////////////////

        [TestMethod]
        public void UpdateAccount_NegativeBalance_ExpectedFalseResult()
        {
            //Arrange
            var account = testData.balanceLessThanZero;
            bool expectedResponse = false;

            //Act
            var response = accountBL.UpdateAccount(account);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void UpdateAccount_IBANLengthLessThan10_ExpectedFalseResult()
        {
            //Arrange
            var account = testData.IBANLengthLessThan10;
            bool expectedResponse = false;

            //Act
            var response = accountBL.UpdateAccount(account);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void UpdateAccount_NullIBAN_ExpectedFalseResult()
        {
            //Arrange
            var account = testData.nullIBAN;
            bool expectedResponse = false;

            //Act
            var response = accountBL.UpdateAccount(account);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

    }
}
