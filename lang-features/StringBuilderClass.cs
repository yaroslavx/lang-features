using System.Text;

namespace lang_features;

public class StringBuilderClass
{
    public static void Main()
    {
        StringBuilder builder = new StringBuilder();
        
        builder.AppendLine("some Random Line");
        builder.AppendLine("some Random Line 1");

        // Console.WriteLine(builder);
    }
}