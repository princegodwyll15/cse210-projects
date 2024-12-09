public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through a breathing challenge.")
    {
    }

    public void Run()
    {
        int totalDuration = GetDuration();
        int currentDuration = 0;
        int breathDuration = 2;
        int increment = 2;

        while (currentDuration < totalDuration)
        {
            int remainingTime = totalDuration - currentDuration;
            if (breathDuration > remainingTime)
            {
                breathDuration = remainingTime;
            }

            Console.WriteLine($"\nBreath In for {breathDuration} seconds...");
            for (int i = breathDuration; i > 0; i--)
            {
                Console.Write($"\rTime Remaining: {i} seconds...");
                Thread.Sleep(1000);
                currentDuration++;
            }
            Console.WriteLine("\rDone! ");

            Console.WriteLine($"\nBreath Out for {breathDuration} seconds...");
            for (int i = breathDuration; i > 0; i--)
            {
                Console.Write($"\rTime Remaining: {i} seconds...");
                Thread.Sleep(1000);
                currentDuration++;
            }
            Console.WriteLine("\rDone! ");

            if (currentDuration < totalDuration)
            {
                Console.WriteLine("Taking Pulse...");
                int pulseTime = Math.Min(2000, totalDuration - currentDuration);
                Thread.Sleep(pulseTime);
                Console.WriteLine("Pulse checked!");
                currentDuration += pulseTime / 1000;
            }

            breathDuration += increment;
            increment++;
        }
    }
}


