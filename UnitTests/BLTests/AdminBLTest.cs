using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankBLL;
using UnitTests.BLTestDatas;

namespace UnitTests.BLTests
{
    [TestClass]
    public class AdminBLTest
    {
        private AdminBL adminBL = new AdminBL();
        private AdminBLTestData testData = new AdminBLTestData();

        [TestMethod]
        public void InsertUser_NoUppercaseInPassword_ExpectedFalseResponse()
        {
            //Arrange
            var user = testData.noUppercaseInPassword;
            var expectedResponse = false;

            //Act
            bool response = adminBL.InsertUser(user);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void InsertUser_NoNonAlphanumericInPassword_ExpectedFalseResponse()
        {
            //Arrange
            var user = testData.noNonAlphanumericInPassword;
            var expectedResponse = false;

            //Act
            bool response = adminBL.InsertUser(user);

            //Assert
            Assert.AreEqual(expectedResponse, response);

        }
        
        [TestMethod]
        public void InsertUser_NoNumbersInPassword_ExpectedFalseResponse()
        {
            //Arrange
            var user = testData.noNumberInPassword;
            var expectedResponse = false;

            //Act
            bool response = adminBL.InsertUser(user);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void InsertUser_NoDomainInMail_ExpectedFalseResponse()
        {
            //Arrange
            var user = testData.noDomainInMail;
            var expectedResponse = false;

            //Act
            bool response = adminBL.InsertUser(user);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void InsertUser_CorrectData_ExpectedTrueResponse()
        {
            //Arrange
            var user = testData.correctUserData;
            var expectedResponse = true;

            //Act
            bool response = adminBL.IsValid(user);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        ///////////////////////
        ////    Update     ////
        ///////////////////////

        [TestMethod]
        public void UpdateUser_NoUppercaseInPassword_ExpectedFalseResponse()
        {
            //Arrange
            var user = testData.noUppercaseInPassword;
            var expectedResponse = false;

            //Act
            bool response = adminBL.UpdateUser(user);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void UpdateUser_NoNonAlphanumericInPassword_ExpectedFalseResponse()
        {
            //Arrange
            var user = testData.noNonAlphanumericInPassword;
            var expectedResponse = false;

            //Act
            bool response = adminBL.UpdateUser(user);

            //Assert
            Assert.AreEqual(expectedResponse, response);

        }

        [TestMethod]
        public void UpdateUser_NoNumbersInPassword_ExpectedFalseResponse()
        {
            //Arrange
            var user = testData.noNumberInPassword;
            var expectedResponse = false;

            //Act
            bool response = adminBL.UpdateUser(user);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void UpdateUser_NoDomainInMail_ExpectedFalseResponse()
        {
            //Arrange
            var user = testData.noDomainInMail;
            var expectedResponse = false;

            //Act
            bool response = adminBL.UpdateUser(user);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void UpdateUser_CorrectData_ExpectedTrueResponse()
        {
            //Arrange
            var user = testData.correctUserData;
            var expectedResponse = true;

            //Act
            bool response = adminBL.IsValid(user);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }
    }
}
