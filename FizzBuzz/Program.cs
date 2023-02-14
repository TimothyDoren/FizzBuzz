for (int i = 1; i <= 30; i++)
{
    if (i % 3 == 0 && i % 5 != 0)
    {
        Console.Write($"{i} ");
        Console.WriteLine("Fizz");
    }
    if (i % 5 == 0 && i % 3 != 0)
        {
        Console.Write($"{i} ");
        Console.WriteLine("Buzz");
        }
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.Write($"{i} ");
        Console.WriteLine("FizzBuzz");
    }
}
