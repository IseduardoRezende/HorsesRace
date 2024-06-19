namespace HorsesRace.Elements
{
    public class Element
    {
        public Element(int speed, int initialDistance)
        {
            Speed = speed;
            InitialDistance = initialDistance;
        }
        
        public int Speed { get; }

        public int InitialDistance { get; }
        
        public static void Inspect(Element element, ConsoleColor elementColor)
        {
            Console.ForegroundColor = elementColor;
            Console.WriteLine(element);
            Console.ResetColor();
        }

        public override string ToString()
        {
            return "\nElement Details:\n" +
                   $"Speed: {Speed}\n" +
                   $"Initial Distance: {InitialDistance}\n";
        }
    }  
}
