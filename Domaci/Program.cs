int totalScore = 0;
int[] scores = new int[10];

for (int frame = 1; frame <= 10; frame++)
{
    Console.WriteLine($"Frame {frame}");
    Console.WriteLine($"Total score of frame: {totalScore}");

    int roll1 = GetRollResult("First roll: ");
    if (roll1 == 10) // Strike
    {
        Console.WriteLine("Strike!");
        totalScore += 10;
        if (frame == 10)
        {
            totalScore += GetRollResult("Bonus roll 1: ");
            totalScore += GetRollResult("Bonus roll 2: ");
        }
        continue;
    }

    int roll2 = GetRollResult("Second roll: ");
    int frameScore = roll1 + roll2;

    if (frameScore == 10) // Spare
    {
        Console.WriteLine("Spare!");
        totalScore += 10;
        if (frame == 10)
        {
            totalScore += GetRollResult("Bonus roll: ");
        }
    }
    else
    {
        totalScore += frameScore;
    }
}

Console.WriteLine($"Total Score: {totalScore}");

    static int GetRollResult(string message)
{
    int result;
    do
    {
        Console.Write(message);
    } while (!int.TryParse(Console.ReadLine(), out result) || result < 0 || result > 10);

    return result;
}