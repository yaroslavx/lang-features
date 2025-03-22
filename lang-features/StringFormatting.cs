namespace lang_features;

public class StringFormatting
{
    public static void Main()
    {
        string string1 = string.Format("My name is {0}", "RandomName");
        // Console.WriteLine(string1);
        // Console.WriteLine($"My name is {"RandomName"}");

        // Console.WriteLine("some \n\tstring");
        // Console.WriteLine($"some {Environment.NewLine}string");

        // Console.WriteLine(@"\n\t\\\qrwq[");

        double answer = 33.1;
        // string res = string.Format("{0:d}", answer);
        // Console.WriteLine(res);
        //
        // res = string.Format("{0:d4}", answer);
        // Console.WriteLine(res);
        
        // string res = string.Format("{0:f}", answer);
        // Console.WriteLine(res);
        //
        // res = string.Format("{0:f4}", answer);
        // Console.WriteLine(res);
        
        // Console.OutputEncoding = System.Text.Encoding.UTF8;
        //
        // double money = 2.8;
        // string res = string.Format("{0:C}", money);
        // Console.WriteLine(res);
        // Console.WriteLine(money.ToString("C2"));
        //
        // Console.WriteLine($"{money:C2}");
    }
}