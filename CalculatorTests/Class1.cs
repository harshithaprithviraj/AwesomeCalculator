using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalculatorTests
{
    [TestFixture]
    class CalcTests
    {
       
        [Test]
        public void GetAddition_Input3point4and5point6_Returns9point0()
        {//Arrange
            double firstNumber = 3.4;
            double secondNumber = 5.6;
            double expectedResult = firstNumber + secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input7point4and5point2_Returns2point2()
        {//Arrange
            double firstNumber = 7.4;
            double secondNumber = 5.2;
            double expectedResult = firstNumber - secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input7point4and5point2_Returns38point48()
        {//Arrange
            double firstNumber = 7.4;
            double secondNumber = 5.2;
            double expectedResult = firstNumber * secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input6point4and5point2_Returns1point23()
        {//Arrange
            double firstNumber = 6.4;
            double secondNumber = 5.2;
            double expectedResult = firstNumber / secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input9point4and5point2_Returns14point6()
        {//Arrange
            double firstNumber = 9.4;
            double secondNumber = 5.2;
            double expectedResult = firstNumber + secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input9point4and3point2_Returns6point2()
        {//Arrange
            double firstNumber = 9.4;
            double secondNumber = 3.2;
            double expectedResult = firstNumber - secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void GetMultiplication_Input2point4and5point2_Returns38point48()
        {//Arrange
            double firstNumber = 2.4;
            double secondNumber = 5.2;
            double expectedResult = firstNumber * secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
