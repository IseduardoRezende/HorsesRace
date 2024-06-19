using HorsesRace.Elements;
using HorsesRace.Enums;

namespace HorsesRace.Races
{
    public class Race
    {
        private readonly Element _elementOne;
        private readonly Element _elementTwo;
        private readonly Bet _bet;

        public Race(Bet bet)
        {
            _elementOne = ElementRandomizer.Randomize();
            _elementTwo = ElementRandomizer.Randomize();
            _bet = bet;
        }       

        public RaceDetail Run()
        {
            RaceEnvironment.Inspect();

            Console.Write("First:");
            Element.Inspect(_elementOne, ConsoleColor.Blue);

            Console.Write("Second:");
            Element.Inspect(_elementTwo, ConsoleColor.Red);

            RaceDesign.Draw(_elementOne, ConsoleColor.Blue);
            RaceDesign.Draw(_elementTwo, ConsoleColor.Red);

            var winner = GetWinner();

            return new RaceDetail
            {
                RightBet = WasRightBet(winner),
                BetResult = GetBetResult(winner),
                BetDescription = Enum.GetName(_bet)!
            };
        }

        private Element? GetWinner()
        {
            var elementOnePoints = RaceStatistic.CalculateTotalPoints(_elementOne);
            var elementTwoPoints = RaceStatistic.CalculateTotalPoints(_elementTwo);

            if (elementOnePoints == elementTwoPoints)
                return null;

            return elementOnePoints < elementTwoPoints ? _elementOne : _elementTwo;
        }
       
        private bool WasRightBet(Element? winner)
        {
            return _bet is Bet.First && winner == _elementOne 
                                     ||
                  _bet is Bet.Second && winner == _elementTwo
                                     ||
                   _bet is Bet.Draw  && winner is null; 
        }

        private string GetBetResult(Element? element)
        {
            return element is null ? nameof(Bet.Draw) : element == _elementOne ? nameof(Bet.First) : nameof(Bet.Second);
        }
    }
}
