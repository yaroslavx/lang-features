namespace lang_features;

public class DateTimeClass
{
    public static void Main()
    {
        DateTime now = DateTime.Now;
        // Console.WriteLine(now.Hour);
        
        DateTime dt = new DateTime(2021, 12, 3 );
        // Console.WriteLine(dt);
        // Console.WriteLine(dt.AddDays(50));

        TimeSpan ts = now - dt;
        Console.WriteLine(ts);
    }
}