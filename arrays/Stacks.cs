namespace arrays;

public class Stacks
{
    public static void Main()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Console.WriteLine(stack.Peek());

        stack.Pop();

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}