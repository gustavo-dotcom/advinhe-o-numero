Random random = new Random();
int secretNumber = random.Next(1, 100);

do
{
    Console.WriteLine("Type a number between 1 and 100: ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == secretNumber)
    {
        Console.WriteLine("Congratuations! You've guessed it");    
    }
    else if (guess > secretNumber)
    {
        Console.WriteLine("Guess lower");
    }
    else
    {
        Console.WriteLine("Guess bigger");
    }
} 
while (true);