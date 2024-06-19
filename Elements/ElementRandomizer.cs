namespace HorsesRace.Elements
{
    public class ElementRandomizer
    {
        private static readonly Random _random = new();

        public const int MinSpeed = 1;
        public const int MaxSpeed = 31;
        
        public const int MinInitialDistance = -30;
        public const int MaxInitialDistance = 1;

        public static Element Randomize()
        {
            return new Element(speed: _random.Next(MinSpeed, MaxSpeed), 
                               initialDistance: _random.Next(MinInitialDistance, MaxInitialDistance));
        }        
    }
}
