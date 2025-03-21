namespace lang_features;

public class VariablesScopes
{
    public static void Main()
    {
        var a = 1;
        {
            var b = -1;
            {
                var c = 3;

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
    
            Console.WriteLine(a);
            Console.WriteLine(b);
            // Console.WriteLine(c);
        }
        Console.WriteLine(a);
        // Console.WriteLine(b);
        // Console.WriteLine(c);
    }
}