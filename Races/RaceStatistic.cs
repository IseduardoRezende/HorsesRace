using HorsesRace.Elements;

namespace HorsesRace.Races
{
    public class RaceStatistic
    {
        public static int CalculateTotalPoints(Element element)
        {
            int count = 0;

            for (int i = 0; i < Math.Abs(element.InitialDistance); i += element.Speed)
            {
                count++;
            }

            for (int i = 0; i < RaceEnvironment.FinishLine; i += element.Speed)
            {
                count++;
            }

            return count;
        }        
    }
}
