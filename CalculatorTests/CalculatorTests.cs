using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    using System;
    using System.Collections.Generic;

    public class Tests
    {
        private List<double> ExpectedResultsList = new List<double>();
        private double testDigitA = 10;
        private double testDigitB = 10;

        [SetUp]
        public void Setup()
        {
            this.ExpectedResultsList = CreateResultsList(testDigitA, testDigitB);
        }

        [Test]
        public void TestIndividualFunctions()
        {
            double result = CalculatorOperations.Add(testDigitA, testDigitB);
            Assert.AreEqual(result, ExpectedResultsList[0]);

            result = CalculatorOperations.Subtract(testDigitA, testDigitB);
            Assert.AreEqual(result, ExpectedResultsList[1]);

            result = CalculatorOperations.Multiply(testDigitA, testDigitB);
            Assert.AreEqual(result, ExpectedResultsList[2]);

            result = CalculatorOperations.Divide(testDigitA, testDigitB);
            Assert.AreEqual(result, ExpectedResultsList[3]);

            result = CalculatorOperations.Power(testDigitA, testDigitB);
            Assert.AreEqual(result, ExpectedResultsList[4]);
        }

        [TestCase(12, 3)]
        [TestCase(14, 7)]
        [TestCase(26, 15)]
        [TestCase(2, 38)]
        [TestCase(1234, 5678)]
        public void TestIndividualFunctionsMultiple(double DigitA, double DigitB)
        {
            List<double> ResultsList = this.CreateResultsList(DigitA, DigitB);

            double result = CalculatorOperations.Add(DigitA, DigitB);
            Assert.AreEqual(result, ResultsList[0]);

            result = CalculatorOperations.Subtract(DigitA, DigitB);
            Assert.AreEqual(result, ResultsList[1]);

            result = CalculatorOperations.Multiply(DigitA, DigitB);
            Assert.AreEqual(result, ResultsList[2]);

            result = CalculatorOperations.Divide(DigitA, DigitB);
            Assert.AreEqual(result, ResultsList[3]);

            result = CalculatorOperations.Power(DigitA, DigitB);
            Assert.AreEqual(result, ResultsList[4]);
        }

        private List<double> CreateResultsList(double DigitA, double DigitB)
        {
            List<double> ResultsList = new List<double>();

            ResultsList.Add(DigitA + DigitB);
            ResultsList.Add(DigitA - DigitB);
            ResultsList.Add(DigitA * DigitB);
            ResultsList.Add(DigitA / DigitB);
            ResultsList.Add(Math.Pow(DigitA, DigitB));

            return ResultsList;
        }
    }
}