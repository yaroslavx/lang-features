namespace oop;

public interface IBaseCollection
{
    void Add(object obj);
    void Remove(object obj);
}

public static class BaseCollectionExtensions
{
    public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
    {
        foreach (var item in objects)
        {
            collection.Add(item);
        }
    }
}

public class BaseCollection : IBaseCollection
{
    private readonly object[] _items;
    private int _count = 0;
    
    public BaseCollection(int initialCapacity)
    {
        _items = new object[initialCapacity];
    }
    
    public void Add(object obj)
    {
        _items[_count] = obj;
        _count++;
    }

    public void Remove(object obj)
    {
        _items[_count] = null;
        _count--;
    }
}