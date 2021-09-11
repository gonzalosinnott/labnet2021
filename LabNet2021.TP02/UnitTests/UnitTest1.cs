using Entities.Clases;
using Entities.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideZero_Test()
        {
            decimal number = 10;

            Logic.DivideZero(number);
        }

        [TestMethod]
        public void ValidateInput_Test()
        {
            string number = "10";
            double num;

            num = Logic.ValidateInput(number);

            Assert.AreEqual(10, num);
        }

        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void ValidateInput_Test_WrongInput()
        {
            string number = "A";

            Logic.ValidateInput(number);
        }


        [TestMethod]
        public void DivideOperation_Test()
        {
            string number1 = "10";
            string number2 = "2";
            double result;

            result = Logic.DivideOperation(number1, number2);

            Assert.AreEqual(5, result);
        }


        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideOperation_Test_FailByZero()
        {
            string number1 = "10";
            string number2 = "0";

            Logic.DivideOperation(number1, number2);

        }
    }
}
