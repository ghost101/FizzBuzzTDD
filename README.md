# FizzBuzzTDD - Walkthrough
_Author: Abdul Hamid_

This walkthrough documents the steps taken to implement the FizzBuzz problem using a Test-Driven Development (TDD) approach in Visual Studio 2022 using C# and xUnit.

---

## 1. Project Setup

- Created a new **default console app** in Visual Studio 2022
- Solution named `FizzBuzzTDD`

---

## 2. First Failing Test

- Created a new xUnit test project
- Added a **project reference** from the test project to the app project
- Wrote the first test:
  ```csharp
 [Fact]
public void ReturnNumberAsString()
{
    var fizzBuzz = new FizzBuzz();
    string result = fizzBuzz.GetNum(1);
    Assert.Equal("1", result);
}

  ```

---

## 3. Make the First Test Pass

- Created `FizzBuzz.cs` in the main project
- Implemented just enough code to make the test pass:
  ```csharp
  public class FizzBuzz
  {
      public string GetNum(int number) => number.ToString();
  }
  ```

---

## 4. Add Iteration Logic

- Updated `Program.cs` to loop from 1 to 100:
  ```csharp
  var fizzBuzz = new FizzBuzz();
  for (int i = 1; i <= 100; i++)
  {
      Console.WriteLine(fizzBuzz.GetNum(i));
  }
  ```

---

## 5. Continue TDD: Add More Tests

- Wrote tests for:
  - Divisible by 3 → `"Fizz"`
  - Divisible by 5 → `"Buzz"`
  - Divisible by both 3 and 5 → `"FizzBuzz"`

---

## 6. Improve the Test Suite

- Used `[Theory]` and `[InlineData]` to consolidate logic:
  ```csharp
  [Theory]
  [InlineData(1, "1")]
  [InlineData(3, "Fizz")]
  [InlineData(5, "Buzz")]
  [InlineData(15, "FizzBuzz")]
  public void GetNum_ReturnsCorrectFizzBuzzOutput(int input, string expected)
  {
      var fizzBuzz = new FizzBuzz();
      string result = fizzBuzz.GetNum(input);
      Assert.Equal(expected, result);
  }
  ```

---

## 7. Final Refactor

- Cleaned up method naming
- Ensured output was **centered** in the console using:

  ```csharp
  static void CenterText(string text)
  {
      int leftPadding = (Console.WindowWidth - text.Length) / 2;
      Console.WriteLine(new string(' ', Math.Max(0, leftPadding)) + text);
  }
  ```

- Output from 1 to 100 is now neatly displayed and formatted.

---

✅ This walkthrough demonstrates using TDD principles to iteratively build a solution from test to implementation, with a final polish on output.
