namespace arrays;

public class Queues
{
    public static void Main()
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        
        Console.WriteLine(queue.Peek());

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}