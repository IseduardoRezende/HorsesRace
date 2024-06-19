namespace HorsesRace.Races
{
    public class RaceEnvironment
    {
        public const int FinishLine = 30;

        public const char RunningToStartLine = '@';
        public const char RunningToFinishLine = '-';

        public static void Inspect()
        {
            Console.WriteLine("\nEnvironment Details:\n" +
                              $"{RunningToStartLine} is Running to Start Line\n" +
                              $"{RunningToFinishLine} is Running to Finish Line\n");
        }        
    }
}
