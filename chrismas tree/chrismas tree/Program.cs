Console.Write("Enter hight: ");
int hight = int.Parse(Console.ReadLine());
Console.Clear();
for (int i = 0; i < hight - 1; i++)
{
    Console.Write(" ");
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("$");
for (int i = 0; i < hight; i++)
{
    for (int j = 0; j < hight - i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < 2 * i + 1; k++)
    {
        ConsoleColor randomColor = (ConsoleColor)new Random().Next(16);
        Console.ForegroundColor = randomColor;
        if (randomColor == ConsoleColor.Black || randomColor == ConsoleColor.DarkGray)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        Console.Write("*");
        Thread.Sleep(50);
    }
    Console.WriteLine();
}
for (int d = 0; d < hight - 2; d++)
{
    Console.Write(" ");
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("| |");
while (true)
{
    Console.Clear();
    for (int i = 0; i < hight - 1; i++)
    {
        Console.Write(" ");
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("$");
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < hight - i - 1; j++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k < 2 * i + 1; k++)
        {
            ConsoleColor randomColor = (ConsoleColor)new Random().Next(16);
            Console.ForegroundColor = randomColor;
            if (randomColor == ConsoleColor.Black || randomColor == ConsoleColor.DarkGray)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for (int d = 0; d < hight - 2; d++)
    {
        Console.Write(" ");
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("| |");
    Thread.Sleep(50);
}
