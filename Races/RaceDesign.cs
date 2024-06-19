using HorsesRace.Elements;

namespace HorsesRace.Races
{
    public class RaceDesign
    {
        public static void Draw(Element element, ConsoleColor elementColor)
        {
            Console.ForegroundColor = elementColor;

            DrawDistance(element);
            DrawSpeed(element);
            DrawFinishLine();

            Console.ResetColor();
        }       

        private static void DrawDistance(Element element)
        {
            for (int i = 0; i < Math.Abs(element.InitialDistance); i += element.Speed)
            {
                Thread.Sleep(100);
                Console.Write('@');
            }
        }

        private static void DrawSpeed(Element element) 
        {
            for (int i = 0; i < RaceEnvironment.FinishLine; i += element.Speed)
            {
                Thread.Sleep(100);
                Console.Write('-');
            }
        }

        private static void DrawFinishLine()
        {
            Console.WriteLine('*');
        }
    }
}
