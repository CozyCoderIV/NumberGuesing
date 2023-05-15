class NG
{
    // Attributes
    // Constructor
    // Methods

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the C# Guessing Game !!!");

        Random random = new Random();
        int num = random.Next(1, 10);

        Console.Write("\nGuess: ");

        int gnum = Convert.ToInt32(Console.ReadLine());

        while (gnum != num)
        {
            Console.Write("\nTry again : ");
            gnum = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nYou guessed Correctly !");

        Console.ReadKey();
    }
}