namespace control_flow;

public class Switches
{
    public static void Main()
    {
        int someRandomNumber = 11;

        switch (someRandomNumber)
        {
            case 1:
            case 3:
            case 5:
                Console.WriteLine("Not 11");
                break;
            case 2:
            case 4:
            case 8:
                Console.WriteLine("Not 11");
                break;
            case 11:
                Console.WriteLine("11");
                break;
            default:
                throw new AggregateException("Not 11");
        }
    }
}