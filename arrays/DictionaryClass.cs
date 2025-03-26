namespace arrays;

public class DictionaryClass
{
    public static void Main()
    {
        var randomDictionary = new Dictionary<int, string>()
        {
            { 1, "one" },
            { 2, "two" },
        };
        randomDictionary.Add(3, "randomString");

        string oneString = randomDictionary[1];

        Dictionary<int, string>.KeyCollection keys = randomDictionary.Keys;
        foreach (var item in keys)
        {
            // Console.WriteLine(item);
        }

        Dictionary<int, string>.ValueCollection values = randomDictionary.Values;
        foreach (var item in values)
        {
            // Console.WriteLine(item);
        }

        foreach (KeyValuePair<int, string> pair in randomDictionary)
        {
            // Console.WriteLine(pair;
        }

        // Console.WriteLine(randomDictionary.Count);

        bool containsKey = randomDictionary.ContainsKey(2);

        randomDictionary.Remove(2);

        if (randomDictionary.TryAdd(1, "newOne"))
        {
            // Console.WriteLine("newOne");
        }
        else
        {
            // Console.WriteLine("Not newOne");
        }

        if (randomDictionary.TryGetValue(1, out string value))
        {
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}