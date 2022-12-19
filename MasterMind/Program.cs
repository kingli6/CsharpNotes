// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Generate the secret code
var code = Enumerable.Range(0, 4).Select(x => new Random().Next(1, 7)).ToArray();

// Loop until the player breaks the code or runs out of turns
for (int i = 0; i < 10; i++)
{
    // Prompt the player for their guess
    Console.Write("Enter your guess (4 digits between 1 and 6): ");
    var guess = Console.ReadLine().Trim().Select(x => x - '0').ToArray();

    // Check the guess and give feedback
    int correctDigits = code.Zip(guess, (c, g) => c == g ? 1 : 0).Sum();
    int correctValues = code.Intersect(guess).Count() - correctDigits;
    Console.WriteLine($"{correctDigits} correct digits in the correct place, {correctValues} correct digits in the wrong place");

    // Check if the player has broken the code
    if (correctDigits == 4)
    {
        Console.WriteLine("Congratulations, you broke the code!");
        break;
    }
}
        
    
