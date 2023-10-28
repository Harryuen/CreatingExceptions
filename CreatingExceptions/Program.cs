namespace CreatingExceptions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Circle circle1 = new Circle();
                circle1.SetRadius(5.0);// One object with positive radius
                Console.WriteLine(circle1.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Circle circle2 = new Circle();
                circle2.SetRadius(-1.0); // One object with negative radius
                Console.WriteLine(circle2.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Circle circle3 = new Circle();
                circle3.SetRadius(0.0); // One object with radius of zero
                Console.WriteLine(circle3.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}