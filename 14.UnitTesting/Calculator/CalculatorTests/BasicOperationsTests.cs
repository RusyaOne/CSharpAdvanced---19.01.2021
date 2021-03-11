using Calculator;
using System;
using Xunit;

namespace CalculatorTests
{
    public class BasicOperationsTests
    {
        [Theory]
        [InlineData(1, 4, 5)]
        [InlineData(-1, 8, 7)]
        [InlineData(4, 5, 9)]
        public void Add_AddTwoIntegers_ResultIsEqualToSumOfIntegers(int firstNumber, int secondNumber, int expected)
        {
            //Arrange
            BasicOperations basicOperations = new BasicOperations();

            //Act
            var result = basicOperations.Add(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}