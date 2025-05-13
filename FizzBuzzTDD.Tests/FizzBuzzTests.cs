namespace FizzBuzzTDD.Tests
{
    public class FizzBuzzTests
    {
    //    [Fact]
    //    public void ReturnNumAsString()
    //    {
    //        // Arrange
    //        var fizzBuzz = new FizzBuzz();

    //        // Act
    //        string result = fizzBuzz.GetNum(1);

    //        // Assert
    //        Assert.Equal("1", result);

    //    }

    //    [Fact]
    //    public void ReturnString_WhenDivisibleBy3()
    //    {
    //        var fizzBuzz = new FizzBuzz();
    //        string result = fizzBuzz.GetNum(3);

    //        Assert.Equal("Fizz", result);

    //    }

    //    [Fact]
    //    public void ReturnString_WhenDivisibleBy5()
    //    {

    //        var fizzBuzz = new FizzBuzz();
    //        string result = fizzBuzz.GetNum(5);

    //        Assert.Equal("Buzz", result);
    //    }

    //    [Fact]
    //    public void ReturnString_WhenDivisibleBy3and5()
    //    {

    //        var fizzBuzz = new FizzBuzz();
    //        string result = fizzBuzz.GetNum(15);

    //        Assert.Equal("FizzBuzz", result);
    //    }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(45, "FizzBuzz")]
        [InlineData(98, "98")]
        public void GetNum_ReturnsCorrectFizzBuzzOutput(int input, string expected)
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetNum(input);
            Assert.Equal(expected, result);
        }
    }
}
