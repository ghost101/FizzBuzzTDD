using FizzBuzzTDD;

var fizzBuzz = new FizzBuzz();

for (int i = 1; i <= 100; i++)
{
    string output = fizzBuzz.GetNum(i);
    CenterText(output);
}
Console.ReadLine();

static void CenterText(string text)
{
    int textWidth = text.Length;
    int leftPadding = (Console.WindowWidth - textWidth) / 2;

    if (leftPadding > 0)
    {
        Console.WriteLine(new string(' ', leftPadding) + text);
    }
}
