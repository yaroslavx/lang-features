namespace arrays;

public class ArrayClass
{
    public static void Main()
    {
        int[] a1;
        a1 = new int[5];

        int[] a2 = new int[5];
        
        int[] a3 = new int[5] { 1, 2, 3, 4, 5 };
        
        int[] a4 = {1, 2, 3, 4, 5 };

        Array randomArray = new int[5];

        Array randomArray2 = Array.CreateInstance(typeof(int), 5);
        randomArray2.SetValue(12, 0);

        // Console.WriteLine(randomArray2.GetValue(0));
        
        int[] numbers = {1, 2, 3, 4, 15, 6, 7, 8, 9, 10};
        Array.Sort(numbers);
        int index = Array.BinarySearch(numbers, 9);
        // Console.WriteLine(index);
        
        int[] numbersCopy = new int[10];
        Array.Copy(numbers, numbersCopy, numbers.Length);

        int[] numbersCopy2 = new int[10];
        numbersCopy.CopyTo(numbersCopy2, 0);
        
        Array.Reverse(numbersCopy2);
    }
}