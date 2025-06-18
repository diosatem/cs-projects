public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }

    public void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_sessionDuration);

        while (DateTime.Now < endTime)
        {
            string[] countdown = ["Breathe in...", "Now, breathe out..."];

            foreach (string s in countdown)
            {
                Console.Clear();
                Console.Write($"{s} ");
                CountdownTimer(5);
                Console.Write("\n");
            }
        }
        DisplayEndPrompt();
    }
}