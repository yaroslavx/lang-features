namespace control_flow;

public class Conditional
{
    public static void Main()
    {
        int someVar = 125;

        bool isLow = someVar <= 100;
        bool isNormal = someVar > 100 && someVar < 200;
        bool isHigh = someVar >= 200;

        bool isNice = isNormal || isHigh;

        // if (isNice)
        // {
        //     Console.WriteLine("Nice");
        // }
        // else
        // {
        //     Console.WriteLine("Low");
        // }

        // if (!isNice)
        // {
        //     Console.WriteLine("Not nice");
        // }

        // if (isHigh)
        // {
        //     Console.WriteLine("High");
        // } else if (isNormal)
        // {
        //     Console.WriteLine("Normal");
        // } else if (isLow)
        // {
        //     Console.WriteLine("Low");
        // }
        // else
        // {
        //     Console.WriteLine("Something went wrong");
        // }

        // if (isLow || isNormal)
        // {
        //     Console.WriteLine("Low or Normal");
        // }

        // Console.WriteLine(isNice ? "Nice" : "Not nice");
    }
}