namespace HorsesRace.Races
{
    public class RaceDetail
    {
        public required string BetResult { get; init; }

        public required string BetDescription { get; init; }
        
        public required bool RightBet { get; init; }

        public void Inspect()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "\nRice Details:\n" +
                   $"Bet Description: {BetDescription}\n" +
                   $"Was Right Bet ? {RightBet}\n" +
                   $"Bet Result is: {BetResult}\n";
        }
    }
}
