string? option;
Console.Write("Pick an option(Write: up, down, binary, while or while_quest!: ");
option = Convert.ToString(Console.ReadLine());


if (option == "up" || option == "Up")
{
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i + 1);
        }
}
else if (option == "down" || option == "Down")
{
    for (int f = 10; f >= 0; f--)
    {
        Console.WriteLine(f);
    }
}
else if (option == "binary" || option == "Binary")
{
    Console.Write("How many cool numbers do you want?: ");
    int count = Convert.ToInt32(Console.ReadLine());
    
    for (int r = 1; r <= count; r++)
    {
        double result = Math.Pow(2, r);
        Console.WriteLine(result);
    }
}
else if (option == "while" || option == "While")
{
    Random numberGen = new Random();

    int roll = 0;
    int attempts = 0;

    Console.WriteLine("Press enter to roll the die.");
    while (roll != 6)
    {
        Console.ReadKey();
        
        roll = numberGen.Next(1, 7);
        Console.WriteLine("You rolled: " + roll);
        attempts++;
    }
    Console.WriteLine("It took you " + attempts + " attempts to roll a six.");
}
else if (option == "while_quest" || option == "While_quest")
{
    Random numberGen = new Random();

    int roll01 = 0;
    int roll02 = 1;
    int attempts = 0;
    
    Console.WriteLine("Press a key to roll the die...");
    
    while (roll01 != roll02)
    {
        Console.ReadKey();
        
        roll01 = numberGen.Next(1, 7);
        roll02 = numberGen.Next(1, 7);
        
        Console.WriteLine("Roll 1: " + roll01);
        Console.WriteLine("Roll 2: " + roll02 + "\n");

        attempts++;
    }
    Console.WriteLine("it took you " + attempts + " attempts to roll two of a kind.");
}
else
{
    Console.WriteLine("Invalid input!!!");
    Console.Write("Press any key to exit...");
}
// Wait before exit...
Console.ReadKey();