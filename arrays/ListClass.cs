namespace arrays;

public class ListClass
{
    public static void Main()
    {
        var intList = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        intList.Add(7);

        int[] intArray = { 1, 2, 3 };
        intList.AddRange(intArray);

        if (intList.Remove(1))
        {
            
        }

        // Console.WriteLine(string.Join(", ", intList));
        
        intList.RemoveAt(0);

        intList.Reverse();
        
        // Console.WriteLine(string.Join(", ", intList));
        
        bool contains = intList.Contains(10);

        int min = intList.Min();
        int max = intList.Max();

        int index = intList.IndexOf(7);
        int index1 = intList.LastIndexOf(7);

        for (int i = 0; i < intList.Count; i++)
        {
            // Console.WriteLine(intList[i]);
        }

        foreach (var item in intList)
        {
            // Console.WriteLine(item);
        }
        
        
    }
}