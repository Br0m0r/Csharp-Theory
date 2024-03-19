namespace MathFunct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find highest or lower value between 2 values
            int lowerst = Math.Min(1, 2);
            int highest = Math.Max(1, 2);

            //Round Up or Down
            //If its halfway between,it always rounds towards the even integer
            double rounded = Math.Round(9.5); //10
            double rounded2 = Math.Round(10.5); //10
            double rounded3 = Math.Round(10.123123, 2); //Second argument specifies how many digits ro round e.g. here it gives 10.123
            double rounded4 = Math.Round(-11.5, MidpointRounding.AwayFromZero); //11
            //force a round up or down
            double roundD = Math.Floor(9.9); // 9
            double roundU = Math.Ceiling(9.1); // 10

            //trigonometric functs
            double sin = Math.Sin(0);
            double cos = Math.Cos(0);
            double tan = Math.Tan(0);
            double arcSin = Math.Asin(0);
            double arcCos = Math.Acos(0);
            double arcTan = Math.Atan(0);

            //Other Math functions
            double squareRoot = Math.Sqrt(144); // 12
            double power = Math.Pow(2, 3); // 8
            double absoluteValue = Math.Abs(-15);

        }
    }
}